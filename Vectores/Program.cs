using System.Numerics;
using System.Runtime.Intrinsics;

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

       static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void ejercicio1()
        {
            Console.Clear();

            /*
                   Un vector es un segmento de un mapa que tiene una direccion y sentido 
                   Sus propiedades basicas son:

                   -Igualdad: dos vectores son iguales si tienen la misma magnitud y direccion, tambien son iguales en caso de que sus cordenadas sean iguales.

                   -Vectores opuestos, paralelos y antiparalelos:
                           +Opuestos: Los vectores opuestos son toda pareja de vectores con la misma magnitud pero direccion opuesta.

                           +Paralelos: Los vectores paralelos son aquellos que tienen la misma direccion pero no la misma magnitud.

                           +Antiparalelos: Los vectores antiparalelos  sin tienen direccion opuesta pero no la misma magnitud
                   -Suma y resta: La suma y resta de vectores se puede definir con la siguientes formulas:
                               -Suma: a+b=(a1+b1)e1+(a2+b2)e2+(a3+b3)e3
                               -Resta: a-b=(a1-b1)e1+(a2-b2)e2+(a3-b3)e3

                   -Multiplicacion de escala: Un vector puede ser multiplicado por un numero real "r", para ello se usa esta formula:
                               - ra=(ra1)e1+(ra2)e2 +(ra3)e3

                   -Longitud: La longitud o magnitud de un vector a se denota por ||a||, ls longitud se puede calcular con la norma ecludiana: ||a|| =Raiz((a1*a1)+(a2*a2)+(a3*a3))

                   -Vector unitario: Es cualquier vector con longitud de uno, estos vectores se suelen emplear en indicar una direccion. Un vector de longitud arbitraria se puede dividir por si mismo para crear un vector unitario, este proceso se conoce como normalizar, y la formula para realizarlo es: â=(a/||a||)=(a1/||a||)e1+(a2/||a||)e2+(a3/||a||)e3

                   -Vector cero: el vector 0 es el vector de longitud 0, en coordenadas es (0,0,0) y es denotado como 0, a diferencia de otros vectores, tiene direccion arbitraqria y no puede normalizarse. La suma del vector 0 con un vector X es igual a X (0+X=X)

                   -Producto escalado: el producto escala de dos vectores(a y b) se denota por a*b y se define como:a*b==||a|| ||b|| cos0
                       Tambien se puede definir como la suma de dos productos: a*b=a1*b1+a2*b2+a3*b3

                   -Producto cruzado: Solo es utilizado en 3 o 7 dimensiones, se puede calcular con la siguiente formula: a * b=(a2b3-a3b2)e1 + (a3b1-a1b3)e2+(a1b2-a2b1)e3  

                   -Proudcto de triple escala: no es un operador realmente nuevo, sino una forma de aplcar 2 operadores de multiplicacion de 3 vectores y se calcula con la siguiente formula: (abc)=a(b * c)*/
            menuActividadesIniciacion();
        }
        public static void ejercicio2()
        {
            Console.Clear();
            int xA = 1, yA = 4;
            int xB = 6, yB = 6;


            int AB_x = xB - xA;
            int AB_y = yB - yA;


            int vectorBA_x = xA - xB;
            int vectorBA_y = yA - yB;


            Console.WriteLine("Vector de A a B: (" + AB_x + ", " + AB_y + ")");
            Console.WriteLine("Vector de B a A: (" + vectorBA_x + ", " + vectorBA_y + ")");
            menuActividadesIniciacion();
        }
        public static void ejercicio3()
        {
            Console.Clear();
            Vector2 VectorA = new Vector2(3, 2);
            Vector2 vectorB = new Vector2(1, 1);
            Vector2 vectorC = new Vector2(4, 5);


            Console.WriteLine("Vector a: (" + VectorA.X + ", " + VectorA.Y + ")");
            Console.WriteLine("Vector b: (" + vectorB.X + ", " + vectorB.Y + ")");
            Console.WriteLine("Vector c: (" + vectorC.X + ", " + vectorC.Y + ")");


            menuActividadesIniciacion();
        }
        public static void ejercicio4()
        {
            Console.Clear();

            //Vector Of
            Vector2 OF;
            Vector2 Origen = new Vector2(7, 2);
            Vector2 Final = new Vector2(8, 5);
            OF = Final - Origen;
            Console.WriteLine($"Vector OrigenFin dados los vectores {Origen} y {Final} es igual a :" + OF);


            //Longitud del vector of
            double LongitudOF;
        
            LongitudOF = Math.Sqrt(((Final.X - Origen.X) * (Final.X - Origen.X)) + ((Final.Y - Origen.Y) * (Final.Y - Origen.Y)));
            Console.WriteLine("La longitud del vector OF es igual a " + LongitudOF);


            //Regla del paralelogramo

            Vector2 v = new Vector2(2,3);
            Vector2 w = new Vector2(5, 1);


            Console.WriteLine($"La regla del paralelogramo dice que el resultado de la suma de dos vectores es el mismo aunque se apliquen en ordenes distintos:" +
                $"Por ejemplo la suma del vector v({v}) y la suma del vector w({w}) es da siempre {v+w}, ya se sume primero el vector W o el vector V");

            //Resta de vectores
             v = new Vector2(4, 1);
             w = new Vector2(-3, -2);
            Console.WriteLine($"La resta de el vector v y W genera la siguiente cordenada {v+w}");





            menuActividadesIniciacion();
        }
        public static void ejercicio5()
        {
            Console.Clear();
            Vector3 A = new Vector3(5, -2, 4);
            Vector3 B = new Vector3(-1, -7, 3);

            //Magnitud
            float magnitudA = A.Length();
            float magnitudB = B.Length();


            Vector3 suma = Vector3.Add(A, B);
            Vector3 resta = Vector3.Subtract(A, B);
            Vector3 multiplicacionEscalada = Vector3.Multiply(A, 2);
            float productoEscalado = Vector3.Dot(A, B);
            Vector3 productoCruzado = Vector3.Cross(A, B);

            // Normalizar los vectores 
            Vector3 VUnitarioA = Vector3.Normalize(A);
            Vector3 VUnitarioB = Vector3.Normalize(B);

            // Verificar si los vectores son aproximadamente iguales
            bool Igual = Vector3.Equals(A, B);

            // Mostrar resultados
            Console.WriteLine("|a|: " + magnitudA);
            Console.WriteLine("|b|: " + magnitudB);
            Console.WriteLine("a + b: (" + suma.X + ", " + suma.Y + ", " + suma.Z + ")");
            Console.WriteLine("a - b: (" + resta.X + ", " + resta.Y + ", " + resta.Z + ")");
            Console.WriteLine("2 * a: (" + multiplicacionEscalada.X + ", " + multiplicacionEscalada.Y + ", " + multiplicacionEscalada.Z + ")");
            Console.WriteLine("a · b: " + productoEscalado);
            Console.WriteLine("a x b: (" + productoCruzado.X + ", " + productoCruzado.Y + ", " + productoCruzado.Z + ")");
            Console.WriteLine("Â: (" + VUnitarioA.X + ", " + VUnitarioA.Y + ", " + VUnitarioA.Z + ")");
            Console.WriteLine("B̂: (" + VUnitarioB.X + ", " + VUnitarioB.Y + ", " + VUnitarioB.Z + ")");
            Console.WriteLine("a ≏ b: " + Igual);



            menuActividadesIniciacion();
        }
        public static void ejercicio6()
        {
            Console.Clear();
            int limite;
            Console.WriteLine("Introduce un número entero:");
            limite = int.Parse(Console.ReadLine());

            for (int i = 2; i <= limite; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
            menuActividadesIniciacion();
        }
        public static void ejercicio7()
        {
            Console.Clear();
            /*
             Los vectores en los videojuegos tienen una gran variedad de usos, permitiendo realizar calculas y representar informacion en diversas areas.
             Algunas de estas areas usadas son:
                    -Posicion y orientacion de un personaje
                    -Calcular el movimiento de objetos
                    -Detectar y resolver eventos de colisiones
                    -Emular las fisicas del mundo real en el videojuego
                    -Describir los vertices de modelos 3d
                    -Calcular las trayectorias de animación
                    -Controlar IA y las trayectorias de personajes
                    -Modelar la direccion e intensidad del sonido tridimensional
             */



            menuActividadesIniciacion();
        }
       

    }
}