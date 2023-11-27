

using Clases.Ejercicio1;
using Clases.Ejercicio2;
using Clases.Ejercicio3;
using Clases.Ejercicio4;
using Clases.Ejercicio5;
using Clases.Ejercicio8;
using Clases.Ejercicio10;

using System.Timers;
using circulo = Clases.Ejercicio4.circulo;
using rectangulo = Clases.Ejercicio3.rectangulo;

namespace Clases
{
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
            Punto punto1 = new Punto(45, 53);
            Punto punto2 = new Punto(27, 94);
            Punto punto3 = new Punto(11, 112);

            Console.WriteLine($"punto1: x={punto1.GetX()}, y={punto1.GetY()}");
            Console.WriteLine($"punto2: x={punto2.GetX()}, y={punto2.GetY()}");
            Console.WriteLine($"punto3: x={punto3.GetX()}, y={punto3.GetY()}");

            punto1.SetX(10);
            punto2.SetY(20);
            punto3.SetX(100);
            punto3.SetY(200);

            Console.WriteLine($"punto1: x={punto1.GetX()}, y={punto1.GetY()}");
            Console.WriteLine($"punto2: x={punto2.GetX()}, y={punto2.GetY()}");
            Console.WriteLine($"punto3: x={punto3.GetX()}, y={punto3.GetY()}");


            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();
            Linea linea1 = new Linea(1, 2, 3, 4);
            Linea linea2 = new Linea(3, 5, 8, 7);
            Linea linea3 = new Linea(51, 32, 34, 43);

            linea1.puntoMedio();
            linea2.puntoMedio();
            linea3.puntoMedio();
            linea3.puntoMedio();
            menuActividadesIniciacion();
        }
        public static void ejercicio3()
        {
            Console.Clear();
            rectangulo r1 = new rectangulo(32, 54);
            rectangulo r2 = new rectangulo(352, 97);
            rectangulo r3 = new rectangulo(12, 24);

            r1.area();
            r2.area();
            r3.area();

            menuActividadesIniciacion();
        }
        public static void ejercicio4()
        {
            Console.Clear();
            circulo c1 = new circulo(32);
            circulo c2 = new circulo(352);
            circulo c3 = new circulo(12);

            c1.area();
            c2.area();
            c3.area();
            c1.circunferencia();
            c2.circunferencia();
            c3.circunferencia();

            menuActividadesIniciacion();
        }
        public static void ejercicio5()
        {
            Console.Clear();
            List<(String, int)> notas1 = new List<(String, int)> { ("Mates", 1), ("Lengua", 5), ("Tecnologia", 9) };
            List<(String, int)> notas2 = new List<(String, int)> { ("Mates", 4), ("Lengua", 8), ("Tecnologia", 3) };
            List<(String, int)> notas3 = new List<(String, int)> { ("Mates", 7), ("Lengua", 0), ("Tecnologia", 2) };



            estudiante e1 = new estudiante("Mauricio", notas1);
            estudiante e2 = new estudiante("Luisma", notas2);
            estudiante e3 = new estudiante("Aida", notas3);

            Console.WriteLine($"La nota media del {e1.getNombre()} es: {e1.medianotas(e1.notas)}");
            Console.WriteLine($"La nota media del {e2.getNombre()} es: {e2.medianotas(e2.notas)}");
            Console.WriteLine($"La nota media del {e3.getNombre()} es: {e3.medianotas(e3.notas)}");


            menuActividadesIniciacion();
        }
        public static void ejercicio6()
        {
            Console.Clear();
            Punto punto1b = new Punto(45, 53);
            Punto punto2b = new Punto(27, 94);
            Punto punto3b = new Punto(11, 112);
            Console.WriteLine("Distancia ecludiana: " + Punto.distanciaEuclida(punto3b, punto2b));
            Console.WriteLine("Distancia ecludiana: " + Punto.distanciaEuclida(punto1b, punto3b));
            Console.WriteLine("Distancia ecludiana: " + Punto.distanciaEuclida(punto2b, punto1b));

            menuActividadesIniciacion();
        }
        public static void ejercicio7()
        {
            Console.Clear();
            Punto punto1c = new Punto(45, 53);
            Punto punto2c = new Punto(27, 94);
            Punto punto3c = new Punto(11, 112);
            Linea2D linea1c = new Linea2D(punto3c, punto2c);
            Linea2D linea2c = new Linea2D(punto1c, punto3c);
            Linea2D linea3c = new Linea2D(punto2c, punto1c);


            var Medio1 = Linea2D.puntoMedioSegmento(linea1c);
            var Medio2 = Linea2D.puntoMedioSegmento(linea2c);
            var Medio3 = Linea2D.puntoMedioSegmento(linea3c);

            Console.WriteLine("Punto medio del segmento : (" + Medio1.Item1 + ")(" + Medio1.Item2 + ")");
            Console.WriteLine("Punto medio del segmento : (" + Medio2.Item1 + ")(" + Medio2.Item2 + ")");
            Console.WriteLine("Punto medio del segmento : (" + Medio3.Item1 + ")(" + Medio3.Item2 + ")");



            Console.WriteLine("Distancia ecludiana del segmento :" + Linea2D.distanciaEuclida(linea1c));
            Console.WriteLine("Distancia ecludiana del segmento :" + Linea2D.distanciaEuclida(linea2c));
            Console.WriteLine("Distancia ecludiana del segmento :" + Linea2D.distanciaEuclida(linea3c));



            menuActividadesIniciacion();
        }
        public static void ejercicio8()
        {
            Console.Clear();
            Punto p1 = new Punto(2, 23);
            Punto p2 = new Punto(4, 3);
            Punto p3 = new Punto(22, 35);

            Ejercicio8.rectangulo r1 = new Ejercicio8.rectangulo(1, 2, p1);
            Ejercicio8.rectangulo r2 = new Ejercicio8.rectangulo(11, 25, p2);
            Ejercicio8.rectangulo r3 = new Ejercicio8.rectangulo(65, 29, p3);

            Ejercicio8.circulo c1 = new Ejercicio8.circulo(32, p1);
            Ejercicio8.circulo c2 = new Ejercicio8.circulo(976, p2);
            Ejercicio8.circulo c3 = new Ejercicio8.circulo(74, p3);


            Console.WriteLine($"El area del rectangulo es:" + r1.area());
            Console.WriteLine($"El area del rectangulo es:" + r2.area());
            Console.WriteLine($"El area del rectangulo es:" + r3.area());

            Console.WriteLine($"El area del circulo es:" + c1.area());
            Console.WriteLine($"El area del circulo es:" + c2.area());
            Console.WriteLine($"El area del circulo es:" + c3.area());

            menuActividadesIniciacion();
        }
        public static void ejercicio9()
        {
            Console.Clear();

            Random r = new Random();
         
            List<(String, int)> notasa1 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasa2 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasa3 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasa4 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasa5 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };

            List<(String, int)> notasb1 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasb2 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasb3 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasb4 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasb5 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };

            List<(String, int)> notasc1 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasc2 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasc3 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasc4 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };
            List<(String, int)> notasc5 = new List<(String, int)> { ("Mates", r.Next(1, 9)), ("Lengua", r.Next(1, 9)), ("Tecnologia", r.Next(1, 9)) };


            estudiante ea1 = new estudiante("Mauricio", notasa1);
            estudiante ea2 = new estudiante("Luisma", notasa2);
            estudiante ea3 = new estudiante("Aida", notasa3);
            estudiante ea4 = new estudiante("Paca", notasa4);
            estudiante ea5 = new estudiante("Fermin", notasa5);

            estudiante eb1 = new estudiante("Pilar", notasb1);
            estudiante eb2 = new estudiante("Pepe", notasb2);
            estudiante eb3 = new estudiante("Carla", notasb3);
            estudiante eb4 = new estudiante("Marta", notasb4);
            estudiante eb5 = new estudiante("Clark", notasb5);

            estudiante ec1 = new estudiante("Bruce", notasc1);
            estudiante ec2 = new estudiante("Peter", notasc2);
            estudiante ec3 = new estudiante("Louis", notasc3);
            estudiante ec4 = new estudiante("Miguel", notasc4);
            estudiante ec5 = new estudiante("Luis", notasc5);

            List<estudiante> lista1 = new List<estudiante> { ea1,ea2, ea3, ea4, ea5 };
            List<estudiante> lista2 = new List<estudiante> { eb1, eb2, eb3, eb4, eb5 };
            List<estudiante> lista3 = new List<estudiante> { ec1, ec2, ec3, ec4, ec5 };
            List<List<estudiante>> Curso= new List<List<estudiante>> { lista1,lista2,lista3};
            Console.WriteLine("El grupo con mayor promedio es el grupo con el indice: " + estudiante.mayorPromedio(Curso));

            menuActividadesIniciacion();
        }
        public static void ejercicio10()
        {
            Console.Clear();

            A objetoA = new A();
            B objetoB = new B();
            C objetoC = new C();

            objetoA.MetodoComun(); 
            objetoB.MetodoComun(); 
            objetoC.MetodoComun();



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