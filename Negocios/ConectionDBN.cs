using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public class ConectionDBN
    {
        ConexionDataBase cn = new ConexionDataBase();

        public int ConsultaSql(string user, string pass)
        {
            return cn.login(user, pass);
        }

        public int accesoUsuario(string user)
        {
            return cn.acceso(user);
        }


        //Funciones para ventana de usuario
        public DataTable ConsultarTabla()
        {

            return cn.consultarDatos();
        }


        public int AgregarATabla(string nom, string appe, string dni, string pass, string tel, string user, string tipo)
        {


            return cn.AgregarDatos(nom, appe, dni, pass, tel, user, tipo);

        }
        public int EliminarDeTabla(string user)
        {

            return cn.EliminarDatos(user);

        }

        public int EditarTabla(int id, string nom, string appe, string dni, string pass, string tel, string user, string tipo)
        {
            return cn.ModificarDatos(id, nom, appe, dni, pass, tel, user, tipo);
        }

        //Funciones para ventana de inventario

        public DataTable ConsultaTablaInventario()
        {

            return cn.ConsultaInventario();
        }

        public int AgregarAInventario(string produc, string catg, float precio, int cant,string cod)
        {

            return cn.AgregarIventario(produc, catg, precio, cant, cod);
        }

        public int EditarInventario(int id, string produc, string catg, decimal precio, int cant, string cod)
        {
            return cn.ModificarInventario(id, produc, catg, precio, cant, cod);

        }

        public int EliminarDeInventario(int id) {
            return cn.EmliminarInventario(id);
        }

        //Funciones para ventana clientes

        public DataTable ConsultaTablaClientes() {
            return cn.ConsultaCleintes();
        }

        public int AgregarAClientes(string nom, string apellido, string dni, string email, string nClient){
            return cn.AgregarCliente(nom, apellido, dni, email, nClient);
        }

        public int EditarCliente(string nom, string apellido, string dni, string email, string nClient) {
            return cn.Modificarcliente(nom, apellido, dni, email, nClient);
        }

        public int EliminarDeClientes(string nClient) {
            return cn.EliminarCliente(nClient);
          }


        //Funciones Ventran principal

        public string consultaFactura() {
            return cn.consultaFactura();
        }

        public Tuple<string, float> consultaPrecio(string cod) {
           return  cn.consultaPrecio(cod);
        }

        public Tuple<string, float> consultaCliente(string cod)
        {
            return cn.consultaCliente(cod);
        }
            //Funcion de facturar
        public void facturar(List<Factura> F) {
            cn.Facturar(F);
        }

        //funcio grafico de venta

        public DataTable consultarVentas() {
            return cn.ConsultaVentas();
        }
    }
}
