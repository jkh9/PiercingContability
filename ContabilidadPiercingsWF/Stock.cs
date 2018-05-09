using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContabilidadPiercingsWF
{
    [Serializable]
    class Stock
    {
        //Clase que controla el stock 

        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Stock(string name, double price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }
    }
}
