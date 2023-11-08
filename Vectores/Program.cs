namespace Vectores
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
            Console.WriteLine("Pulse 2 para acceder a las actividades extra ");
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
            Console.WriteLine("Escriba esc para volver atras");

            String eleccion;
            eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "1":
                    ejercicio1();
                        /*
                        Un vector es un segmento de un mapa que tiene una direccion y sentido 
                        Sus propiedades basicas son:

                        -Igualdad: dos vectores son iguales si tienen la misma magnitud y direccion, tambien son iguales en caso de que sus cordenadas sean iguales.

                        -Vectores opuestos, paralelos y antiparalelos:
                                -Opuestos: Los vectores opuestos son toda pareja de vectores con la misma magnitud pero direccion opuesta.

                                -Paralelos: Los vectores paralelos son aquellos que tienen la misma direccion pero no la misma magnitud.

                                -Antiparalelos: Los vectores antiparalelos  sin tienen direccion opuesta pero no la misma magnitud
                        -
                        */
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
            Console.WriteLine("Pulse 11 para acceder a el ejercicio 11");
            Console.WriteLine("Pulse 12 para acceder a el ejercicio 12");
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
                case "11":
                    ejercicio11();

                    break;

                case "12":
                    ejercicio12();

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


            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();

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


        //ejercicios normales
        public static void ejercicio11()
        {
            Console.Clear();

            menuActividades();

        }
        public static void ejercicio12()
        {
            Console.Clear();

            menuActividades();

        }
       
    }
}