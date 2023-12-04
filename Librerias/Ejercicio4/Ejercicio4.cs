using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace Librerias.Ejercicio4
{
    internal class Ejercicio4
    {

        public static void ej4()
        {
            int resultadoSuma;
            List<int> resultadosTiradas=new List<int>();
            List<string> resultados = new List<string>();
            

            Random random = new Random(); 

            for (int i = 0; i < 10000; i++)
            {
                int dado1 = random.Next(1, 7);
                int dado2 = random.Next(1, 7);
                resultadoSuma = dado1 + dado2;
                resultadosTiradas.Add(resultadoSuma);
            }

            resultadosTiradas.OrderByDescending(x => x);

             using (StreamWriter file = new StreamWriter("resultadosTiradas.txt"))
             {
                 file.WriteLine(ContarRepeticiones(resultadosTiradas));
                 Console.WriteLine(ContarRepeticiones(resultadosTiradas));

             }
             //metodo alternativo

            //File.WriteAllText("Textos concatenados", ContarRepeticiones(resultadosTiradas));
            Console.WriteLine("Resultados:\n" + ContarRepeticiones(resultadosTiradas));

        }

        static string ContarRepeticiones(List<int> lista)
        {
            string resultado="";
            List<(int,int)> mayor=new List<(int,int)>();    
            Dictionary<int, int> conteo = new Dictionary<int, int>();

       
            for (int i = 2; i <= 12; i++)
            {
                conteo[i] = 0;
            }

            foreach (int numero in lista)
            {
                if (conteo.ContainsKey(numero))
                {
                    conteo[numero]++;
                }
               

            }
            
            // Imprimir los resultados
            foreach (var kvp in conteo)
            {
                resultado+="Número "+ kvp.Key+" : " +kvp.Value+" veces.\n";
                mayor.Add((kvp.Key, kvp.Value));
            }

            mayor = mayor.OrderByDescending(item => item.Item2).ToList();

            resultado += "El resultado que mas se repite es: " + mayor[0].Item1+".\n";
            resultado += "El segundo resultado que mas se repite es: " + mayor[1].Item1 + ".\n";
            resultado += "El tercer resultado que mas se repite es: " + mayor[2].Item1 + ".\n";

            return resultado;
        }
    }

    
}
