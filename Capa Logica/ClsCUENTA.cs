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

//CREAMOS LA CUENTA BANCO QUE CONTENDRA LA FUNCIONES Y PROCEDIMIENTOS A
//UTILIZAR EN NUESTRO FORMULARIOS Y REPORTES POSTERIORES.

namespace TF_JhersonVargas.Capa_Logica
{

    //DECLARAMOS VARIAS VARIABLES ESTATICAS RELACIONADAS CON EL ACCESO A
    //BASE DE DATOS UTILIZANDO ADO.NET.
    internal class ClsCUENTA
    {
        public static SqlConnection Cn;
        public static SqlCommand Cm;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        //___________________________________________________________

        //CREAMOS EL METOD Llenarcombox_Cuenta USANDO EL PROCEDIMIENTO ALMACENADO Llenar_Cuenta
        //EL CUAL SERA PARA MOSTRAR LOS ELEMENTOS DE BANCO EN EL COMBOX DEL BANCO
        public static void Llenarcombox_Cuenta()
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = ClsConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Llenar_Cuenta";

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt = new DataTable();
            da.Fill(dt);

            Cn.Close();
        }



        //-------------------------------------------------------
        //CREAMOS EL METODO InsertarCuenta USANDO EL PROCEDIMIENTO ALMACENADO CrearCuenta
        //PARA PODER GUARDAR LOS REGISTROS DE LOS CAMPOS DE MI FORMULARIO Y ESTOS SEA ENVIADOS
        // A MI TABLA DE DATOS EN MI BASE DE DATOS
        public static void InsertarCuenta(Metodo_CUENTA c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = ClsConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cm.CommandText = "CrearCuenta";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.Add(new SqlParameter("@nro_cta", SqlDbType.Int));
            Cm.Parameters["@nro_cta"].Value = c.nro_cta;
            Cm.Parameters.Add(new SqlParameter("@nro_sucursal", SqlDbType.Int));
            Cm.Parameters["@nro_sucursal"].Value = c.nro_sucursal;
            Cm.Parameters.Add(new SqlParameter("@cod_banco", SqlDbType.Int));
            Cm.Parameters["@cod_banco"].Value = c.cod_banco;
            Cm.Parameters.Add(new SqlParameter("@cod_cli", SqlDbType.Int));
            Cm.Parameters["@cod_cli"].Value = c.cod_cli;
            Cm.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Float));
            Cm.Parameters["@saldo"].Value = c.saldo;
            Cm.Parameters.Add(new SqlParameter("@fechaapertura", SqlDbType.Date));
            Cm.Parameters["@fechaapertura"].Value = c.fechaapertura;
            Cm.Parameters.Add(new SqlParameter("@tipocta", SqlDbType.VarChar));
            Cm.Parameters["@tipocta"].Value = c.tipocta;

            Cn.Open();
            Cm.ExecuteNonQuery();
            Cn.Close();
        }

        //-----------------------------------------------------
        //CREAMOS EL METODO BuscarCuentas CON EL PROCEDIMIENTO ALMACENADO
        //Consultar_Cuentas_Idcuentas PARA MOSTRAR LOS CAMPOS DE LA TABLS
        //EN EL FORMULARIO AL DAR CLICK EN EL BOTON
        public static void BuscarCuentas(Metodo_CUENTA cuenta)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = ClsConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "Consultar_Cuentas_Idcuentas";
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@nro_cta", cuenta.nro_cta);
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("Cuenta no encontrada");
            }

            while (dr.Read())
            {
                cuenta.nro_cta = int.Parse(dr[0].ToString());
                cuenta.nro_sucursal = int.Parse(dr[1].ToString());
                cuenta.cod_banco = int.Parse(dr[2].ToString());
                cuenta.cod_cli = int.Parse(dr[3].ToString());
                cuenta.saldo = float.Parse(dr[4].ToString());
                cuenta.fechaapertura = DateTime.Parse(dr[5].ToString());
                cuenta.tipocta = dr[6].ToString();
                cuenta.banco_nombre = dr[7].ToString();
                cuenta.ciudad_sucursal = dr[8].ToString();
                cuenta.nombres_cliente = dr[9].ToString();

            }
            
            Cn.Close();
        }

        //-------------------------------------------------------------------
        public static void ColsultarNCuentas(Metodo_CUENTA c)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = ClsConexion.cnCadena();
            Cn.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = Cn;
            da.SelectCommand.CommandText = "Consultar_Cuentas_Idcuentas";
            da.SelectCommand.Parameters.AddWithValue("@nro_cta", c.nro_cta);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            ds = new DataSet();
            da.Fill(ds, "Cargar NCuentas");

            Cn.Close();
        }
        //_----------------------------------------------------------------------

        /*
        public static void BuscarCuentaSucursal(Metodo_CUENTA la)
        {
            Cn = new SqlConnection();
            Cn.ConnectionString = ClsConexion.cnCadena();
            Cm = new SqlCommand();
            Cm.Connection = Cn;
            Cn.Open();
            Cm.CommandText = "VConsultar_Cuenta_Sucursal"; // Reemplaza con el nombre correcto del procedimiento almacenado
            Cm.CommandType = CommandType.StoredProcedure;
            Cm.Parameters.AddWithValue("@nro_sucursal", la.nro_sucursal); // Asegúrate de tener el parámetro correcto
            dr = Cm.ExecuteReader();
            if (dr.HasRows == false)
            {
                throw new Exception("Cuenta no Encontrada");
            }

            while (dr.Read())
            {
                la.nro_cta = int.Parse(dr[0].ToString()); // Asegúrate de tener el índice correcto
                la.nro_sucursal = int.Parse(dr[1].ToString()); // Asegúrate de tener el índice correcto
                la.cod_banco = int.Parse(dr[2].ToString()); // Asegúrate de tener el índice correcto
                la.cod_cli = int.Parse(dr[3].ToString()); // Asegúrate de tener el índice correcto
                la.saldo = float.Parse(dr[4].ToString()); // Asegúrate de tener el índice correcto
                la.fechaapertura = DateTime.Parse(dr[5].ToString()); // Asegúrate de tener el índice correcto
                la.tipocta = dr[6].ToString(); // Asegúrate de tener el índice correcto
            }
            Cn.Close();
        }
        */




























    }
}
