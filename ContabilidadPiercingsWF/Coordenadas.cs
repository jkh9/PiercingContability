using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContabilidadPiercingsWF
{
    public class Coordenadas
    {
        public int Panel { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public Coordenadas(int panel , int row, int column)
        {
            Panel = panel;
            Row = row;
            Column = column;
        }
    }
}
