using System;

namespace _7.NumerosOrdemInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = null;

            numeros = new int[15];
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Insira o {i + 1}º número:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numeros);
            Console.Write("\n\n");
            foreach (int i in numeros) Console.WriteLine(i);
        }
    }
}
