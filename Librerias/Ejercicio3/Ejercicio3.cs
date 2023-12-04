using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias.Ejercicio3
{
     class Ejercicio3
    {
        public static void ej3()
        {
            try
            {
                // Lee el contenido del archivo 1 y almacénalo en una variable
                string textoArchivo1 = File.ReadAllText("project-history.es.txt");

                // Lee el contenido del archivo 2 y almacénalo en otra variable
                string textoArchivo2 = File.ReadAllText("Countries-Europe.txt");

                // Concatena los dos textos en una nueva variable
                string textos_concatenados = textoArchivo1 + textoArchivo2;

                // Crea un nuevo archivo y escribe el contenido concatenado
                File.WriteAllText("textos_concatenados.txt", textos_concatenados);

                Console.WriteLine("Se han concatenado los textos y se ha creado el archivo 'textos_concatenados.txt'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
