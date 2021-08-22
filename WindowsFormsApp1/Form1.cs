using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string dni = txt_DNI.Text;
            string nombre = txt_nombre.Text;
            string apellido = txt_Apellido.Text;
            string direccion = txt_direccion.Text;
            string telefono = txt_telefono.Text;
            string email = txt_email.Text;
            string fec_nac = txt_fecha_nac.Text;
            string departamento = txt_departamento.Text;

            dgvUsuarios.Rows.Add("", dni, nombre, apellido, direccion, telefono, email, fec_nac, departamento);

        }
    }
}
