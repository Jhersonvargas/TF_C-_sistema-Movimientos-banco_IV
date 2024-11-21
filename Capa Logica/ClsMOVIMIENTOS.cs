using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//                                            CLsMOVIMIENTOS

//AGREGAMOS LOS SIGUIENTES TRES USING PARA PODER TRABAJAR CON SQL Y HACER
//LA CONEXION DE LA CAPA LOGICA CON LA CAPA DE DATOS.
using System.Data;
using System.Data.SqlClient;
using TF_JhersonVargas.Capa_Datos;

//CREAMOS LA CLASE MOVIMIENTOS QUE CONTENDRA LA FUNCIONES Y PROCEDIMIENTOS A
//UTILIZAR EN NUESTRO FORMULARIOS Y REPORTES POSTERIORES.

namespace TF_JhersonVargas.Capa_Logica
{

    //DECLARAMOS VARIAS VARIABLES ESTATICAS RELACIONADAS CON EL ACCESO A
    //BASE DE DATOS UTILIZANDO ADO.NET.
    internal class ClsMOVIMIENTOS
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;


        //-----------------------------------------------------------------------------------------------

        //CREAMOS LA SIGUIENTE FUNCION QUE HARA USO DEL PROCEDIMIENTO ALMACENADO RealizarDeposito
        //EL CUAL FUNCIONARA CON EL PARAMETRO nro_cta E importe PARA ACTAULIZAR EL ESTADO SE SALDO
        //DE LA CUENTA Y A LA VEZ INCORPORAR UN REGISTRO EN LA TABLA MOVIMIENTOS
        public static void RealizarDeposito(int nroCuenta, double importe)
        {
            using (SqlConnection connection = new SqlConnection(ClsConexion.cnCadena()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("RealizarDeposito", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@nro_cta", SqlDbType.Int)).Value = nroCuenta;
                    command.Parameters.Add(new SqlParameter("@importe", SqlDbType.Float)).Value = importe;

                    command.ExecuteNonQuery();
                }
            }
        }


        //-------------------------------------------------------------------------------------------------


        //CREAMOS LA SIGUIENTE FUNCION QUE HARA USO DEL PROCEDIMIENTO ALMACENADO RealizarRetiro
        //EL CUAL FUNCIONARA CON EL PARAMETRO nro_cta E importe PARA ACTAULIZAR EL ESTADO SE SALDO
        //DE LA CUENTA Y A LA VEZ INCORPORAR UN REGISTRO EN LA TABLA MOVIMIENTOS
        public static void RealizarRetiro(int nroCuenta, double importe)
        {
            using (SqlConnection connection = new SqlConnection(ClsConexion.cnCadena()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("RealizarRetiro", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@nro_cta", SqlDbType.Int)).Value = nroCuenta;
                    command.Parameters.Add(new SqlParameter("@importe", SqlDbType.Float)).Value = importe;

                    command.ExecuteNonQuery();
                }
            }
        }


































    }
}
