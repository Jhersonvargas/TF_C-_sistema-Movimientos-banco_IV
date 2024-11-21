using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//                                        FORMULARIO MostrarMovimientosFecha

namespace TF_JhersonVargas
{
    public partial class MostrarMovimientosFecha : Form
    {
        //AHORA CREARENOS UN CRYSTAL REPORT, NOS DIRIGIREMOS A A GREGAR ELEMNTOS Y ELEGIMOS EL CRYSTAL REPORT,
        //DESPUES SEGUIREMOS LOS PASOS Y ECOGEREMOS QUE FUNCIONE CON UN PROCEDIMIENTO CREADO EN LA BASE DE
        //DATOS EL CUAL MUESTRA LOS MOVIMINETO SPOR FECHAS, DEPUES DE ESO EDITAREMOS LA PRESENTACION DE LOS
        //CAMPOS EN EL REPORTE Y YA ESTARIA LISTO SU FUNCIONAMIENTO SOLO PARA SE LLAMADO Y ENVIAR LOS PARRAMETRO
        //NECESRIOS PARA QUE FUNCIONE.


        //LUEGO CREAREMOS OTRO FORMULARIO LLAMADO MostrarMovimientosFecha EL CUAL LE AGREAGREMOS UN CRYSTAL
        //REPORT VIEWER QUE ES EN DONDE SE MOSTRARA EL REPORTE CREADO

        //CREAMOS DOS VARIABLES PUBLICAS AÑO Y AÑO2 QUE SERA LAS QUE RESIBIRAN
        //LOS PARAMETOS PRA REALIZAR LAS FUNCION DE MOSTRA POR AÑOS
        public int año = 0;
        public int año2 = 0;

        public MostrarMovimientosFecha()
        {
            InitializeComponent();
        }

        //HAREMOS CLICK EN EL FORMULARIO PARA QUE SE NOS ABRA EL SIGUIENTE EVENTO LOAD,
        //DENTRO DE ESTE HAREMOS USO DEL REPORTE CREADO Y EL crystalReportMovimientos
        //PARA PODER VISUALIZARLO A TRAVES DE UNA LLAMADA DESPUES DE RECIBIR LOS
        //PARAMETRO DE AÑOS PARA MOSTRA LOS INTERVALOS DE FECHA
        private void MostrarMovimientosFecha_Load(object sender, EventArgs e)
        {
            ReporteMovimientos reporte = new ReporteMovimientos();
            crystalReportMovimientos.ReportSource = reporte;
            reporte.SetParameterValue("@año", this.año);
            reporte.SetParameterValue("@año2", this.año2);

            //AÑADIMOS EL USUARIO Y CONTRASEÑA DE NUESTRA BASE DE DATOS
            reporte.SetDatabaseLogon("sa", "12345");

            //ENVIAMOS TODOS LO DE REPORTE AL crystalReportMovimientos PARA PODER CARAGR
            //EL REPORTE Y PODER VISUALIZARLO
            crystalReportMovimientos.ReportSource = reporte;
        }

        private void crystalReportMovimientos_Load(object sender, EventArgs e)
        {

        }
    }
}
