using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilidadPiercingsWF
{
    public partial class PantallaConfirmacionPiercing : Form
    {
        public double Price { get; set; }
        public int Cantidad { get; set; }

        public PantallaConfirmacionPiercing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cantidad = Convert.ToInt32(textBox1.Text);
                Price = Convert.ToDouble(textBox2.Text);
            }
            catch (Exception)
            {

            }
            Close();
        }

        public void ShowScreen(double price)
        {
            Cantidad = 0;
            Price = price;
            textBox1.Text = "";
            textBox2.Text = price.ToString();
            ShowDialog();
        }
    }
}
