using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ContabilidadPiercingsWF
{
    //Clase que gestiona la parte de las compras
    class Compras
    {
        const string RUTA = "Compras.dat";
        public List<Compra> ComprasDiarias { get; set; }

        public Compras()
        {
            LoadCompras();
            ComprasDiarias.Add(new Compra(15,"ps algo bonito"));
        }

        ~Compras()
        {
            SaveCompras();
        }

        //Guardar Ventas
        public void LoadCompras()
        {
            if (!(File.Exists(RUTA)))
            {
                MessageBox.Show("No se ha encontrado el fichero de compra");
                ComprasDiarias = new List<Compra>();
            }
            else
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream input = new FileStream(RUTA, FileMode.Open);

                    ComprasDiarias = (List<Compra>)binaryFormatter.Deserialize(input);

                    input.Close();
                }
                catch (Exception )
                {
                    ComprasDiarias = new List<Compra>();
                }
            }
        }
        //Cargar Ventas
        public void SaveCompras()
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream output = new FileStream(RUTA, FileMode.Create);

                binaryFormatter.Serialize(output, ComprasDiarias);

                output.Close();
            }
            catch (Exception e)
            {
            }
        }
    }
}
