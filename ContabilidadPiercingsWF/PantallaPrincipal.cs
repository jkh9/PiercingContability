using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContabilidadPiercingsWF
{
    public partial class PantallaPrincipal : Form
    {
        /*
         * Formulario con la ventana principal, que contiene al resto de clases y que gestiona el contol del programa
         */

        Form PantallaConfiguracion;

        public PantallaPrincipal()
        {
            InitializeComponent();
            PantallaConfiguracion = new PantallaConfiguracion();

            panel2.Location = new Point(btnIngreso.Location.X - panel2.Width, btnIngreso.Location.Y);
            pantallaVentas.BringToFront();

            this.KeyPress += new KeyPressEventHandler(this.PantallaPrincipal_KeyPress);
            this.KeyPreview = true;
        }


        private void btnIngreso_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(btnIngreso.Location.X - panel2.Width, btnIngreso.Location.Y);
            pantallaVentas.BringToFront();
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            panel2.Location = new Point(btnGasto.Location.X - panel2.Width, btnGasto.Location.Y);
            pantallaCompras.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ventasDiarias.BringToFront();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            comprasDiarias.BringToFront();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            Hardware.MoveScreen(this, e);
        }

        private void PantallaPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                ventasDiarias.EliminarSeleccion();
            }
        }
    }
}
