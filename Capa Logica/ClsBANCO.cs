using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//                                            CLsBANCO

//AGREGAMOS LOS SIGUIENTES TRES USING PARA PODER TRABAJAR CON SQL Y HACER
//LA CONEXION DE LA CAPA LOGICA CON LA CAPA DE DATOS.
using System.Data;
using System.Data.SqlClient;
using TF_JhersonVargas.Capa_Datos;

//CREAMOS LA CLASE BANCO QUE CONTENDRA LA FUNCIONES Y PROCEDIMIENTOS A
//UTILIZAR EN NUESTRO FORMULARIOS Y REPORTES POSTERIORES.

namespace TF_JhersonVargas.Capa_Logica
{

    //DECLARAMOS VARIAS VARIABLES ESTATICAS RELACIONADAS CON EL ACCESO A
    //BASE DE DATOS UTILIZANDO ADO.NET.
    internal class ClsBANCO
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;


        //CREAMOS EL METODO Llenarcombox_Banco USANDO EL PROCEDIMIENTO ALMACENADO Llenar_Banco
        //EL CUAL SERA PARA MOSTRAR LOS ELEMENTOS DE BANCO EN EL COMBOX DEL BANCO
        public static void Llenarcombox_Banco()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = ClsConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Llenar_Banco";

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);

            Cn.Close();
        }





















    }
}
