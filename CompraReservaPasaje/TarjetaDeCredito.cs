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
        }

        private void TarjetaDeCredito_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos correctos, confirme el pago");
            this.Dispose();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(textBox4.Text);
            }
            catch (Exception h)
            {
                MessageBox.Show("Solo pueden ir números");
                if (textBox4.TextLength > 0)
                {
                    textBox4.Text = textBox4.Text.Substring(0, textBox4.Text.Length - 1);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("Solo pueden ir caracteres alfabéticos");
                    textBox1.Text = "";
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("El dni debe ser un numero entero sin puntos ni comas");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception h)
            {
                MessageBox.Show("Solo pueden ir números");
                if (textBox2.TextLength > 0)
                {
                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
                }
            }
        }

      

    }
}
