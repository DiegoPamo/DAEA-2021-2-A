using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Obtenemos los campos de los input
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            //Cadena de conexion a la base de datos
            string str = "Server=LAPTOP-4QOQIRRG\\LOCAL;Database=db_lab03; Integrated Security=true";

            try
            {
                conn = new SqlConnection(str);
                conn.Open();

                //Consulta para la validacion de cuenta de usuario.
                String consulta = "SELECT usuario_nombre, usuario_password FROM tbl_usuario WHERE usuario_nombre='" +
                              usuario + "' AND usuario_password='" + password + "'";

                SqlCommand cmd = new SqlCommand(consulta, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PrincipalMDI principal = new PrincipalMDI(); //Si la consulta procede con normalidad ejecutar PrincipalMDI
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales proporciondas incorrectas", //Mensaje de la caja de texto
                                    "ADVERTENCIA", //Titulo
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Simbolo de Advertencia
                }


                conn.Close(); //Una vez que ejecute toda la validacion, cerramos la conexion ya que por el momento
                              //no necesitamos jalar datos aun
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexion al servidor: \n" + ex.ToString(),
                                "ERROR", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error); //Simbolo de error
            }

            /*if (usuario == "diego02" && password == "123456")
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Las credenciales brindadas son erroneas",
                                "Error al Iniciar Sesion",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }*/


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
