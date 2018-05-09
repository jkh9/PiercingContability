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
    public partial class VentasDiarias : UserControl
    {
        public Ventas ventas { get;}
        public List<Coordenadas> Coordenadas { get; set; }
        public List<Panel> Paneles { get; set; }
        public List<Label> Labels { get; set; }
        public Panel Aux { get; set; }

        public VentasDiarias()
        {
            Coordenadas = new List<Coordenadas>();
            ventas = new Ventas();

            InitializeComponent();
        }

        public void MostrarVentas()
        {
            List<Venta> ventasDiarias = ventas.VentasDiarias;
            Paneles = new List<Panel>();
            Labels = new List<Label>();
            Controls.Clear();
            InitializeComponent();
            double total = 0;
            int row, column = 0;
            for (int i = 0; i < ventasDiarias.Count; i++)
            {
                row = 0;
                Panel panel = new Panel();
                panel.Location = new Point(0, 30 + (30 * i));
                panel.Size = new Size(366, 30);
                panel.Name = i+"";
                panel.TabIndex = 4;
                panel.BackColor = Color.White;
                Controls.Add(panel);
                Paneles.Add(panel);

                Label name = new Label();
                name.BorderStyle = BorderStyle.FixedSingle;
                name.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                name.Location = new Point(0,0);
                name.Name = i+" "+row + " "+column;
                name.Size = new Size(122, 30);
                name.TabIndex = 0;
                name.Text = ventasDiarias[i].PiercingType.Nombre;
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Click += new EventHandler(this.lbl_Click);
                panel.Controls.Add(name);
                Labels.Add(name);
                Coordenadas.Add(new Coordenadas(i,row,column));
                row++;

                Label precio = new Label();
                precio.BorderStyle = BorderStyle.FixedSingle;
                precio.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                precio.Location = new Point(122, 0);
                precio.Name = i + " " + row + " " + column;
                precio.Size = new Size(122, 30);
                precio.TabIndex = 0;
                precio.Text = ventasDiarias[i].Cantidad.ToString();
                precio.TextAlign = ContentAlignment.MiddleCenter;
                precio.Click += new EventHandler(this.lbl_Click);
                panel.Controls.Add(precio);
                Labels.Add(precio);
                Coordenadas.Add(new Coordenadas(i, row, column));
                row++;

                Label lblTotal = new Label();
                lblTotal.BorderStyle = BorderStyle.FixedSingle;
                lblTotal.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblTotal.Location = new Point(244,0);
                lblTotal.Name = i + " " + row + " " + column;
                lblTotal.Size = new Size(122, 30);
                lblTotal.TabIndex = 0;
                lblTotal.Text = ventasDiarias[i].Precio.ToString();
                lblTotal.TextAlign = ContentAlignment.MiddleCenter;
                lblTotal.Click += new EventHandler(this.lbl_Click);
                panel.Controls.Add(lblTotal);
                Labels.Add(lblTotal);
                Coordenadas.Add(new Coordenadas(i, row, column));
                column++;

                total += ventasDiarias[i].Precio;
            }
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            int position = getPosition((Label)sender);
            Coordenadas coordenadasActuales = Coordenadas[position];
            Panel panelActual = Paneles[coordenadasActuales.Panel];

            if (panelActual.BackColor == Color.Red)
            {
                panelActual.BackColor = Color.White;
            }
            else
            {
                if (Aux == null)
                {
                    Aux = panelActual;
                }
                else
                {
                    Aux.BackColor = Color.White;
                    Aux = panelActual;
                }
                panelActual.BackColor = Color.Red;
            }
        }

        private int getPosition(Label labelPulsada)
        {
            string[]parts = labelPulsada.Name.Split();
            Coordenadas actual = new Coordenadas(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]));
            for (int i = 0; i < Coordenadas.Count; i++)
            {
                if (actual.Column == Coordenadas[i].Column)
                {
                    return i;
                }
            }
            return 0;
        }

        private int getPositionInList(Panel panelActual)
        {
            return Convert.ToInt32(panelActual.Name);
        }

        public void EliminarSeleccion()
        {
            int position = getPositionInList(Aux);
            ventas.VentasDiarias.RemoveAt(position);
            MostrarVentas();
        }
    }
}
