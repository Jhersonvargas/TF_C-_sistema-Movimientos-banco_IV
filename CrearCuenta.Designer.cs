namespace TF_JhersonVargas
{
    partial class CrearCuenta
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
            this.txtnro_cta = new System.Windows.Forms.TextBox();
            this.cbnro_sucursal = new System.Windows.Forms.ComboBox();
            this.cmdbuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbcod_banco = new System.Windows.Forms.ComboBox();
            this.cbcod_cli = new System.Windows.Forms.ComboBox();
            this.dpfechaapertura = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTipoCuenta = new System.Windows.Forms.TextBox();
            this.cmdgrabar = new System.Windows.Forms.Button();
            this.cmdnuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnro_cta
            // 
            this.txtnro_cta.Location = new System.Drawing.Point(115, 31);
            this.txtnro_cta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnro_cta.Name = "txtnro_cta";
            this.txtnro_cta.Size = new System.Drawing.Size(279, 20);
            this.txtnro_cta.TabIndex = 34;
            this.txtnro_cta.Click += new System.EventHandler(this.txtnro_cta_Click);
            this.txtnro_cta.TextChanged += new System.EventHandler(this.txtnro_cta_TextChanged);
            // 
            // cbnro_sucursal
            // 
            this.cbnro_sucursal.FormattingEnabled = true;
            this.cbnro_sucursal.Location = new System.Drawing.Point(115, 63);
            this.cbnro_sucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbnro_sucursal.Name = "cbnro_sucursal";
            this.cbnro_sucursal.Size = new System.Drawing.Size(371, 21);
            this.cbnro_sucursal.TabIndex = 33;
            this.cbnro_sucursal.SelectedIndexChanged += new System.EventHandler(this.cbnro_sucursal_SelectedIndexChanged);
            this.cbnro_sucursal.Click += new System.EventHandler(this.cbnro_sucursal_Click);
            // 
            // cmdbuscar
            // 
            this.cmdbuscar.BackColor = System.Drawing.Color.White;
            this.cmdbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdbuscar.Location = new System.Drawing.Point(399, 30);
            this.cmdbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdbuscar.Name = "cmdbuscar";
            this.cmdbuscar.Size = new System.Drawing.Size(87, 21);
            this.cmdbuscar.TabIndex = 29;
            this.cmdbuscar.Text = "Buscar";
            this.cmdbuscar.UseVisualStyleBackColor = false;
            this.cmdbuscar.Click += new System.EventHandler(this.cmdbuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tipocta";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Fechaapertura";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre del banco:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ciudad Surcusal:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "N de cuenta:";
            // 
            // cbcod_banco
            // 
            this.cbcod_banco.FormattingEnabled = true;
            this.cbcod_banco.Location = new System.Drawing.Point(115, 105);
            this.cbcod_banco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcod_banco.Name = "cbcod_banco";
            this.cbcod_banco.Size = new System.Drawing.Size(371, 21);
            this.cbcod_banco.TabIndex = 42;
            this.cbcod_banco.SelectedIndexChanged += new System.EventHandler(this.cbcod_banco_SelectedIndexChanged);
            this.cbcod_banco.Click += new System.EventHandler(this.cbcod_banco_Click);
            // 
            // cbcod_cli
            // 
            this.cbcod_cli.FormattingEnabled = true;
            this.cbcod_cli.Location = new System.Drawing.Point(115, 136);
            this.cbcod_cli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcod_cli.Name = "cbcod_cli";
            this.cbcod_cli.Size = new System.Drawing.Size(371, 21);
            this.cbcod_cli.TabIndex = 43;
            this.cbcod_cli.Click += new System.EventHandler(this.cbcod_cli_Click);
            // 
            // dpfechaapertura
            // 
            this.dpfechaapertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpfechaapertura.Location = new System.Drawing.Point(115, 194);
            this.dpfechaapertura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dpfechaapertura.Name = "dpfechaapertura";
            this.dpfechaapertura.Size = new System.Drawing.Size(135, 20);
            this.dpfechaapertura.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nombre del cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(115, 164);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(135, 20);
            this.txtSaldo.TabIndex = 47;
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.Location = new System.Drawing.Point(115, 221);
            this.txtTipoCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.Size = new System.Drawing.Size(141, 20);
            this.txtTipoCuenta.TabIndex = 48;
            this.txtTipoCuenta.TextChanged += new System.EventHandler(this.txtTipoCuenta_TextChanged);
            // 
            // cmdgrabar
            // 
            this.cmdgrabar.BackColor = System.Drawing.Color.White;
            this.cmdgrabar.Image = global::TF_JhersonVargas.Properties.Resources.accept_icon_icons_com_74428;
            this.cmdgrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdgrabar.Location = new System.Drawing.Point(283, 259);
            this.cmdgrabar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdgrabar.Name = "cmdgrabar";
            this.cmdgrabar.Size = new System.Drawing.Size(94, 39);
            this.cmdgrabar.TabIndex = 31;
            this.cmdgrabar.Text = "Grabar";
            this.cmdgrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdgrabar.UseVisualStyleBackColor = false;
            this.cmdgrabar.Click += new System.EventHandler(this.cmdgrabar_Click);
            // 
            // cmdnuevo
            // 
            this.cmdnuevo.BackColor = System.Drawing.Color.White;
            this.cmdnuevo.Image = global::TF_JhersonVargas.Properties.Resources.new_file_40454;
            this.cmdnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdnuevo.Location = new System.Drawing.Point(155, 259);
            this.cmdnuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdnuevo.Name = "cmdnuevo";
            this.cmdnuevo.Size = new System.Drawing.Size(95, 39);
            this.cmdnuevo.TabIndex = 30;
            this.cmdnuevo.Text = "Nuevo";
            this.cmdnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdnuevo.UseVisualStyleBackColor = false;
            this.cmdnuevo.Click += new System.EventHandler(this.cmdnuevo_Click);
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(533, 309);
            this.Controls.Add(this.txtTipoCuenta);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dpfechaapertura);
            this.Controls.Add(this.cbcod_cli);
            this.Controls.Add(this.cbcod_banco);
            this.Controls.Add(this.txtnro_cta);
            this.Controls.Add(this.cbnro_sucursal);
            this.Controls.Add(this.cmdgrabar);
            this.Controls.Add(this.cmdnuevo);
            this.Controls.Add(this.cmdbuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.Load += new System.EventHandler(this.CrearCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnro_cta;
        private System.Windows.Forms.ComboBox cbnro_sucursal;
        private System.Windows.Forms.Button cmdgrabar;
        private System.Windows.Forms.Button cmdnuevo;
        private System.Windows.Forms.Button cmdbuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbcod_banco;
        private System.Windows.Forms.ComboBox cbcod_cli;
        private System.Windows.Forms.DateTimePicker dpfechaapertura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtTipoCuenta;
    }
}