using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ejercicio10
{
    internal class Ejercicio10
    {
    }

    public class A
    {
        protected int valorA = 1;
        public virtual void MetodoComun()
        {
            Console.WriteLine("Método de la clase A "+valorA);
        }
    }

    public class B : A
    {
        protected int valorb = 2;

        public override void MetodoComun()
        {
            Console.WriteLine("Método de la clase B " + valorb + this.valorA);

        }
    }

    public class C : B
    {
        protected int valorc = 3;

        public override void MetodoComun()
        {
            Console.WriteLine("Método de la clase C "+ valorc+this.valorA+this.valorb);
        }
    }
}
