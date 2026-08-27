void ejercicio1()
{
    Stack<char> invertida = new Stack<char>();

    Console.WriteLine("Ingrese una palabra/frase");
    string palabra = Console.ReadLine();

    string nueva = "";

    foreach (char j in palabra)
    {
        invertida.Push(j);
    }

    for (int i = 0; 0 < invertida.Count; i++)
    {
        nueva += invertida.Pop();
    }
    Console.WriteLine($"Palabra invertida: {nueva}");
}
ejercicio1();

void ejercicio2()
{
    bool parar = false;
    Stack<string> historial = new Stack<string>();
    historial.Push("google.com");
    historial.Push("github.com");
    historial.Push("stackoverflow.com");

    Console.WriteLine("Desea volver atras??(1 si 2 no)");
    int respuesta = Convert.ToInt32(Console.ReadLine());

    
        if(respuesta == 1)
        {
            if(historial.TryPop(out string paginaAnterior))
            {
                Console.WriteLine($"URL actual: {historial.Peek()}");
                Console.WriteLine($"Regresando a: {paginaAnterior}");
                parar = true;
            }
        }
        else if(respuesta == 2)
        {
            Console.WriteLine($"URL actual: {historial.Peek()}");
        }
    
}
ejercicio2();

void ejercicio3()
{
    Console.WriteLine("Ingrese un mensaje como este { [ ( a + b ) ] } (similar)");

    bool salida = false;

    foreach()
    {

    }
}

void ejercicio4()
{
    AccionTexto acciones = new AccionTexto("", "","");
    
    acciones.guardar_accion("escribir", "perritos","12:00");
    acciones.guardar_accion("leer", "gatitos", "12:00");
    
    Console.WriteLine("Ingrese 1 para hacer Control Z ");
    int opcion = Convert.ToInt32(Console.ReadLine());
    
    if(opcion == 1)
    {
        acciones.deshacer();
    }
}

//clase acciontexto
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AccionTexto
    {
        public string tipoaccion { get; set; }

        public string contenido { get; set; }

        public string fechahora { get; set; }

        public AccionTexto(string tipoaccion, string contenido, string fechahora)
        {
            this.tipoaccion = tipoaccion;

            this.contenido = contenido;

            this.fechahora = fechahora;
        }

        Stack<AccionTexto> historial = new Stack<AccionTexto>();

        public void guardar_accion(string tipoaccion, string contenido, string fechahora)
        {
            AccionTexto guardado = new AccionTexto(tipoaccion,contenido,fechahora);
            historial.Push(guardado);
        }

        public void deshacer()
        {
            if (historial.TryPop(out AccionTexto ultima))
            {
                Console.WriteLine($"Deshecho: {ultima.tipoaccion} {ultima.contenido} {ultima.fechahora}");
            }
            else
            {
                Console.WriteLine("No hay acciones para deshacer.");
            }
        }
    }
}
