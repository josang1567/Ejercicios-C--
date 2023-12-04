using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.Ejercicio2
{
    internal class Ejercicio2
    {public static void ej2()
        {
            Console.WriteLine("Ejemplo 1");

            StringBuilder builder = new();
            builder.AppendLine("Hello");
            builder.AppendLine("World!");

            Console.WriteLine(builder.ToString());


            Console.WriteLine("Ejemplo 2");

            int? maybe = 12;

            if (maybe is int number)
            {
                Console.WriteLine($"The nullable int 'maybe' has the value {number}");
            }
            else
            {
                Console.WriteLine("The nullable int 'maybe' doesn't hold a value");
            }

            Console.WriteLine("\nEjemplo 3");
            var result = QueryCityData("New York City");

            var city = result.Item1;
            var pop = result.Item2;
            var size = result.Item3;

            Console.WriteLine(result.Item1+" "+result.Item2+" "+result.Item3);
        }
        private static (string, int, double) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);

            return ("", 0, 0);
        }
    }


}
