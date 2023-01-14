namespace PrimerosPasosCSharp_2.terceraFase
{
    internal class Class3
    {
        private static void Main(string[] args)
        {
            Apartado1();
            Apartado2();
        }


        // https://learn.microsoft.com/es-es/training/modules/csharp-for/
        private static void Apartado1()
        {
            // Un for simple, pero al reves
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                // Uso de break + if para romper la iteracion
            }

            // Desafio FizzBuzz
            /*
             * Reglas:
             * - Valores de salida entre 1 y 100; un número por línea.
             * - Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
             * - Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
             * - Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.
             * 
             */

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine($"{i}-FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine($"{i}-Fizz");
                else if (i % 5 == 0) Console.WriteLine($"{i}-Buzz");
                else Console.WriteLine(i);
            }
        }

        // https://learn.microsoft.com/es-es/training/modules/csharp-do-while/
        private static void Apartado2()
        {
            // Ejemplo de un do-while simple
            Random random = new Random();
            int current = 0;

            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);

            /* Desafio batalla de rol
             * 
             * Reglas:
             * 
             * - El héroe y el monstruo comenzarán con 10 puntos de salud.
             * - Todos los ataques tendrán un valor comprendido entre 1 y 10.
             * - El héroe atacará primero.
             * - Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
             * - Si la salud del monstruo es mayor que 0, puede atacar al héroe.
             * - Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
             * - Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
             * - Imprima el ganador.
             */

            string heroe = "Raiden";
            string enemigo = "Armstrong";
            int saludH = 10;
            int saludE = 10;
            do
            {
                var ataque = new Random().Next(1, 11); // Cargamos el ataque del heroe
                var ataque2 = new Random().Next(1, 11); // Cargamos el ataque del rival

                Console.WriteLine($"{heroe} lanza un ataque de {ataque} ");
                saludE = saludE - ataque;

                Console.WriteLine($"{enemigo} lanza un ataque de {ataque2}");
                saludH = saludH - ataque2;

                Console.WriteLine($"Salud Heroe: {saludH} || Salud Enemigo: {saludE}");
            } while (saludE > 0 && saludH > 0);

            if (saludE <= 0) Console.WriteLine($"{enemigo} perdio");
            else if (saludH <= 0) Console.WriteLine($"{heroe} perdio");
        }
    }
}
