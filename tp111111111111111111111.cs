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
    string palabra = Console.ReadLine();
    Stack<string> Palabra_ingresada = new Stack<string>();
    Palabra_ingresada.Push(palabra);
    
    bool parentesis_correcion1 = false;
    bool parentesis_correcion2 = false;
    bool corchete_correcion1 = false;
    bool corchete_correcion2 = false;
    bool llaves_correcion1 = false;
    bool llaves_correcion2 = false;
    
    foreach(char Letra in palabra)
    {
        if (c == '(')
        {
            parentesis_correcion1 = true;
        }
        if (c == ')' && parentesis_correcion1 == true)
        {
            parentesis_correcion2 = true;
        }
    }
    foreach(char Letra2 in palabra)
    {
        if(Letra2 == '[')
        {
            corchete_correcion1 = true;
        }
        if(Letra2 == ']' && corchete_correcion1 == true)
        {
            corchete_correcion2 = true;
        }
    }
    foreach(char Letra3 in palabra)
    {
        if(Letra3 == '{')
        {
           llaves_correcion1 = true;
        }
        if(Letra3 == '}' && llaves_correcion1 == true)
        {
            llaves_correcion2 = true;
        }
    }

    if(parentesis_correcion2 == true && corchete_correcion2 == true && llaves_correcion2 == true)
    {
         Console.WriteLine("El mensaje no esta bien redactado");
         Palabra_ingresada.Peek();
         return true;
    }
    else
    {
         Console.WriteLine("El mensaje no esta bien redactado");
         Palabra_ingresada.Peek();
         return false;
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
