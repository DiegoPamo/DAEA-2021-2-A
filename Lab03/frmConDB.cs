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

namespace Lab03
{
    public partial class frmConDB : Form
    {
        SqlConnection conn;
        public frmConDB()
        {
            InitializeComponent();
        }

        private void frmConDB_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Declaramos las variables que almacenaran los valores de los TextBox
            //y definimos una cadena de conexion

            String servidor = txtServidor.Text;
            String bd = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";Database=" + bd + ";";

            //La cadena de conexion cambia en funcion del estado del CheckBox
            if (chkAutenticacion.Checked)
                str += "Integrated Security=true";
            else
                str += "User Id=" + user + ";Password=" + pwd + ";";

            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado Satisfactoriamente");
                btnDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar al servidor: \n" + ex.ToString());
            }

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            //Obtenemos el estado de la conexion, en caso de que este abierta
            //recuperamos informacion de la misma
            try
            {
                if (conn.State == ConnectionState.Open)
                    MessageBox.Show("Estado del servidor: " + conn.State +
                        "\nVersion del Servidor: " + conn.ServerVersion +
                        "\nBase de Datos: " + conn.Database);
                else
                    MessageBox.Show("Estado del Servidor: " + conn.State);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible mostrar el estado del servidor: \n" +
                    ex.ToString());
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexion cerrada satisfactoriamente");
                    btnDesconectar.Enabled = false;
                }
                else
                    MessageBox.Show("La conexion ya esta cerrada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al cerrar la conexion: \n" +
                    ex.ToString());
            }
        }

        private void chkAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutenticacion.Checked)
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(conn);
            persona.Show();
        }
    }
}
