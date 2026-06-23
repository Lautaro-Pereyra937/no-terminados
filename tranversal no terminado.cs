using System;
using System.Security.Cryptography;

void ejercicioa()
{
    for (int num = 3; num <= 101; num += 3)
    {
        Console.WriteLine("Los multiplos(de 3) del 1 al 100 son:" + num);
    }
}

void ejerciciob()
{
    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());

    if (edad > 18)
    {
        Console.WriteLine("Usted es mayor de edad");

    }
    else if (edad == 18)
    {
        Console.WriteLine("Usted tiene justo 18");
    }
    else if (edad < 18)
    {

        Console.WriteLine("Usted es menor de edad");
    }
}

void ejercicioc()
{
    Console.WriteLine("Ingrese una palabra y veremos cuantas letras tiene");
    string palabra = Console.ReadLine();

    Console.WriteLine("Su palabra tiene:" + palabra.Length + " letras");
}

void ejerciciod()
{
    string contraseña = "ratas";

    int conteos = 0;

    while (conteos < 5)
    {
        Console.WriteLine("Ingrese la contraseña secreta(tiene solo 5 intentos)");
        string ingreso = Console.ReadLine();
        conteos++;
        if (ingreso == contraseña)
        {
            Console.WriteLine("si adivino");
            return;
        }
    }
    Console.WriteLine("no adivino");
}

void ejercicioe()
{
    int numeroalto = 1;

    for (int num = 0; num < 10; num++)
    {
        Console.WriteLine("Ingrese 10 numeros");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > numeroalto)
        {
            numeroalto = numero;
        }
    }
    Console.WriteLine("El numero mas alto es: " + numeroalto);
}

void ejerciciof()
{
    Console.WriteLine("Ingrese su nombre y apellido");
    string nombreap = Console.ReadLine();

    string resultado = "";
    bool mayusculas = true;

    foreach (char c in nombreap)
    {
        if (c == ' ')
        {
            resultado += c;
            mayusculas = true;
        }
        else if (mayusculas)
        {
            resultado += char.ToUpper(c);

            mayusculas = false;
        }
        else
        {
            resultado += char.ToLower(c);
        }
    }
    Console.WriteLine("Nombre con iniciales en mayusculas: " + resultado);
}

void ejerciciog()
{
    for (int num = 7; num <= 71; num += 7)
    {

        Console.WriteLine("La tabla del 7 es: " + num);
    }
}

void ejercicioh()
{
    for (int num = 10; num > 0; num--)
    {
        Console.WriteLine("Cuenta regresiva: " + num);
    }
    Console.WriteLine("oa");
}

void ejercicioi()
{
    Console.WriteLine("Ingrese un numero y veremos si es par o impar");
    int verificacion = Convert.ToInt32(Console.ReadLine());

    if (verificacion % 2 == 0)
    {
        Console.WriteLine("Es par");
    }
    else
    {
        Console.WriteLine("Es impar");
    }
}

void ejercicioj()
{
    Console.WriteLine("Ingrese una frase");
    string frase = Console.ReadLine();

    string vocales = "aeiouAEOIU";
    int contador = 0;

    foreach (char M in frase)
    {
        foreach (char L in vocales)
        {
            if (M == L)
            {
                contador++;
            }
        }
    }
    Console.WriteLine("Hay " + contador + " vocales");
}
void ejerciciok()
{
    Console.WriteLine("Ingrese un numero");
    int tabla = Convert.ToInt32(Console.ReadLine());

    for (int num = 1; num <= 12; num++)
    {
        int multiplicacion = tabla * num;
        Console.WriteLine("La tabla de su numero(hasta el 12) es: " + multiplicacion);
    }
}

void ejerciciol()
{
    int contador = 0;
    while (contador <= 100)
    {
        Console.WriteLine("Ingrese un numero");
        int nume = Convert.ToInt32(Console.ReadLine());

        contador += nume;
    }
    Console.WriteLine("Supero el limite del contador");
}

void ejerciciom()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();

    foreach (char Y in palabra)
    {
        Console.WriteLine(Y);
    }
}

void ejercicion()
{
    Console.WriteLine("Ingrese su edad");
    int edadpibe = Convert.ToInt32(Console.ReadLine());

    if (edadpibe >= 16)
    {
        Console.WriteLine("Usted puede votar y tener una licencia de conducir");
    }
    else if (edadpibe <= 15)
    {
        Console.WriteLine("Usted no puede ni votar ni manejar");
    }
}

void ejercicioo()
{
    for (int num = 50; num <= 0; num += 5)
    {
        Console.WriteLine("Numeros del 50 al 0 de forma descendiente(de 5 en 5)" + num);
    }
}
void ejerciciop()
{
    Console.WriteLine("Ingrese una contraseña");
    string contraseña = Console.ReadLine();

    Console.WriteLine("Ingresela nuevamente");
    string contraseña2 = Console.ReadLine();

    while (contraseña != contraseña2)
    {
        Console.WriteLine("Intente nuevamente");
        contraseña = Console.ReadLine();
        contraseña2 = Console.ReadLine();
    }
    Console.WriteLine("Acceso permitido");
}
void ejercicioq()
{
    Console.WriteLine("Ingrese nombres");
    string nombres = Console.ReadLine();

    while (nombres.Length < 10)
    {
        Console.WriteLine("Ingrese nombres");
        nombres = Console.ReadLine();
    }
}

void ejercicior()
{
    Console.WriteLine("Ingrese una oracion");
    string oracion = Console.ReadLine();

    string letrA = "aA";

    int letrasA = 0;

    foreach (char A in oracion)
    {
        foreach (char a in letrA)
        {
            if (A == a)

                letrasA++;
        }
    }
    Console.WriteLine("Tiene " + letrasA + " letras A");
}
void ejercicioa2()
{
    Random azar = new Random();
    int numeroaleatorio = azar.Next(1, 11);

    Console.WriteLine("Ingrese un numero para un juego(1 a 10):");
    int numero = Convert.ToInt32(Console.ReadLine());

    while (numeroaleatorio != numero)
    {
        if (numeroaleatorio >= 3 && numeroaleatorio <= 6)
        {
            Console.WriteLine("Pista el numero esta entre 3 y 6");
        }
        else if (numeroaleatorio < 3)
        {
            Console.WriteLine("Pista el numero es bajo");
        }
        else if (numeroaleatorio > 6)
        {
            Console.WriteLine("Pista el numero es alto");
        }
        Console.WriteLine("No era ese , ingrese de nuevo:");
        numero = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Usted adivino el numero era: " + numeroaleatorio);
}

void ejerciciob2()
{
    Console.WriteLine("Ingrese un numero entero");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("Ingrese numeros positivos");
    }
    for (int num = 1; num <= numero; num++)
    {
        if (numero % num == 0)
        {
            Console.WriteLine("Sus divisores son:" + num);
        }
    }
}

void ejercicioc2()
{
    Console.WriteLine("Los primeros 20 numeros de la secuencia de fibonacci son: ");

    int acumulador = 0;

    int acumulador3 = 1;

    for (int num = 1; num <= 18; num++)
    {
        int acumulador4 = acumulador + acumulador3;
        acumulador = acumulador3;
        acumulador3 = acumulador4;
        Console.WriteLine("La secuencia de fibonacci(20 primeros digitos): " + acumulador4);
    }
}

void ejerciciod2()
{
    bool calculadora = true;
    while (calculadora == true)
    {
        Console.WriteLine("1 para sumar, 2 para restar,3 para multiplicar ,4  para dividir y 5 para salir");
        int x = Convert.ToInt32(Console.ReadLine());

        switch (x)
        {
            case 1:
                Console.WriteLine("Ingrese un numero");
                int numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                int suma = numero + numero2;
                Console.WriteLine("Resultado: " + suma);
                break;

            case 2:
                Console.WriteLine("Ingrese un numero");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                numero2 = Convert.ToInt32(Console.ReadLine());

                int resta = numero - numero2;
                Console.WriteLine("Resultado: " + resta);
                break;

            case 3:
                Console.WriteLine("Ingrese un numero");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                numero2 = Convert.ToInt32(Console.ReadLine());

                if (numero2 == 0)
                {
                    Console.WriteLine("No puede dividir por 0");
                }
                else
                {
                    int division = numero / numero2;
                    Console.WriteLine("Resultado: " + division);
                }
                break;

            case 4:
                Console.WriteLine("Ingrese un numero");
                numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                numero2 = Convert.ToInt32(Console.ReadLine());

                int multi = 0;
                multi = numero * numero2;

                Console.WriteLine("Resultado: " + multi);
                break;

            case 5:
                calculadora = false;
                Console.WriteLine("Saliendo");
                break;

            default:
                Console.WriteLine("Opcion no disponible");
                break;
        }
    }
}
void ejercicioe2()
{
    Console.WriteLine("Ingrese un numero entero no negativo para su factorial");
    int numero = Convert.ToInt32(Console.ReadLine());

    int acumulador = 1;

    if (numero < 0)
    {
        Console.WriteLine("Ingrese numeros positivos");
    }

    for (int num = 1; num <= numero; num++)
    {
        acumulador *= num;
    }
    Console.WriteLine("El factorial de su numero es: " + acumulador);
}
void ejerciciof2()
{
    Console.WriteLine("Ingrese su nombre para asignarle un turno o 1 para terminar");
    string nombre = Console.ReadLine();

    int cont = 0;

    while (nombre != "1")
    {
        cont++;
        Console.WriteLine($"Turno numero {cont}");
        Console.WriteLine("Ingrese su nombre para asignarle un turno o 1 para terminar");
        nombre = Console.ReadLine();
    }
}
ejerciciof2();

void ejerciciog2()
{
    for (int u = 1; u <= 101; u++)
    {
        if (u % 2 == 0)
        {
            Console.WriteLine("Los numeros pares del 1 al 100 son:" + u);
        }
    }
}

void ejercicioh2()
{
    bool pasaje = true;
    while (pasaje == true)
    {
        Console.WriteLine("1 para pasar de C° a F°, 2 para salir");
        int o = Convert.ToInt32(Console.ReadLine());

        switch (o)
        {
            case 1:
                bool usuario = true;
                while (usuario != false)
                {
                    Console.WriteLine("Ingrese la temperatura(o 99999 para salir)");
                    int temperatura = Convert.ToInt32(Console.ReadLine());

                    if (temperatura == 99999)
                    {
                        usuario = false;
                    }
                    else
                    {
                        double fahrenheit = (temperatura * 1.8) + 32;
                        Console.WriteLine("Resultado: " + fahrenheit + "°F");
                    }
                }
                break;
            case 2:
                pasaje = false;
                Console.WriteLine("Saliendo");
                break;

            default:
                Console.WriteLine("Opcion no disponible");
                break;
        }
    }
}
void ejercicioi2()
{
    Console.WriteLine("Ingrese un numero entero");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero < 2)
    {
        Console.WriteLine("El numero no es primo");
    }
    for (int num = 2; num <= numero; num++)
    {
        if (numero % num == 0)
        {
            Console.WriteLine("El numero no es primo");
            return;
        }
    }
    Console.WriteLine("El numero no es primo");
}

string[] nombres = new string[100000000000];

void ejercicioj2()
{
    Console.WriteLine("Ingresa los nombres (escribe 'salir' para terminar):");

    for (int i = 0; i < nombres.Length; i++)
    {
        Console.Write($"Nombre {i + 1}: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "salir")
        {
            foreach (string nombre in nombres)
            {
                Console.WriteLine($"Saludos {nombre}");
            }
            break;
        }
    }
}
ejercicioj2();

void ejerciciok2()
{
    string[] nombres1 = new string[10];

    Console.WriteLine("Ingresa nombres:");

    for (int i = 0; i < nombres1.Length; i++)
    {
        Console.Write($"Nombre {i + 1}: ");
        string nombre = Console.ReadLine();

        bool duplicado = false;
        foreach (string nom in nombres1)
        {
            if (nom == nombre)
            {
                duplicado = true;
                break;
            }
        }

        if (duplicado)
        {
            Console.WriteLine("¡Nombre repetido! El programa ha terminado.");
            break;
        }

        nombres1[i] = nombre;
    }
}

void ejerciciol2()
{
    for (int y = 100; y <= 201; y++)
    {
        if (y % 7 == 0 && y % 10 == 3)
        {
            Console.WriteLine("los números entre 100 y 200 que sean múltiplos de 7 y terminan en 3 son:" + y);
        }
    }
}
void ejerciciom2()
{
    Console.WriteLine("Ingrese el precio de los productos");
    int precio = Convert.ToInt32(Console.ReadLine());

    int total = 0;

    int cant = 0;

    while (precio < 1000)
    {
        Console.WriteLine("Ingrese el precio de los productos");
        precio = Convert.ToInt32(Console.ReadLine());
        total += precio;
        cant++;
    }
    Console.WriteLine($"La cantidad de productos es: {cant}");
}

void ejercicion2()
{
    bool asterisco = true;
    Console.WriteLine("Complete su formulario");

    Console.WriteLine("Ingrese su nombre");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese su gmail");
    string gmail = Console.ReadLine();

    foreach (char l in gmail)
    {
        if (l == '@')
        {
            asterisco = false;
            break;
        }
    }

    if (asterisco == true)
    {
        Console.WriteLine("Ingrese un gmail correcto");
    }
    else
    {
        Console.WriteLine("Perfecto  su formulario esta hecho" + "Nombre: " + nombre + " Edad: " + edad + " Gmail " + gmail);
    }
}
void ejercicioo2()
{
    Console.WriteLine("Ingrese un numero de mas de 2 digitos");
    string num = Console.ReadLine();

    foreach (char digitos in num)
    {
        Console.WriteLine("Digitos por separado:" + digitos);
    }
}

void ejerciciop2()
{
    Random manos = new Random();

    int contador = 0;

    int contmaquina = 0;

    bool manitas = true;

    while (manitas == true)
    {
        int numaleatorio = manos.Next(1, 4);

        Console.WriteLine("Elige 1 para piedra 2 para tijera 3 para papel");

        int juego = Convert.ToInt32(Console.ReadLine());

        if (numaleatorio == 1 && juego == 2)
        {
            contmaquina = contmaquina + 1;
        }
        else if (numaleatorio == 1 && juego == 3)
        {
            contador = contador + 1;
        }
        else if (numaleatorio == 2 && juego == 3)
        {
            contmaquina = contmaquina + 1;
        }
        else if (numaleatorio == 2 && juego == 1)
        {
            contador = contador + 1;
        }
        else if (numaleatorio == 3 && juego == 1)
        {
            contmaquina = contmaquina + 1;
        }
        else if (numaleatorio == 3 && juego == 2)
        {
            contador = contador + 1;
        }
        else if (numaleatorio == juego)
        {
            Console.WriteLine("empataron");
        }
        if (contador == 3)
        {
            Console.WriteLine("Ganaste mas veces tu" + contador + "-" + contmaquina);
            manitas = false;
        }
        else if (contmaquina == 3)
        {
            Console.WriteLine("Gano mas veces la maquina" + contmaquina + "-" + contador);
            manitas = false;
        }
    }
}

void ejercicioq2()
{
    Random yu = new Random();

    for (int q = 0; q < 10; q++)
    {
        int numerosaleatorios = yu.Next(1, 101);

        if (numerosaleatorios > 50)
        {
            Console.WriteLine("Los 10 numeros generados(1 al 100) mayores a 50 son:" + numerosaleatorios);
        }
    }
}

void ejercicior2()
{
    float promedio = 0;

    int notaalta = 0;

    int ingresos = 0;

    string nombrenotamasalta = "";

    while (ingresos < 5)
    {
        Console.WriteLine("Ingrese el nombre");

        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese su nota");

        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota > 10 || nota < 1)
        {
            Console.WriteLine("Ingrese calificaciones validas");
        }
        else
        {
            promedio = promedio + nota;
            ingresos++;
        }
        if (nota > notaalta)
        {
            notaalta = nota;
            nombrenotamasalta = nombre;
        }
    }

    Console.WriteLine("El promedio es:" + promedio / 5);
    Console.WriteLine("La mejor nota la tiene:" + nombrenotamasalta + " con " + notaalta);
}

void ejercicios()
{
    string abc = "abcdefghijklmnopqrstuvwxyz";
    string dadovuelta = "";

    for (int l = abc.Length - 1; l >= 0; l--)
    {
        dadovuelta = dadovuelta + abc[l];
    }
    Console.WriteLine("Abecedario invertido: " + dadovuelta);
}

void ejercicioa3()
{
    bool vuelta = true;

    int votacion = 0;

    int votacion2 = 0;

    int votacion3 = 0;

    while (vuelta == true)
    {
        Console.WriteLine("Ingrese 1 para votar a pepe, 2 para jorge y 3 para cristian(o 4 para terminar)");
        string opcion = Console.ReadLine();

        if (opcion == "1")
        {
            votacion = votacion + 1;
        }
        else if (opcion == "2")
        {
            votacion2 = votacion2 + 1;
        }
        else if (opcion == "3")
        {
            votacion3 = votacion3 + 1;
        }
        else if (opcion == "4")
        {
            if (votacion > votacion2 && votacion > votacion3)
            {
                Console.WriteLine("Gano pepe");
            }
            else if (votacion2 > votacion && votacion2 > votacion3)
            {
                Console.WriteLine("Gano jorge");
            }
            else if (votacion3 > votacion2 && votacion3 > votacion)
            {
                Console.WriteLine("Gano cristian");
            }
            vuelta = false;
        }
    }
}

bool ejecutando = true;

while (ejecutando == true)
{
    Console.WriteLine("Ingrese 1 para ejercicio a, 2 para ejercicio b, 3 para ejercicio c, 4 para ejercicio d, 5 para ejercicio e, 6 para ejercicio f, 7 para ejercicio g, 8 para ejercicio h, 9 para ejercicio i, 10 para ejercicio j, 11 para ejercicio k, 12 para ejercicio l, 13 para ejercicio m, 14 para ejercicio n, 15 para ejercicio o, 16 para ejercicio p, 17 para ejercicio q, 18 para ejercicio r , 19 para ejercicioa2 , 20 para ejercicio b2 , 21 para ejercicio c2, 22 para ejercicio d2, 23 para ejercicio e2 , 24 para ejercicio g2 , 25 para ejercicio h2 , 26 para ejercicio i2 , 27 para ejercicio l2 , 28 para ejercicio n2 , 29 para ejercicio o2 , 30 para ejercicio p2 , 31 para ejercicio q2 , 32 para ejercicio r2 , 33 para ejercicio s , 34 para ejercicio a3 ,35para salir");
    int numero = Convert.ToInt32(Console.ReadLine());

    switch (numero)
    {
        case 1:
            ejercicioa();
            break;

        case 2:
            ejerciciob();
            break;

        case 3:
            ejercicioc();
            break;

        case 4:
            ejerciciod();
            break;

        case 5:
            ejercicioe();
            break;

        case 6:
            ejerciciof();
            break;

        case 7:
            ejerciciog();
            break;

        case 8:
            ejercicioh();
            break;

        case 9:
            ejercicioi();
            break;

        case 10:
            ejercicioj();
            break;

        case 11:
            ejerciciok();
            break;

        case 12:
            ejerciciol();
            break;

        case 13:
            ejerciciom();
            break;

        case 14:
            ejercicion();
            break;

        case 15:
            ejercicioo();
            break;

        case 16:
            ejerciciop();
            break;

        case 17:
            ejercicioq();
            break;

        case 18:
            ejercicior();
            break;

        case 19:
            ejercicioa2();
            break;

        case 20:
            ejerciciob2();
            break;

        case 21:
            ejercicioc2();
            break;

        case 22:
            ejerciciod2();
            break;

        case 23:
            ejercicioe2();
            break;

        case 24:
            ejerciciog2();
            break;

        case 25:
            ejercicioh2();
            break;

        case 26:
            ejercicioi2();
            break;

        case 27:
            ejerciciol2();
            break;

        case 28:
            ejercicion2();
            break;

        case 29:
            ejercicioo2();
            break;

        case 30:
            ejerciciop2();
            break;

        case 31:
            ejercicioq2();
            break;

        case 32:
            ejercicior2();
            break;

        case 33:
            ejercicios();
            break;

        case 34:
            ejercicioa3();
            break;

        case 35:
            ejecutando = false;
            Console.WriteLine("Programa finalizado. ¡Hasta luego!");
            break;

        default:
            Console.WriteLine("Esa opción no existe, intenta con un número del 1 al 35.");
            break;
    }
}
