namespace Ejercicio1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(45, 53);
            Punto punto2 = new Punto(27, 94);
            Punto punto3 = new Punto(11, 112);

            Console.WriteLine($"punto1: x={punto1.GetX()}, y={punto1.GetY()}");
            Console.WriteLine($"punto2: x={punto2.GetX()}, y={punto2.GetY()}");
            Console.WriteLine($"punto3: x={punto3.GetX()}, y={punto3.GetY()}");

            punto1.SetX(10);
            punto2.SetY(20);
            punto3.SetX(100);
            punto3.SetY(200);

            Console.WriteLine($"punto1: x={punto1.GetX()}, y={punto1.GetY()}");
            Console.WriteLine($"punto2: x={punto2.GetX()}, y={punto2.GetY()}");
            Console.WriteLine($"punto3: x={punto3.GetX()}, y={punto3.GetY()}");

        }
    }

    class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetX(int nuevoX)
        {
            x = nuevoX;
        }

        public void SetY(int nuevoY)
        {
            y = nuevoY;
        }
    }
}