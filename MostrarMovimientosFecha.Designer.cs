namespace TF_JhersonVargas
{
    partial class MostrarMovimientosFecha
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
            this.crystalReportMovimientos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportMovimientos
            // 
            this.crystalReportMovimientos.ActiveViewIndex = -1;
            this.crystalReportMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportMovimientos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportMovimientos.Location = new System.Drawing.Point(0, 0);
            this.crystalReportMovimientos.Name = "crystalReportMovimientos";
            this.crystalReportMovimientos.Size = new System.Drawing.Size(800, 450);
            this.crystalReportMovimientos.TabIndex = 0;
            this.crystalReportMovimientos.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportMovimientos.Load += new System.EventHandler(this.crystalReportMovimientos_Load);
            // 
            // MostrarMovimientosFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportMovimientos);
            this.Name = "MostrarMovimientosFecha";
            this.Text = "MostrarMovimientosFecha";
            this.Load += new System.EventHandler(this.MostrarMovimientosFecha_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportMovimientos;
    }
}