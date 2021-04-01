
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaFacturacion));
			this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.rbConsumidorFinal = new System.Windows.Forms.RadioButton();
			this.rbNFC = new System.Windows.Forms.RadioButton();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDetalleFactura
			// 
			this.dgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvDetalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalleFactura.Location = new System.Drawing.Point(12, 271);
			this.dgvDetalleFactura.Name = "dgvDetalleFactura";
			this.dgvDetalleFactura.Size = new System.Drawing.Size(910, 276);
			this.dgvDetalleFactura.TabIndex = 0;
			// 
			// txtCliente
			// 
			this.txtCliente.Font = new System.Drawing.Font("SamsungOneUIKorean", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCliente.Location = new System.Drawing.Point(122, 74);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.Size = new System.Drawing.Size(128, 23);
			this.txtCliente.TabIndex = 1;
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Font = new System.Drawing.Font("SamsungOneUIKorean", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmpleado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtEmpleado.Location = new System.Drawing.Point(122, 113);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(128, 23);
			this.txtEmpleado.TabIndex = 2;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("SamsungOneUIKorean", 9.75F);
			this.dateTimePicker1.Location = new System.Drawing.Point(122, 155);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(250, 23);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("SamsungOneUILatin 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 22);
			this.label1.TabIndex = 4;
			this.label1.Text = "Cliente:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("SamsungOneUILatin 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "Empleado:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("SamsungOneUILatin 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fecha:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("SamsungOneUILatin 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(691, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 22);
			this.label4.TabIndex = 10;
			this.label4.Text = "Devuelta:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("SamsungOneUILatin 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(691, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 22);
			this.label5.TabIndex = 9;
			this.label5.Text = "Efectivo:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("SamsungOneUIKorean", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textBox1.Location = new System.Drawing.Point(779, 110);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(128, 23);
			this.textBox1.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("SamsungOneUIKorean", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(779, 71);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(128, 23);
			this.textBox2.TabIndex = 7;
			// 
			// rbConsumidorFinal
			// 
			this.rbConsumidorFinal.AutoSize = true;
			this.rbConsumidorFinal.Font = new System.Drawing.Font("SamsungOneUIKorean", 9.75F);
			this.rbConsumidorFinal.Location = new System.Drawing.Point(38, 203);
			this.rbConsumidorFinal.Name = "rbConsumidorFinal";
			this.rbConsumidorFinal.Size = new System.Drawing.Size(130, 20);
			this.rbConsumidorFinal.TabIndex = 11;
			this.rbConsumidorFinal.TabStop = true;
			this.rbConsumidorFinal.Text = "Consumidor Final";
			this.rbConsumidorFinal.UseVisualStyleBackColor = true;
			// 
			// rbNFC
			// 
			this.rbNFC.AutoSize = true;
			this.rbNFC.Font = new System.Drawing.Font("SamsungOneUIKorean", 9.75F);
			this.rbNFC.Location = new System.Drawing.Point(38, 226);
			this.rbNFC.Name = "rbNFC";
			this.rbNFC.Size = new System.Drawing.Size(108, 20);
			this.rbNFC.TabIndex = 12;
			this.rbNFC.TabStop = true;
			this.rbNFC.Text = "Crédito Fiscal";
			this.rbNFC.UseVisualStyleBackColor = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAgregar.Location = new System.Drawing.Point(807, 171);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(100, 28);
			this.btnAgregar.TabIndex = 13;
			this.btnAgregar.Text = "+ Nuevo";
			this.btnAgregar.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(246)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(934, 65);
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
			// VentanaFacturacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
			this.ClientSize = new System.Drawing.Size(934, 559);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.rbNFC);
			this.Controls.Add(this.rbConsumidorFinal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.txtEmpleado);
			this.Controls.Add(this.txtCliente);
			this.Controls.Add(this.dgvDetalleFactura);
			this.Name = "VentanaFacturacion";
			this.Text = "VentanaFacturacion";
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.TextBox txtEmpleado;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton rbConsumidorFinal;
		private System.Windows.Forms.RadioButton rbNFC;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dgvDetalleFactura;
	}
}