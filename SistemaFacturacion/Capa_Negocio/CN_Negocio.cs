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

        public void extraerArt(string codigoArt, string cantidadArt)
        {
            ObjetoCD.extraerArt(int.Parse(codigoArt), int.Parse(cantidadArt));
        }

        public void CrearFactura(string empleado, string cliente, string fecha, string tipoFactura)
        {
            ObjetoCD.CrearFactura(empleado, cliente, fecha, tipoFactura);
        }

        public void CrearFacturaNCF(string empleado, string cliente, string fecha, string tipoFactura, string NCF)
        {
            ObjetoCD.CrearFacturaNCF(empleado, cliente, fecha, tipoFactura, NCF);
        }

        public void AgregarNCF(string codigoFactura, string NCF)
        {
            ObjetoCD.AgregarNCF(int.Parse(codigoFactura), NCF);
        }

        public DataTable MostrarArt()
        {
            DataTable Tabla = new DataTable();
            Tabla = ObjetoCD.MostrarArt();
            return Tabla;
        }
    }
}
