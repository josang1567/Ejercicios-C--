using System;

namespace Arrays_y_o_listas
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
            Console.WriteLine("Pulse 11 para acceder a el ejercicio 11");
            Console.WriteLine("Pulse 12 para acceder a el ejercicio 12");
            Console.WriteLine("Pulse 13 para acceder a el ejercicio 13");
            Console.WriteLine("Pulse 14 para acceder a el ejercicio 14");
            Console.WriteLine("Pulse 15 para acceder a el ejercicio 15");
            Console.WriteLine("Pulse 16 para acceder a el ejercicio 16");
            Console.WriteLine("Pulse 17 para acceder a el ejercicio 17");
            Console.WriteLine("Escriba esc para volver atras");

            String eleccion;
            eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "11":
                    ejercicio11();

                    break;

                case "12":
                    ejercicio12();

                    break;
                case "13":
                    ejercicio13();

                    break;

                case "14":
                    ejercicio14();

                    break;
                case "15":
                    ejercicio15();

                    break;

                case "16":
                    ejercicio16();

                    break;
                case "17":
                    ejercicio17();

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
            string[] elementos = {"primero","segundo","tercero","cuarto","quinto" };
            
            for (int i = 0; i <= 4; i++)
            {
                if (i == 0 || i ==2 || i==4)
                {
                    Console.Write(elementos[i]+" ");
                }
            }

            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();
            int[] elementos = { 1, 2, 3, 4, 5 };
            int suma = 0;
            for (int i = 0; i <= 4; i++)
            {
                suma +=  elementos[i];
            }
            Console.WriteLine(suma);
            menuActividadesIniciacion();
        }
        public static void ejercicio3()
        {
            Console.Clear();
            int[] elementos = { 1, 2, 3, 4, 5 };
            int multiplicacion = 1;
            for (int i = 0; i <= 4; i++)
            {
                multiplicacion *= elementos[i];
            }
            Console.WriteLine(multiplicacion);

            menuActividadesIniciacion();
        }
        public static void ejercicio4()
        {
            Console.Clear();

            List<int> lista=new List<int> { 1, 2, 3, 4, 5 };
            foreach (var item in lista)
            {
                Console.WriteLine(item);

            }

            lista.RemoveAt(0); 
            lista.RemoveAt(1);
            lista.RemoveAt(lista.Count - 1);

            foreach (var item in lista)
            {
                Console.Write(item+" ");

            }
            menuActividadesIniciacion();
        }
        public static void ejercicio5()
        {
            Console.Clear();

            List<int> lista = new List<int> { 1, 2, 3, 4, 5 };
            foreach (var item in lista)
            {
                Console.Write(item+" ");

            }

            for (int i = 0; i <= 4; i++)
            {
                if (i == 0 || i == 2 || i == 4)
                {
                    lista[i] = 7;
                }
            }
                Console.WriteLine("");


            foreach (var item in lista)
            {
                Console.Write(item + " ");

            }

            menuActividadesIniciacion();
        }
        public static void ejercicio6()
        {
            Console.Clear();
            List<string> letras = new List<string> { "1", "2", "3", "4", "5" };
            List<int> numeros=new List<int>();

            for (int i = 0; i < letras.Count; i++)
            {
                numeros.Add(Convert.ToInt32(letras[i]));
                
            }
            foreach (var item in numeros) 
            {
                Console.Write(item);
            }
            menuActividadesIniciacion();
        }
        public static void ejercicio7()
        {
            Console.Clear();
            List<string> letras = new List<string> { "1", "2", "3", "4", "5" };

            foreach (var item in letras)
            {
                Console.Write(item);
            }
            Console.WriteLine($"\nEl numero de elementos es igual a {letras.Count}");

            menuActividadesIniciacion();
        }
        public static void ejercicio8()
        {
            Console.Clear();
            List<int> numeros = new List<int> { 34,75,21,9,-54 };
            foreach (var item in numeros)
            {
                Console.Write(item+" ");
            }
            numeros.Sort((a, b) => a.CompareTo(b));
            Console.WriteLine("");

            foreach (var item in numeros)
            {
                Console.Write(item+" ");
            }


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
        public static void ejercicio13()
        {
            Console.Clear();


            menuActividades();

        }
        public static void ejercicio14()
        {
            Console.Clear();
            menuActividades();

        }
        public static void ejercicio15()
        {
            Console.Clear();

            menuActividades();

        }

        public static void ejercicio16()
        {
            Console.Clear();


            menuActividades();

        }
        public static void ejercicio17()
        {
            Console.Clear();



            menuActividades();
        }
       
    }
}