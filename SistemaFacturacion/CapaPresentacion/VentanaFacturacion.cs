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


using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;



namespace CapaPresentacion
{
	public partial class VentanaFacturacion : Form
	{
		//Creación de la instancia Capa Negocio, que permite utilizar los métodos de la misma
		CN_Negocio ObjetoCN = new CN_Negocio();		

		// Variables de control visibilidad
		bool bnuevaFactura = false;
		bool bfacturaCompleta = false;

		public VentanaFacturacion()
		{
			InitializeComponent();
		}

		//Método para mostrar artículos enl DGV
		public void MostrarArt()
		{
			dgvDetalleFactura.DataSource = ObjetoCN.MostrarArt();
			dgvDetalleFactura.Columns[2].DefaultCellStyle.Format = ".00";
			dgvDetalleFactura.Columns[3].DefaultCellStyle.Format = ".00";
		}

		//Evento para mostrar los artículos una vez cargue la ventana
		private void VentanaFacturacion_Load(object sender, EventArgs e)
		{
			ObjetoCN.LimpiarTablaDetalle();
			MostrarArt();
		}

		//Actividades a realizar una vez el evento click sea ejecutado
		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "SELECT COUNT(*) FROM tblDetalleFactura WHERE codigoArticulo=@Id";

				if (ObjetoCN.ExisteRegistro(txtCodigoArt.Text, query) == false)
				{
					ObjetoCN.extraerArt(txtCodigoArt.Text, nudCantidad.Text);
					MostrarArt();
					txtCodigoArt.Clear();
					nudCantidad.Value = 1;
				}
				else
				{
					MessageBox.Show("El artículo ingresado ya existe. Intente con otro código.", "Artículo existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtCodigoArt.Clear();
					nudCantidad.Value = 1;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("El código ingresado es inválido.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Función botón nueva factura
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			bnuevaFactura = true;
			gestionarVisibilidadBtnPrincipales();
			gestionarVisibilidadBtnGenerarFactura();
			LimpiarCamposFacturacion();			
		}

		// Función botón cancelar factura
		private void btnCancelarFactura_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro de eliminar la factura corriente?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				restaurarFacturacion();
				LimpiarCamposFacturacion();
				LimpiarCampos();
				MessageBox.Show("Factura cancelada.", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		// Botón FACTURAR; deduce el total a pagar
		private void btnFacturar_Click(object sender, EventArgs e)
		{
			// Montos de pago
			lblMontoPago.Text = generarTotalPagar().ToString();
			lblMontoITBIS.Text = calcularITBIS(Convert.ToDouble(lblMontoPago.Text)).ToString();
			lblTotalPagar.Text = (Convert.ToDouble(lblMontoPago.Text) + Convert.ToDouble(lblMontoITBIS.Text)).ToString();

			bfacturaCompleta = true;
			gestionarVisibilidadBtnGenerarFactura();
		}

		// Botón GENERAR FACTURA; indica la devuelta del cliente y genera la impresión de la factura
		private void btnCrearFactura_Click(object sender, EventArgs e)
		{


            // Efectivo y cambio
            if (txtEfectivo.Text != "")
            {
				double vCambio = Math.Round(Convert.ToDouble(txtEfectivo.Text) - Convert.ToDouble(lblTotalPagar.Text));

				if (Convert.ToDouble(txtEfectivo.Text) < Convert.ToDouble(lblTotalPagar.Text))
					MessageBox.Show("El monto es insuficiente. Intente nuevamente.", "Monto insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
				{
					lblCambio.Text = $"{vCambio}";
					restaurarFacturacion();
					ObjetoCN.AgregarITBISTOTAL(lblMontoITBIS.Text, lblTotalPagar.Text);
					#region Generar reporte(Factura)

					//Estancia del Reporte
					FrmFactura form = new FrmFactura();
					ReportDocument oRep = new ReportDocument();
					ParameterField pf = new ParameterField();
					ParameterFields pfs = new ParameterFields();
					ParameterDiscreteValue pdv = new ParameterDiscreteValue();

					// variable del procedimiento almacenado
					pf.Name = "@procMostrarFactura";
					pf.CurrentValues.Add(pdv);
					pfs.Add(pf);


					oRep.Load(@"C:\Users\Deivy\Source\Repos\samyrd309\IDS340-Sistema-Facturacion\SistemaFacturacion\CapaPresentacion\rptFactur.rpt");
					form.crystalReportViewer1.ReportSource = oRep;
					form.Show();

					//Exportar Reporte a PDF
					oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\Deivy\Downloads\factura.pdf");
					#endregion
				}

            }
            else
                MessageBox.Show("Indique el monto en efectivo.", "Complete los campos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ObjetoCN.AgregarITBISTOTAL(lblMontoITBIS.Text, lblTotalPagar.Text);

			
			// Inserta los campos de NCF y tipo de factura en función de la opción seleccionada
			switch (rbNFC.Checked)
			{
				default:
					try
					{
						if (txtCliente.Text.Trim() != "" || txtEmpleado.Text.Trim() != "")						
							ObjetoCN.CrearFactura(txtEmpleado.Text, txtCliente.Text, dateTimePicker1.Text, "Consumidor final", lblMontoPago.Text, lblMontoITBIS.Text, lblTotalPagar.Text);													
						else						
							MessageBox.Show("Debe indicar el nombre del cliente y empleado.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);						
					}
					catch (Exception ex)
					{
						MessageBox.Show("error" + ex);
					}
					break;

				case true:
					try
					{
						if (txtCliente.Text.Trim() != "" || txtEmpleado.Text.Trim() != "")						
							ObjetoCN.CrearFacturaNCF(txtEmpleado.Text, txtCliente.Text, dateTimePicker1.Text, "Crédito fiscal", txtNCF.Text, lblMontoPago.Text, lblMontoITBIS.Text, lblTotalPagar.Text);
						else
							MessageBox.Show("Debe indicar el nombre del cliente y empleado.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception ex)
					{
						MessageBox.Show("error" + ex);
					}
					break;
			}
			LimpiarCampos();
		}

		// Funciones mostrar textbox NCF
		private void rbNFC_CheckedChanged(object sender, EventArgs e)
		{
			if (rbNFC.Checked == true)
				txtNCF.Enabled = true;
		}

		private void rbConsumidorFinal_CheckedChanged(object sender, EventArgs e)
		{
			if (rbConsumidorFinal.Checked == true)
				txtNCF.Enabled = false;
		}

		//////// MÉTODOS LIMPIEZA CAMPOS ////////
		
		//Método para limpiar campos una vez se ingrese un articulo
		private void LimpiarCampos()
		{
			txtCodigoArt.Text = "";
			nudCantidad.Value = 1;
			txtCliente.Text = "";
		}

		//Método para limpiar los campos de pago
		public void LimpiarCamposFacturacion()
		{
			lblMontoPago.Text = "";
			lblMontoITBIS.Text = "";
			lblTotalPagar.Text = "";
			lblCambio.Text = "";
			txtEfectivo.Text = "";
			ObjetoCN.LimpiarTablaDetalle();
			MostrarArt();
		}

		//////// FIN MÉTODOS LIMPIEZA CAMPOS ////////


		//////// FUNCIONES VISIBILIDAD ////////

		// Funcion que gestiona la visibilidad de los botones agregar producto y cancelar factura
		private void gestionarVisibilidadBtnPrincipales()
		{
			switch (bnuevaFactura)
			{
				case true:
					{
						btnNuevo.Enabled = false;
						btnAgregar.Enabled = true;
						btnFacturar.Enabled = true;
						btnCancelarFactura.Enabled = true;
						txtCliente.Enabled = true;
						txtCodigoArt.Enabled = true;
						nudCantidad.Enabled = true;
						rbConsumidorFinal.Enabled = true;
						rbNFC.Enabled = true;
						txtEfectivo.Enabled = true;
						txtNCF.Enabled = false;
					}
					break;

				default:
					{
						btnNuevo.Enabled = true;
						btnAgregar.Enabled = false;
						btnFacturar.Enabled = false;
						btnCancelarFactura.Enabled = false;
						txtCliente.Enabled = false;
						txtCodigoArt.Enabled = false;
						nudCantidad.Enabled = false;
						rbConsumidorFinal.Enabled = false;
						rbNFC.Enabled = false;
						txtEfectivo.Enabled = false;
						txtNCF.Enabled = false;
					}
					break;
			}
		}

		// Funcion que habilita o deshabilita el boton para generar la factura
		private void gestionarVisibilidadBtnGenerarFactura()
		{
			switch (bfacturaCompleta)
			{
				case true:
					{
						btnCrearFactura.Enabled = true;
					}
					break;

				default:
					{
						btnCrearFactura.Enabled = false;
					}
					break;
			}
		}

		//////// FIN FUNCIONES VISIBILIDAD ////////

		//////// FUNCIONES FACTURAR ////////

		// Función para sumar las columnas del DGV
		private double generarTotalPagar()
		{
			double totalPagar = 0;
			foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
			{
				totalPagar += Convert.ToDouble(fila.Cells[3].Value);
			}
			return totalPagar;
		}

		// Funcion calcular ITBIS
		private double calcularITBIS(double montoBase)
		{
			const double ITBIS = 0.18;
			double totalITBIS = montoBase * ITBIS;
			return totalITBIS;
		}

		// Funcion para restaurar la facturacion
		public void restaurarFacturacion()
		{
			bfacturaCompleta = false;
			bnuevaFactura = false;
			gestionarVisibilidadBtnGenerarFactura();
			gestionarVisibilidadBtnPrincipales();
		}

		//////// FIN FUNCIONES FACTURAR ////////
	}
}