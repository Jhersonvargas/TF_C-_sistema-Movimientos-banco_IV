using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AHORA CREAMOS UN METODO PARA LA SIGUINTE TABLA EN NUESTRA BASE DE DATOS

namespace TF_JhersonVargas.Capa_Datos
{

    //CREAMOS UN ARCHIVO LLAMADO METODO CUENTA, EN EL CUAL ESTARAN LOS ATRIBUTOS
    //DE LA TABLA CUENTA,  LO ESPECIFICAREMOS COMO PUBLICO, EL TIPO DE DATO, EL
    //NOMBRE DEL ATRIBUTO Y FINALMEMTE COLOCAMOS GET Y SET PARA CONTROLAR EL ACCESO
    //A LOS ATRIBUTOS DE ESTA CLASE.
    internal class Metodo_CUENTA
    {
        public int nro_cta { get; set; }
        public int nro_sucursal { get; set; }
        public int cod_banco { get; set; }
        public int cod_cli { get; set; }
        public float saldo { get; set; }
        public DateTime fechaapertura { get; set; }
        public string tipocta { get; set; }
        public string banco_nombre { get; set; }
        public string ciudad_sucursal { get; set; }
        public string nombres_cliente { get; set; }
    }
}
