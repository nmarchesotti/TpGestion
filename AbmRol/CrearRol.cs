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
    public partial class CrearRol : Form
    {
        public CrearRol()
        {
            InitializeComponent();
            checkedListBox1_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe especificar un nombre");
            }
            else if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe al menos seleccionar una funcionalidad para su rol");
            }
            else
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
                {
                    cn.Open();
                    /*+SqlCommand cmdc = new SqlCommand("select count(*) as Total from LOS_QUE_VAN_A_APROBAR.Rol where IdRol = " + textBox1.Text,cn);
                    cmdc.CommandType = CommandType.Text;
                    int pruebita =  Convert.ToInt32(cmdc.ExecuteScalar());
                    MessageBox.Show(pruebita.ToString());*/
                    SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.NuevoRol", cn);
                    
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@NuevoNombre", SqlDbType.NVarChar, 255).Value = textBox1.Text;
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd2 = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.ObtenerNuevoRolInsertado()", cn);
                    cmd2.CommandType = CommandType.Text;
                    int IdRolNuevo = Convert.ToInt32(cmd2.ExecuteScalar());

                    SqlCommand cmd3 = new SqlCommand("LOS_QUE_VAN_A_APROBAR.FuncionalidadParaRol", cn);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.Add("@IdRol", SqlDbType.Int).Value = IdRolNuevo;
                    cmd3.Parameters.Add("@IdFuncionalidad", SqlDbType.Int);
                    DataRow row;

                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    {
                        row = ((((DataRowView)checkedListBox1.CheckedItems[i]))).Row;
                        int valor = Convert.ToInt32(row[checkedListBox1.ValueMember]);
                        cmd3.Parameters["@IdFuncionalidad"].Value = valor;
                        cmd3.ExecuteNonQuery();

                    }

                    MessageBox.Show("Rol creado exitosamente");
                    cn.Close();
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

        private void checkedListBox1_Load()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
               
                using (SqlCommand cmd = new SqlCommand("select IdFuncionalidad, Descripcion from LOS_QUE_VAN_A_APROBAR.Funcionalidad", cn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        ((ListBox)checkedListBox1).DataSource = dt;
                        ((ListBox)checkedListBox1).DisplayMember = "Descripcion";
                        ((ListBox)checkedListBox1).ValueMember = "IdFuncionalidad";
                    }
                }
            }
        }
    }
}


public class ListItem
{
    public string Descripcion;
    public int IdFuncionalidad;

    public ListItem(string text, int value)
    {
        this.Descripcion = text;
        this.IdFuncionalidad = value;
    }
}
