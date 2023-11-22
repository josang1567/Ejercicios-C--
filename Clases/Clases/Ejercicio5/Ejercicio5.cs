using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Ejercicio5
{
   
    class estudiante
    {
        public string nombre;
        public List<(String, int)> notas;

        public estudiante(string nombre, List<(String, int)> notas)
        {
            this.nombre = nombre;
            this.notas = notas;
        }

        public string getNombre()
        {
            return nombre;
        }

        public List<(String, int)> getNotas()
        {
            return notas;
        }

        public void setNombre(string newnombre)
        {
            nombre = newnombre;
        }

        public void setNotas(List<(String, int)> notasnuevas)
        {
            notas = notasnuevas;
        }

        public void medianotas(List<(String, int)> notas)
        {
            double notasmedias = 0;

            foreach (var item in notas)
            {
                notasmedias += item.Item2;
            }
            notasmedias = notasmedias / notas.Count();
            Console.WriteLine($"La nota media del {getNombre()} es: {notasmedias}");
        }

    }

}
