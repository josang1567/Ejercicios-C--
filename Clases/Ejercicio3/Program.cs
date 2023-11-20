namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangulo r1= new rectangulo(32,54);    
            rectangulo r2= new rectangulo(352,97);    
            rectangulo r3= new rectangulo(12,24);

            r1.area();
            r2.area();
            r3.area();
        }
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
        public  void area()
        {
            int area = 0;
            area = longitud * ancho;
            Console.WriteLine($"El area es igual a {area}");
        }
    }
}