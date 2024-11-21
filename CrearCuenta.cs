using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//                                        FORMULARIO CrearCuenta

//AÑADIR LAs CONEXIONES A LA CAPA DE DATOS Y CAPA LOGICA QUE ES DONDE
//SE ENCUENTRAS LOS METODOS Y LAS CLASES
using System.Windows.Forms;
using TF_JhersonVargas.Capa_Datos;
using TF_JhersonVargas.Capa_Logica;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace TF_JhersonVargas
{
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        //CREAREMOS LOS SIGUIENTES PRIVATE VOID PATRA MOSTRAR LOS DATOS EN LOS COMBOX DEL FORMULARIO:

        //EMPEZAREMOS CREANDO EL PRIVATE VOID LlenarSucursal EL CUAL USARA LA CLASE SURCURSAL QUE LLAMARA
        //AL METODO LlenarcomboxSucursal, DESPUES MOSTRARA LOS PARAMETRO INDICADOS EN EL COMBOX 
        private void LlenarSucursal()
        {
            ClsSUCURSAL.LlenarcomboxSucursal();
            cbnro_sucursal.DataSource = ClsSUCURSAL.dt;
            cbnro_sucursal.DisplayMember = "ciudad";
            cbnro_sucursal.ValueMember = "nro_sucursal";
            cbnro_sucursal.Text = "Seleccionar";
        }

        //EMPEZAREMOS CREANDO EL PRIVATE VOID LlenarBanco EL CUAL USARA LA CLASE BANCO QUE LLAMARA
        //AL METODO Llenarcombox_Banco, DESPUES MOSTRARA LOS PARAMETRO INDICADOS EN EL COMBOX
        private void LlenarBanco()
        {
            ClsBANCO.Llenarcombox_Banco();
            cbcod_banco.DataSource = ClsBANCO.dt;
            cbcod_banco.DisplayMember = "nombre";
            cbcod_banco.ValueMember = "cod_banco";
            cbcod_banco.Text = "Seleccionar";
        }

        //EMPEZAREMOS CREANDO EL PRIVATE VOID LlenarCliente EL CUAL USARA LA CLASE CLIENTE QUE LLAMARA
        //AL METODO Llenarcombox_Cliente, DESPUES MOSTRARA LOS PARAMETRO INDICADOS EN EL COMBOX
        private void LlenarCliente()
        {
            ClsCLIENTE.Llenarcombox_Cliente();
            cbcod_cli.DataSource = ClsCLIENTE.dt;
            cbcod_cli.DisplayMember = "nombres";
            cbcod_cli.ValueMember = "cod_cli";
            cbcod_cli.Text = "Seleccionar";
        }

        



        //HAREMOS CLICK EN EL FORMULARIO Y NOS ABRIRA EL SIGUIENTE PRIVATE VOID DL FORMULARIO
        //LLAMADAO "CREARCUENTA", DENTRO DE ESTE LLAMAREMOS A LOS METODOS LLENAR SUCURSAL,
        //LLENAR BANCO Y LLENAR CLIENTE, LO QUE HARAN ESTOS SERA MOSTRA LOS PARAMETRO EN LOS
        //COMBOX DEL FORMULARIO PARA PODER SER SELLECIONADOS.
        private void CrearCuenta_Load(object sender, EventArgs e)
        {
            LlenarSucursal();
            LlenarBanco();
            LlenarCliente();
            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnro_cta_Click(object sender, EventArgs e)
        {
            
        }

        //CREARE UN EVENTO DE CLICK PARA MI COMBOX SURCURSAL, DENTRO
        //DE ESTE LLAMARE AL METODO CREADO LLENAR SUCURSAL QUE SERVIRA
        //PARA MOSTRAR LOS DATOS EN EL COMBOX ASIGNADO EN MI FORMULARIO
        private void cbnro_sucursal_Click(object sender, EventArgs e)
        {
            LlenarSucursal();
        }

        //CREARE UN EVENTO DE CLICK PARA MI COMBOX BANCO, DENTRO
        //DE ESTE LLAMARE AL METODO CREADO LlenarBanco() QUE SERVIRA
        //PARA MOSTRAR LOS DATOS EN EL COMBOX ASIGNADO EN MI FORMULARIO
        private void cbcod_banco_Click(object sender, EventArgs e)
        {
            LlenarBanco();
        }

        //CREARE UN EVENTO DE CLICK PARA MI COMBOX CLIENTE, DENTRO
        //DE ESTE LLAMARE AL METODO CREADO LlenarCliente()() QUE SERVIRA
        //PARA MOSTRAR LOS DATOS EN EL COMBOX ASIGNADO EN MI FORMULARIO
        private void cbcod_cli_Click(object sender, EventArgs e)
        {
            LlenarCliente();
        }

        private void cbtipocta_Click(object sender, EventArgs e)
        {
            
        }


        //ESTANDO EN EL FORMULARIO "CREARCUENTA", LO QUE HAREMOS AQUI ES
        //CREAR UN CODIGO DENTRO DEL BOTON GRABAR, ESTO PARA QUE TODOS LOS
        //PARAMETROS INGRESADOS EN LOS TEXBOX Y COMBOX DEL FORMULARIO SE
        //GUARDEN EN LA TABLA CUENTA COMO NUEVO REGISTRO, PARA ESTO HACEMOS
        //USO DEL METODO CUENTA, CONVERTIMOS LOS DATOS PARA QUE PUEDAN SER
        //ALMACENADOS, HACEMOS USO DE LA CLASE CUENTAS PARA LLAMAR UNA FUNCION
        //LLAMARA INSERTACUENTA PARA GUARDAR ESTOS DATOS EN LA TABLA DE SQL SERVER.
        private void cmdgrabar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea guardar la información en la base de datos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Metodo_CUENTA cuenta = new Metodo_CUENTA();

                // Obtener el número de cuenta
                cuenta.nro_cta = Convert.ToInt32(txtnro_cta.Text);

                // Obtener los valores seleccionados de los ComboBox
                
                cuenta.nro_sucursal = Convert.ToInt32(cbnro_sucursal.SelectedValue);
                cuenta.cod_banco = Convert.ToInt32(cbcod_banco.SelectedValue);
                cuenta.cod_cli = Convert.ToInt32(cbcod_cli.SelectedValue);
                cuenta.saldo = (float)Convert.ToDouble(txtSaldo.Text);
                cuenta.fechaapertura = DateTime.Parse(dpfechaapertura.Text);
                // Obtener el valor de tripocta desde el TextBox
                cuenta.tipocta = txtTipoCuenta.Text;

                // Llamada al método para insertar en la base de datos
                ClsCUENTA.InsertarCuenta(cuenta);

                MessageBox.Show("La cuenta se ha guardado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmdeditar_Click(object sender, EventArgs e)
        {

        }

        private void cbtipocta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //DENTRO DEL FORMULARIO USAREMOS UN FOREACH Y ESTABLECEREMOS UN CONTROL
        //PARA VACIAR TODOS LOS TECBOX, COMBOX Y DATAPICKER PRESENTES EN MI
        //FORMULARIO DE CREA CUENTA 
        private void cmdnuevo_Click(object sender, EventArgs e)
        {
            // Limpio las casillas y controles del formulario
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    // En el caso que sea un textbox se va a poner en blanco
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    // En el caso que sea un combobox se va a poner "seleccionar en ves de mostrar algun nombre de index
                    LimpiarCampos();               
                }

                dpfechaapertura.Text = string.Empty;

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        //CREARREMO EL CODIGO PARA EL BOTON BUSCAR, AQUI HAREMOS USO DEL Metodo_CUENTA
        //TAMBIEN DE EL METODO BuscarCuentas PARA DEVOLVERNOS LOS PARAMETROS EN LOS CAMPOS
        //DEL FORMULARIO
        private void cmdbuscar_Click(object sender, EventArgs e)
        {

            Metodo_CUENTA cuenta = new Metodo_CUENTA();
            cuenta.nro_cta = Convert.ToInt32(txtnro_cta.Text); // Asegúrate de obtener el valor correcto del ComboBox

            try
            {
                ClsCUENTA.BuscarCuentas(cuenta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cuenta no encontrada");
                LimpiarCampos(); // Limpia los campos si la cuenta no se encuentra
                return; // Sale del método sin seguir ejecutando el código
            }

            txtnro_cta.Text = cuenta.nro_cta.ToString();
            /*
            cbcod_banco.SelectedText = cuenta.banco_nombre;
            cbcod_cli.SelectedText = cuenta.nombres_cliente;
            cbnro_sucursal.SelectedText = cuenta.ciudad_sucursal;
            //*/
            //*
            cbnro_sucursal.SelectedValue = cuenta.nro_sucursal;
            cbcod_banco.SelectedValue = cuenta.cod_banco;
            cbcod_cli.SelectedValue = cuenta.cod_cli;
            //*/
            txtSaldo.Text = cuenta.saldo.ToString();
            dpfechaapertura.Value = cuenta.fechaapertura;
            txtTipoCuenta.Text = cuenta.tipocta;
        }



        //CREAMOS ESTE PRIVAE VOID DE LimpiarCampos QUE LUEGO LLAMAREMOS 
        //EN EL BOTIN BUSCAR PARA MANEJAR UN ERROR
        private void LimpiarCampos()
        {
            // Limpia los campos del formulario
            txtnro_cta.Text = "";
            cbnro_sucursal.SelectedIndex = -1;
            cbcod_banco.SelectedIndex = -1;
            cbcod_cli.SelectedIndex = -1;
            cbcod_banco.Text = "Seleccionar";
            cbcod_cli.Text = "Seleccionar";
            cbnro_sucursal.Text = "Seleccionar";
            txtSaldo.Text = "";
            dpfechaapertura.Value = DateTime.Today;
            txtTipoCuenta.Text = "";
        }

        private void cbnro_sucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbcod_banco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnro_cta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
