using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//                                        FORMULARIO ACCESO

//AÑADIR LAs CONEXIONES A LA CAPA DE DATOS Y CAPA LOGICA QUE ES DONDE
//SE ENCUENTRAS LOS METODOS Y LAS CLASES
using System.Windows.Forms;
using TF_JhersonVargas.Capa_Datos;
using TF_JhersonVargas.Capa_Logica;



namespace TF_JhersonVargas
{
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //HACEMOS CLICK EN EL BOTON INGRESAR EN EL CUAL SE ABRIRA EL SIGUIENTE PRIVATE VOID,
        //EN ESTE CODIGO HAREMOS USO DE EL METODO CLIENTE PARA VALIDAR EL CODIGO DEL CLIENTE
        //QUE SERA EL ID INGRESADO EN EL TXTBOX, LO MISMO SERA CON EL DNI EL CUAL EN ESTE CASO
        //SERA LA CLAVE DEL LOGIN
        private void btningresar_Click(object sender, EventArgs e)
        {
            Metodo_CLIENTE Gl = new Metodo_CLIENTE();
            Gl.cod_cli = txtusuario.Text;
            Gl.dni = txtclave.Text;
            try
            {

                //HAREMOS USO DE LA CLASE CLIENTE QUE ES EN DONDE CREAMOS UN METODO, EL CUAL LLAMAMOS
                //"VALIDAUSUARIO", SI EL METODO VALIDA CORRECTAMENTE LOS DOS CAMPOS NOS REDIRIGIRA A
                //OTRO FORMULARIO 
                ClsCLIENTE.ValidarUsuario(Gl);
                Menu formPrincipal = new Menu();
                formPrincipal.Show();

                // USAREMOS THIS. HIDE PARA QUE CIERRE el formulario de acceso (FormAcceso)
                this.Hide();
            }
            //EN EL CASO LOS CAMPOS PARA VALIDAR EL USUARIO SEAN INCORRECTOS, AÑADIREMOS UNA
            //EXCEPCION PARA CONTROLAR EL ERROR Y NOS PERMITA SEGUIR TRABAJANDO, ESTO HARA QUE
            //NOS MUESTRE UN MENSAJE DE "USUARIO INCORRECTO"
            catch (Exception) { MessageBox.Show("Usuario no encontrado"); }
            txtusuario.Text = Gl.cod_cli;
            txtclave.Text = Gl.dni;
        }
    }
}
