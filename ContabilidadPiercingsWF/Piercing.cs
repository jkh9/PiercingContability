using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContabilidadPiercingsWF
{
    [Serializable]
    public class Piercing
    {
        /*
         * Clase para controlar los piercings
         */
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Piercing(string nombre, int precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public Piercing()
        {

        }
    }
}
