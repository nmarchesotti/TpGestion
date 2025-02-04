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
    public partial class EleccionBaja : Form
    {
        string IdCrucero;
        public EleccionBaja(string IdCrucero)
        {
            InitializeComponent();
            this.IdCrucero = IdCrucero;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    if (checkBox1.Checked)
                    {
                        DateTime fechaAReprogramar = Convert.ToDateTime(dateTimePicker1.Text);

                        using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.cambioCrucero", cn))
                        {
                            cn.Open();
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@tiempo", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
                            cmd.Parameters.Add("@IdCruceroViejo", SqlDbType.NVarChar, 50).Value = this.IdCrucero;

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cambio realizado correctamente");
                        }
                    }

                }
            }
            catch (SqlException) { MessageBox.Show("No hay cruceros disponibles"); }
        }
    }
}
