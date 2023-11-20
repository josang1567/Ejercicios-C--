using System.Drawing;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            circulo r1 = new circulo(32);
            circulo r2 = new circulo(352);
            circulo r3 = new circulo(12);

            r1.area();
            r2.area();
            r3.area();
            r1.circunferencia();
            r2.circunferencia();
            r3.circunferencia();


        }
    }
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
            area = Math.PI*radio;
            Console.WriteLine($"El area es igual a {area}");
        }

        public void circunferencia()
        {
            double circunferencia = 0;
            circunferencia = Math.PI * (radio*2);
            Console.WriteLine($"El circunferencia es igual a {circunferencia}");
        }
    }
}