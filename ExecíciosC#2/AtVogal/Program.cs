using System;

namespace AtSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor, insira o seu nome:");
            string nome=Console.ReadLine().ToLower();
            string primeiraLetra = nome.Substring(0,1);

            Console.WriteLine("Seja bem vindo "+nome+"!!!");            

            switch (primeiraLetra)
            {
                case "a": 
                    Console.WriteLine("Seu nome começa com a vogal 'A' igual Abelha");
                    break;
                case "e": 
                    Console.WriteLine("Seu nome começa com a vogal "+ primeiraLetra + " igual Elefante");
                    break;
                case "i": 
                    Console.WriteLine("Seu nome começa com a vogal "+ primeiraLetra + " igual Igreja");
                    break;
                case "o": 
                    Console.WriteLine("Seu nome começa com a vogal "+ primeiraLetra + " igual Odirlei");
                    break;
                case "u": 
                    Console.WriteLine("Seu nome começa com a vogal "+ primeiraLetra + " igual Uva");
                    break;
                default:
                    Console.WriteLine("Seu nome não começa com nenhuma vogal");
                    break;
            }
        }
    }
}
