using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ejercicio1
{
   
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
    


}
