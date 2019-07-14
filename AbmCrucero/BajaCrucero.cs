using System;
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
    public partial class BajaCrucero : Form
    {
        string IdCrucero;
        public BajaCrucero()
        {
            InitializeComponent();
            comboBox1_Load();
            InicializarComboBoxTiposBaja();
        }

        private void comboBox1_Load()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString);
            cn.Open();
            SqlCommand sc = new SqlCommand("select IdCrucero from LOS_QUE_VAN_A_APROBAR.ListarCrucerosHabilitados", cn);
            SqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("IdCrucero", typeof(string));
            dt.Load(reader);

            comboBox1.SelectedValue = "IdCrucero";
            comboBox1.DisplayMember = "IdCrucero";
            comboBox1.DataSource = dt;
            cn.Close();
        }

        private void InicializarComboBoxTiposBaja()
        {
            var dataSource = new List<String>();
            dataSource.Add("Vida util finalizada");
            dataSource.Add("Fuera de servicio");

            this.comboBoxTipoBaja.DataSource = dataSource;
            this.comboBoxTipoBaja.DisplayMember = "Name";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["GD_CRUCEROS"].ConnectionString))
            {
                if (comboBoxTipoBaja.SelectedItem == "Vida util finalizada")
                {
                    using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.BajaDefinitiva", cn))
                    {
                        cn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                        string crucero = Convert.ToString(drv2["IdCrucero"]);
                        this.IdCrucero = crucero;
                        cmd.Parameters.Add("@IdCrucero", SqlDbType.NVarChar, 50).Value = crucero;
                        MessageBox.Show(crucero);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Crucero dado de baja satisfactoriamente");
                        cn.Close();
                        switch (MessageBox.Show("¿Queres buscar otro crucero para reprogramar viajes?",
                          "WonderWord",
                            MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                EleccionBaja form = new EleccionBaja(this.IdCrucero);
                                form.StartPosition = FormStartPosition.CenterScreen;
                                form.Show();
                                this.Dispose();
                                break;

                            case DialogResult.No:
                                // "No" processing
                                break;

                        }
                    }
                }
                else
                {
                    using (SqlCommand cmd = new SqlCommand("LOS_QUE_VAN_A_APROBAR.BajaFueraDeServicio", cn))
                    {

                        cn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        DataRowView drv2 = (DataRowView)comboBox1.SelectedItem;
                        string crucero = Convert.ToString(drv2["IdCrucero"]);
                        this.IdCrucero = crucero;
                        cmd.Parameters.Add("@IdCrucero", SqlDbType.NVarChar, 50).Value = crucero;
                        MessageBox.Show(crucero);

                        string fecha = calendarioBajaCrucero.Text;
                        cmd.Parameters.Add("@FechaDeAlta", SqlDbType.DateTime2, 3).Value = fecha;



                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Crucero en reparación satisfactorio");
                        cn.Close();
                        cn.Dispose();

                    }

                }

            }

            /*EleccionBaja form = new EleccionBaja(this.IdCrucero);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ABMCrucero form = new ABMCrucero();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}