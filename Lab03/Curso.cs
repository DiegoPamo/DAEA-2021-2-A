﻿using System;
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
    public partial class Curso : Form
    {
        SqlConnection conn;
        public Curso(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "SELECT * FROM Course";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvCursos.DataSource = dt;
                dgvCursos.Refresh();
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String Tittle = txtCurso.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarCursoNombre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Title";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = Tittle;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvCursos.DataSource = dt;
                dgvCursos.Refresh();
            }
            else
            {
                MessageBox.Show("La conexion esta cerrada");
            }
        }
    }
}
