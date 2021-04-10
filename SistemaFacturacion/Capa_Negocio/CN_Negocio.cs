using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Negocio
{
    /*Capa de Negocio
  * Creación de métodos a través de instancias de la CapaDatos 
  * Con el fin de que puedan ser utilizadas en la Capa Presentación
  * Respetando las propiedaes de la arquitectura NCapas
  * Cumpliendo a su vez con las bases del POO
  */
    public class CN_Negocio
    {

        CD_Datos ObjetoCD = new CD_Datos();

        // Función para mostrar los artículos de la factura
        public DataTable MostrarArt()
        {
            DataTable Tabla = new DataTable();
            Tabla = ObjetoCD.MostrarArt();
            return Tabla;
        }

        // Función extraer artículos de tabla inventario
        public void extraerArt(string codigoArt, string cantidadArt)
        {
            ObjetoCD.extraerArt(int.Parse(codigoArt), int.Parse(cantidadArt));
        }

        // Función crear factura
        public void CrearFactura(string empleado, string cliente, string fecha, string tipoFactura, string subtotal, string impuesto, string totalPagar)
        {
            ObjetoCD.CrearFactura(empleado, cliente, fecha, tipoFactura, Convert.ToDouble(subtotal), Convert.ToDouble(impuesto), Convert.ToDouble(totalPagar));
        }

        // Función crear factura con NCF
        public void CrearFacturaNCF(string empleado, string cliente, string fecha, string tipoFactura, string NCF, string subtotal, string impuesto, string totalPagar)
        {
            ObjetoCD.CrearFacturaNCF(empleado, cliente, fecha, tipoFactura, NCF, Convert.ToDouble(subtotal), Convert.ToDouble(impuesto), Convert.ToDouble(totalPagar));
        }

        // Funcion agregar NCF  a una factura particular
        public void AgregarNCF(string codigoFactura, string NCF)
        {
            ObjetoCD.AgregarNCF(int.Parse(codigoFactura), NCF);
        }

        // Función para limpiar los artículos de la factura
        public void LimpiarTablaDetalle()
		{
            ObjetoCD.LimpiarTablaDetalle();
		}

        // Función para agregar ITBIS y total a pagar de la factura
        public void AgregarITBISTOTAL (string ITBIS, string totalPagar)
        {
            ObjetoCD.AgregarITBISTOTAL(Convert.ToDouble(ITBIS), Convert.ToDouble(totalPagar));
        }
    }
}
