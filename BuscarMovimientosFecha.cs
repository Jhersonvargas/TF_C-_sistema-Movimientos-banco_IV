using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//                                        FORMULARIO BuscarMovimientosFecha

namespace TF_JhersonVargas
{
    public partial class BuscarMovimientosFecha : Form
    {
        public BuscarMovimientosFecha()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e, int fechaDesde)
        {



           
        }

        private void txthasta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesde_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAñoDesde_Click(object sender, EventArgs e)
        {

        }

        //ESTANDO EN EL FORMULARIO BUSCAR MOVIMIENTOS POR FECHA, LO QUE HAREMOS AQUI ES
        //CREAR UN CODIGO DENTRO DEL BOTON IMPRIMIR, ESTO PARA QUE AL INGRESAR LOS
        //PARAMETROS AÑO Y AÑO2 NOS REDIRIJA A OTRA FORMULARIO DONDE CON UN CRYSTALREPORT
        //NOS MOSTRARA EL REGISTRO DE LOS MOVIMIENTOS ENTRE ESAS FECHAS 
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MostrarMovimientosFecha imprimirmovimientos = new MostrarMovimientosFecha();
            imprimirmovimientos.año = int.Parse(this.txtdesde.Text);
            imprimirmovimientos.año2 = int.Parse(this.txthasta.Text);
            imprimirmovimientos.ShowDialog();
        }

        private void BuscarMovimientosFecha_Load(object sender, EventArgs e)
        {

        }
    }
}
