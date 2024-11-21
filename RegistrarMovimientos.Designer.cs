namespace TF_JhersonVargas
{
    partial class RegistrarMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarMovimientos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnro_cuenta = new System.Windows.Forms.TextBox();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnVerMovimientos = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de cuenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe";
            // 
            // txtnro_cuenta
            // 
            this.txtnro_cuenta.Location = new System.Drawing.Point(380, 88);
            this.txtnro_cuenta.Name = "txtnro_cuenta";
            this.txtnro_cuenta.Size = new System.Drawing.Size(100, 26);
            this.txtnro_cuenta.TabIndex = 3;
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(380, 155);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(100, 26);
            this.txtimporte.TabIndex = 4;
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDepositar.Image = ((System.Drawing.Image)(resources.GetObject("btnDepositar.Image")));
            this.btnDepositar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepositar.Location = new System.Drawing.Point(316, 239);
            this.btnDepositar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(119, 46);
            this.btnDepositar.TabIndex = 15;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepositar.UseVisualStyleBackColor = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRetirar.Image = ((System.Drawing.Image)(resources.GetObject("btnRetirar.Image")));
            this.btnRetirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetirar.Location = new System.Drawing.Point(479, 239);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(118, 46);
            this.btnRetirar.TabIndex = 16;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnVerMovimientos
            // 
            this.btnVerMovimientos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerMovimientos.Image = global::TF_JhersonVargas.Properties.Resources.Access2_35731;
            this.btnVerMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerMovimientos.Location = new System.Drawing.Point(557, 111);
            this.btnVerMovimientos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnVerMovimientos.Name = "btnVerMovimientos";
            this.btnVerMovimientos.Size = new System.Drawing.Size(205, 55);
            this.btnVerMovimientos.TabIndex = 18;
            this.btnVerMovimientos.Text = "ver movimientos realizados";
            this.btnVerMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerMovimientos.UseVisualStyleBackColor = false;
            this.btnVerMovimientos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(167, 239);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(118, 46);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // RegistrarMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnVerMovimientos);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.txtnro_cuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarMovimientos";
            this.Text = "RegistrarMovimientos";
            this.Load += new System.EventHandler(this.RegistrarMovimientos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnro_cuenta;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnVerMovimientos;
        private System.Windows.Forms.Button btnNuevo;
    }
}