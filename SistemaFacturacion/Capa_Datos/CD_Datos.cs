using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
	public class CD_Datos
	{
		//Instancias y comandos del servidor SQL
		private CD_Conexion Conexion = new CD_Conexion();
		private SqlCommand Comando = new SqlCommand();
		private SqlDataReader LeerFilas;

		//Método para extraer artículos de la tabla SQL concerniente al inventario 
		public void extraerArt(int codigoArticulo, int cantidadArticulo)
		{
			Comando.Connection = Conexion.AbrirConexion();
			Comando.CommandText = "procLlamarArt";
			Comando.CommandType = CommandType.StoredProcedure;
			Comando.Parameters.AddWithValue("@codigoArticulo", codigoArticulo);
			Comando.Parameters.AddWithValue("@cantidad", cantidadArticulo);
			Comando.ExecuteNonQuery();
			Comando.Parameters.Clear();
		}

		//Método para mostrar artículos extraídos de la tabla inventario (Servidor SQL)
		public DataTable MostrarArt()
		{
			DataTable Tabla = new DataTable();
			Comando.Connection = Conexion.AbrirConexion();
			Comando.CommandText = "procMostrarArt";
			Comando.CommandType = CommandType.StoredProcedure;
			LeerFilas = Comando.ExecuteReader();
			Tabla.Load(LeerFilas);
			LeerFilas.Close();
			Conexion.CerrarConexion();
			return Tabla;
		}

		//Procedimiento para crear factura
		public void CrearFactura(string empleado, string cliente, string fecha, string tipoFactura, double subtotal, double impuesto, double totalPagar)
		{
			Comando.Connection = Conexion.AbrirConexion();
			Comando.CommandText = "procCrearFactura";
			Comando.CommandType = CommandType.StoredProcedure;
			Comando.Parameters.AddWithValue("@empleado", empleado);
			Comando.Parameters.AddWithValue("@nombreCliente", cliente);
			Comando.Parameters.AddWithValue("@fechaEmision", fecha);
			Comando.Parameters.AddWithValue("@tipoFactura", tipoFactura);
			Comando.Parameters.AddWithValue("@subtotal", subtotal);
			Comando.Parameters.AddWithValue("@impuesto", impuesto);
			Comando.Parameters.AddWithValue("@totalPagar", totalPagar);
			Comando.ExecuteNonQuery();
			Comando.Parameters.Clear();
		}

		//Procedimiento para crear factura NCF
		public void CrearFacturaNCF(string empleado, string cliente, string fecha, string tipoFactura, string NCF, double subtotal, double impuesto, double totalPagar)
		{
			Comando.Connection = Conexion.AbrirConexion();
			Comando.CommandText = "procCrearFacturaNCF";
			Comando.CommandType = CommandType.StoredProcedure;
			Comando.Parameters.AddWithValue("@empleado", empleado);
			Comando.Parameters.AddWithValue("@nombreCliente", cliente);
			Comando.Parameters.AddWithValue("@fechaEmision", fecha);
			Comando.Parameters.AddWithValue("@tipoFactura", tipoFactura);
			Comando.Parameters.AddWithValue("@NCF", NCF);
			Comando.Parameters.AddWithValue("@subtotal", subtotal);
			Comando.Parameters.AddWithValue("@impuesto", impuesto);
			Comando.Parameters.AddWithValue("@totalPagar", totalPagar);
			Comando.ExecuteNonQuery();
			Comando.Parameters.Clear();
		}

		//Procedimiento almacenado para agregar NCF a tblFactura
		public void AgregarNCF(int codigoFactura, string NCF)
		{
			Comando.Connection = Conexion.AbrirConexion();
			Comando.CommandText = "procAgregarNCF";
			Comando.CommandType = CommandType.StoredProcedure;
			Comando.Parameters.AddWithValue("@codigoFactura", codigoFactura);
			Comando.Parameters.AddWithValue("@NCF", NCF);
			Comando.ExecuteNonQuery();
			Comando.Parameters.Clear();
		}

		// Procedimiento almacenado para eliminar los registros tblDetalleFactura
		public void LimpiarTablaDetalle()
		{
			Comando.Connection = Conexion.AbrirConexion();
			Comando.CommandText = "procLimpiarDetalleFactura";
			Comando.CommandType = CommandType.StoredProcedure;
			Comando.ExecuteNonQuery();
		}
	}
}
