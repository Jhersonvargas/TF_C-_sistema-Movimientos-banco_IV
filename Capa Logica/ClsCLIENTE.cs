using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//                                            CLsCUENTA

//AGREGAMOS LOS SIGUIENTES TRES USING PARA PODER TRABAJAR CON SQL Y HACER
//LA CONEXION DE LA CAPA LOGICA CON LA CAPA DE DATOS.
using System.Data;
using System.Data.SqlClient;
using TF_JhersonVargas.Capa_Datos;

//CREAMOS LA CLASE CLIENTE QUE CONTENDRA LA FUNCIONES Y PROCEDIMIENTOS A
//UTILIZAR EN NUESTRO FORMULARIOS Y REPORTES POSTERIORES.

namespace TF_JhersonVargas.Capa_Logica
{

    //DECLARAMOS VARIAS VARIABLES ESTATICAS RELACIONADAS CON EL ACCESO A
    //BASE DE DATOS UTILIZANDO ADO.NET.
    internal class ClsCLIENTE
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;


        //VALIDAR USUARIO PARA EL FORMULARIO DE LOGIN
        public static void ValidarUsuario(Metodo_CLIENTE c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = ClsConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "validar_usuario";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@cod_cli", c.cod_cli);
            Cm.Parameters.AddWithValue("@dni", c.dni);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("Usuario no encontrado");
            }

            while (dr.Read())
            {
                c.cod_cli = dr[0].ToString();
                c.dni = dr[1].ToString();

            }
            Cn.Close();

        }



        //LLENAR COMBOX DEL FORMULARIO
        public static void Llenarcombox_Cliente()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = ClsConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Llenar_Cliente";

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);

            Cn.Close();
        }
















    }
}
