
namespace CapaPresentacion
{
	partial class VentanaFacturacion
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaFacturacion));
			this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lblCliente = new System.Windows.Forms.Label();
			this.lblEmpleado = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rbConsumidorFinal = new System.Windows.Forms.RadioButton();
			this.rbNFC = new System.Windows.Forms.RadioButton();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblCodigoArt = new System.Windows.Forms.Label();
			this.txtCodigoArt = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancelarFactura = new System.Windows.Forms.Button();
			this.btnFacturar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblMontoPago = new System.Windows.Forms.Label();
			this.lblMontoITBIS = new System.Windows.Forms.Label();
			this.txtEfectivo = new System.Windows.Forms.TextBox();
			this.lblTotalPagar = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblCambio = new System.Windows.Forms.Label();
			this.btnCrearFactura = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNCF = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDetalleFactura
			// 
			this.dgvDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvDetalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDetalleFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDetalleFactura.ColumnHeadersHeight = 30;
			this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDetalleFactura.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDetalleFactura.EnableHeadersVisualStyles = false;
			this.dgvDetalleFactura.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.dgvDetalleFactura.Location = new System.Drawing.Point(12, 313);
			this.dgvDetalleFactura.MultiSelect = false;
			this.dgvDetalleFactura.Name = "dgvDetalleFactura";
			this.dgvDetalleFactura.ReadOnly = true;
			this.dgvDetalleFactura.RowHeadersVisible = false;
			this.dgvDetalleFactura.RowHeadersWidth = 51;
			this.dgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvDetalleFactura.Size = new System.Drawing.Size(805, 330);
			this.dgvDetalleFactura.TabIndex = 0;
			// 
			// txtCliente
			// 
			this.txtCliente.Enabled = false;
			this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCliente.Location = new System.Drawing.Point(125, 88);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(226, 24);
			this.txtCliente.TabIndex = 1;
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Enabled = false;
			this.txtEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtEmpleado.Location = new System.Drawing.Point(125, 131);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(226, 24);
			this.txtEmpleado.TabIndex = 2;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(125, 265);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(226, 22);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// lblCliente
			// 
			this.lblCliente.AutoSize = true;
			this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCliente.Location = new System.Drawing.Point(25, 90);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(70, 20);
			this.lblCliente.TabIndex = 4;
			this.lblCliente.Text = "Cliente:";
			// 
			// lblEmpleado
			// 
			this.lblEmpleado.AutoSize = true;
			this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmpleado.Location = new System.Drawing.Point(25, 135);
			this.lblEmpleado.Name = "lblEmpleado";
			this.lblEmpleado.Size = new System.Drawing.Size(94, 20);
			this.lblEmpleado.TabIndex = 5;
			this.lblEmpleado.Text = "Empleado:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 266);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fecha:";
			// 
			// rbConsumidorFinal
			// 
			this.rbConsumidorFinal.AutoSize = true;
			this.rbConsumidorFinal.Checked = true;
			this.rbConsumidorFinal.Enabled = false;
			this.rbConsumidorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.rbConsumidorFinal.Location = new System.Drawing.Point(166, 180);
			this.rbConsumidorFinal.Name = "rbConsumidorFinal";
			this.rbConsumidorFinal.Size = new System.Drawing.Size(130, 20);
			this.rbConsumidorFinal.TabIndex = 11;
			this.rbConsumidorFinal.TabStop = true;
			this.rbConsumidorFinal.Text = "Consumidor Final";
			this.rbConsumidorFinal.UseVisualStyleBackColor = true;
			this.rbConsumidorFinal.CheckedChanged += new System.EventHandler(this.rbConsumidorFinal_CheckedChanged);
			// 
			// rbNFC
			// 
			this.rbNFC.AutoSize = true;
			this.rbNFC.Enabled = false;
			this.rbNFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.rbNFC.Location = new System.Drawing.Point(306, 180);
			this.rbNFC.Name = "rbNFC";
			this.rbNFC.Size = new System.Drawing.Size(108, 20);
			this.rbNFC.TabIndex = 12;
			this.rbNFC.Text = "Crédito Fiscal";
			this.rbNFC.UseVisualStyleBackColor = true;
			this.rbNFC.CheckedChanged += new System.EventHandler(this.rbNFC_CheckedChanged);
			// 
			// btnNuevo
			// 
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnNuevo.Location = new System.Drawing.Point(803, 210);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(130, 28);
			this.btnNuevo.TabIndex = 13;
			this.btnNuevo.Text = "+ Nueva factura";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(246)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1123, 65);
			this.panel1.TabIndex = 14;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(121, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// lblCodigoArt
			// 
			this.lblCodigoArt.AutoSize = true;
			this.lblCodigoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodigoArt.Location = new System.Drawing.Point(746, 88);
			this.lblCodigoArt.Name = "lblCodigoArt";
			this.lblCodigoArt.Size = new System.Drawing.Size(136, 20);
			this.lblCodigoArt.TabIndex = 16;
			this.lblCodigoArt.Text = "Código Artículo:";
			// 
			// txtCodigoArt
			// 
			this.txtCodigoArt.Enabled = false;
			this.txtCodigoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigoArt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtCodigoArt.Location = new System.Drawing.Point(888, 86);
			this.txtCodigoArt.MaxLength = 6;
			this.txtCodigoArt.Name = "txtCodigoArt";
			this.txtCodigoArt.Size = new System.Drawing.Size(194, 24);
			this.txtCodigoArt.TabIndex = 15;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.Teal;
			this.btnAgregar.Enabled = false;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAgregar.Location = new System.Drawing.Point(951, 166);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(130, 28);
			this.btnAgregar.TabIndex = 17;
			this.btnAgregar.Text = "+ Agregar producto";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// nudCantidad
			// 
			this.nudCantidad.Enabled = false;
			this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudCantidad.Location = new System.Drawing.Point(1039, 125);
			this.nudCantidad.Margin = new System.Windows.Forms.Padding(2);
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(40, 22);
			this.nudCantidad.TabIndex = 18;
			this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(948, 125);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(86, 20);
			this.lblCantidad.TabIndex = 19;
			this.lblCantidad.Text = "Cantidad:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 218);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "Número Comprobante Fiscal:";
			// 
			// btnCancelarFactura
			// 
			this.btnCancelarFactura.BackColor = System.Drawing.Color.Maroon;
			this.btnCancelarFactura.Enabled = false;
			this.btnCancelarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelarFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCancelarFactura.Location = new System.Drawing.Point(952, 210);
			this.btnCancelarFactura.Name = "btnCancelarFactura";
			this.btnCancelarFactura.Size = new System.Drawing.Size(130, 28);
			this.btnCancelarFactura.TabIndex = 23;
			this.btnCancelarFactura.Text = "Cancelar factura";
			this.btnCancelarFactura.UseVisualStyleBackColor = false;
			this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
			// 
			// btnFacturar
			// 
			this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.btnFacturar.Enabled = false;
			this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFacturar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnFacturar.Location = new System.Drawing.Point(966, 447);
			this.btnFacturar.Name = "btnFacturar";
			this.btnFacturar.Size = new System.Drawing.Size(116, 28);
			this.btnFacturar.TabIndex = 24;
			this.btnFacturar.Text = "Facturar";
			this.btnFacturar.UseVisualStyleBackColor = false;
			this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(852, 562);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 25;
			this.label2.Text = "Cambio:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(852, 529);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 20);
			this.label4.TabIndex = 26;
			this.label4.Text = "Efectivo:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(852, 339);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 20);
			this.label5.TabIndex = 27;
			this.label5.Text = "Subtotal:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(852, 374);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 20);
			this.label6.TabIndex = 28;
			this.label6.Text = "ITBIS (18%):";
			// 
			// lblMontoPago
			// 
			this.lblMontoPago.AutoSize = true;
			this.lblMontoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoPago.Location = new System.Drawing.Point(978, 339);
			this.lblMontoPago.Name = "lblMontoPago";
			this.lblMontoPago.Size = new System.Drawing.Size(0, 20);
			this.lblMontoPago.TabIndex = 29;
			this.lblMontoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMontoITBIS
			// 
			this.lblMontoITBIS.AutoSize = true;
			this.lblMontoITBIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoITBIS.Location = new System.Drawing.Point(978, 374);
			this.lblMontoITBIS.Name = "lblMontoITBIS";
			this.lblMontoITBIS.Size = new System.Drawing.Size(0, 20);
			this.lblMontoITBIS.TabIndex = 30;
			this.lblMontoITBIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtEfectivo
			// 
			this.txtEfectivo.Enabled = false;
			this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEfectivo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtEfectivo.Location = new System.Drawing.Point(937, 529);
			this.txtEfectivo.Name = "txtEfectivo";
			this.txtEfectivo.Size = new System.Drawing.Size(145, 22);
			this.txtEfectivo.TabIndex = 31;
			// 
			// lblTotalPagar
			// 
			this.lblTotalPagar.AutoSize = true;
			this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalPagar.Location = new System.Drawing.Point(978, 412);
			this.lblTotalPagar.Name = "lblTotalPagar";
			this.lblTotalPagar.Size = new System.Drawing.Size(0, 20);
			this.lblTotalPagar.TabIndex = 33;
			this.lblTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(852, 412);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 20);
			this.label8.TabIndex = 32;
			this.label8.Text = "Total a pagar:";
			// 
			// lblCambio
			// 
			this.lblCambio.AutoSize = true;
			this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCambio.Location = new System.Drawing.Point(933, 562);
			this.lblCambio.Name = "lblCambio";
			this.lblCambio.Size = new System.Drawing.Size(0, 20);
			this.lblCambio.TabIndex = 34;
			// 
			// btnCrearFactura
			// 
			this.btnCrearFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.btnCrearFactura.Enabled = false;
			this.btnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCrearFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCrearFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCrearFactura.Location = new System.Drawing.Point(966, 592);
			this.btnCrearFactura.Name = "btnCrearFactura";
			this.btnCrearFactura.Size = new System.Drawing.Size(116, 28);
			this.btnCrearFactura.TabIndex = 35;
			this.btnCrearFactura.Text = "Crear factura";
			this.btnCrearFactura.UseVisualStyleBackColor = false;
			this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(25, 179);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(135, 20);
			this.label7.TabIndex = 36;
			this.label7.Text = "Tipo de factura:";
			// 
			// txtNCF
			// 
			this.txtNCF.Enabled = false;
			this.txtNCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNCF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtNCF.Location = new System.Drawing.Point(272, 218);
			this.txtNCF.Name = "txtNCF";
			this.txtNCF.Size = new System.Drawing.Size(194, 24);
			this.txtNCF.TabIndex = 20;
			// 
			// VentanaFacturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(1123, 648);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnCrearFactura);
			this.Controls.Add(this.lblCambio);
			this.Controls.Add(this.lblTotalPagar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtEfectivo);
			this.Controls.Add(this.lblMontoITBIS);
			this.Controls.Add(this.lblMontoPago);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnFacturar);
			this.Controls.Add(this.btnCancelarFactura);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNCF);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.nudCantidad);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.lblCodigoArt);
			this.Controls.Add(this.txtCodigoArt);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.rbNFC);
			this.Controls.Add(this.rbConsumidorFinal);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblEmpleado);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.txtEmpleado);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.dgvDetalleFactura);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "VentanaFacturacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VentanaFacturacion";
			this.Load += new System.EventHandler(this.VentanaFacturacion_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.TextBox txtEmpleado;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblEmpleado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rbConsumidorFinal;
		private System.Windows.Forms.RadioButton rbNFC;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCodigoArt;
        private System.Windows.Forms.TextBox txtCodigoArt;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancelarFactura;
		private System.Windows.Forms.Button btnFacturar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblMontoPago;
		private System.Windows.Forms.Label lblMontoITBIS;
		private System.Windows.Forms.TextBox txtEfectivo;
		private System.Windows.Forms.Label lblTotalPagar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblCambio;
		private System.Windows.Forms.Button btnCrearFactura;
		public System.Windows.Forms.DataGridView dgvDetalleFactura;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNCF;
	}
}