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

namespace FrbaCrucero.LoginYSeguridad
{
    public partial class Login : Form
    {
        short intentos = 0;
        public Login()
        {
            InitializeComponent();
            txtcontraseña.PasswordChar = '*';
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                
                using (SqlCommand cmd = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.ValidarUsuario(@Username,@Password)", cn))
                {
                    
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = txtusuario.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 255).Value = txtcontraseña.Text;
                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                    if (resultado == 1)
                    {
                        MessageBox.Show("Conexion exitosa");
                        SqlCommand cmd2 = new SqlCommand("select LOS_QUE_VAN_A_APROBAR.IdDeRol(@Username,@Password)", cn);
                        cmd2.CommandType = CommandType.Text;
                        cmd2.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = txtusuario.Text;
                        cmd2.Parameters.Add("@Password", SqlDbType.NVarChar, 255).Value = txtcontraseña.Text;
                        int idRol = Convert.ToInt32(cmd2.ExecuteScalar());

                        List<String> funcionalidades = new List<String>();
                        string query = "select F.Descripcion from LOS_QUE_VAN_A_APROBAR.FuncionalidadPorRol as FPR join LOS_QUE_VAN_A_APROBAR.Funcionalidad F on F.IdFuncionalidad = FPR.IdFuncionalidad where FPR.IdRol = " + idRol + " and FPR.Estado = 'Habilitado'";
                        using (SqlCommand cmd3 = new SqlCommand(query, cn))
                            {
                                using (SqlDataReader reader = cmd3.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        funcionalidades.Add(reader.GetString(0));
                                    }
                                }
                            }
                        
                        menuAdmin form = new menuAdmin(funcionalidades);
                        form.StartPosition = FormStartPosition.CenterScreen;
                        form.Show();
                        this.Dispose();
                    }
                    else if(resultado ==0)
                    {
                        MessageBox.Show("Credenciales inválidas");
                        intentos++;
                        if (intentos == 3)
                        {
                            SqlCommand cmd2 = new SqlCommand("LOS_QUE_VAN_A_APROBAR.InhabilitarAdmin", cn);
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = txtusuario.Text;
                            cmd2.Parameters.Add("@Password", SqlDbType.NVarChar, 255).Value = txtcontraseña.Text;
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Administrador inhabilitado");
                            PantallaInicial.Inicio form = new PantallaInicial.Inicio();
                            form.StartPosition = FormStartPosition.CenterScreen;
                            form.Show();
                            this.Dispose();
                            
                        }

                    }

                    else if (resultado == 2)
                    {
                        MessageBox.Show("Su administrador fue bloqueado por reiterados intentos");
                    }



                    cn.Close();
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PantallaInicial.Inicio form = new PantallaInicial.Inicio();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }
    }
}

