using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FINALMENTE CREAMOS UN METODO PARA LA ULTIMA TABLA EN NUESTRA BASE DE DATOS

namespace TF_JhersonVargas.Capa_Datos
{

    //CREAMOS UN ARCHIVO LLAMADO METODO SURCUSAL, EN EL CUAL ESTARAN LOS ATRIBUTOS
    //DE LA TABLA SURCUSAL,  LO ESPECIFICAREMOS COMO PUBLICO, EL TIPO DE DATO, EL
    //NOMBRE DEL ATRIBUTO Y FINALMEMTE COLOCAMOS GET Y SET PARA CONTROLAR EL ACCESO
    //A LOS ATRIBUTOS DE ESTA CLASE.
    internal class Metodo_SUCURSAL
    {
        public int nro_sucursal { get; set; }
        public int cod_banco { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public int telefono { get; set; }
    }
}
