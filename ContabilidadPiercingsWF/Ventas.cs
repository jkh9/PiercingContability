using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ContabilidadPiercingsWF
{
    //Clase que gestiona la parte de ventas
    public class Ventas
    {
        //    this.pantallaVentas = new ContabilidadPiercingsWF.PantallaVentas(ventasDiarias);
        
        const string RUTA = "Ventas.dat";
        public List<Venta> VentasDiarias { get; set; }

        public Ventas()
        {
           LoadVentas();
        }

        ~Ventas()
        {
            SaveVentas();
        }

        //Cargar Ventas
        public void LoadVentas()
        {
            if (!(File.Exists(RUTA)))
            {
                MessageBox.Show("No se ha encontrado el fichero de ventas");
                VentasDiarias = new List<Venta>();
            }
            else
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream input = new FileStream(RUTA, FileMode.Open);

                    VentasDiarias = (List<Venta>)binaryFormatter.Deserialize(input);

                    input.Close();
                }
                catch (Exception e)
                {
                    VentasDiarias = new List<Venta>();
                }
            }
        }
        //Guardar Ventas
        public void SaveVentas()
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream output = new FileStream(RUTA, FileMode.Create);

                binaryFormatter.Serialize(output, VentasDiarias);

                output.Close();
            }
            catch (Exception e)
            {
            }
        }

        //Añadir Venta
        public void AddVenta(Piercing piercing, int cantidad , double precio)
        {
            bool piercingYaVendido = false;

            foreach (Venta item in VentasDiarias)
            {
                if (item.PiercingType == piercing)
                {
                    piercingYaVendido = true;
                }
            }

            if (piercingYaVendido)
            {
                for (int i = 0; i < VentasDiarias.Count; i++)
                {
                    if (VentasDiarias[i].PiercingType == piercing)
                    {
                        VentasDiarias[i].Cantidad += cantidad;
                        VentasDiarias[i].Precio += precio * (double) cantidad;
                    }
                }
            }
            else
            {
                VentasDiarias.Add(new Venta(piercing, cantidad, (precio * cantidad)));
            }
            SaveVentas();
        }
    }
}
