using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome de usuário: ");
            string nomeUsuario = Console.ReadLine();

            bool senhaValida = false;

            while (senhaValida == false)

            {
                Console.WriteLine("Insira sua senha: ");
                string senhaUsuario = Console.ReadLine();

                if (nomeUsuario!=senhaUsuario)
                {
                    Console.WriteLine("Senha válida");
                    senhaValida = true;
                }
                else
                {
                    Console.WriteLine("Senha Inválida");
                }
            }
        }
    }
}
