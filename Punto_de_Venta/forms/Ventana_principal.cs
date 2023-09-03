using Punto_de_Venta.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Punto_de_Venta;
using Negocios;
using Entidades;
using System.Drawing.Printing;


namespace Punto_de_Venta
{
    public partial class Ventana_principal : Form
    {
        private string usuarioIngresado;

        ConectionDBN cn = new ConectionDBN();

        private float subtotal = 0;
        private float total = 0;
        private float desc =  0;
        
        private DataTable dt;

        public Ventana_principal(string user)
        {
            InitializeComponent();
            usuarioIngresado = user;//inicializo con user desde el form 1 para traer el nombre de usurio que se ingreso en el login

            //inicializa con los tbox de impuestos y descuento con un valor predeterminado
            TBox_impu.Text = (float.Parse(StripTbox_impuesto.Text) * 100).ToString();
            Tbox_descu.Text = StripTbox_descuento.Text;


            //inicializa el gid view vacio con las columnas a completar

            dt = new DataTable();

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio x Unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio Total");

            Grid_principal.DataSource = dt;
            Tbox_factura.Text = cn.consultaFactura();
        }

        
        private void Ventana_principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        //acceder a la ventana de usuarios solo si es administrador
        private void menu_usuarios_Click(object sender, EventArgs e)
        {
            if (cn.accesoUsuario(usuarioIngresado) == 1)
            {
                this.Hide();
                Ventana_Usuarios V_usuairio = new Ventana_Usuarios();
                this.Hide();
                V_usuairio.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("No tienes el acceso a esta ventana.");
            }



        }

        //acceder al inventaio, se desbolquean las funcines de crud para administradores
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_Inventario V_Inventario = new Ventana_Inventario();
            this.Hide();
            V_Inventario.ShowDialog();
            this.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventan_Clientes V_clientes = new Ventan_Clientes();
            this.Hide();
            V_clientes.ShowDialog();
            this.Show();
        }

        //Actualizar el Text box con el descuento e impuesto agragados.
        private void impuestoYDescuentoChange(object sender, EventArgs e)
        {
            try
            {
                TBox_impu.Text = (float.Parse(StripTbox_impuesto.Text) * 100).ToString();
                desc = float.Parse(StripTbox_descuento.Text);
                Tbox_descu.Text = (desc*100).ToString();
            }
            catch (Exception)
            {

                TBox_impu.Text = "";
                Tbox_descu.Text = "";
            }
           
        }
        

        //agregar prodcuto a la factura
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //alamcenamos la tupla en un objeto de tipo var
            var result = cn.consultaPrecio(Tbox_CProducto.Text);
            //creamos una fila para agregar
            DataRow Row = dt.NewRow();

            //entre los corchetes le asignames la columna correspondiente.
            Row["Codigo"] =Tbox_CProducto.Text;
            Row["Producto"] = result.Item1;//del objeto result obtenemos  la tupla y el 1 item es el precio.
            Row["Precio x Unidad"] = result.Item2;
            Row["Cantidad"] =Tbox_cant.Text;
            Row["Descuento"] =Tbox_descu.Text;
            Row["Precio Total"] = result.Item2 * Convert.ToInt32(Tbox_cant.Text);//$*cant

            //agregamos la fila al data grid
            dt.Rows.Add(Row);

            subtotal = subtotal + (result.Item2 * Convert.ToInt32(Tbox_cant.Text));
          
            total = subtotal + (subtotal*float.Parse(StripTbox_impuesto.Text)) - (subtotal* desc) ;

            N_subtotal.Text = subtotal.ToString();
            N_Total.Text = total.ToString();

        }

        //agregar cliente a la factura
        private void btn_buscar_Click(object sender, EventArgs e)
        {
           
            var result = cn.consultaCliente(Tbox_Ccliente.Text);

            Tbox_nameCliente.Text = result.Item1;

            desc = result.Item2;

            Tbox_descu.Text= (desc * 100).ToString();

          


        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            
            List<Factura> lista_items = new List<Factura>();

            //recorremos el grid x fila y cada columna es un atributo de la clase factura. 
            foreach (DataRow fila in dt.Rows)
            {
                Factura fact = new Factura();

                fact.Codigo = fila["Codigo"].ToString();
                fact.Producto = fila["Producto"].ToString();
                fact.PxU1 = fila["Precio x Unidad"].ToString();
                fact.Cantiada1 = fila["Cantidad"].ToString();
                fact.Descuento = fila["Descuento"].ToString();
                fact.PrecioTortal1 = fila["Precio Total"].ToString();

                fact.Cliente1 = Tbox_nameCliente.Text;
                fact.Cod_cliente1 = Tbox_Ccliente.Text;

                fact.Subtotal1 = subtotal.ToString();
                fact.Total1 = total.ToString();

                fact.NFactura1 = Tbox_factura.Text;

                //agregamos cada instacia de la clase factura a una lista. Estas instancias son las filas del grid
                lista_items.Add(fact);


                // Proceso de facturación 

                PrintDocument printDocument1 = new PrintDocument();//creamos un nuevo documento de impresion
                PrinterSettings ps = new PrinterSettings();// creamos las configuraciones de imprecion

                //le damos las caracteristicas del ps al printdocument1
                printDocument1.PrinterSettings = ps;

                printDocument1.PrintPage += imprimir; //le asignamos a la pagina que vamos a imprimir lo que este en el evento imprimir
                printDocument1.Print();//lo enviuamos a imprimir abrindo la ventana.





            }

            cn.facturar(lista_items);
            MessageBox.Show($"Se realizo la factura N°{Tbox_factura.Text}.");
            Tbox_factura.Text = cn.consultaFactura();

        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            //designamos las caracteristicas del texto que se va a imprimir

            Font ft = new Font("Arial",14);
            int whith = 300; //ancho del espacio que ocupe el texto
            int y = 20;//altura de margen superior

            

            e.Graphics.DrawString("---PUNTO DE VENTA---", ft, Brushes.Black, new RectangleF(0,y+=20, whith,20));

            e.Graphics.DrawString($"Fatura #{Tbox_factura.Text}", ft, Brushes.Black, new RectangleF(0, y += 20, whith, 20));
            e.Graphics.DrawString($"{Tbox_nameCliente.Text}", ft, Brushes.Black, new RectangleF(0, y += 20, whith, 20));
            e.Graphics.DrawString("---Productos (valor sin IVA 21% incluido)---", ft, Brushes.Black, new RectangleF(0, y += 30, whith, 20));

            foreach (DataRow fila in dt.Rows)
            {
                e.Graphics.DrawString($"{fila["Codigo"].ToString()} {fila["Producto"].ToString()} ${fila["Precio Total"].ToString()}"
                    
                    , ft, Brushes.Black, new RectangleF(0, y += 20, whith, 20));
            }

            e.Graphics.DrawString($"Subtotal: {subtotal.ToString()}", ft, Brushes.Black, new RectangleF(0, y += 40, whith, 20));
            e.Graphics.DrawString($"IVA: ${(subtotal* float.Parse(StripTbox_impuesto.Text)).ToString()}", ft, Brushes.Black, new RectangleF(0, y += 10, whith, 20));
            if (desc != 0)
            {
                e.Graphics.DrawString($"Descuento: {(desc*100).ToString()}%", ft, Brushes.Black, new RectangleF(0, y += 20, whith, 20));
            }
            e.Graphics.DrawString($"---Total--- ${total.ToString()}", ft, Brushes.Black, new RectangleF(0, y += 20, whith, 20));

            e.Graphics.DrawString("Gracias por su compra!", ft, Brushes.Black, new RectangleF(0, y += 40, whith, 20));
        }

        private void graficoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grafico_de_venta GV = new Grafico_de_venta();
            this.Hide();
            GV.ShowDialog();
            this.Show();
        }
    }
}
