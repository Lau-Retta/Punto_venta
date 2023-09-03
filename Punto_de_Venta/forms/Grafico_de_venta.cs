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
using System.Windows.Forms.DataVisualization.Charting;

namespace Punto_de_Venta.forms
{
    public partial class Grafico_de_venta : Form
    {
        ConectionDBN cn = new ConectionDBN();
        public Grafico_de_venta()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            DataTable dt = cn.consultarVentas();

            chart1.Titles.Add("Productos vendidos");

            foreach (DataRow row in dt.Rows)//recorremos las filas de la tabla
            {
                Series serie = chart1.Series.Add(row["Producto"].ToString());// le asignamos a las series del cart el valor de producto.

                serie.Points.Add(Convert.ToInt32(row["Cantidad"].ToString()));

                //serie.Label = row["Producto"].ToString();


            }
        }
    }
}
