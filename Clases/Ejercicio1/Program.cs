﻿namespace Ejercicio1
{

    internal class Program
    {
        static void Main(string[] args)
        {
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

            //ejercicio 6

            Console.WriteLine("Distancia ecludiana: " + Punto.distanciaEuclida(punto3, punto2));
            Console.WriteLine("Distancia ecludiana: " + Punto.distanciaEuclida(punto1, punto3));
            Console.WriteLine("Distancia ecludiana: " + Punto.distanciaEuclida(punto2, punto1));

            //ejercicio 7

            Linea2D linea1 = new Linea2D(punto3, punto2);
            Linea2D linea2 = new Linea2D(punto1, punto3);
            Linea2D linea3 = new Linea2D(punto2, punto1);


            var Medio1 = Linea2D.puntoMedioSegmento(linea1);
            var Medio2 = Linea2D.puntoMedioSegmento(linea2);
            var Medio3 = Linea2D.puntoMedioSegmento(linea3);

            Console.WriteLine("Punto medio del segmento : (" + Medio1.Item1 + ")(" + Medio1.Item2 + ")");
            Console.WriteLine("Punto medio del segmento : (" + Medio2.Item1 + ")(" + Medio2.Item2 + ")");
            Console.WriteLine("Punto medio del segmento : (" + Medio3.Item1 + ")(" + Medio3.Item2 + ")");



            Console.WriteLine("Distancia ecludiana del segmento :" + Linea2D.distanciaEuclida(linea1));
            Console.WriteLine("Distancia ecludiana del segmento :" + Linea2D.distanciaEuclida(linea2));
            Console.WriteLine("Distancia ecludiana del segmento :" + Linea2D.distanciaEuclida(linea3));
        }
    }

    class Punto
    {
        private double x;
        private double y;

        public Punto(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()
        {
            return x;
        }

        public double GetY()
        {
            return y;
        }

        public void SetX(double nuevoX)
        {
            x = nuevoX;
        }

        public void SetY(double nuevoY)
        {
            y = nuevoY;
        }
        //------------------------------------------------------
        //Ejercicio 6

        public static double distanciaEuclida(Punto punto1, Punto punto2)
        {
            double distancia = 0;

            distancia = Math.Sqrt(((punto2.x - punto1.x) * (punto2.x - punto1.x)) + ((punto2.y - punto1.y) * (punto2.y - punto1.y)));


            return distancia;
        }


    }
    //-------------------------------------------------------------------
    //Ejercicio 7
    class Linea2D
    {
        private Punto p1;
        private Punto p2;


        public Linea2D(Punto p1, Punto p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public Punto getP1()
        {

            return p1;
        }
        public Punto getP2()
        {

            return p2;
        }

        public void SetP1(Punto p1Nuevo)
        {
            p1 = p1Nuevo;
        }
        public void SetP2(Punto p2Nuevo)
        {
            p2 = p2Nuevo;
        }

        public static (double, double) puntoMedioSegmento(Linea2D linea)
        {
            double puntoMedioX = 0;
            double puntoMedioY = 0;

            puntoMedioX = (linea.p1.GetX() + linea.p2.GetX()) / 2;
            puntoMedioY = (linea.p1.GetY() + linea.p2.GetY()) / 2;


            return (puntoMedioX, puntoMedioY);
        }

        public static double distanciaEuclida(Linea2D linea)
        {
            double distancia = 0;

            distancia = Math.Sqrt(((linea.p2.GetX() - linea.p1.GetX()) * (linea.p2.GetX() - linea.p1.GetX())) + ((linea.p2.GetY() - linea.p1.GetY()) * (linea.p2.GetY() - linea.p1.GetY())));


            return distancia;
        }

    }
    //-----------------------------------------------
    //Ejercicio 8
    class Forma
    {
        Punto centro;

        public static double area()
        {
            var rand = new Random();
            return rand.Next(1, 5);
        }
    }
}