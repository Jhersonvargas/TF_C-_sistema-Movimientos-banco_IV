using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CREAMOS LA CLASE CONEXION DENTRO DE UNA CARPETA LLAMAADA 'CAPA DATOS'

namespace TF_JhersonVargas.Capa_Datos
{
    internal class ClsConexion
    {
        public static string cnCadena()
        {
            //CREAMOS LA CONEXION DE MI PROYECTO VON LA BASE DE DATOS
            //CREADA ES SQL SERVER, COLOCAMOS EL NOMBRE DEL SERVIDOR,
            //NOMBRE DE LA BASE DE DATOS, USUARIO Y CONTRASEÑA DE LA BASE DE DATOS.

            string str = "SERVER = MAICOL\\SQLEXPRESS; DataBase=MovimientosBanco; UID=sa;PWD=12345";
            return str;
        }
    }
}






