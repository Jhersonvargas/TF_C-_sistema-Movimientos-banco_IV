using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AHORA CREAMOS UN METODO PARA LA SIGUINTE TABLA EN NUESTRA BASE DE DATOS

namespace TF_JhersonVargas.Capa_Datos
{

    //CREAMOS UN ARCHIVO LLAMADO METODO MOVIMIENTOS, EN EL CUAL ESTARAN LOS ATRIBUTOS
    //DE LA TABLA MOVIMIENTOS,  LO ESPECIFICAREMOS COMO PUBLICO, EL TIPO DE DATO, EL
    //NOMBRE DEL ATRIBUTO Y FINALMEMTE COLOCAMOS GET Y SET PARA CONTROLAR EL ACCESO
    //A LOS ATRIBUTOS DE ESTA CLASE.
    internal class Metodo_MOVIMIENTOS
    {
        public int nro_mov { get; set; }
        public int nro_cta { get; set; }
        public int nro_sucursal { get; set; }
        public int cod_banco { get; set; }
        public string tipo_mov { get; set; }
        public DateTime fecha_mov { get; set; }
        public decimal importe { get; set; }
        public DateTime año{ get; set; }
        public DateTime año2 { get; set; }
    }
}
