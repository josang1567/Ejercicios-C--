namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(String, int)> notas1= new List<(String, int)> {("Mates",1),("Lengua",5),("Tecnologia",9) };
            List<(String, int)> notas2= new List<(String, int)> {("Mates",4),("Lengua",8),("Tecnologia",3) };
            List<(String, int)> notas3= new List<(String, int)> {("Mates",7),("Lengua",0),("Tecnologia",2) };



            estudiante e1 = new estudiante("Mauricio",notas1);
            estudiante e2 = new estudiante("Luisma", notas2);
            estudiante e3 = new estudiante("Aida", notas3);


            e1.medianotas(e1.notas);
            e2.medianotas(e2.notas);
            e3.medianotas(e3.notas);

        }
    }
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
            nombre= newnombre;
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