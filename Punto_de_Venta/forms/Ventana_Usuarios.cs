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

using Negocios;

namespace Punto_de_Venta.forms
{
    public partial class Ventana_Usuarios : Form
    {
        Negocios.ConectionDBN cn = new ConectionDBN();
        public Ventana_Usuarios()
        {
            InitializeComponent();
            dgv_tabla.DataSource = cn.ConsultarTabla();
        }

      

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //nom, appe, dni, pass, tel, user, tipo
            cn.AgregarATabla(Tbox_name.Text, Tbox_apellido.Text, Tbox_dni.Text, Tbox_contrasena.Text, Tbox_tel.Text, Tbox_usuario.Text, Tbox_cuentas.Text); ;

            MessageBox.Show("Usuario: " + Tbox_usuario.Text + " se ha agregado exitosamente.");
            //vaciar los text box para poder seguir agregando usuarios
            Tbox_name.Text = "";
            Tbox_dni.Text = ""; 
            Tbox_tel.Text = "";
            Tbox_usuario.Text = "";
            Tbox_contrasena.Text = "";
            Tbox_apellido.Text = "";
            Tbox_cuentas.Text = "";

            dgv_tabla.DataSource = cn.ConsultarTabla();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (Tbox_id.Text != "")
            {
                cn.EditarTabla(Convert.ToInt32(Tbox_id.Text), Tbox_name.Text, Tbox_apellido.Text, Tbox_dni.Text, Tbox_contrasena.Text, Tbox_tel.Text, Tbox_usuario.Text, Tbox_cuentas.Text);

              

                MessageBox.Show("Usuario: " + Tbox_usuario.Text + " se modifico exitosamente.");
                //vaciar los text box para poder seguir agregando usuarios
                Tbox_id.Text = "";
                Tbox_name.Text = "";
                Tbox_dni.Text = "";
                Tbox_tel.Text = "";
                Tbox_usuario.Text = "";
                Tbox_contrasena.Text = "";
                Tbox_apellido.Text = "";
                Tbox_cuentas.Text = "";
                dgv_tabla.DataSource = cn.ConsultarTabla();
            }
            else
            {
                MessageBox.Show("Ingrese el usario que desee modificar");
            }

            dgv_tabla.DataSource = cn.ConsultarTabla();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            if (Tbox_usuario.Text != "")
            {
                cn.EliminarDeTabla(Tbox_usuario.Text);

                MessageBox.Show($"Se elimino al usuario: {Tbox_usuario.Text} correctamente");
                Tbox_usuario.Text = "";
                dgv_tabla.DataSource = cn.ConsultarTabla();
            }
            else {
                MessageBox.Show("Ingrese el usario que desee eliminar");
            }
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
