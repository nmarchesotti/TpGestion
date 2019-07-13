using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class TarjetaDeCredito : Form
    {
        public TarjetaDeCredito()
        {
            InitializeComponent();
            textBox4.PasswordChar = '*';
        }

        private void TarjetaDeCredito_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != null && textBox1.Text != null && textBox2.Text != null)
            {
                MessageBox.Show("Datos correctos, confirme el pago");
                this.Dispose();
            }
            else { MessageBox.Show("Completar campos"); }
        }
    }
}
