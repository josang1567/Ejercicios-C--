using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Variables_C_
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
            String holaMundo = "¡Hola, mundo!";
            Console.WriteLine(holaMundo);
           
            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();
            int numero;
            numero = 321;
            Console.WriteLine(numero);
           
            menuActividadesIniciacion();
        }
        public static void ejercicio3()
        {
            Console.Clear();
            int edad;
            int altura;
            edad = 18;
            altura = 190;
            Console.WriteLine($"Tengo {edad} años y mido {altura} cm");
           
            menuActividadesIniciacion();
        }
        public static void ejercicio4()
        {
            Console.Clear();
            int numero1;
            int numero2;
            int suma;
            numero1 = 1;
            numero2 = 2;
            Console.WriteLine($"El primer numero es {numero1}");
            Console.WriteLine($"El segundo numero es {numero2}");
            suma = numero1 + numero2;
            Console.WriteLine($"La suma de ambos numeros es {suma}");
           
            menuActividadesIniciacion();
        }
        public static void ejercicio5()
        {
            Console.Clear();
            int numero= 122413;
            bool verdadero=false;
            string linea = "Hola mundo";
            float decimales = 43.34f;

            Console.WriteLine($"int: {numero}, Boolean: {verdadero},  String: {linea}, Float: {decimales}");
           
            menuActividadesIniciacion();
        }
        public static void ejercicio6()
        {
            Console.Clear();
            float radio = 13.4f;
            float pi = 3.141592f;
            float circunferencia;

            Console.WriteLine($"El radio es {radio}");
            circunferencia=2*pi*radio;
            Console.WriteLine($"La circunferencia es {circunferencia}");

           
            menuActividadesIniciacion();
        }
        public static void ejercicio7()
        {
            Console.Clear();
            float radio = 13.4f;
            float pi = 3.141592f;
            float area;

            Console.WriteLine($"El radio es {radio}");
            area =  pi * (radio * radio);
            Console.WriteLine($"El area es {area}");

           
            menuActividadesIniciacion();
        }
        public static void ejercicio8()
        {
            Console.Clear();
            String latitud = "-234,62";
            float valor = 21.34f;
            float variable = Convert.ToSingle(latitud)-valor;
            Console.WriteLine(variable);

           
            menuActividadesIniciacion();
        }
        public static void ejercicio9()
        {
            Console.Clear();
            float celsius = 36.56f;
            float fahrenheit = 0;

            Console.WriteLine($"El valor {celsius} en fahrenheit es igual a:");
            celsius = (celsius * 1.8f) + 32;
            Console.WriteLine(celsius);


           
            menuActividadesIniciacion();
        }
        public static void ejercicio10()
        {
            Console.Clear();

            float celsius = 0;
            float fahrenheit = 97.808f;

            Console.WriteLine($"El valor {fahrenheit} en celcius es igual a:");
            fahrenheit = (fahrenheit - 32) / 1.8f;
            Console.WriteLine(fahrenheit);


           
            menuActividadesIniciacion();
        }


        //ejercicios normales
        public static void ejercicio11()
        {
            Console.Clear();
            int uno = 0;
            int dos = 0;
            int tres = 0;

            Console.WriteLine("Inserte el valor uno");
            uno=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte el valor dos");
            dos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte el valor 3");
            tres = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Entrada:{uno} {dos} {tres} Salida: {uno+dos+tres}");
           
            menuActividades();

        }
        public static void ejercicio12()
        {
            Console.Clear();
            float fahrenheit = 0;
            float celsius = 0;

            Console.WriteLine("Inserte la temperatura en fahrenheit para convertir a celsius");
            fahrenheit = Convert.ToInt32(Console.ReadLine());



            celsius = (fahrenheit - 32) / 1.8f;
            Console.WriteLine($"{fahrenheit} grados fahrenheit equivalen a {celsius} grados celsius");
           
            menuActividades();

        }
        public static void ejercicio13()
        {
            Console.Clear();
            int largo=0;
            int ancho=0;
            int area;//largo * ancho
            int perimetro;//(largo*2) * (ancho*2) 

            Console.WriteLine("Inserte el largo");
            largo = Convert.ToInt32(Console.ReadLine());
            
            while (largo >= ancho)
            {
                Console.WriteLine("Inserte el ancho");
            ancho = Convert.ToInt32(Console.ReadLine());
                if(largo >= ancho)
                {
                    Console.WriteLine("El largo tiene que ser mayor que el ancho");
                }
            }
            
            area = ancho * largo;
            perimetro = ((area*2) * (ancho*2));
            Console.WriteLine($"El area del rectangulo es igual a {area} \n" +
                $"El perimetro del rectangulo es igual a {perimetro} ");


           
            menuActividades();

        }
        public static void ejercicio14()
        {
            Console.Clear();
            string uno ;
            string dos ;
           

            Console.WriteLine("Inserte el valor uno");
            uno =Console.ReadLine();

            Console.WriteLine("Inserte el valor dos");
            dos =Console.ReadLine();

           

            Console.WriteLine($"Entrada:{uno+dos} Salida: {Convert.ToInt32(uno+dos)+5}");
           
            menuActividades();

        }
        public static void ejercicio15()
        {
            Console.Clear();
            int uno = 0;
            int dos = 0;
            int tres = 0;
            int multiplicacion = 0;

            Console.WriteLine("Inserte el valor uno");
            uno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte el valor dos");
            dos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte el valor 3");
            tres = Convert.ToInt32(Console.ReadLine());

            multiplicacion = uno * dos * tres;
            
            multiplicacion = Convert.ToInt32( Convert.ToString(multiplicacion) + "4");
            Console.WriteLine($"el resultado es: {multiplicacion/2}");
           
            menuActividades();

        }

        public static void ejercicio16()
        {
            Console.Clear();
            int valor=0;
            Console.WriteLine("Inserte un entero");
            
            valor = Convert.ToInt32(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
           
            menuActividades();

        }
        public static void ejercicio17()
        {
            Console.Clear();
            int uno = 0;
            int dos = 0;
            int tres = 0;
            int cuatro = 0;
            int cinco = 0;
         

            Console.WriteLine("Inserte el valor uno");
            uno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte el valor dos");
            dos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte el valor 3");
            tres = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte el valor 4");
            cuatro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserte el valor 5");
            cinco = Convert.ToInt32(Console.ReadLine());

            int[] enteros = { uno,dos,tres, cuatro, cinco};
            foreach (int entero in enteros)
            {
                if (entero % 2 == 0)
                {
                    Console.Write("0 ");
                }
                else
                {
                    Console.Write("1 ");
                }
            }
            Console.Write("\n ");


           
            menuActividades();
        }
        public static void ejercicio18()
        {
            Console.Clear();
            int valor = 0;
            Console.WriteLine("Inserte un entero");

            valor = Convert.ToInt32(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("GNU");
            }
            else
            {
                Console.WriteLine("");
            }
           
            menuActividades();
           
        }
    }
}