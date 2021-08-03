using System;

namespace _5.Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<=10; i++)
            {
                Console.WriteLine($"Tabuada do {i}");
                Console.WriteLine($"0 X {i} = {0*i}");
                Console.WriteLine($"1 X {i} = {1*i}");
                Console.WriteLine($"2 X {i} = {2*i}");
                Console.WriteLine($"3 X {i} = {3*i}");
                Console.WriteLine($"4 X {i} = {4*i}");
                Console.WriteLine($"5 X {i} = {5*i}");
                Console.WriteLine($"6 X {i} = {6*i}");
                Console.WriteLine($"7 X {i} = {7*i}");
                Console.WriteLine($"8 X {i} = {8*i}");
                Console.WriteLine($"9 X {i} = {9*i}");
                Console.WriteLine($"10 X {i} = {10*i}");
                Console.Write("\n\n");
            }
        }

        // static void Main(string[] args)
        // {
        //     for (int i = 0; i<11; i++)
        //     {
                    // for (var c = 0; c <11; c++)
                    // {
                    //     Console.WriteLine($"{i} x {c} = {(i*c)}");
                    // }
        //     }
        // }
    }
}
