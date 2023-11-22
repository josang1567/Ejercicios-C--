using Clases.Ejercicio5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ejercicio4
{
   
    class circulo
    {
        public double radio;

        public circulo(double radio)
        {
            this.radio = radio;
        }
        public void area()
        {
            double area = 0;
            area = Math.PI * radio;
            Console.WriteLine($"El area es igual a {area}");
        }

        public void circunferencia()
        {
            double circunferencia = 0;
            circunferencia = Math.PI * (radio * 2);
            Console.WriteLine($"El circunferencia es igual a {circunferencia}");
        }
    }
}
