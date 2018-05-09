using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContabilidadPiercingsWF
{
    public partial class PantallaVentas : UserControl
    {
        /*
         * Ventana que contiene los piercings que están a la venta
         */

        List<Button> BotonesPiercings = new List<Button>();
        Database database = new Database();
        PantallaConfirmacionPiercing confirmacion = new PantallaConfirmacionPiercing();
        VentasDiarias ventasDiarias { get; }

        public PantallaVentas(VentasDiarias newVentasDiarias)
        {
            ventasDiarias = newVentasDiarias;
            InitializeComponent();
            MostrarPiercings();
            ventasDiarias.MostrarVentas();
        }

        //Método para crear los botones de las posibles ventas al arrancar el programa y en función de los piercings que haya
        public void MostrarPiercings()
        {
            List<Piercing> Piercings = database.Piercings;

            int row = 0;
            int column = 0;
            for (int i = 0; i < Piercings.Count; i++)
            {
                Button p1 = new Button();
                p1.Location = new Point(row * 100, column * 100);
                p1.Name = row+" "+column;
                p1.Size = new Size(100, 100);
                p1.TabIndex = 0;
                p1.Text = Piercings[i].Nombre;
                p1.UseVisualStyleBackColor = true;
                p1.Click += new EventHandler(this.btn_Click);
                this.Controls.Add(p1);
                BotonesPiercings.Add(p1);
                row++;

                if ((i + 1) % 6 == 0)
                {
                    row = 0;
                    column++;
                }
            }
        }

        //Método para cuando se clicka en un piercing
        private void btn_Click(object sender, EventArgs e)
        {
            Button actual = ((Button)sender);
            Piercing actualP = database.GetPiercing(actual.Text);

            confirmacion.ShowScreen(actualP.Precio);
            if (confirmacion.Cantidad > 0)
            {
                ventasDiarias.ventas.AddVenta(actualP, confirmacion.Cantidad, confirmacion.Price);
            }
            ventasDiarias.MostrarVentas();
        }
    }
}
