/*
 * Primeros pasos en C#
 * Tutorial que he seguido: https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/tutorials/
 * 
 */

/*
 * Se pueden tener varios Main en un proyecto, pero sera necesario indicarle al IDE cual de ellos sera el que se ejecute.
 * Pasos a seguir (Visual Studio): Proyecto -> Propiedades de X_PROYECTO -> Objeto de inicio
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ejercicios Cadenas\n");
        cadenasSimples();
        Console.WriteLine("----------");

        Console.WriteLine("\nEjercicios Numericos\n");
        manipulacionNumeros();
        Console.WriteLine("----------");

        Console.WriteLine("\nEjercicios Bifurcaciones y Bucles\n");
        bifurcaciones();
        Console.WriteLine("----------");

        Console.WriteLine("\nEjercicios sobre Colecciones\n");
        colecciones();
        Console.WriteLine("----------");

    }

    // https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/tutorials/hello-world
    private static void cadenasSimples()
    {
        // Escribir por terminal, equivalencia a sout en java/println en kotlin
        Console.WriteLine("¡Hola Mundo!\n");

        // Creacion de una variable String
        string dato = "Alysys";
        Console.WriteLine(dato);

        // Interpolacion de cadenas
        Console.WriteLine($"!Hola {dato}!");  //Tambien es posible: Console.WriteLine("!Hola " + dato + "!");

        // Usamos Trim para recortar espacios
        string dato2 = "  Kratos  -";
        string dato2Trim = dato2.Trim();  // Es posible usar: TrimStart() o TrimEnd()
        Console.WriteLine(dato2);
        Console.WriteLine(dato2Trim + "\n");

        // Mayusculas o Minusculas: ToUpper() o ToLower()
        Console.WriteLine(dato2Trim.ToUpper());

        // Reemplazar un elemento
        dato2Trim = dato2Trim.Replace("Kratos", "Atreus");
        Console.WriteLine(dato2Trim);

        // Ejemplo de contains
        string dato3 = "Hazlo o no lo hagas. Pero no lo intentes.";
        Console.WriteLine(dato3.Contains("no")); // Devuelve un Boolean
    }

    // https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp
    private static void manipulacionNumeros()
    {
        // Operacion basica entre dos variables
        int a = 1;
        int b = 2;
        Console.WriteLine(a + b); // int c = a + b
        // Es posible operar como en la vida diaria, es decir, sigue el orden logico, y si algo se quiere realizar antes, se usan los ()

        // Int cuenta con un rango de numero maximo y minimo
        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"El rango de int es desde {min} hasta {max}");

        // Si un calculo se pasa de ese limite, se producira una condicion de subdesbordamiento o desbordamiento
        int dato = max + 1;
        Console.WriteLine($"Ejemplo de desbordamiento: {dato}");

        // El uso de double para los numeros que tengan decimales
        double c = 5;
        double d = (a + b) / c;
        Console.WriteLine(d);

        // Double tambien cuenta con un rango maximo y minimo
        double maxDouble = double.MaxValue;
        double minDouble = double.MinValue;
        Console.WriteLine($"El rango de double es desde {minDouble} hasta {maxDouble}");

        // Decimal, parecido a double, menos rango, mas preciso
        decimal minDecimal = decimal.MinValue;
        decimal maxDecimal = decimal.MaxValue;
        Console.WriteLine($"El rango de terminal es desde {minDecimal} hasta {maxDecimal}");
    }

    // https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops
    private static void bifurcaciones()
    {
        // Un ejemplo de If
        int a = 1;
        if ( a == 1 ) // Uso de && y de || como en Java
        {
            Console.WriteLine("Se entro en el IF");
        } else { 
            Console.WriteLine("No entro en el IF"); 
        }

        // Un ejemplo de while
        int contador = 0;
        while ( contador <= 10 )
        {
            Console.WriteLine(contador);
            contador++;
        }

        // Un ejemplo de do-while
        int contador2 = 0;
        do
        {
            Console.WriteLine(contador2);
            contador2++;
        } while( contador2 <= 10 );

        // Un ejemplo de bucle for
        for(int contador3 = 0; contador3 <= 10; contador3++)
        {
            Console.WriteLine(contador3);
        }

        // Bucles anidados
        for (int fila = 1; fila < 11; fila++)
        {
            for (char columna = 'a'; columna < 'k'; columna++)
            {
                Console.WriteLine($"La casilla es ({fila}, {columna})");
            }
        }

        // Desafio Bucle
        int resultado = 0;
        for (int data1 = 1; data1 <= 20; data1++)
        {
            if(data1%3 == 0)
            {
                resultado = resultado + data1;
                Console.WriteLine(".");
            }
        }
        Console.WriteLine(resultado);
    }

    // https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/tutorials/list-collection
    private static void colecciones()
    {
        // Una lista de nombres; uso de var como en Kotlin
        var nombres = new List<String> { "Mario", "Alysys", "Felipe" };
        foreach(var i in nombres)
        {
            Console.WriteLine(i);
        }

        // Se pueden agregar o eliminar elementos
        nombres.Add("Kratos");
        nombres.Remove("Felipe");
        foreach (var i in nombres)
        {
            Console.WriteLine(i);
        }

        // Se pueden acceder a elementos especificos usando el indice
        Console.WriteLine($"El nombre de indice 0 es: {nombres[0]}");

        // Se puede usar el metodo count para ver el numero de elementos de la coleccion
        Console.WriteLine($"La lista tiene {nombres.Count} nombres");

        // Es posible buscar y ordenar una lista
        var search = nombres.IndexOf("Alysys");
        if (search != -1)
        {
            Console.WriteLine($"Encontrado en indice {search}");
        }
        else Console.WriteLine("No encontrado");

        // Uso de sort para ordenar alfabeticamente
        nombres.Sort();
        foreach(var i in nombres)
        {
            Console.WriteLine(i);
        }

        // Es posible crear listas con otros tipos de datos
        var numerosFibonacci = new List<int> { 1, 1 };

        // Desafio de colecciones
        do
        {
            var previous = numerosFibonacci[numerosFibonacci.Count - 1];
            var previous2 = numerosFibonacci[numerosFibonacci.Count - 2];

            numerosFibonacci.Add(previous + previous2);
        } while (numerosFibonacci.Count < 20);

        foreach (var i in numerosFibonacci)
            Console.WriteLine(i);
    }
}