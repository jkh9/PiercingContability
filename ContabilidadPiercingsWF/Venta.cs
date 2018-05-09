using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContabilidadPiercingsWF
{
    [Serializable]
    public class Venta
    {
        /*
         * Clase que gestiona las ventas
         */
        public Piercing PiercingType { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public Venta(Piercing piercingType, int cantidad) : 
            this(piercingType,cantidad,piercingType.Precio)
        {
        }

        public Venta(Piercing piercingType, int cantidad , double precio)
        {
            PiercingType = piercingType;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
