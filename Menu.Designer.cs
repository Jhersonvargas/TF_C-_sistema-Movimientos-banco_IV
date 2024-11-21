namespace TF_JhersonVargas
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuentaDeBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMovimientosPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarMovimientosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Sienna;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaDeBancoToolStripMenuItem,
            this.registraMovimientosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // crearCuentaDeBancoToolStripMenuItem
            // 
            this.crearCuentaDeBancoToolStripMenuItem.Name = "crearCuentaDeBancoToolStripMenuItem";
            this.crearCuentaDeBancoToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.crearCuentaDeBancoToolStripMenuItem.Text = "Crear cuenta de banco";
            this.crearCuentaDeBancoToolStripMenuItem.Click += new System.EventHandler(this.crearCuentaDeBancoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarMovimientosPorFechaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // buscarMovimientosPorFechaToolStripMenuItem
            // 
            this.buscarMovimientosPorFechaToolStripMenuItem.Name = "buscarMovimientosPorFechaToolStripMenuItem";
            this.buscarMovimientosPorFechaToolStripMenuItem.Size = new System.Drawing.Size(369, 34);
            this.buscarMovimientosPorFechaToolStripMenuItem.Text = "Buscar movimientos por fecha";
            this.buscarMovimientosPorFechaToolStripMenuItem.Click += new System.EventHandler(this.buscarMovimientosPorFechaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarMovimientosRealizadosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // registraMovimientosToolStripMenuItem
            // 
            this.registraMovimientosToolStripMenuItem.Name = "registraMovimientosToolStripMenuItem";
            this.registraMovimientosToolStripMenuItem.Size = new System.Drawing.Size(291, 34);
            this.registraMovimientosToolStripMenuItem.Text = "Registra movimientos";
            this.registraMovimientosToolStripMenuItem.Click += new System.EventHandler(this.registraMovimientosToolStripMenuItem_Click);
            // 
            // mostrarMovimientosRealizadosToolStripMenuItem
            // 
            this.mostrarMovimientosRealizadosToolStripMenuItem.Name = "mostrarMovimientosRealizadosToolStripMenuItem";
            this.mostrarMovimientosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(369, 34);
            this.mostrarMovimientosRealizadosToolStripMenuItem.Text = "Mostrar movimientos realizados";
            this.mostrarMovimientosRealizadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarMovimientosRealizadosToolStripMenuItem_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaDeBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMovimientosPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarMovimientosRealizadosToolStripMenuItem;
    }
}