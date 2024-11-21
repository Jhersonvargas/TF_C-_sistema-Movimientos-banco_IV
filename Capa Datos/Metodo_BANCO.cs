using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//AHORA CREAMOS UN METODO PARA CADA TABLA QUE TENGAMOS EN NUESTRA BASE DE DATOS

namespace TF_JhersonVargas.Capa_Datos
{
    //CREAMOS UN ARCHIVO LLAMADO METODO BANCO, EN EL CUAL ESTARAN LOS ATRIBUTOS
    //DE LA TABLA BANCO,  LO ESPECIFICAREMOS COMO PUBLICO, EL TIPO DE DATO, EL
    //NOMBRE DEL ATRIBUTO Y FINALMEMTE COLOCAMOS GET Y SET PARA CONTROLAR EL ACCESO
    //A LOS ATRIBUTOS DE ESTA CLASE.
    internal class Metodo_BANCO
    {
        public int cod_banco { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }

    }
}

