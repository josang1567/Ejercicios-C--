using System.Data;

namespace Condicionales
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
            Random rnd = new Random();
            int uno = rnd.Next(0, 100);
            int dos = rnd.Next(0, 100);

            Console.WriteLine($"Numero uno: {uno}\n" +
                $"Numero Dos: {dos}");

            if (uno == dos)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");

            }

            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();
            Random rnd = new Random();
            int uno = rnd.Next(0, 100);
            Console.WriteLine($"Numero: {uno}");
            if (uno % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("No es par");

            }

            menuActividadesIniciacion();
        }
        public static void ejercicio3()
        {
            Console.Clear();
            Random rnd = new Random();
            int uno = rnd.Next(0, 2);
            int negativo = rnd.Next(1, 3);
            if (negativo % 2 != 0)
            {
                uno *= -1;
            }

            Console.WriteLine($"Numero: {uno}");
            if (uno == 0)
            {
                Console.WriteLine("Es cero");
            }

            else if (uno < 0)
            {
                Console.WriteLine("Es negativo");

            }
            else if (uno > 0)
            {
                Console.WriteLine("Es positivo");

            }



            menuActividadesIniciacion();
        }
        public static void ejercicio4()
        {
            Console.Clear();
            Random rnd = new Random();
            int uno = rnd.Next(0, 200);
            int negativo = rnd.Next(1, 3);
            if (negativo % 2 != 0)
            {
                uno *= -1;
            }

            Console.WriteLine($"Numero: {uno}");
            if (uno < 0)
            {
                Console.WriteLine("Es menor que cero");

            }
            else if (uno >= 0 && uno <= 50)
            {
                Console.WriteLine("Esta entre 0 y 50");

            }
            else if (uno >= 51 && uno <= 100)
            {
                Console.WriteLine("Esta entre 51 y 100");
            }
            else if (uno > 100)
            {
                Console.WriteLine("Es mayor que 100");
            }


            menuActividadesIniciacion();
        }
        public static void ejercicio5()
        {
            Console.Clear();

            List<char> consonantes = new List<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'ñ', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };

            List<char> vocales = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            Random random = new Random();
            char letraAleatoria = (char)('a' + random.Next(0, 26));
            Console.WriteLine($"La letra es {letraAleatoria}");



            if (consonantes.Contains(letraAleatoria))
            {
                Console.WriteLine("La letra es una consonante");
            }
            else if (vocales.Contains(letraAleatoria))
            {
                Console.WriteLine("La letra es una vocal");
            }

            menuActividadesIniciacion();
        }
        public static void ejercicio6()
        {
            Console.Clear();
            Random rnd = new Random();
            int anguloUno = rnd.Next(10, 80); ;
            int anguloDos = rnd.Next(10, 80); ;
            int anguloTres = rnd.Next(10, 80); ;
            Console.WriteLine($"Los angulos son {anguloUno} {anguloDos} {anguloTres}");


            if (anguloUno + anguloDos + anguloTres == 180)
            {
                Console.WriteLine("Se puede formar un triangulo");

            }
            else
            {
                Console.WriteLine("No se puede formar un triangulo");

            }


            menuActividadesIniciacion();
        }
        public static void ejercicio7()
        {
            Console.Clear();

            Random rnd = new Random();
            int uno = rnd.Next(0, 10);
            int dos = rnd.Next(0, 10);

            Console.WriteLine($"Numero uno: {uno}\n" +
                $"Numero Dos: {dos}");

            if (uno < dos)
            {
                Console.WriteLine($"{uno} es mayor");
            }
            else if (uno > dos)
            {
                Console.WriteLine($"{dos} es mayor");

            }
            else
            {
                Console.WriteLine("Son iguales");
            }


            menuActividadesIniciacion();
        }
        public static void ejercicio8()
        {
            Console.Clear();
            Random rnd = new Random();
            int uno = rnd.Next(0, 10);
            int dos = rnd.Next(0, 10);
            int tres = rnd.Next(0, 10);
            Console.WriteLine($"Numero uno: {uno}\n" +
               $"Numero Dos: {dos}\n" +
               $"Numero tres: {tres}");


            if (uno >= dos && uno >= tres)
            {
                Console.WriteLine($"El numero {uno} es el mayor de los tres");
            }
            else if (dos > uno && dos >= tres)
            {
                Console.WriteLine($"El numero {dos} es el mayor de los tres");
            }
            else if (tres > uno && tres > dos)
            {
                Console.WriteLine($"El numero {tres} es el mayor de los tres");
            }



            menuActividadesIniciacion();
        }
        public static void ejercicio9()
        {
            Console.Clear();
            String uno = "a";
            String dos = "a";
            String tres = "a";


            if (uno == dos && dos == tres)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");

            }

            menuActividadesIniciacion();
        }
        public static void ejercicio10()
        {
            Console.Clear();
            Random rnd = new Random();
            int edad = rnd.Next(0, 101);


            Console.WriteLine($"Edad: {edad}");

            if (edad >= 1 && edad < 16)
            {
                Console.WriteLine("No esta en edad para trabajar");

            }
            else

            if (edad >= 16 && edad < 67)
            {
                Console.WriteLine("Esta en edad para trabajar");

            }
            else
            if (edad >= 67)
            {
                Console.WriteLine("No esta en edad para trabajar");

            }


            menuActividadesIniciacion();
        }


        //ejercicios normales
        public static void ejercicio11()
        {
            Console.Clear();
            int uno;
            int dos;

            Console.WriteLine("Inserte el valor 1");
            uno = intChecker();

            Console.WriteLine("Inserte el valor 2");
            dos = intChecker();

            if (uno + dos >= 10 && uno + dos <= 19)
            {
                Console.WriteLine("20");
            }
            else
            {
                Console.WriteLine(uno + dos);

            }

            menuActividades();

        }
        public static void ejercicio12()
        {
            Console.Clear();
            int uno;
            int dos;
            int tres;
            bool aparece = false;
            List<int> requisitos = new List<int> { 1, 3 };
            Console.WriteLine("Inserte el valor 1");
            uno = intChecker();

            Console.WriteLine("Inserte el valor 2");
            dos = intChecker();

            Console.WriteLine("Inserte el valor 3");
            tres = intChecker();

            if (requisitos.Contains(uno))
            {
                aparece = true;
            }
            else if (requisitos.Contains(dos))
            {
                aparece = true;
            }
            else if (requisitos.Contains(tres))
            {
                aparece = true;
            }

            Console.WriteLine(aparece);

            menuActividades();

        }
        public static void ejercicio13()
        {
            Console.Clear();
            int uno = 0;
            int dos = 0;
            int tres = 0;
            int cuatro = 0;
            int cinco = 0;

            bool impar = false;

            Console.WriteLine("Inserte el valor 1");
            uno = intChecker();

            Console.WriteLine("Inserte el valor 2");
            dos = intChecker();

            Console.WriteLine("Inserte el valor 3");
            tres = intChecker();

            Console.WriteLine("Inserte el valor 4");
            cuatro = intChecker();

            Console.WriteLine("Inserte el valor 5");
            cinco = intChecker();




            if (uno % 2 != 0 && dos % 2 != 0 && tres % 2 != 0)
            {


                impar = true;
            }
            else

            if (dos % 2 != 0 && tres % 2 != 0 && cuatro % 2 != 0)
            {

                impar = true;
            }
            else

            if (tres % 2 != 0 && cuatro % 2 != 0 && cinco % 2 != 0)
            {

                impar = true;
            }
            Console.WriteLine(impar);

            menuActividades();

        }
        public static void ejercicio14()
        {
            Console.Clear();

            String cadena;
            Console.WriteLine("Introduce la cadena");
            cadena = Console.ReadLine();
            String substring = "";
            List<string> vocales = new List<string> { "a", "e", "i", "o", "u" };
            int tamaño = cadena.Length;

            for (int i = 0; i < tamaño; i++)
            {


                if (!vocales.Contains(cadena[i].ToString()))
                {
                    substring += (cadena[i].ToString());
                }
            }

            cadena = substring;
            Console.WriteLine(cadena);
            menuActividades();

        }
        public static void ejercicio15()
        {

            Console.Clear();
            List<int> numeros = new List<int>();
            int busqueda;
            bool encontrado = false;
            int posicion = 0;
            Random rnd = new Random();

            Console.WriteLine("Introduce El valor de busqueda");
            busqueda = intChecker();

            bool inside = false;

            while (inside == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Introduce El valor de busqueda");
                    numeros.Add(intChecker());
                }
                if (numeros.Contains(busqueda) == true)
                {
                    inside = true;
                }
                else
                {
                    Console.WriteLine($"Por favor introduzca el valor {busqueda} dento de la lista");
                }
            }
            /*for (int i = 0; i < 5; i++)
            {
              
                numeros.Add(rnd.Next(0,50));
            }
            numeros[rnd.Next(0, numeros.Count)] = busqueda;*/
            for (int i = 0; i < 5 && encontrado == false; i++)
            {
                if (numeros[i] == busqueda)
                {
                    posicion = i;
                    encontrado = true;
                }
            }
            foreach (int i in numeros)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine(" ");

            Console.WriteLine(posicion);
            menuActividades();

        }

        public static void ejercicio16()
        {
            Console.Clear();
            List<int> enteros1 = new List<int>();
            List<int> enteros2 = new List<int>();
            bool aparece = false;
            int contador = 0;
            Console.WriteLine("Introducion de valores de la primera lista");

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Introduce un valor:");
                enteros1.Add(intChecker());
            }
            Console.WriteLine("Introducion de valores de la segunda lista");

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("Introduce un valor:");
                enteros2.Add(intChecker());
            }

            for (int i = 0; i < enteros1.Count && aparece == false; i++)
            {
                if (enteros2.Contains(enteros1[i]))
                {
                    contador++;
                }
            }
            if (contador == 3)
            {
                Console.WriteLine("Si");
            }
            else
            {
                Console.WriteLine("No");

            }

            menuActividades();

        }
        public static void ejercicio17()
        {
            Console.Clear();
            float valor;
            string respuesta = "";
            bool correcto = false;
            Console.WriteLine("Inserte el valor");
            valor = floatChecker();
            while (correcto==false)
            {
                Console.WriteLine("Es un valor en cm o metros");
                respuesta = Console.ReadLine();
               if(respuesta == "cm" || respuesta == "metros")
                {
                    correcto = true;

                }

            }
            switch (respuesta)
            {
                case "cm":
                    valor /= 100;
                    Console.WriteLine($"{valor}m");
                    break;
                case "metros":
                    valor *= 100;
                    Console.WriteLine($"{valor}cm");

                    break;
            }


            menuActividades();
        }
        public static void ejercicio18()
        {
            Console.Clear();
            int entero1;
            int entero2;
            Console.WriteLine("Inserte el valor 1");
            entero1 = intChecker();
            Console.WriteLine("Inserte el valor 2");
            entero2 = intChecker();


            if (entero1 > 21 && entero2 > 21)
            {
                Console.WriteLine( 0);
            }

            int diferencia1 = Math.Abs(21 - entero1);
            int diferencia2 = Math.Abs(21 - entero2);

            if (entero1 > 21 || diferencia1 > diferencia2)
            {
                Console.WriteLine( entero2);
            }
            else
            {
                Console.WriteLine( entero1);
            }


            menuActividades();

        }
        public static void ejercicio19()
        {
            Console.Clear();
            Console.WriteLine("entra");
            string[,] tablero = {{ " ", " ", " " },{ " ", " ", " " },{ " ", " ", " " }};

            for (int fila = 0; fila < 3;fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.WriteLine($"Inserte el valor de la fila:{fila} columna_{columna}");
                    tablero[fila,columna]=Console.ReadLine();
                }


            }
            if (ComprobarGanador(tablero) != "Empate")
            {
                Console.WriteLine("Gana " + ComprobarGanador(tablero) );
            }
            else
            {
                Console.WriteLine( ComprobarGanador(tablero));

            }

            menuActividades();

        }

        static string ComprobarGanador(string[,] tablero)
        {
            // Verifica filas y columnas
            for (int i = 0; i < 3; i++)
            {
                if (tablero[i, 0] == tablero[i, 1] && tablero[i, 1] == tablero[i, 2] && tablero[i, 0] != " ")
                    return tablero[i, 0];

                if (tablero[0, i] == tablero[1, i] && tablero[1, i] == tablero[2, i] && tablero[0, i] != " ")
                    return tablero[0, i];
            }

            // Verifica diagonales
            if (tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2] && tablero[0, 0] != " ")
               return tablero[0, 0];

            if (tablero[0, 2] == tablero[1, 1] && tablero[1, 1] == tablero[2, 0] && tablero[0, 2] != " ")
              return  tablero[0, 2];

            return "Empate";
        }

        public static void ejercicio20()
        {
            Console.Clear();
            Console.WriteLine("Introduce un número entero (mayor que 0 y menor que 10,000):");
            int numero = intChecker();
            List<int> excepcion = new List<int>() {50,51,52,53,54,56,57,58,59};   
            if (numero > 0 && numero < 10000)
            {
                string numeroComoTexto = numero.ToString();

                if (numeroComoTexto.Contains("5") && !numeroComoTexto.EndsWith("15") && numero != 500 )
                {
                    Console.WriteLine("Si");
                }
                else
                {
                    Console.WriteLine("No.");
                }
            }
           
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

        public static float floatChecker()
        {
            float numero = 0;
            String input = Console.ReadLine();
            try
            {
                numero = Single.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingrese un número entero válido.");
                floatChecker();
            }
            return numero;
        }
    }
}