using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF_JhersonVargas.Capa_Datos;
using TF_JhersonVargas.Capa_Logica;

namespace TF_JhersonVargas
{
    public partial class Ventanilla : Form
    {
        public Ventanilla()
        {
            InitializeComponent();
        }


        private void LlenarSaldo()
        {
            
        }



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Metodo_CUENTA Gl = new Metodo_CUENTA();
            Gl.nro_cta = Convert.ToInt32(txtBuscar.Text);
            ClsCUENTA.ColsultarNCuentas(Gl);
            dataGridCL.DataSource = ClsCUENTA.ds;
            dataGridCL.DataMember = "Cargar NCuentas";
        }

        private void Ventanilla_Load(object sender, EventArgs e)
        {
            //DateTime fecha = DateTime.Now;
            //lblFechaApertura.Text = fecha.ToString();
        }

        //el siguiente boton realiza el retiro de la cuenta de dsaldo a traves de la funcion
        private void BTQuitar_Click(object sender, EventArgs e)
        {
            try
            {

                // Obtener el número de cuenta
                int nroCuenta = Convert.ToInt32(txtBuscar.Text);

                // Obtener el importe del retiro
                double importe = Convert.ToDouble(txtImporte.Text);

                // Llamar al método de la capa lógica para realizar el retiro
                ClsMOVIMIENTOS.RealizarRetiro(nroCuenta, importe);

                MessageBox.Show("Retiro realizado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el retiro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridCL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LblNcuenta.Text = this.dataGridCL.Rows[e.RowIndex].Cells[0].Value.ToString();
            LblCsucursal.Text = this.dataGridCL.Rows[e.RowIndex].Cells[8].Value.ToString();
            lblBanco.Text = this.dataGridCL.Rows[e.RowIndex].Cells[7].Value.ToString();
            lblNCliente.Text = this.dataGridCL.Rows[e.RowIndex].Cells[9].Value.ToString();
            lblSaldo.Text = this.dataGridCL.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblTipoCuenta.Text = this.dataGridCL.Rows[e.RowIndex].Cells[6].Value.ToString();
            
            DateTime fecha = (DateTime)this.dataGridCL.Rows[e.RowIndex].Cells[5].Value;
            string fechaFormateada = fecha.ToString("dd-MM-yyyy"); //Defino el formato que quiero que se miestre en el label

            lblFechaApertura.Text = fechaFormateada;
        }

        private void dataGridCL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                // Obtener el número de cuenta
                int nroCuenta = Convert.ToInt32(txtBuscar.Text);

                // Obtener el importe del depósito
                double importe = Convert.ToDouble(txtImporte.Text);

                // Llamar al método de la capa lógica para realizar el depósito
                ClsMOVIMIENTOS.RealizarDeposito(nroCuenta, importe);

                MessageBox.Show("Depósito realizado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el depósito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblSaldo.Text = this.dataGridCL.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
