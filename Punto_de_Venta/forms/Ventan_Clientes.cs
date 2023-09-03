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


namespace Punto_de_Venta.forms
{

    public partial class Ventan_Clientes : Form
    {
        ConectionDBN cn = new ConectionDBN();
        public Ventan_Clientes()
        {
            InitializeComponent();
            Grid_clientes.DataSource = cn.ConsultaTablaClientes();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_agregar_Click(object sender, EventArgs e)
        {
            cn.AgregarAClientes(Tbox_nombre.Text, Tbox_apellido.Text, Tbox_dni.Text, Tbox_email.Text, Tbox_Ncliente.Text);

            MessageBox.Show($"Cliente {Tbox_nombre.Text} {Tbox_apellido.Text} se agrego exitosamente");

            Tbox_nombre.Text = "";
            Tbox_apellido.Text = "";
            Tbox_dni.Text = "";
            Tbox_email.Text = "";

            Grid_clientes.DataSource = cn.ConsultaTablaClientes();
        }

        private void bnt_modificar_Click(object sender, EventArgs e)
        {
            cn.EditarCliente(Tbox_nombre.Text, Tbox_apellido.Text, Tbox_dni.Text, Tbox_email.Text, Tbox_Ncliente.Text);

            MessageBox.Show($"EL cliente {Tbox_nombre.Text} {Tbox_apellido.Text} se modifico exitosamente");

            Tbox_Ncliente.Text = "";
            Tbox_nombre.Text = "";
            Tbox_apellido.Text = "";
            Tbox_dni.Text = "";
            Tbox_email.Text = "";

            Grid_clientes.DataSource = cn.ConsultaTablaClientes();


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Tbox_Ncliente.Text != "")
            {
                cn.EliminarDeClientes(Tbox_Ncliente.Text);

                MessageBox.Show("El cliente se eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("La id ingresada no es valida.");
            }

            Grid_clientes.DataSource = cn.ConsultaTablaClientes();
        }
    }
}
