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

        public double medianotas(List<(String, int)> notas)
        {
            double notasmedias = 0;

            foreach (var item in notas)
            {
                notasmedias += item.Item2;
            }
            notasmedias = notasmedias / notas.Count();

            return notasmedias;
        }

        //-------------------
        //Ejercicio 9
        public int mayorPromedio(List<List<estudiante>> grupos)
        {
            int indiceMayor = 0;
            double promedio = 0;
            for (int i = 0; i < grupos.Count; i++)
            {
                double notamedia = 0;

                for (int j = 0; j < grupos[i].Count; j++)
                {
                    notamedia += grupos[i][j].medianotas(grupos[i][j].notas);
                }
                notamedia /= grupos[i].Count;

                if (notamedia > promedio)
                {
                    promedio = notamedia;
                    indiceMayor++;
                }

            }


            return indiceMayor;
        }



    }

}
