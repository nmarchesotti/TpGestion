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

namespace FrbaCrucero.AbmRol
{
    public partial class BajaRol : Form
    {
        public BajaRol()
        {
            InitializeComponent();
            comboBox1_Load();
        }


        private void comboBox1_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdRol, Nombre from LOS_QUE_VAN_A_APROBAR.Rol where Estado = 'Habilitado'", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("IdRol", typeof(Int32));
            dt.Load(reader);

            comboBox1.ValueMember = "IdRol";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = dt;
            cn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.BajaRol", cn))
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    DataRowView drv = (DataRowView)comboBox1.SelectedItem;
                    Int32 valueOfItem = Convert.ToInt32(drv["IdRol"]);
                    cmd.Parameters.Add("@IdRol", SqlDbType.Int).Value = valueOfItem;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rol dado de baja exitosamente");
                    cn.Close();
                    cn.Dispose();
                    MenuRol form = new MenuRol();
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();
                    this.Dispose();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuRol form = new MenuRol();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }
     }
}
