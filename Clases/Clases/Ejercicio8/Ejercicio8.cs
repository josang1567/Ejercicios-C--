using Clases.Ejercicio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ejercicio8
{
   
     //-----------------------------------------------
    //Ejercicio 8
    abstract class Forma
    {
        public Punto centro;

        public Forma(Punto centro)
        {
            this.centro = centro;
        }

        public abstract double area();


    }

    class rectangulo8 : Forma
    {
        public int longitud;
        public int ancho;

        public rectangulo8(int longitud, int ancho, Punto centro) : base(centro)
        {
            this.longitud = longitud;
            this.ancho = ancho;
            this.centro = centro;
        }
        public override double area()
        {
            double area = 0;
            area = longitud * ancho;
            return area;
        }

    }

    class circulo8 : Forma
    {
        public double radio;

        public circulo8(double radio, Punto centro) : base(centro)
        {
            this.radio = radio;
            this.centro = centro;
        }

        public override double area()
        {
            double area = 0;
            area = Math.PI * radio;
            return area;
        }

    
}
