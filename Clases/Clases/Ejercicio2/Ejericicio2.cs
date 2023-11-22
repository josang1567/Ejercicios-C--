using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ejercicio2
{
   
    class Linea
    {
        int x1, x2, y1, y2;
        public Linea(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public void puntoMedio()
        {
            int xMedio = 0;
            int yMedio = 0;

            xMedio = (x2 + x1) / 2;
            yMedio = (y2 + y1) / 2;

            Console.WriteLine($"El punto medio es {xMedio},{yMedio}");

        }
    }
}
