namespace Librerias
{
    using Librerias.Ejercicio1;
    using Librerias.Ejercicio2;

    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            menuActividadesIniciacion();
        }

     
        public static void menuActividadesIniciacion()
        {
            Console.WriteLine("\n\nMenu de Actividades de iniciacion");
            Console.WriteLine("Pulse 1 para acceder a el ejercicio 1");
            Console.WriteLine("Pulse 2 para acceder a el ejercicio 2");
            Console.WriteLine("Pulse 3 para acceder a el ejercicio 3");
            Console.WriteLine("Pulse 4 para acceder a el ejercicio 4");
            Console.WriteLine("Pulse 5 para acceder a el ejercicio 5");
            Console.WriteLine("Pulse 6 para acceder a el ejercicio 6");
            Console.WriteLine("Pulse 7 para acceder a el ejercicio 7");
            Console.WriteLine("Pulse 8 para acceder a el ejercicio 8");
            Console.WriteLine("Pulse 9 para acceder a el ejercicio 9");
            Console.WriteLine("Pulse 10 para acceder a el ejercicio 10");
            Console.WriteLine("Escriba esc para volver atras");

            String eleccion;
            eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "1":
                    ejercicio1();

                    break;

                case "2":
                    ejercicio2();

                    break;
                case "3":
                    ejercicio3();

                    break;

                case "4":
                    ejercicio4();

                    break;
                case "5":
                    ejercicio5();

                    break;

                case "6":
                    ejercicio6();

                    break;
                case "7":
                    ejercicio7();

                    break;

                case "8":
                    ejercicio8();

                    break;
                case "9":
                    ejercicio9();

                    break;

                case "10":
                    ejercicio10();

                    break;
                case ("esc"):
                    Environment.Exit(0);

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Elija uno de los ejercicios del listado\n\n");
                    menuActividadesIniciacion();

                    break;
            }
        }

      
        public static void ejercicio1()
        {
            Console.Clear();
            Vector2 vecto1 = new Vector2(45, 53);
            Vector2 vecto2 = new Vector2(27, 94);
          Console.WriteLine(  Librerias.Ejercicio1.Ejercicio1.CalculateAngle(vecto1,vecto2));


            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();
            Librerias.Ejercicio2.Ejercicio2.ej2();
            menuActividadesIniciacion();
        }
        public static void ejercicio3()
        {
            Console.Clear();


            menuActividadesIniciacion();
        }
        public static void ejercicio4()
        {
            Console.Clear();


            menuActividadesIniciacion();
        }
        public static void ejercicio5()
        {
            Console.Clear();

            menuActividadesIniciacion();
        }
        public static void ejercicio6()
        {
            Console.Clear();

            menuActividadesIniciacion();
        }
        public static void ejercicio7()
        {
            Console.Clear();




            menuActividadesIniciacion();
        }
        public static void ejercicio8()
        {
            Console.Clear();


            menuActividadesIniciacion();
        }
        public static void ejercicio9()
        {
            Console.Clear();




            menuActividadesIniciacion();
        }
        public static void ejercicio10()
        {
            Console.Clear();





            menuActividadesIniciacion();
        }



        public static int intChecker()
        {
            int numero = 0;
            String input = Console.ReadLine();
            try
            {
                numero = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.");
                intChecker();
            }
            return numero;
        }
    }
}