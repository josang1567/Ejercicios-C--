using System.Numerics;
using System.Collections;
namespace Matemáticas_para_IA___Trigonometría
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menuInicial();
        }

        public static void menuInicial()
        {
            Console.WriteLine("\n\nPulse 1 para acceder a las actividades");
            Console.WriteLine("Pulse 2 para acceder a las actividades extra");
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
            Console.WriteLine("Pulse 6 para acceder a el ejercicio 6");
            Console.WriteLine("Pulse 7 para acceder a el ejercicio 7");
            Console.WriteLine("Pulse 8 para acceder a el ejercicio 8");
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

            Console.WriteLine("Pulse 9 para acceder a el ejercicio 9");
            Console.WriteLine("Pulse 10 para acceder a el ejercicio 10");
            Console.WriteLine("Pulse 11 para acceder a el ejercicio 11");
            Console.WriteLine("Escriba esc para volver atras");

            String eleccion;
            eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "9":
                    ejercicio9();

                    break;

                case "10":
                    ejercicio10();

                    break;
                case "11":
                    ejercicio11();

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


        public static void ejercicio1()
        {
            Console.Clear();
            List<double> list = new List<double> { Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, (2 * Math.PI) / 3, (3 * Math.PI) / 4, Math.PI, (3 * Math.PI) / 2, 2 * Math.PI };

            foreach (var item in list)
            {
                Console.WriteLine($"El angulo {item} en radianes es igual a: " + item * (180 / Math.PI) + "º");
            }

            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();
            List<double> list = new List<double> { 30, 45, 90, 120, 135, 180, 270, 360 };

            foreach (var item in list)
            {

                Console.WriteLine($"El angulo {item} en grados es igual a: " + item * (Math.PI / 180) + "radianes");
            }
            menuActividadesIniciacion();
        }
        public static void ejercicio3()
        {
            Console.Clear();
            for (int i = 0; i < 361; i++)
            {
                Console.WriteLine("Grado: " + i);
                Console.WriteLine($"Seno de {i}: " + Math.Sin(i * (Math.PI / 180)));
                Console.WriteLine($"Coseno de {i}: " + Math.Cos(i * (Math.PI / 180)));
            }

            menuActividadesIniciacion();
        }
        public static void ejercicio4()
        {
            Console.Clear();
            List<double> list = new List<double> { 54, 31, 28, 81, 99 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Tangente de {list[i]}: " + Math.Tan(list[i] * (Math.PI / 180)));
                Console.WriteLine($"Arcoseno de {list[i]}: " + Math.Asin(list[i] * (Math.PI / 180)));
                Console.WriteLine($"Arcocoseno de {list[i]}: " + Math.Acos(list[i] * (Math.PI / 180)));
                Console.WriteLine($"Arcotangente de {list[i]}: " + Math.Atan(list[i] * (Math.PI / 180)) + "\n");
            }

            menuActividadesIniciacion();
        }
        public static void ejercicio5()
        {
            Console.Clear();
            Vector2 vectorA = new Vector2(1, 1);
            Vector2 vectorB = new Vector2(-2, 0);
            Vector2 vectorV = new Vector2(1, 1);
            Vector2 vectorW = new Vector2(1, -1);

            double anguloAB = 0;
            double anguloVW = 0;

            anguloAB = Math.Atan2((vectorA.Y * vectorB.X) - (vectorA.X * vectorB.Y), ((vectorA.X * vectorB.X) + (vectorA.Y * vectorB.Y))); ;
            anguloVW = Math.Atan2((vectorV.Y * vectorW.X) - (vectorV.X * vectorV.Y), ((vectorV.X * vectorW.X) + (vectorV.Y * vectorW.Y)));


            Console.WriteLine("Angulo A y B: " + anguloAB * (180 / Math.PI) + "º");
            Console.WriteLine("Angulo V y W: " + anguloVW * (180 / Math.PI) + "º");


            menuActividadesIniciacion();
        }
        public static void ejercicio6()
        {
            Console.Clear();
            Vector3 vectorA = new Vector3(9, 2, 7);
            Vector3 vectorb = new Vector3(4, 8, 10);
            Vector3 vectorV = new Vector3(-3, 5, -1);
            Vector3 vectorW = new Vector3(4, -1, 6);

            Console.WriteLine($"El angulo entre el vector {vectorA} y el vector{vectorb} es "+ angulo3D(vectorA,vectorb));
            Console.WriteLine($"El angulo entre el vector {vectorV} y el vector{vectorW} es " + angulo3D(vectorV, vectorW));

            menuActividadesIniciacion();
        }

       
        public static float angulo3D(Vector3 a, Vector3 b)
        {
            Vector3 cross = Vector3.Cross(a, b);
            float dot = Vector3.Dot(a, b);

            return MathF.Atan2(cross.Length(), dot) * (180 / MathF.PI);
        }

   
     
        public static void ejercicio9()
        {
            Console.Clear();

            /*
               List<double> list = new List<double> { Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, (2 * Math.PI) / 3, (3 * Math.PI) / 4, Math.PI, (3 * Math.PI) / 2, 2 * Math.PI };

        foreach (var item in list)
        {
            Console.WriteLine($"El angulo {item} en radianes es igual a: " + item * Mathf.Deg2Rad + "º");
        }

        List<double> list2 = new List<double> { 30, 45, 90, 120, 135, 180, 270, 360 };

        foreach (var item in list2)
        {

            Console.WriteLine($"El angulo {item} en grados es igual a: " + item * Mathf.Rad2Deg + "radianes");
        }
             
             */
            menuActividadesIniciacion();
        }
        public static void ejercicio10()
        {
            Console.Clear();

            /*
             5
             
             Vector2 vectorA = new Vector2(1, 1);
            Vector2 vectorB = new Vector2(-2, 0);
            Vector2 vectorV = new Vector2(1, 1);
            Vector2 vectorW = new Vector2(1, -1);

            double anguloAB = 0;
            double anguloVW = 0;

            anguloAB = Vector2.Angle(vectorA,vectorB);
            anguloVW =Vector2.Angle(vectorV,vectorW);


            Console.WriteLine("Angulo A y B: " + anguloAB * (180 / Math.PI) + "º");
            Console.WriteLine("Angulo V y W: " + anguloVW * (180 / Math.PI) + "º");


             6

            Vector3 vectorA = new Vector3(9, 2, 7);
            Vector3 vectorb = new Vector3(4, 8, 10);
            Vector3 vectorV = new Vector3(-3, 5, -1);
            Vector3 vectorW = new Vector3(4, -1, 6);

           double anguloAB = 0;
            double anguloVW = 0;

            anguloAB = Vector3.Angle(vectorA,vectorB);
            anguloVW =Vector3.Angle(vectorV,vectorW);

             */



            menuActividadesIniciacion();
        }


        //ejercicios normales
        public static void ejercicio11()
        {
            Console.Clear();

            //ejercicio 1
            Console.WriteLine("Ejercicio 1 calcular precio cable:");

            double a1 = 20;
            double angulo1 = 30 * (Math.PI / 180);
            double h1;


            h1=20/Math.Sin(angulo1);
            Console.WriteLine("Ejercicio 1 Solucion: "+ h1*12);

            //Ejercicio 2
            Console.WriteLine("Ejercicio 2 altura del arbol:");

            double b2 = 8;
            double angulo2 = 36.87;
            double h2;


            menuActividades();

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