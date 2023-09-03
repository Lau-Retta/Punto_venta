using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

namespace Datos
{
	public class ConexionDataBase
	{
		//Datos para el conectionString de la data base
		static string servidor = "localhost";
		static string bd = "punto_de_venta"; //base de datos
		static string usuario = "root";
		static string password = "[your pass]";
		static string puerto = "3306";
		string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" +
			"user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd;

		

		MySqlConnection conexion = new MySqlConnection();

		//valida el acceso como administrador,para restringir funciones y accesos a datos criticos.
		public int acceso(string user) {
			conexion.ConnectionString = cadenaConexion;
			conexion.Open();
			int count;
			string query = "Select Count(*) From login Where usuario='" + user + "'  and tipo_cuenta='admin' ";
			MySqlCommand cmd = new MySqlCommand(query, conexion);

			count = Convert.ToInt32(cmd.ExecuteScalar());
			conexion.Close();
			return count;

		}

		//validad el acceso a la ventana principal
		public int login(string usuario, string contrasena)
		{
			conexion.ConnectionString = cadenaConexion;
			conexion.Open(); //abrir la conexion

			int count;
			//seleciona de la BD la cantidad de usuarios y contraseñas ingresados que existen en la tabla y retorna la cantidad
			string query = "Select Count(*) From login Where usuario='" + usuario + "'  and contrasena='" + contrasena + "' ";

			MySqlCommand cmd = new MySqlCommand(query, conexion);

			count = Convert.ToInt32(cmd.ExecuteScalar());//ejecuta la consulta y devulve laprimera columna de la primera fila del conjunto de resultados

			conexion.Close();
			

			return count;
		}

		
	
		//controles para la ventana de usuaruios;
		public DataTable consultarDatos()
		{
			conexion.ConnectionString = cadenaConexion;
			conexion.Open();

			string query = "Select * from login";
			MySqlCommand comando = new MySqlCommand(query, conexion);
			MySqlDataAdapter data = new MySqlDataAdapter(comando);
			DataTable tabla = new DataTable();
			data.Fill(tabla);
			conexion.Close();
			return tabla;
			
		}
			
		public int AgregarDatos(string nom, string appe, string dni, string pass, string tel, string user, string tipo) {
			
			int flag = 0;
			conexion.Open();
			string queryInsert = "INSERT INTO login (nombre, apellido ,dni ,contrasena, telefono, usuario, tipo_cuenta) VALUES ('" + nom + "','"+appe+"','"+dni+"','" + pass + "','"+tel+"','" + user + "','"+tipo+"')";
			MySqlCommand comando_insert = new MySqlCommand(queryInsert, conexion);
			comando_insert.ExecuteNonQuery();
			conexion.Close();
			return flag;
		}

		public int EliminarDatos(string user)
		{
			int flag = 0;
			conexion.Open();
			string queryDelete = "DELETE FROM login WHERE usuario = '" + user + "'";
			MySqlCommand comando_insert = new MySqlCommand(queryDelete, conexion);
			comando_insert.ExecuteNonQuery();
			conexion.Close();
			return flag;
		}

		public int ModificarDatos(int id, string nom, string appe, string dni, string pass, string tel, string user, string tipo)
        {
			int flag = 0;
			conexion.Open();
			string queryEdit = "UPDATE login SET nombre = '"+nom+"', apellido ='"+appe+"', dni = '"+dni+"', contrasena= '"+pass+"', telefono= '"+tel+"', usuario= '"+user+"', tipo_cuenta= '"+tipo+"' WHERE id = '"+id+"'";
			MySqlCommand comando_edit = new MySqlCommand(queryEdit, conexion);
			comando_edit.ExecuteNonQuery();
			conexion.Close();
			return flag;
        }


		//controles de inventario

		public DataTable ConsultaInventario() {

			conexion.ConnectionString = cadenaConexion;
			conexion.Open();

			string query = "Select * from inventario";
			MySqlCommand comando = new MySqlCommand(query, conexion);
			MySqlDataAdapter data = new MySqlDataAdapter(comando);
			DataTable tabla = new DataTable();
			data.Fill(tabla);
			conexion.Close();
			return tabla;
		}

		public int AgregarIventario(string produc, string catg, float precio, int cant, string cod) {

			int flag = 0;
			conexion.Open();
			string queryInsert = "INSERT INTO inventario (productos, categoria, precio, cantidad,codigo) VALUES (@productos,@categoria,@precio,@cantidad,@codigo)";
			MySqlCommand comando_insert = new MySqlCommand(queryInsert, conexion);

			comando_insert.Parameters.AddWithValue("@productos", produc);
			comando_insert.Parameters.AddWithValue("@categoria", catg);
			comando_insert.Parameters.AddWithValue("@precio", precio);
			comando_insert.Parameters.AddWithValue("@cantidad", cant);
			comando_insert.Parameters.AddWithValue("@Codigo", cod);

			comando_insert.ExecuteNonQuery();
			conexion.Close();

			return flag;
		}
		public int ModificarInventario(int id, string produc, string catg, decimal precio, int cant, string cod)
		{
			int flag = 0;
			conexion.Open();

			string queryEdit = "UPDATE inventario SET productos = @productos, categoria = @categoria, precio = @precio, cantidad = @cantidad, codigo=@codigo WHERE id = @id";
			MySqlCommand comando_edit = new MySqlCommand(queryEdit, conexion);

			/* En lugar de concatenar el valor decimal directamente en la cadena de consulta, debes utilizar parámetros 
			 * en la consulta para evitar problemas de formato y posibles vulnerabilidades de seguridad.*/
			comando_edit.Parameters.AddWithValue("@productos", produc);
			comando_edit.Parameters.AddWithValue("@categoria", catg);
			comando_edit.Parameters.AddWithValue("@precio", precio);
			comando_edit.Parameters.AddWithValue("@cantidad", cant);
			comando_edit.Parameters.AddWithValue("@codigo", cod);
			comando_edit.Parameters.AddWithValue("@id", id);

			comando_edit.ExecuteNonQuery();

			conexion.Close();

			return flag;
		}

		public int EmliminarInventario(int id) {
			int flag = 0;
			conexion.Open();
			string queryDelete = "DELETE FROM inventario WHERE id = @id";

			MySqlCommand comando_insert = new MySqlCommand(queryDelete, conexion);

			comando_insert.Parameters.AddWithValue("@id", id);

			comando_insert.ExecuteNonQuery();

			conexion.Close();
		
			return flag;
		}



		//controles para tabla de clientes

		public DataTable ConsultaCleintes()
		{

			conexion.ConnectionString = cadenaConexion;
			conexion.Open();

			string query = "Select * from  clientes";
			MySqlCommand comando = new MySqlCommand(query, conexion);
			MySqlDataAdapter data = new MySqlDataAdapter(comando);
			DataTable tabla = new DataTable();
			data.Fill(tabla);
			conexion.Close();
			return tabla;
		}

		public int AgregarCliente(string nom, string apellido, string dni, string email,string nClient)
		{

			int flag = 0;
			conexion.Open();
			string queryInsert = "INSERT INTO clientes (Nombre, Apellido, Dni, Email, N_cliente) VALUES (@Nombre, @Apellido, @Dni, @Email, @N_cliente)";
			MySqlCommand comando_insert = new MySqlCommand(queryInsert, conexion);

			comando_insert.Parameters.AddWithValue("@Nombre", nom);
			comando_insert.Parameters.AddWithValue("@Apellido", apellido);
			comando_insert.Parameters.AddWithValue("@Dni", dni);
			comando_insert.Parameters.AddWithValue("@Email", email);
			comando_insert.Parameters.AddWithValue("@n_cliente", nClient);

			comando_insert.ExecuteNonQuery();
			conexion.Close();

			return flag;
		}
		public int Modificarcliente(string nom, string apellido, string dni, string email, string nClient)
		{
			int flag = 0;
			conexion.Open();

			string queryEdit = "UPDATE clientes SET Nombre=@Nombre, Apellido=@Apellido, Dni=@Dni, Email=@Email  WHERE N_cliente = @n_cliente";

			MySqlCommand comando_edit = new MySqlCommand(queryEdit, conexion);

			comando_edit.Parameters.AddWithValue("@Nombre", nom);
			comando_edit.Parameters.AddWithValue("@Apellido", apellido);
			comando_edit.Parameters.AddWithValue("@Dni", dni);
			comando_edit.Parameters.AddWithValue("@Email", email);
			//comando_edit.Parameters.AddWithValue("@id", id);
			comando_edit.Parameters.AddWithValue("@n_cliente", nClient);

			comando_edit.ExecuteNonQuery();

			conexion.Close();

			return flag;
		}

		public int EliminarCliente(string n_client)
		{
			int flag = 0;
			conexion.Open();
			string queryDelete = "DELETE FROM clientes WHERE N_cliente = @n_cliente";

			MySqlCommand comando_insert = new MySqlCommand(queryDelete, conexion);

			comando_insert.Parameters.AddWithValue("@n_cliente", n_client);

			comando_insert.ExecuteNonQuery();

			conexion.Close();

			return flag;
		}

		//consultas y controles de ventana principal

		public string consultaFactura() {
			conexion.ConnectionString = cadenaConexion;
			conexion.Open();
			string resultado;

			string query = "SELECT (SELECT MAX(NumFactura) AS max_factura FROM facturacion) + 1 AS max_factura; ";
			MySqlCommand comando = new MySqlCommand(query, conexion);

			
			MySqlDataReader reg = comando.ExecuteReader();

			
			if (reg.Read())
			{
				
				resultado = reg["max_factura"].ToString();
				
			}
			else {
				
				resultado= "";
				
			}
			conexion.Close();
			return resultado;

		}

		// trae el producto y su precio.
		public Tuple<string,float> consultaPrecio(string cod)
		{
			conexion.ConnectionString = cadenaConexion;
			conexion.Open();

			string produc = "";
			float precio=0;
			string query = "SELECT * FROM inventario WHERE Codigo = @codigo ";

			MySqlCommand comando = new MySqlCommand(query, conexion);
			comando.Parameters.AddWithValue("@codigo", cod);

			MySqlDataReader reg = comando.ExecuteReader();

			if (reg.Read())
			{
				produc = reg["productos"].ToString();
				precio = float.Parse(reg["precio"].ToString());
			}
			
			conexion.Close();
			return Tuple.Create(produc, precio);
		}

		// traer el cliente y su descuento.
		public Tuple<string, float> consultaCliente(string cod)
		{
			conexion.ConnectionString = cadenaConexion;
			conexion.Open();

			string nombre = "";
			float descuento = 0;
			string query = "SELECT concat(Nombre,' ',Apellido) as nombre , Descuento FROM punto_de_venta.clientes WHERE N_cliente =@codigo;";

			MySqlCommand comando = new MySqlCommand(query, conexion);
			comando.Parameters.AddWithValue("@codigo", cod);

			MySqlDataReader reg = comando.ExecuteReader();

			if (reg.Read())
			{
				nombre = reg["nombre"].ToString();
				descuento = float.Parse(reg["Descuento"].ToString());
			}

			conexion.Close();
			return Tuple.Create(nombre, descuento);
		}

		//controles para facturar.
		public void Facturar(List<Factura> F) {
			
			conexion.Open();
            foreach  (Factura fact in F)
            {
				string queryInsert = "INSERT INTO facturacion (Codigo, Producto,PrecioXUnidad, Cantidad, Cliente, Cod_Cliente, Descuento, Subtotal, Total, NumFactura) " +
				 "VALUES (@Codigo, @Producto, @PxU ,@Cantidad, @Cliente, @Cod.Cliente,@Descuento ,@Subtotal, @Total, @NumFactura)";
				MySqlCommand comando_insert = new MySqlCommand(queryInsert, conexion);

				comando_insert.Parameters.AddWithValue("@codigo",fact.Codigo);
				comando_insert.Parameters.AddWithValue("@Producto", fact.Producto);
				comando_insert.Parameters.AddWithValue("@PxU", fact.PxU1);
				comando_insert.Parameters.AddWithValue("@Cantidad", fact.Cantiada1);
				comando_insert.Parameters.AddWithValue("@Cliente",fact.Cliente1);
				comando_insert.Parameters.AddWithValue("@Cod.Cliente",fact.Cod_cliente1);
				comando_insert.Parameters.AddWithValue("@Descuento", fact.Descuento);
				comando_insert.Parameters.AddWithValue("@Subtotal",fact.Subtotal1);
				comando_insert.Parameters.AddWithValue("@Total", fact.Total1);
				comando_insert.Parameters.AddWithValue("@NumFactura", fact.NFactura1);

				comando_insert.ExecuteNonQuery();
			}
			
			
			conexion.Close();

			
		}



		//control para graficos de ventas

		public DataTable ConsultaVentas() {
			conexion.ConnectionString = cadenaConexion;
			conexion.Open();

			string query = "SELECT Producto, count(Producto) Cantidad FROM punto_de_venta.facturacion group by Producto";
			MySqlCommand comando = new MySqlCommand(query, conexion);
			MySqlDataAdapter data = new MySqlDataAdapter(comando);
			DataTable tabla = new DataTable();
			data.Fill(tabla);
			conexion.Close();
			return tabla;
		}
	}
}
