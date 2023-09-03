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

namespace Punto_de_Venta
{
    public partial class Form1 : Form
    {
        public bool Key { get; set; }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            ConectionDBN conexion = new ConectionDBN();
            /*
            if (conexion.ConsultaSql(Usuario_text.Text, contrasena_text.Text) == 1)
            {
                
                this.Hide(); //con this indicamos que estamos hablando de este form
                             //y con hide decimos que minimice la ventana del login

                Ventana_principal v1 = new Ventana_principal(Usuario_text.Text);
                v1.Show();//mostramos la ventana principal
                MessageBox.Show("Bienvenido");

                if (conexion.accesoUsuario(Usuario_text.Text) == 1) {
                    
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }*/

            this.Hide(); //con this indicamos que estamos hablando de este form
                         //y con hide decimos que minimice la ventana del login

            Ventana_principal v1 = new Ventana_principal(Usuario_text.Text);
            v1.Show();//mostramos la ventana principal
            MessageBox.Show("Bienvenido");
        }
        
    }   
}
