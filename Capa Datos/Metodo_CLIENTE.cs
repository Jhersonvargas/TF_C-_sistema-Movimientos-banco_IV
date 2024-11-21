using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AHORA CREAMOS UN METODO PARA LA SIGUINTE TABLA EN NUESTRA BASE DE DATOS

namespace TF_JhersonVargas.Capa_Datos
{

    //CREAMOS UN ARCHIVO LLAMADO METODO CLIENTE, EN EL CUAL ESTARAN LOS ATRIBUTOS
    //DE LA TABLA CLIENTE,  LO ESPECIFICAREMOS COMO PUBLICO, EL TIPO DE DATO, EL
    //NOMBRE DEL ATRIBUTO Y FINALMEMTE COLOCAMOS GET Y SET PARA CONTROLAR EL ACCESO
    //A LOS ATRIBUTOS DE ESTA CLASE.
    internal class Metodo_CLIENTE
    {
        public string cod_cli { get; set; }
        public string dni { get; set; }
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public string direccion { get; set; }
        public string ciudad { get; set; }
        public string email { get; set; }
    }
}
