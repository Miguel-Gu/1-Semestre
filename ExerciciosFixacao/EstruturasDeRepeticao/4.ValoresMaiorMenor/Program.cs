using System;

namespace _4.ValoresMaiorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = new int[10];

            for(var i = 0; i<10; i++)
            {
                Console.WriteLine($"Insira o {i+1}º número");
                Numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(Numeros);
            Console.Write("\n\n");
            // foreach (int i in Numeros) Console.WriteLine(i);
            Console.WriteLine($"Maior valor lido: {Numeros[9]}");
            Console.WriteLine($"Menor valor lido: {Numeros[0]}");
        }
    }
}
