using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MiBasesitadeDatos
{
    internal class Program
    {
        static void Mostrar(Punto2D punto)
        {
            Console.WriteLine($"Coordenada X: {X} Coordenada Y: {Y}");
        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("Ingrese coordenada n°1 en X ");
            int corx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada n°1 en Y");
            int cory = Convert.ToInt32(Console.ReadLine());

            Punto2D punto1 = new Punto2D(corx,cory);

            Console.WriteLine("Ingrese coordenada n°2 en X ");
            corx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada n°2 en Y");
            cory = Convert.ToInt32(Console.ReadLine());
            Punto2D punto2 = new Punto2D(corx,cory);

            Console.WriteLine("Ingrese coordenada n°3 en X ");
            corx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada n°3 en Y");
            cory = Convert.ToInt32(Console.ReadLine());
            Punto2D punto3 = new Punto2D(corx,cory);

            Mostrar(punto1);
            Mostrar(punto2);
            Mostrar(punto3);
















































            using var db = new AppDbContext();

            //insertar

            var LoQueVoyaInsertar = new datos
            {
                Apellido = "Ramirez",
                DNI = "30256319",
                Nombre = "Kevin",
                tucu = 2
            };

            db.datos.Add(LoQueVoyaInsertar);

            //Consultar

            var todos = await db.datos.ToListAsync();

            foreach (var asterisco in todos)
            {
                Console.WriteLine(asterisco.Apellido);
            }

            //Ejecutar una linea SQL

            string SQL = "SELECT * FROM datos where Id = 2";
            var lista = await db.datos.FromSqlRaw(SQL).ToListAsync();

            foreach(var asterisco in lista)
            {
                Console.WriteLine($"Nombre: {asterisco.Nombre} Apellido: {asterisco.Apellido} DNI: {asterisco.DNI} tucu: {asterisco.tucu}");
            }

            //buscar un usuario en especifico

            int id = 1;

            var datoBuscado = LoQueVoyaInsertar;
            datoBuscado = await db.datos.FindAsync(id);

            if(datoBuscado != null)
            {
                Console.WriteLine(datoBuscado.Nombre);
            }
            else
            {
                Console.WriteLine("no hay un dato con ese id");
            }

            if (datoBuscado != null)
            {
                datoBuscado.Nombre = "Lisandro";
                datoBuscado.Apellido = "Fernandez";
                datoBuscado.DNI = " 2343242";
                datoBuscado.tucu = 17;
                await db.SaveChangesAsync();
            }

            //borrar dato

            if(datoBuscado != null)
            {
                db.datos.Remove(datoBuscado);
                await db.SaveChangesAsync();
            }

            db.SaveChanges();
        }
    }
}
