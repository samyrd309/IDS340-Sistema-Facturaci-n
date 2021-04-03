using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
namespace CapaPresentacion
{
    public partial class VentanaFacturacion : Form
    {

        //Creación de la instancia Capa Negocio, que permite utilizar los métodos de la misma
        CN_Negocio ObjetoCN = new CN_Negocio();
        public VentanaFacturacion()
        {
            InitializeComponent();
        }


        //Método para mostrar artículos enl DGV
        public void MostrarArt()
        {
            dgvDetalleFactura.DataSource = ObjetoCN.MostrarArt();
        }

        //Evento para mostrar los artículos una vez cargue la ventana
        private void VentanaFacturacion_Load(object sender, EventArgs e)
        {
            MostrarArt();
        }

        //Método para limpiar campos una vez se ingrese un articulo
        public void LimpiarCampos()
        {
            txtCodigoArt.Text = "";
            nudCantidad.Value = 1;
            txtCliente.Text = "";
            txtEmpleado.Text = "";
            txtNCF.Text = "";
            cmbTipoPago.Text = "";
        }

        //Actividades a realizar una vez el evento click sea ejecutado

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ObjetoCN.extraerArt(txtCodigoArt.Text, nudCantidad.Text);
                LimpiarCampos();
                MostrarArt();
            }
            catch (Exception)
            {
                MessageBox.Show("El código ingresado es inválido");
                LimpiarCampos();
            }
        }

        private void rbNFC_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNFC.Checked == true)
            {
                txtNCF.Enabled = true;
                
            }
        }

        private void rbConsumidorFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConsumidorFinal.Checked == true)
            {
                txtNCF.Enabled = false;

            }
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            switch (rbNFC.Checked)
            {
                default:
                    try
                    {
                        MessageBox.Show("default");
                        ObjetoCN.CrearFactura(txtEmpleado.Text, txtCliente.Text, dateTimePicker1.Text, cmbTipoPago.Text);
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error" + ex);
                    }
                    break;
                case true:
                    MessageBox.Show("NCF");
                    try
                    {
                        ObjetoCN.CrearFacturaNCF(txtEmpleado.Text, txtCliente.Text, dateTimePicker1.Text, cmbTipoPago.Text, txtNCF.Text);
                        LimpiarCampos();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("error" + ex);
                    }
                    break;

            }
            
            
            
        }
    }

        
    
}
