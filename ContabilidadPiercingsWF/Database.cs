using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ContabilidadPiercingsWF
{
    //Clase que contiene los datos de los piercings y del stock
    class Database
    {
        const string RUTAPIERCINGS = "Piercings.dat";
        const string RUTASTOCK = "Stock.dat";

        public List<Piercing> Piercings { get; set; }
        public List<Stock> StockTotal { get; set; }

        public Database()
        {
            LoadStock();
            LoadPiercings();
        }

        ~Database()
        {
            SaveStock();
            SavePiercings();
        }

        //Guardar Piercings
        public void LoadPiercings()
        {
            if (!(File.Exists(RUTAPIERCINGS)))
            {
                MessageBox.Show("No se ha encontrado el fichero de piercings");
                Piercings = new List<Piercing>();
            }
            else
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream input = new FileStream(RUTAPIERCINGS, FileMode.Open);

                    Piercings = (List<Piercing>)binaryFormatter.Deserialize(input);

                    input.Close();
                }
                catch (Exception e)
                {
                    Piercings =  new List<Piercing>();
                }
            }
        }
        //Cargar Piercings
        public void SavePiercings()
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream output = new FileStream(RUTAPIERCINGS, FileMode.Create);

                binaryFormatter.Serialize(output, Piercings);

                output.Close();
            }
            catch (Exception e)
            {
            }
        }

        //Guardar Stock
        public void LoadStock()
        {
            if (!(File.Exists(RUTASTOCK)))
            {
                MessageBox.Show("No se ha encontrado el fichero de stock");
                StockTotal = new List<Stock>();
            }
            else
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream input = new FileStream(RUTASTOCK, FileMode.Open);

                    StockTotal = (List<Stock>)binaryFormatter.Deserialize(input);

                    input.Close();
                }
                catch (Exception e)
                {
                    StockTotal = new List<Stock>();
                }
            }
        }
        //Cargar Stock
        public void SaveStock()
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream output = new FileStream(RUTASTOCK, FileMode.Create);

                binaryFormatter.Serialize(output, StockTotal);

                output.Close();
            }
            catch (Exception e)
            {
            }
        }

        //Crear tipos de piercings
        public void CrearPiercing(string nombre, int precio)
        {
            Piercing a = new Piercing(nombre, precio);
            Piercings.Add(a);
        }

        //Devolver un piercing desde un nombre
        public Piercing GetPiercing(string name)
        {
            foreach (Piercing item in Piercings)
            {
                if (item.Nombre == name)
                {
                    return item;
                }
            }
            return new Piercing();
        }

        //Devolver precio de un piercing
        public double GetPrice(string name)
        {
            foreach (Piercing item in Piercings)
            {
                if (item.Nombre == name)
                {
                    return item.Precio;
                }
            }
            return 0;
        }

        //Cambiar precio de un piercing
        public void ChangePrice(string name, int price)
        {
            foreach (Piercing item in Piercings)
            {
                if (item.Nombre == name)
                {
                    item.Precio = price;
                }
            }
        }

        //Cambiar nombre de un piercing
        public void ChangeName(string name, string newName)
        {
            foreach (Piercing item in Piercings)
            {
                if (item.Nombre == name)
                {
                    item.Nombre = newName;
                }
            }
        }
    }
}
