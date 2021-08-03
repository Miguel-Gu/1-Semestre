using System;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira o seu nome:");
            string nomePessoa=Console.ReadLine();

            Console.WriteLine("Seja bem vindo "+nomePessoa+"!!!");

            Console.WriteLine("Quantos anos você tem?");
            int idadePessoa=int.Parse(Console.ReadLine());

            int meses=idadePessoa*12;
            int dias=idadePessoa*365;
            int horas=idadePessoa*8760;
            int minutos=idadePessoa*525600;

            Console.WriteLine("A sua idade em:");
            Console.WriteLine("Meses: " + meses + " meses");
            Console.WriteLine("Dias: " + dias + " dias");
            Console.WriteLine("Horas " + horas + " horas");
            Console.WriteLine("Minutos " + minutos + " minutos");
        }
    }
}