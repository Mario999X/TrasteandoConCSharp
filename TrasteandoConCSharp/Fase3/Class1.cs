// https://learn.microsoft.com/es-es/training/paths/csharp-data/?WT.mc_id=dotnet-35129-website&ns-enrollment-type=Collection&ns-enrollment-id=yz26f8y64n7k07

namespace PrimerosPasosCSharp_3.primeraFase
{
    class Class1
    {
        private static void Main(string[] args)
        {
            apartado1();
        }

        // https://learn.microsoft.com/es-es/training/modules/csharp-convert-cast/
        private static void apartado1()
        {
            string data1 = "hola";
            string data2 = "5";
            int data3 = 10;
            Console.WriteLine(data1 + data3.ToString());

            Console.WriteLine(data2 + data3);
            Console.WriteLine(int.Parse(data2) + data3); // Uso de TryParse para asegurar que una cadena puede ser convertida en un valor numerico


            // Desafio, se da un listado con strings, entre ellos, cadenas y numericos, se debe mostrar una suma de los numericos y mostrar una cadena completa de las cadenas que se muestren.
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            string resultadoLetras = "";
            decimal resultadoNumerico = 0;
            decimal numero;

            foreach (string i in values)
            {
                if (decimal.TryParse(i, out numero))
                {
                    //Console.WriteLine(numero);
                    resultadoNumerico += numero;
                }
                else resultadoLetras += i;
            }
            Console.WriteLine(resultadoNumerico);
            Console.WriteLine(resultadoLetras);

            // No funciona como se espera, no se hace bien la conversion del primer numero.

            // Desafio, cambiar el codigo original y mostrar el siguiente resultado
            /*
             * Divide value1 by value2, display the result as an int: 2
             * Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
             * Divide value3 by value1, display the result as a float: 0.3583333
             */

            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            var result1 = value1 / value2; // La solucion correcta seria: Convert.ToInt32((decimal)value1 / value2)
            var result2 = value2 / Decimal.Parse(value3.ToString());
            var result3 = value3 / value1;

            // Your code here to set result1
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }

    }
}