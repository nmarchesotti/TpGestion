using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class DarDeBaja : Form
    {
        public DarDeBaja()
        {
            InitializeComponent();
            InicializarComboBoxTiposBaja();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BorrarCrucero_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InicializarComboBoxTiposBaja(){
            var dataSource = new List<String>();
            dataSource.Add("Vida util finalizada");
            dataSource.Add("Fuera de servicio");

            this.comboBoxTipoBaja.DataSource = dataSource;
            this.comboBoxTipoBaja.DisplayMember = "Name";

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
    }
}
