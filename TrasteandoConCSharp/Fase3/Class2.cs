// https://learn.microsoft.com/es-es/training/modules/csharp-arrays-operations/

namespace TrasteandoConCSharp.Fase3
{
    internal class Class2
    {
        private static void Main(string[] args)
        {
            apartado1();

            apartado2();
        }

        private static void apartado1()
        {
            // Uso de Sort y Reverse para ordenar e invertir los elementos de un array
            // Uso de Clear para eliminar elementos de un array: (array, indice de inicio, elementos a eliminar) los dos ultimos son opcionales, es decir, podemos borrar todo en vez de elementos especificos.

            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("");

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            // Uso de Resize para cambiar el tamaño de un array: Array.Resize(ref pallets, 6);

            // Desafio, invertir la siguiente cadena
            string pangram = "The quick brown fox jumps over the lazy dog";

            char[] pangramChars = pangram.ToCharArray();
            Array.Reverse( pangramChars );

            pangram = new string( pangramChars );

            Console.WriteLine(pangram);

            // Desafio, mostrar los ids que empiezen con B
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            string[] idsIndividuales = orderStream.Split( ',' );

            foreach(string id in idsIndividuales)
            {
                if (id.StartsWith("B")) Console.WriteLine(id);
            }
        }

        private static void apartado2()
        {
            // La forma mas dificil de hacer el hola mundo de la historia, uso de format en un String
            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);

            // Aplicacion de la moneda local de un pais, desgraciadamente a mi no me funciona
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            // Aplicacion de formato a numeros
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");

            // Aplicacion de formatos a %
            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");
        }
    }
}
