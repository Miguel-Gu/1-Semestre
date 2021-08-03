using System;

namespace AtRomano
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor, insira um número de 1 a 10 em algarismos romanos :");
            string algarismo=Console.ReadLine().ToLower();           

            switch (algarismo)
            {
                case "i": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 1");
                    break;
                case "ii": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 2");
                    break;
                case "iii": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 3");
                    break;
                case "iv": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 4");
                    break;
                case "v": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 5");
                    break;
                case "vi": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 6");
                    break;
                case "vii": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 7");
                    break;
                case "viii": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 8");
                    break;
                case "ix": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 9");
                    break;
                case "x": 
                    Console.WriteLine("Esse algarismo no Indo-Arábico vale 10");
                    break;
                default:
                    Console.WriteLine("Insira um valor entre 1 e 10");
                    break;
            }
        }
    }
}
