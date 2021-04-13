using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{

	/*Clase encargada de la conexión SQL, en la cual, se conecta el proyecto con el QUERY del servidor SQL y su respectiva Base de datos
      * Adecuándose a las bases de la arquitectura NCAPAS
      */
	class CD_Conexion
	{
		static private string CadenaConexion = "Server= LAPTOP-3O0264U2; DataBase= bdFacturacion; Integrated Security = true";
		private SqlConnection Conexion = new SqlConnection(CadenaConexion);

		//Método que se encarga de abrir la conexión SQL
		public SqlConnection AbrirConexion()
		{
			if (Conexion.State == ConnectionState.Closed)
				Conexion.Open();
			return Conexion;
		}

		//Método que se encarga de cerrar la conexión SQL
		public SqlConnection CerrarConexion()
		{
			if (Conexion.State == ConnectionState.Open)
				Conexion.Close();
			return Conexion;
		}
	}
}
