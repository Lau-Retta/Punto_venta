using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using System.Globalization;

namespace Punto_de_Venta.forms
{
    public partial class Ventana_Inventario : Form
    {
        Negocios.ConectionDBN cn = new ConectionDBN();
        public Ventana_Inventario()
        {
            InitializeComponent();
            Grid_inventario.DataSource = cn.ConsultaTablaInventario();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_agregar_Click(object sender, EventArgs e)
        {
            string precioString = Tbox_precio.Text;
            float precioFloat;

            if (float.TryParse(precioString, out precioFloat))
            {
                cn.AgregarAInventario(Tbox_producto.Text, Tbox_catg.Text, precioFloat, Convert.ToInt32(Tbox_cant.Text), TBox_codigo.Text);
                MessageBox.Show($"El producto {Tbox_producto.Text} fue agregado exitosamente!");

                Tbox_producto.Text = "";
                Tbox_catg.Text = "";
                Tbox_precio.Text = "";
                Tbox_cant.Text = "";
                TBox_codigo.Text = "";

                Grid_inventario.DataSource = cn.ConsultaTablaInventario();
            }
            else
            {
                MessageBox.Show("El valor del precio no es válido.");
            }

            Grid_inventario.DataSource = cn.ConsultaTablaInventario();
        }

        private void bnt_modificar_Click(object sender, EventArgs e)
        {
            if (Tbox_id.Text != "")
            {

                string precioString = Tbox_precio.Text;
                decimal precioDecimal;
                if (decimal.TryParse(precioString, NumberStyles.Float, new CultureInfo("es-ES"), out precioDecimal)) {

                    cn.EditarInventario(Convert.ToInt32(Tbox_id.Text), Tbox_producto.Text, Tbox_catg.Text, precioDecimal, Convert.ToInt32(Tbox_cant.Text),TBox_codigo.Text);

                }
                else
                {
                    MessageBox.Show("El valor del precio no es válido.");
                }


                MessageBox.Show("Prodcuto: " + Tbox_producto.Text + " se modifico exitosamente.");
                //vaciar los text box para poder seguir agregando usuarios
                Tbox_id.Text = "";
                Tbox_producto.Text = "";
                Tbox_catg.Text = "";
                Tbox_precio.Text = "";
                Tbox_cant.Text = "";
                TBox_codigo.Text = "";

                Grid_inventario.DataSource = cn.ConsultaTablaInventario();
            }
            else
            {
                MessageBox.Show("Ingrese el usario que desee modificar");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Tbox_id.Text != "")
            {
                cn.EliminarDeInventario(Convert.ToInt32(Tbox_id.Text));
                MessageBox.Show("Articulo eliminado.");
            }
            else {
                MessageBox.Show("La id ingresada no es valida.");
            }
            Grid_inventario.DataSource = cn.ConsultaTablaInventario();
        }

    }

    
}
