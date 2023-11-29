using System.Numerics;

namespace Interpolaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menuInicial();
        }

        public static void menuInicial()
        {
            Console.WriteLine("\n\nPulse 1 para acceder a las actividades de iniciación");
            Console.WriteLine("Pulse 2 para acceder a las actividades ");
            Console.WriteLine("Escriba esc para salir");

            String eleccion;
            eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "1":
                    menuActividadesIniciacion();
                    break;

                case "2":
                    menuActividades();
                    break;
                case ("esc"):
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Solo se puede elegir 1 o 2\n\n");
                    menuInicial();
                    break;
            }


        }
        public static void menuActividadesIniciacion()
        {
            Console.WriteLine("\n\nMenu de Actividades de iniciacion");
            Console.WriteLine("Pulse 1 para acceder a el ejercicio 1");
            Console.WriteLine("Pulse 2 para acceder a el ejercicio 2");
            Console.WriteLine("Pulse 3 para acceder a el ejercicio 3");
            Console.WriteLine("Pulse 4 para acceder a el ejercicio 4");
            Console.WriteLine("Pulse 5 para acceder a el ejercicio 5");
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




                case ("esc"):
                    menuInicial();

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Elija uno de los ejercicios del listado\n\n");
                    menuActividadesIniciacion();

                    break;
            }
        }

        public static void menuActividades()
        {
            Console.WriteLine("\n\nMenu de Actividades");
            Console.WriteLine("Pulse 8 para acceder a el ejercicio 8");
            Console.WriteLine("Pulse 9 para acceder a el ejercicio 9");
            Console.WriteLine("Pulse 10 para acceder a el ejercicio 10");
            Console.WriteLine("Escriba esc para volver atras");

            String eleccion;
            eleccion = Console.ReadLine();
            switch (eleccion)
            {
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
                    menuInicial();

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Elija uno de los ejercicios del listado\n\n");
                    menuActividades();

                    break;
            }
        }

        public static float lerp(float from, float to, float weight)
        {
            return from + ((to - from) * weight);
        }


        public static void ejercicio1()
        {
            Console.Clear();
            /*
                   un punto interpolado es un punto que se encuentra en un rango posible en base a unos datos dados.


                  En el siguiente ejemplo se introduce un valor inicialy un valor final fijos junto a un peso variable para poder calcular un punto intermedio.

                   */


            float valorInicial = 0;
            float valorFinal = 20;

            float valorInterpolado1 = lerp(valorInicial, valorFinal, 0.5f);
            float valorInterpolado2 = lerp(valorInicial, valorFinal, 0.25f);
            float valorInterpolado3 = lerp(valorInicial, valorFinal, 0.75f);

            Console.WriteLine(valorInterpolado1);
            Console.WriteLine(valorInterpolado2);
            Console.WriteLine(valorInterpolado3);

            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();
            float valorInicial = 0;
            float valorFinal = 10;

            float valorInterpolado1 = lerp(valorInicial, valorFinal, 0.5f);
            float valorInterpolado2 = lerp(valorInicial, valorFinal, 0.25f);
            float valorInterpolado3 = lerp(valorInicial, valorFinal, 0.75f);

            Console.WriteLine(valorInterpolado1);
            Console.WriteLine(valorInterpolado2);
            Console.WriteLine(valorInterpolado3);
            menuActividadesIniciacion();
        }
        public static void ejercicio3()
        {
            Console.Clear();
            float valorInicial = 0;
            float valorFinal = 80;

            for (int i = 0; i < 100; i++)
            {
                float valorInterpolado1 = lerp(valorInicial, valorFinal, i);
                Console.WriteLine(valorInterpolado1);


            }

            menuActividadesIniciacion();
        }
        public static void ejercicio4()
        {
            Console.Clear();
            Vector2 vectorInicial = new Vector2(-5f, -20f);
            Vector2 vectorFinal = new Vector2(10f, 25f);

            for (float i = 1; i <= 100; i++)
            {
                Vector2 valorInterpolado = Vector2.Lerp(vectorInicial, vectorFinal, i);
                Console.WriteLine($"Vector Interpolado ({i}): ({valorInterpolado.X}, {valorInterpolado.Y})");

            }

            menuActividadesIniciacion();
        }
        public static void ejercicio5()
        {
            Console.Clear();

            Vector3 vectorInicial = new Vector3(1f, 3f, 2f);
            Vector3 vectorFinal = new Vector3(8f, 10f, 9f);

            for (float i = 1; i <= 100; i++)
            {
                Vector3 valorInterpolado = Vector3.Lerp(vectorInicial, vectorFinal, i);
                Console.WriteLine($"Vector Interpolado ({i}): ({valorInterpolado.X}, {valorInterpolado.Y})");

            }


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