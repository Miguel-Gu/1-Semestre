using System;

namespace ExemploConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira o seu nome:");
            string nomePessoa = Console.ReadLine();

            Console.WriteLine("Seja bem vindo " + nomePessoa + "!!!");


            Console.WriteLine("Insira o valor da nota 1" );
            double primeiroNumero = double.Parse(Console.ReadLine());


            Console.WriteLine("Insira o valor da nota 2");
            double segundoNumero = double.Parse(Console.ReadLine());


            Console.WriteLine("Insira o valor da nota 3");
            double terceiroNumero = double.Parse(Console.ReadLine());

            double soma = primeiroNumero + segundoNumero + terceiroNumero;
            double media = soma / 3; 

            Console.WriteLine("A sua média foi: " + Math.Round(media, 1));
            // Console.WriteLine("A sua média foi: " + media.ToString("N1"));

            if (media > 5)
            {
                Console.WriteLine("Você foi aprovado");
            }

            else
            {
                Console.WriteLine("Você foi reprovado");
            }
        }
    }
}
