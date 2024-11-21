using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//                                        FORMULARIO MENU

namespace TF_JhersonVargas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //AHORA CREARREMO UN FORMULARIO MENU, LE AÑADIREMOS UN MENUSTRIP PARA
        //PODER DESPLAZARNOS ENTRE NUESTRO FORMULARIOS CREADOS CREAREMOS DOS SECCIONES,
        //EN LA PRIMERA LLAMADA MANTENIMIENTO: EN LA QUE ENCONTRAREMOS "CREAR CUENTA BANCO"
        //Y LA OTRA LLAMADA CONSULTA: EN LA QUE ENCONTRAREMOS "BUSCAR MOVIMIENTO POR FECHAS"
        //Y "MOSTRAR ,OVIMIENTOS POR FECHA"



        //AL DAR CLIC EN LA SECCION "CREAR CUENTA BANCO" SE NOS ABRIRA EL SIGUIENTE
        //PRIVATE VOID EN EL CUAL REDIRIGRIREMOS A OTRO FORMULARIO LLAMADO CrearCuenta
        //CON TAN SOLO DARLE CLICK AL LA SECCION SELLECCIONADA
        private void crearCuentaDeBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCuenta formSecundario = new CrearCuenta();
            formSecundario.Show();
        }

        //AL DAR CLIC EN LA SECCION "BUSCAR MOVIMIENTO POR FECHAS" SE NOS ABRIRA EL SIGUIENTE
        //PRIVATE VOID EN EL CUAL REDIRIGRIREMOS A OTRO FORMULARIO LLAMADO BuscarMovimientosFecha
        //CON TAN SOLO DARLE CLICK AL LA SECCION SELLECCIONADA
        private void buscarMovimientosPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMovimientosFecha formSecundario = new BuscarMovimientosFecha();
            formSecundario.Show();
        }

        //AL DAR CLIC EN LA SECCION "MOSTRAR MOVIMIENTO POR FECHAS" SE NOS ABRIRA EL SIGUIENTE
        //PRIVATE VOID EN EL CUAL REDIRIGRIREMOS A OTRO FORMULARIO LLAMADO MostrarMovimientosFecha
        //CON TAN SOLO DARLE CLICK AL LA SECCION SELLECCIONADA
        private void mostrarMovimientosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarMovimientosFecha formSecundario = new MostrarMovimientosFecha();
            formSecundario.Show();
        }

        private void registraMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarMovimientos formSecundario = new RegistrarMovimientos();
            formSecundario.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarMovimientosRealizadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MostrarMovimientosFecha formSecundario = new MostrarMovimientosFecha();
            formSecundario.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
