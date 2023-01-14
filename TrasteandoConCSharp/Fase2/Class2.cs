// https://learn.microsoft.com/es-es/training/paths/csharp-logic/?WT.mc_id=dotnet-35129-website&ns-enrollment-type=Collection&ns-enrollment-id=yz26f8y64n7k07

namespace PrimerosPasosCSharp_2.segundaFase
{
    internal class Class2
    {
        private static void Main(string[] args)
        {
            Apartado1();

            Apartado2();
        }

        //https://learn.microsoft.com/es-es/training/modules/csharp-evaluate-boolean-expressions/1-introduction
        private static void Apartado1()
        {
            // Uso de operadores de comparacion: == != <>
            Console.WriteLine(1 < 2); // Boolean

            // Uso del operador condicional
            int precio = 1001;

            int descuento = precio > 1000 ? 100 : 50;
            Console.WriteLine($"Descuento: {descuento}");

            // Desafio, usar el operador condicional y hacer una simulacion de una tirada de moneda
            Random tirada = new Random();
            int moneda = tirada.Next(0, 2);

            string resultado = moneda == 1 ? "cara" : "cruz";
            Console.WriteLine(resultado);

            // Desafio, segun el permiso del usuario saltara un mensaje o otro
            string permission = "Admin"; // Manager o vacio
            int level = tirada.Next(0,60);

            if (permission.ToLower().Contains("admin"))
            {
                if (level > 55) Console.WriteLine("Welcome, Super Admin user.");
                else Console.WriteLine("Welcome, Admin user.");
            }
            else if (permission.ToLower().Contains("manager"))
            {
                if (level >= 20) Console.WriteLine("Contact an Admin for access.");
                else Console.WriteLine("You do not have sufficient privileges.");
            }
            else Console.WriteLine("You do not have sufficient privileges.");
        }

        // https://learn.microsoft.com/es-es/training/modules/csharp-code-blocks/
        private static void Apartado2()
        {
            // Si declaramos una variable fuera del bloque de codigo, importante inicializarla con un valor base.

            /*
             * Creacion de un espacio de nombres; ejemplo practico:
             * Contamos con un espacio llamado: MyNewApp
             * La logica del programa ira en una clase, y el espacio quedaria a llamarse MyNewApp.Business
             * Si queremos un segundo nivel para las clases, se pueden agregar nombres secundarios: MyNewApp.Data
             * 
             * Vamos a diseñar un metodo que obtenga una cadena y la devuelva al reves, se llamara desde este bloque, pero
             * se encontrara en otra clase
             * 
             * A su vez, podemos mover esa nueva clase a un nuevo espacio, por ejemplo, MyNewApp.Utilities
             * 
             * La llamada del metodo seria: Utilities.Util.Reves()
             */

            string mensaje = "aniram al ne etatsila";
            Console.WriteLine(Util.Reves(mensaje));

            // Se puede ahorrar lineas de codigo con el uso de if, como bien se demostro en el apartado 1 de esta clase

            // Desafio, arreglar el siguiente bloque de codigo
            // Original, comentado
            /*
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            foreach (int number in numbers)
            {
                int total;
                total += number;
                if (number == 42)
                {
                    bool found = true;
                }
            }
            if (found)
            {
                Console.WriteLine("Set contains 42");
            }
            Console.WriteLine($"Total: {total}");
            */

            // Arreglado
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0; // Inicializar la variable
            bool found = false; // Inicializar la variable; ambas fuera del foreach

            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)
                {
                    found = true;
                }
            }
            if (found)
            {
                Console.WriteLine("Set contains 42");
            }
            Console.WriteLine($"Total: {total}");
        }

        class Util
        {
            public static string Reves(string s)
            {
                char[] letras = s.ToCharArray();
                Array.Reverse(letras);

                return new string(letras);
            }
        }
    }
}
