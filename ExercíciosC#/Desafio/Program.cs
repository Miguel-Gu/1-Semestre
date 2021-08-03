using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira o seu nome:");
            string nomePessoa=Console.ReadLine();

            Console.WriteLine("Seja bem vindo "+nomePessoa+"!!!");

            Console.WriteLine("Quantos anos você tem?");
            int idade=int.Parse(Console.ReadLine());

            if (idade<5)
            {
                Console.WriteLine("Que pena, você ainda não pode participar");
            }

            else if (idade<8) 
            {
                Console.WriteLine("Você vai participar da Categoria: Infantil A");
            }

            else if (idade<11)
            {
                Console.WriteLine("Você vai participar da Categoria: Infantil B");
            }

            else if (idade<14) 
            {
                Console.WriteLine("Você vai participar da Categoria: Juvenil A");
            }

            else if (idade<18)
            {
                Console.WriteLine("Você vai participar da Categoria: Juvenil B");
            }
                        
            else
            { 
                Console.WriteLine("Você não pode participar devido a pandemia");
            }  
        }
    }
}
