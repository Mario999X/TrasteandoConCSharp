// https://learn.microsoft.com/en-us/training/paths/csharp-first-steps/?WT.mc_id=dotnet-35129-website&ns-enrollment-type=Collection&ns-enrollment-id=yz26f8y64n7k07

namespace PrimerosPasosCSharp_2.primeraFase
{
    internal class Class1
    {
        private static void Main(string[] args)
        {
            usoLibreriasNet();

            arrayBasico();

            codigoLegible();
        }

        // https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/
        private static void usoLibreriasNet()
        {
            Random dado = new Random();
            int tirada = dado.Next(1, 7);

            Console.WriteLine(tirada);

            int tirada2 = dado.Next(1, 7);
            int tirada3 = dado.Next(1, 7);

            Console.WriteLine(tirada2);
            Console.WriteLine(tirada3);

            // Desafio, usar un metodo de System.Math para determinar el numero mas alto
            int value1 = 500;
            int value2 = 600;

            int valueMax = Math.Max(value1, value2);
            Console.WriteLine(valueMax);
        }

        // https://learn.microsoft.com/en-us/training/modules/csharp-arrays/
        private static void arrayBasico()
        {
            string[] nombres = new string[3];
            nombres[0] = "Pepe";
            nombres[1] = "Mario";
            nombres[2] = "L";

            foreach (string s in nombres)
            {
                Console.WriteLine(s);
            }

            nombres[0] = "Kira";
            foreach (string s in nombres)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"El tamaño del array es de: {nombres.Length}\n");

            int[] inventario = { 12, 24, 64, 100 };
            int sumaTotal = 0;
            int numElementos = 0;
            foreach (int i in inventario)
            {
                sumaTotal = sumaTotal + i;
                numElementos++;
            }
            Console.WriteLine(sumaTotal);
            Console.WriteLine(numElementos);

            // Desafio, se da un listado de IDs, se almacenan en un array, si empiezan por B, se imprimen por consola
            string[] ids = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            foreach (string s in ids)
            {
                if (s.StartsWith("B"))
                {
                    Console.WriteLine(s);
                }
            }

        }

        // https://learn.microsoft.com/en-us/training/modules/csharp-readable-code/
        private static void codigoLegible()
        {
            // Las variables se escriben modo camelCase
            /*
             * Ejemplo de comentario de varias lineas.
             * 
             * Un codigo bien comentado deberia ir siempre encima de un metodo,
             * no dentro del propio metodo.
             * 
             * Se pueden usar espacios en blanco (usando enter) para hacer el codigo mas legible.
             * 
             * Desafio, hacer el siguiente codigo mas legible
             */

            // ORIGINAL
            string str = "The quick brown fox jumps over the lazy dog.";
            // convert the message into a char array
            char[] charMessage = str.ToCharArray();
            // Reverse the chars
            Array.Reverse(charMessage);
            int x = 0;
            // count the o's
            foreach (char i in charMessage) { if (i == 'o') { x++; } }
            // convert it back to a string
            string new_message = new String(charMessage);
            // print it out
            Console.WriteLine(new_message);
            Console.WriteLine($"'o' appears {x} times.");

            // ARREGLADO y traducido
            /*
             * En el siguiente bloque de codigo vamos a crear una variable String
             * Ese mensaje lo vamos a convertir en un array de Char, luego, invertiremos el array,
             * contaremos el numero de veces que sale "o" y devolveremos dos resultados:
             *  - El mensaje invertido
             *  - El numero de veces que ha salido "o"
             */
            string mensaje = "El veloz zorro marrón salta sobre el perro perezoso.";

            char[] mensajeChar = mensaje.ToCharArray();
            Array.Reverse(mensajeChar);

            int conteo = 0;
            foreach (var i in mensajeChar)
            {
                if (i.Equals('o'))
                {
                    conteo++;
                }
            }

            string mensajeInvertido = new String(mensajeChar);

            Console.WriteLine(mensajeInvertido);
            Console.WriteLine($"Numero de repeticiones de la letra 'o': {conteo} ");
        }
    }
}
