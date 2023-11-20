namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linea linea1= new Linea(1, 2, 3,4);
            Linea linea2= new Linea(3, 5, 8,7);
            Linea linea3= new Linea(51, 32, 34,43);

            linea1.puntoMedio();
            linea2.puntoMedio();
            linea3.puntoMedio();
        }
    }

    class Linea
    {
        int x1, x2, y1, y2;
        public Linea(int x1,  int y1, int x2, int y2)
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