﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class AltaCrucero : Form
    {
        public AltaCrucero()
        {
            InitializeComponent();
            comboBoxMarca_Load();
            comboBoxModelo_Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMCrucero form = new ABMCrucero();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void comboBoxModelo_Load(){

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdModelo, Descripcion from LOS_QUE_VAN_A_APROBAR.Modelo", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdModelo", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);

            comboBoxModelo.SelectedValue = "Descripcion";
            comboBoxModelo.DisplayMember = "Descripcion";
            comboBoxModelo.DataSource = dt;
            cn.Close();
        }

        private void comboBoxMarca_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdMarca, Descripcion from LOS_QUE_VAN_A_APROBAR.Marca", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdMarca", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));
            dt.Load(reader);

            comboBoxMarca.ValueMember = "Descripcion";
            comboBoxMarca.DisplayMember = "Descripcion";
            comboBoxMarca.DataSource = dt;
            cn.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCantidadCabinas.Text == "" || txtNombreCrucero.Text == "")
            {
                MessageBox.Show("Debe ingresar los valores obligatorios");
            }
            else
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.AltaCrucero", cn))
                    {
                        try
                        {
                            cn.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@IdCrucero", SqlDbType.NVarChar, 50).Value = txtNombreCrucero.Text;

                            DataRowView drv = (DataRowView)comboBoxMarca.SelectedItem;
                            int marca = Convert.ToInt32(drv["IdMarca"]);
                            cmd.Parameters.Add("@IdMarca", SqlDbType.Int).Value = marca;

                            DataRowView drv2 = (DataRowView)comboBoxModelo.SelectedItem;
                            int modelo = Convert.ToInt32(drv2["IdModelo"]);
                            cmd.Parameters.Add("@IdModelo", SqlDbType.Int).Value = modelo;

                            cmd.Parameters.Add("@CantidadCabinas", SqlDbType.Int).Value = txtCantidadCabinas.Text;


                            int resultado = cmd.ExecuteNonQuery();
                            if (resultado != 1) { MessageBox.Show("Ya existe crucero"); }
                            else
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Crucero creado correctamente");

                            }
                            cn.Close();
                            cn.Dispose();
                            this.Dispose();
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("La cantidad de cabinas debe ser un numero entero positivo");
                        }


                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNombreCrucero.Clear();
            txtCantidadCabinas.Clear();
        }

        private void txtNombreCrucero_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
