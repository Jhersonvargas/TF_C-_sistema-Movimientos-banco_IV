namespace TF_JhersonVargas
{
    partial class Ventanilla
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblNcuenta = new System.Windows.Forms.Label();
            this.LblCsucursal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.dataGridCL = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.botom = new System.Windows.Forms.Button();
            this.lblBanco = new System.Windows.Forms.Label();
            this.lblNCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.BTQuitar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCL)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.lblTipoCuenta);
            this.groupBox1.Controls.Add(this.lbls);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.BTAgregar);
            this.groupBox1.Controls.Add(this.BTQuitar);
            this.groupBox1.Controls.Add(this.lblBanco);
            this.groupBox1.Controls.Add(this.lblNCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LblNcuenta);
            this.groupBox1.Controls.Add(this.LblCsucursal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblFechaApertura);
            this.groupBox1.Location = new System.Drawing.Point(13, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(644, 211);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha";
            // 
            // LblNcuenta
            // 
            this.LblNcuenta.BackColor = System.Drawing.Color.Azure;
            this.LblNcuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNcuenta.Location = new System.Drawing.Point(107, 19);
            this.LblNcuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNcuenta.Name = "LblNcuenta";
            this.LblNcuenta.Size = new System.Drawing.Size(212, 24);
            this.LblNcuenta.TabIndex = 3;
            // 
            // LblCsucursal
            // 
            this.LblCsucursal.BackColor = System.Drawing.Color.Azure;
            this.LblCsucursal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCsucursal.Location = new System.Drawing.Point(105, 49);
            this.LblCsucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCsucursal.Name = "LblCsucursal";
            this.LblCsucursal.Size = new System.Drawing.Size(214, 24);
            this.LblCsucursal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "N. Cuenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ciudad Sucursal:";
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.BackColor = System.Drawing.Color.Azure;
            this.lblFechaApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechaApertura.Location = new System.Drawing.Point(439, 16);
            this.lblFechaApertura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(116, 23);
            this.lblFechaApertura.TabIndex = 14;
            // 
            // dataGridCL
            // 
            this.dataGridCL.AllowUserToAddRows = false;
            this.dataGridCL.AllowUserToDeleteRows = false;
            this.dataGridCL.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCL.Location = new System.Drawing.Point(13, 37);
            this.dataGridCL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridCL.Name = "dataGridCL";
            this.dataGridCL.ReadOnly = true;
            this.dataGridCL.RowHeadersWidth = 62;
            this.dataGridCL.Size = new System.Drawing.Size(738, 222);
            this.dataGridCL.TabIndex = 22;
            this.dataGridCL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCL_CellContentClick);
            this.dataGridCL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCL_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(120, 8);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(631, 20);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // botom
            // 
            this.botom.BackColor = System.Drawing.Color.White;
            this.botom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botom.Location = new System.Drawing.Point(13, 8);
            this.botom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.botom.Name = "botom";
            this.botom.Size = new System.Drawing.Size(100, 23);
            this.botom.TabIndex = 20;
            this.botom.Text = "Buscar";
            this.botom.UseVisualStyleBackColor = false;
            // 
            // lblBanco
            // 
            this.lblBanco.BackColor = System.Drawing.Color.Azure;
            this.lblBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBanco.Location = new System.Drawing.Point(105, 85);
            this.lblBanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(214, 24);
            this.lblBanco.TabIndex = 19;
            // 
            // lblNCliente
            // 
            this.lblNCliente.BackColor = System.Drawing.Color.Azure;
            this.lblNCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNCliente.Location = new System.Drawing.Point(103, 115);
            this.lblNCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNCliente.Name = "lblNCliente";
            this.lblNCliente.Size = new System.Drawing.Size(216, 24);
            this.lblNCliente.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Banco:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nombre Cliente:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.BackColor = System.Drawing.Color.Azure;
            this.lblSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldo.Location = new System.Drawing.Point(105, 151);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(212, 24);
            this.lblSaldo.TabIndex = 23;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.BackColor = System.Drawing.Color.Azure;
            this.lblTipoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoCuenta.Location = new System.Drawing.Point(103, 181);
            this.lblTipoCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(216, 24);
            this.lblTipoCuenta.TabIndex = 24;
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Location = new System.Drawing.Point(7, 153);
            this.lbls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(37, 13);
            this.lbls.TabIndex = 25;
            this.lbls.Text = "Saldo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 185);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tipo de Cuenta:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(439, 70);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(116, 20);
            this.txtImporte.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Importe:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 495);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar Codigo";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 43);
            this.label2.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::TF_JhersonVargas.Properties.Resources.Generate_keys_37133__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(190, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 43);
            this.button2.TabIndex = 29;
            this.button2.Text = "Generar codigo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BTAgregar
            // 
            this.BTAgregar.BackColor = System.Drawing.Color.White;
            this.BTAgregar.Image = global::TF_JhersonVargas.Properties.Resources.cash_icon_icons_com_51090;
            this.BTAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTAgregar.Location = new System.Drawing.Point(362, 138);
            this.BTAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.Size = new System.Drawing.Size(118, 43);
            this.BTAgregar.TabIndex = 15;
            this.BTAgregar.Text = "Depositar";
            this.BTAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTAgregar.UseVisualStyleBackColor = false;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click);
            // 
            // BTQuitar
            // 
            this.BTQuitar.BackColor = System.Drawing.Color.White;
            this.BTQuitar.Image = global::TF_JhersonVargas.Properties.Resources.withdrawl_finance_economy_money_bank_icon_192192;
            this.BTQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTQuitar.Location = new System.Drawing.Point(504, 138);
            this.BTQuitar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTQuitar.Name = "BTQuitar";
            this.BTQuitar.Size = new System.Drawing.Size(110, 44);
            this.BTQuitar.TabIndex = 16;
            this.BTQuitar.Text = "Retirar";
            this.BTQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTQuitar.UseVisualStyleBackColor = false;
            this.BTQuitar.Click += new System.EventHandler(this.BTQuitar_Click);
            // 
            // Ventanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridCL);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.botom);
            this.Name = "Ventanilla";
            this.Text = "Ventanilla";
            this.Load += new System.EventHandler(this.Ventanilla_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblNcuenta;
        private System.Windows.Forms.Button BTQuitar;
        private System.Windows.Forms.Label LblCsucursal;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFechaApertura;
        private System.Windows.Forms.DataGridView dataGridCL;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button botom;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.Label lblNCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}