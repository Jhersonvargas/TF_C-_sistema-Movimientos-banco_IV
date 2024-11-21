namespace TF_JhersonVargas
{
    partial class BuscarMovimientosFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarMovimientosFecha));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txthasta = new System.Windows.Forms.TextBox();
            this.txtdesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAñoDesde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(338, 230);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(119, 46);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(514, 174);
            this.txthasta.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(135, 26);
            this.txthasta.TabIndex = 13;
            this.txthasta.TextChanged += new System.EventHandler(this.txthasta_TextChanged);
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(247, 174);
            this.txtdesde.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(135, 26);
            this.txtdesde.TabIndex = 12;
            this.txtdesde.TextChanged += new System.EventHandler(this.txtdesde_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Año Hasta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAñoDesde
            // 
            this.lblAñoDesde.AutoSize = true;
            this.lblAñoDesde.Location = new System.Drawing.Point(152, 178);
            this.lblAñoDesde.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAñoDesde.Name = "lblAñoDesde";
            this.lblAñoDesde.Size = new System.Drawing.Size(93, 20);
            this.lblAñoDesde.TabIndex = 10;
            this.lblAñoDesde.Text = "Año Desde:";
            this.lblAñoDesde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAñoDesde.Click += new System.EventHandler(this.lblAñoDesde_Click);
            // 
            // BuscarMovimientosFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.txtdesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAñoDesde);
            this.Name = "BuscarMovimientosFecha";
            this.Text = "BuscarMovimientosFecha";
            this.Load += new System.EventHandler(this.BuscarMovimientosFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txthasta;
        private System.Windows.Forms.TextBox txtdesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAñoDesde;
    }
}