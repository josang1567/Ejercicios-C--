using System;

namespace Bucles
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
            Console.WriteLine("Pulse 18 para acceder a el ejercicio 18");
            Console.WriteLine("Pulse 19 para acceder a el ejercicio 19");
            Console.WriteLine("Pulse 20 para acceder a el ejercicio 20");
            Console.WriteLine("Pulse 21 para acceder a el ejercicio 21");
            Console.WriteLine("Pulse 22 para acceder a el ejercicio 22");

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

                case "18":
                    ejercicio18();

                    break;
                case "19":
                    ejercicio19();

                    break;
                case "20":
                    ejercicio20();

                    break;
                case "21":
                    ejercicio21();

                    break;
                case "22":
                    ejercicio22();

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
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            int suma = 0;
            int multi = 1;

            for (int i = 0; i < numeros.Count; i++)
            {
                suma += numeros[i];
                multi *= numeros[i];
            }

            Console.WriteLine($"El resultado de la suma de la lista(1,2,3,4,5) es {suma}");
            Console.WriteLine($"El resultado de la multiplicacion de la lista(1,2,3,4,5) es {multi}");

            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();
            int numero = 0;

            Console.WriteLine("introduce un numero");
            numero = intChecker();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {numero} == {i * numero}");
            }

            menuActividadesIniciacion();
        }
        public static void ejercicio3()
        {
            Console.Clear();
            for (int i = 0; i <= 99; i++)
            {
                if (i != 3 && i != 6 && i != 11)
                {
                    Console.Write(i + " ");
                }

            }
            menuActividadesIniciacion();
        }
        public static void ejercicio4()
        {
            Console.Clear();
            int numero = 0;
            int total = 1;
            Console.WriteLine("introduce un numero maximo");
            numero = intChecker();

            for (int i = 1; i <= numero; i++)
            {
                if ((i % 2) != 0)
                {
                    total *= i;
                    Console.WriteLine(i + "   " + total);
                }
            }
            Console.WriteLine(total);

            menuActividadesIniciacion();
        }
        public static void ejercicio5()
        {
            Console.Clear();
            int numero = 0;
            int suma = 0;
            Console.WriteLine("introduce un numero maximo");
            numero = intChecker();

            while (numero != 0)
            {
                suma += numero % 10;
                numero /= 10;
            }

            Console.WriteLine($"La suma de los digitos es: " + suma);

            menuActividadesIniciacion();
        }
        public static void ejercicio6()
        {
            Console.Clear();
            int numero = 0;
            Console.WriteLine("introduce un numero maximo");
            numero = intChecker();




            if (numero < 2)
            {
                Console.WriteLine("No es primo");

            }
            if (EsPrimo(numero) == true)
            {
                Console.WriteLine("Es primo");

            }
            else
            {
                Console.WriteLine("No es primo");

            }

            menuActividadesIniciacion();
        }
        public static void ejercicio7()
        {
            Console.Clear();
            int numero = 0;
            Console.WriteLine("introduce un numero maximo");
            numero = intChecker();



            for (int i = 2; i < numero; i++)
            {
                if (EsPrimo(i) == true)
                {
                    Console.Write(i + " ");

                }
            }



            menuActividadesIniciacion();
        }


        static bool EsPrimo(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static void ejercicio8()
        {
            Console.Clear();
            string fila = "";

            for (int i = 1; i <= 9; i++)
            {
                fila += "*";

                Console.WriteLine(fila.Replace("*", i.ToString()));
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            menuActividadesIniciacion();
        }
        public static void ejercicio9()
        {
            Console.Clear();

            for (int i = 1500; i <= 2700; i++)
            {
                if (i % 7 == 0 && i % 5 == 0)
                {
                    Console.Write($"{i} ");
                }
            }


            menuActividadesIniciacion();
        }
        public static void ejercicio10()
        {
            Console.Clear();

            Console.Write("Ingrese un número entero: ");
            int numero = intChecker();

            Dictionary<int, int> ocurrencias = ContarOcurrenciasDigitos(numero);

            foreach (var par in ocurrencias)
            {
                Console.WriteLine($"El dígito {par.Key} aparece {par.Value} veces.");
            }



            menuActividadesIniciacion();
        }


        static Dictionary<int, int> ContarOcurrenciasDigitos(int numero)
        {
            Dictionary<int, int> ocurrencias = new Dictionary<int, int>();

            // Convierte el número en una cadena para iterar por cada dígito
            string numeroStr = Math.Abs(numero).ToString();

            foreach (char digitoChar in numeroStr)
            {
                int digito = int.Parse(digitoChar.ToString());

                if (ocurrencias.ContainsKey(digito))
                {
                    // Si ya se ha encontrado este dígito, aumenta el contador
                    ocurrencias[digito]++;
                }
                else
                {
                    // Si es la primera vez que se encuentra este dígito, agrega una nueva entrada al diccionario
                    ocurrencias[digito] = 1;
                }
            }

            return ocurrencias;
        }

        //ejercicios normales
        public static void ejercicio11()
        {
            Console.Clear();

            Random random = new Random();
            int tamaño = random.Next(0, 10);
            bool aparece = false;
            List<int> enteros = new List<int>();
            int suma = 0;
            for (int i = 0; i <= random.Next(0, 10); i++)
            {
                Console.Write("Ingrese un número entero: ");
                enteros.Add(intChecker());
            }
            foreach (var item in enteros)
            {
                suma += item;
            }
            Console.WriteLine(suma);
            menuActividades();

        }
        public static void ejercicio12()
        {
            Console.Clear();
            string frase;
            Console.WriteLine("Inserte una frase");
            frase = Console.ReadLine();
            string resultado = "";
            foreach (char letra in frase)
            {
                if (!("aeiouAEIOU".Contains(letra)))
                {
                    resultado += letra.ToString();
                }
            }
            Console.WriteLine(resultado);

            menuActividades();

        }
        public static void ejercicio13()
        {
            Console.Clear();

            Random random = new Random();
            int tamaño = random.Next(0, 10);
            bool aparece = false;
            List<int> enteros = new List<int>();
            for (int i = 0; i <= random.Next(0, 10); i++)
            {
                Console.Write("Ingrese un número entero: ");
                enteros.Add(intChecker());
            }

            for (int i = 0; i <= enteros.Count && aparece == false; i++)
            {
                if (i == 1 || i == 3)
                {
                    aparece = true;
                }
            }

            Console.WriteLine(aparece);
            menuActividades();

        }
        public static void ejercicio14()
        {
            Console.Clear();


            Random random = new Random();
            int tamaño = random.Next(0, 10);
            bool aparece = false;
            int a = 0;
            int p = 0;
            List<int> enteros = new List<int>();
            for (int i = 0; i <= random.Next(0, 10); i++)
            {
                Console.Write("Ingrese un número entero: ");
                enteros.Add(intChecker());
            }

            for (int i = 0; i < enteros.Count && aparece == false; i++)
            {
                if (i != 0)
                {
                    a = i - 1;//anterior
                    p = i + 1;//posterior

                    if ((enteros[i] % 2) != 0)
                    {
                        if (enteros[a] == enteros[i] && enteros[i] == enteros[p])
                        {
                            aparece = true;
                        }
                    }
                }
            }
            Console.WriteLine(aparece);
            menuActividades();

        }
        public static void ejercicio15()
        {
            Console.Clear();
            int numero = 0;
            Console.Write("Ingrese un número entero: ");
            numero = intChecker();
            int suma = 0;
            double resultado = Math.Pow(2, numero);


            string numerodividido = resultado.ToString();

            foreach (char digito in numerodividido)
            {
                if (char.IsDigit(digito))
                {
                    suma += int.Parse(digito.ToString());
                }
            }


            Console.WriteLine(suma);

            menuActividades();

        }

        public static void ejercicio16()
        {
            Console.Clear();

            Random random = new Random();
            int tamaño = random.Next(0, 10);
            bool aumenta = true;

            List<int> enteros = new List<int>();
            for (int i = 0; i <= random.Next(0, 10); i++)
            {
                Console.Write("Ingrese un número entero: ");
                enteros.Add(intChecker());
            }

            for (int i = 1; i < enteros.Count && aumenta == true; i++)
            {
                if (enteros[(i - 1)] > enteros[i])
                {
                    aumenta = false;
                }
            }
            if (aumenta == false)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Si");

            }

            menuActividades();

        }
        public static void ejercicio17()
        {
            Console.Clear();
            Random random = new Random();

            int tamaño = random.Next(0, 10);
            bool aumenta = true;

            List<int> enteros = new List<int>();
            for (int i = 0; i <= random.Next(0, 10); i++)
            {
                Console.Write("Ingrese un número entero: ");
                enteros.Add(intChecker());
            }

            int maxAdyacente = int.MinValue;

            for (int i = 0; i < enteros.Count; i++)
            {
                if (enteros[i] == 0)
                {
                    if (i - 1 >= 0 && Math.Abs(enteros[i - 1]) > maxAdyacente)
                    {
                        maxAdyacente = Math.Abs(enteros[i - 1]);
                    }

                    if (i + 1 < enteros.Count && Math.Abs(enteros[i + 1]) > maxAdyacente)
                    {
                        maxAdyacente = Math.Abs(enteros[i + 1]);
                    }
                }
            }
            Console.WriteLine(maxAdyacente);

            menuActividades();
        }
        public static void ejercicio18()
        {
            Console.Clear();

            Random random = new Random();

            int tamaño = random.Next(0, 10);
            bool aumenta = true;

            int enteros=0 ;
            List<int> digitos = new List<int>();

            
                Console.Write("Ingrese un número entero: ");
                enteros=intChecker();
            
            string numerosConcatenados = string.Join(", ", enteros);
            var recuentos = numerosConcatenados.GroupBy(c => c).Where(g => g.Count() == 3 && char.IsDigit(g.Key)).Select(g => int.Parse(g.Key.ToString()));

            digitos.AddRange(recuentos);
            digitos.OrderBy(x => x).ToList();

            foreach (int digito in digitos)
            {
                Console.Write(digito + " ");
            }
            menuActividades();

        }
        public static void ejercicio19()
        {
            Console.Clear();
            Random random = new Random();
            int tamaño = random.Next(0, 10);
            List<int> enteros = new List<int>();
            List<int> digitos = new List<int>();

            for (int i = 0; i <= random.Next(6, 10); i++)
            {
                Console.Write("Ingrese un número entero: ");
                enteros.Add(intChecker());
            }
            string numerosConcatenados = string.Join(", ", enteros);
            var recuentos = numerosConcatenados.GroupBy(c => c).Where(g => g.Count() == 3 && char.IsDigit(g.Key)).Select(g => int.Parse(g.Key.ToString()));

            digitos.AddRange(recuentos);
            digitos.OrderBy(x => x).ToList();

            foreach (int digito in digitos)
            {
                Console.Write(digito + " ");
            }
            menuActividades();

        }
        public static void ejercicio20()
        {
            Console.Clear();

            menuActividades();

        }
        public static void ejercicio21()
        {
            Console.Clear();
            Random random = new Random();

            int tamaño = random.Next(0, 10);
            List<int> numeros = new List<int>();
            List<int> digitos = new List<int>();

            for (int i = 0; i <= random.Next(6, 10); i++)
            {
                Console.Write("Ingrese un número entero: ");
                numeros.Add(intChecker());
            }

            int indiceTres = numeros.IndexOf(3);

            while (indiceTres != -1 && indiceTres < numeros.Count - 1)
            {
                if (numeros[indiceTres + 1] != 4)
                {
                    numeros.Insert(indiceTres + 1, 4);
                    numeros.RemoveAt(indiceTres + 2);
                }
                indiceTres = numeros.IndexOf(3, indiceTres + 1);
            }

            Console.WriteLine("Lista reorganizada:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            menuActividades();

        }
        public static void ejercicio22()
        {
            Console.Clear();

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