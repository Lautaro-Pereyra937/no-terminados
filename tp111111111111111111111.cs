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