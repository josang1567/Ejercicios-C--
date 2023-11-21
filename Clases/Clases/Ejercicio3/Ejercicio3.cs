using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ejercicio3
{
    internal class Ejercicio3
    {
    }
    class rectangulo
    {
        public int longitud;
        public int ancho;

        public rectangulo(int longitud, int ancho)
        {
            this.longitud = longitud;
            this.ancho = ancho;
        }
        public void area()
        {
            int area = 0;
            area = longitud * ancho;
            Console.WriteLine($"El area es igual a {area}");
        }
    }
}
