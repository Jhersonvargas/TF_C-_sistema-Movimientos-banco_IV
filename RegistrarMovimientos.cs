using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF_JhersonVargas.Capa_Logica;

//                                  FORMULARIO REGISTRA MOVIMIENTO Y ACTUALIZACION DEL SALDO

namespace TF_JhersonVargas
{
    public partial class RegistrarMovimientos : Form
    {
        public RegistrarMovimientos()
        {
            InitializeComponent();
        }


        // EN ESTE BOTON HAREMOS USO DEL LA CLASE MOVIMIENTOS PARA LLAMAR A LA FUNCION RealizarDeposito
        //TOMAREMOS LOS PARAMETROS DE DOS TEXBOX
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número de cuenta
                int nroCuenta = Convert.ToInt32(txtnro_cuenta.Text);

                // Obtener el importe del depósito
                double importe = Convert.ToDouble(txtimporte.Text);

                // Llamar al método de la capa lógica para realizar el depósito
                ClsMOVIMIENTOS.RealizarDeposito(nroCuenta, importe);

                MessageBox.Show("Depósito realizado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el depósito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // EN ESTE BOTON HAREMOS USO DEL LA CLASE MOVIMIENTOS PARA LLAMAR A LA FUNCION RealizarRetiro
        //TOMAREMOS LOS PARAMETROS DE DOS TEXBOX
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el número de cuenta
                int nroCuenta = Convert.ToInt32(txtnro_cuenta.Text);

                // Obtener el importe del depósito
                double importe = Convert.ToDouble(txtimporte.Text);

                // Llamar al método de la capa lógica para realizar el depósito
                ClsMOVIMIENTOS.RealizarDeposito(nroCuenta, importe);

                MessageBox.Show("Depósito realizado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el depósito: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarMovimientos_Load(object sender, EventArgs e)
        {

        }

        //ESTE BOTON NOS  REDIGIRA A OTRO FORMULARIO EN DONDE VEREMOS LOS MOVIMIENTOS REALIZADOS 
        //CATEGORIZADOS POR AÑOS
        private void button1_Click_1(object sender, EventArgs e)
        {
            BuscarMovimientosFecha formSecundario = new BuscarMovimientosFecha();
            formSecundario.Show();
        }


        //ESTE BOTON SERA PARA LIMPIAR LOS CAMPOS DEL FORMULARIO
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtnro_cuenta.Text = "";
            txtimporte.Text = "";
        }
    }
}
