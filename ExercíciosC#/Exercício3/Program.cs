using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, insira o seu nome:");
            string nomePessoa=Console.ReadLine();

            Console.WriteLine("Seja bem vindo "+nomePessoa+"!!!");

            Console.WriteLine("Insira o seu salário:" );
            int salario=int.Parse(Console.ReadLine());

            int porcentagem=(salario/100)*30;
            int salarioReajustado=salario+porcentagem;


            if (salario<500)
            {
                Console.WriteLine("O valor do seu salário reajustado será: " + salarioReajustado + " reais");
            }
            
            else
            {
                Console.WriteLine("Você não tem direito ao aumento");
            }
        }
    }
}
