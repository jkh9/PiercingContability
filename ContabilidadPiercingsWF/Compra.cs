using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContabilidadPiercingsWF
{
    [Serializable]
    class Compra
    {
        /*
         * Clase que gestiona las compras
         */

        public double Price { get; set; }
        public string Description { get; set; }

        public Compra(double price, string description)
        {
            Price = price;
            Description = description;
        }
    }
}
