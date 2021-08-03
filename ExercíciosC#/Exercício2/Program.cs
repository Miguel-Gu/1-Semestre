using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira o seu nome:");
            string nomePessoa=Console.ReadLine();

            Console.WriteLine("Seja bem vindo "+nomePessoa+"!!!");

            Console.WriteLine("Em que ano você nasceu?");
            int anoNascimento=int.Parse(Console.ReadLine());

            int anoAtual=DateTime.Now.Year;

            int idade=anoAtual-anoNascimento;
            int semanas=idade*52;

            Console.WriteLine("Você tem " + idade + " anos, ou seja, " + semanas + " semanas");
        }
    }
}
