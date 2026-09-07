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


bool parar = false;
Stack<string> historial = new Stack<string>();
historial.Push("google.com");
historial.Push("github.com");
historial.Push("stackoverflow.com");

Console.WriteLine("Desea volver atras??(1 si 2 no)");
int respuesta = Convert.ToInt32(Console.ReadLine());

while(parar)
{
    Console.WriteLine("Desea volver atras??(1 si 2 no)");
    respuesta = Convert.ToInt32(Console.ReadLine());
    if(respuesta == 1)
    {
        if(historial.TryPop(out string paginaAnterior))
        {
            Console.WriteLine($"URL actual: {historial.Peek()}");
            Console.WriteLine($"Regresando a: {paginaAnterior}");
        }
        else
        {
            Console.WriteLine("Ya no se puede volver atras");
        }
    }
    else if(respuesta == 2)
    {
        Console.WriteLine($"URL actual: {historial.Peek()}");
        parar = true;
    }
}

Console.WriteLine("Ingrese un mensaje como este { [ ( a + b ) ] } (similar)");
string Palabra = Console.ReadLine();
Stack<string> TextoRandom = new Stack<string>();
TextoRandom.Push(Palabra);
bool VerificarTexto(string ejemplo)
{
    bool parentesis = false;
    bool parentesisbien = false;
    bool corchete = false;
    bool corchetebien = false;
    bool llaves = false;
    bool llavesbien = false;
    foreach(char letra in ejemplo)
    {
        if(letra == '(')
        {
            parentesis = true;
        }
        if(letra == ')' && parentesis == true)
        {
            parentesisbien = true;
        }
    }
    foreach(char letra1 in ejemplo)
    {
        if(letra1 == '[')
        {
            corchete = true;
        }
        if(letra1 == ']' && corchete == true)
        {
            corchetebien = true;
        }
    }
    foreach(char letra2 in ejemplo)
    {
        if(letra2 == '{')
        {
           llaves = true;
        }
        if(letra2 == '}' && llaves == true)
        {
            llavesbien = true;
        }
    }
    if (llavesbien == true && corchetebien == true && parentesisbien == true)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine(VerificarTexto(TextoRandom.Peek()));


AccionTexto acciones = new AccionTexto("", "","");

acciones.guardar_accion("escribir", "perritos","12:00");
acciones.guardar_accion("leer", "gatitos", "12:00");

Console.WriteLine("Ingrese 1 para hacer Control Z ");
int opcion = Convert.ToInt32(Console.ReadLine());

if(opcion == 1)
{
    acciones.deshacer();
}

void ejercicio5()
{

}

void ejercicio6()
{
   procesador procesar = new procesador();

   Tarea tarea1 = new Tarea(1,"Leer","Muy importante",30);
   Tarea tarea2 = new Tarea(2,"Escribir","poco importante",10);

   procesar.guardar_tarea(tarea1);
   procesar.guardar_tarea(tarea2);
    
   procesar.atender_tarea();
}

//clase Tarea
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class Tarea
  {
      public int id { get; set; }

      public string titulo { get; set; }

      public string prioridad { get; set; }

      public int estimacion_minutos { get; set; }
      
      public Tarea(int id, string titulo, string prioridad, int estimacion_minutos)
      {
            this.id = id;

            this.titulo = titulo;

            this.prioridad = prioridad;

            this.estimacion_minutos = estimacion_minutos;
      }
}
    
internal class procesador
{
  Stack<Tarea> Tareas = new Stack<Tarea>();
  public void guardar_tarea(Tarea nueva_tarea)
  {
      Tareas.Push(guardada);
  }

  public void atender_tarea()
  {
      if(Tareas.TryPop(out Tarea tarea_atendida))
      {
           Console.WriteLine($"Vamos a trabajar con {tarea_atendida.titulo}");
      }
      else
      {
           Console.WriteLine("No hay tareas para atender");
      }
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
