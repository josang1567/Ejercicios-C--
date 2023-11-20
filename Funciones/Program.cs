namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menuInicial();
        }

        public static void menuInicial()
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
                    menuInicial();

                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Elija uno de los ejercicios del listado\n\n");
                    menuActividadesIniciacion();

                    break;
            }
        }


        //-------------------------------------------------------------------------

        public static void ejercicio1()
        {
            Console.Clear();
            Console.WriteLine(FuncionEjercicio1(1));
            Console.WriteLine(FuncionEjercicio1(2));
            Console.WriteLine(FuncionEjercicio1(435));
            menuActividadesIniciacion();
        }

        private static bool FuncionEjercicio1(int valor)
        {
            bool par = true;
            if (valor % 2 != 0)
            {
                par = false;
            }
            return par;
        }
        //-------------------------------------------------------------------------

        public static void ejercicio2()
        {
            Console.Clear();
            Console.WriteLine(FuncionEjercicio2(1423, 523));
            Console.WriteLine(FuncionEjercicio2(97, 235));
            Console.WriteLine(FuncionEjercicio2(7, 7));

            menuActividadesIniciacion();
        }
        private static int FuncionEjercicio2(int valor1, int valor2)
        {
            int maximo = 0;

            if (valor1 > valor2 || valor1 == valor2)
            {
                maximo = valor1;
            }
            else if (valor2 > valor1)
            {
                maximo = valor2;
            }
            return maximo;
        }



        //-------------------------------------------------------------------------

        public static void ejercicio3()
        {
            Console.Clear();

            arrayShower(FuncionEjercicio3(1423, 523));
            arrayShower(FuncionEjercicio3(97, 235));
            arrayShower(FuncionEjercicio3(7, 54));
            menuActividadesIniciacion();
        }

        private static int[] FuncionEjercicio3(int valor1, int valor2)
        {
            int[] numeros = new int[3];

            if (valor1 > valor2)
            {
                numeros[0] = valor1;
                numeros[1] = valor2;
                numeros[2] = (valor1 + valor2) / 2;

            }
            else if (valor2 > valor1)
            {
                numeros[0] = valor2;
                numeros[1] = valor1;
                numeros[2] = (valor1 + valor2) / 2;
            }
            return numeros;

        }

        //-------------------------------------------------------------------------
        public static void ejercicio4()
        {
            Console.Clear();
            int[] numeros1 = { 23, 56, 73, 54, 72, 74, 85, 9 };
            int[] numeros2 = { 45, 86, 11, 34, 69, 22, 33, 44 };
            int[] numeros3 = { 88, 752, 356, 362, 300, 299 };
            var resultados1 = FuncionEjercicio4(numeros1);
            var resultados2 = FuncionEjercicio4(numeros2);
            var resultados3 = FuncionEjercicio4(numeros3);

            Console.WriteLine("Ordenado");
            arrayShower(resultados1.Item1);
            arrayShower(resultados2.Item1);
            arrayShower(resultados3.Item1);
            Console.WriteLine("\nMedia");
            Console.WriteLine(resultados1.Item2[0]);
            Console.WriteLine(resultados2.Item2[0]);
            Console.WriteLine(resultados3.Item2[0]);


            menuActividadesIniciacion();
        }

        private static (int[], int[]) FuncionEjercicio4(int[] lista)
        {
            int[] numeros = lista.OrderByDescending(n => n).ToArray();
            int[] media = new int[1];

            int suma = 0;
            foreach (var item in lista)
            {
                suma += item;
            }
            media[0] = suma / lista.Length;


            return (numeros, media);

        }

        //-------------------------------------------------------------------------
        public static void ejercicio5()
        {
            Console.Clear();
            ListShower(FuncionEjercicio5(432));
            ListShower(FuncionEjercicio5(344));
            ListShower(FuncionEjercicio5(123567));
            menuActividadesIniciacion();
        }

        private static List<int> FuncionEjercicio5(int numero)
        {
            List<int> numeros = new List<int>();

            string numeroEnTexto = numero.ToString();

            foreach (char item in numeroEnTexto)
            {
                numeros.Add(int.Parse(item.ToString()));
            }

            return numeros;
        }
        //-------------------------------------------------------------------------
        public static void ejercicio6()
        {
            Console.Clear();
            Console.WriteLine(FuncionEjercicio6(32, 86, "+"));
            Console.WriteLine(FuncionEjercicio6(43, 54, "*"));
            Console.WriteLine(FuncionEjercicio6(3278, 43, "/"));
            menuActividadesIniciacion();
        }

        private static int FuncionEjercicio6(int numero1, int numero2, string tipo)
        {
            int resultado = 0;
            switch (tipo)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 == 0)
                    {
                        resultado = 0;
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                    }
                    break;
            }
            return resultado;
        }

        //-------------------------------------------------------------------------
        public static void ejercicio7()
        {
            Console.Clear();
            List<string> cadena1 = new List<string> { "hola", "qué", "tal" };
            List<int> numeros1 = new List<int> { 56, 32, -56 };
            ObjectShower(FuncionEjercicio7(cadena1, numeros1));
            List<string> cadena2 = new List<string> { "f", "d", "s" };
            List<int> numeros2 = new List<int> { 65, 21, 55, 0 };
            ObjectShower(FuncionEjercicio7(cadena2, numeros2));
            List<string> cadena3 = new List<string> { "a", "b", "c" + "d" };
            List<int> numeros3 = new List<int> { -2, -45, -86 };
            ObjectShower(FuncionEjercicio7(cadena3, numeros3));


            menuActividadesIniciacion();
        }


        public static List<object> FuncionEjercicio7(List<string> texto, List<int> numeros)
        {
            List<object> list = new List<object>();

            for (int i = 0; i < texto.Count; i++)
            {
                list.Add(texto[i]);
                list.Add(numeros[i]);
            }

            return list;
        }
        //-------------------------------------------------------------------------
        public static void ejercicio8()
        {
            Console.Clear();
            Console.WriteLine(FuncionEjercicio8(5));
            Console.WriteLine(FuncionEjercicio8(8));
            Console.WriteLine(FuncionEjercicio8(65));


            menuActividadesIniciacion();
        }

        public static int FuncionEjercicio8(int numero)
        {
            int suma = 0;

            if (numero <= 5)
            {
                suma = 0;
            }
            else
            {
                for (int i = 0; i < numero; i++)
                {
                    if (i != 1 && i != 3)
                    {
                        suma += i;
                    }
                }
            }


            return suma;
        }
        //-------------------------------------------------------------------------
        public static void ejercicio9()
        {
            Console.Clear();
            List<string> lista1 = new List<string> { "pinguino", "pera", "la", "cuadrado", "azul" };
            List<string> lista2 = new List<string> { "manzana", "rosa", "pepe", "rojo", "azul" };
            List<string> lista3 = new List<string> { "te", "verde", "en", "la", "mesa" };

            Console.WriteLine("Lista 1");
            FuncionEjercicio9(lista1);
            Console.WriteLine("Lista 2");
            FuncionEjercicio9(lista2);
            Console.WriteLine("Lista 3");
            FuncionEjercicio9(lista3);

            menuActividadesIniciacion();
        }

        public static void FuncionEjercicio9(List<string> palabras)
        {
            int max = 0;

            foreach (string palabra in palabras)
            {
                if (palabra.Length > max)
                {
                    max = palabra.Length;
                }
            }

            Console.WriteLine(new string('*', max + 4));

            foreach (string palabra in palabras)
            {
                Console.WriteLine($"* {palabra.PadRight(max)} *");
            }

            Console.WriteLine(new string('*', max + 4));
        }
        //-------------------------------------------------------------------------
        public static void ejercicio10()
        {
            Console.Clear();

            Console.WriteLine(FuncionEjercicio10(145436803497798443));
            Console.WriteLine(FuncionEjercicio10(548645554));
            Console.WriteLine(FuncionEjercicio10(4324577598));



            menuActividadesIniciacion();
        }

        public static long FuncionEjercicio10(long numero)
        {
            string secuenciaMayor = "";
            long secuenciaNumerica = 0;
            long mayorSuma = 0;

            string numTexto = numero.ToString();

            for (int i = 0; i < numTexto.Length - 4; i++)
            {
                string secuencia = numTexto.Substring(i, 5);
                long suma = secuencia.Select(c => long.Parse(c.ToString())).Sum();

                if (suma > mayorSuma)
                {
                    mayorSuma = suma;
                    secuenciaMayor = secuencia;
                }
            }
            secuenciaNumerica=long.Parse(secuenciaMayor);

            return secuenciaNumerica;
        }
        //-------------------------------------------------------------------------

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

        public static void arrayShower(int[] numeros)
        {
            foreach (var item in numeros)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
        }

        public static void ListShower(List<int> numeros)
        {
            foreach (var item in numeros)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
        }
        public static void ObjectShower(List<object> numeros)
        {
            foreach (var item in numeros)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
        }
    }
}