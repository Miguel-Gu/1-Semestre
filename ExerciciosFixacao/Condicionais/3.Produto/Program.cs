using System;

namespace _3.Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o nome do produto:");
            string nomeProduto=Console.ReadLine();

            Console.WriteLine("Insira a quantidade adquirida:");
            double quantidadeAdquirida=double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o preço unitário do produto:");
            double precoUnitarioProduto=double.Parse(Console.ReadLine());

            double precoSemDesconto=quantidadeAdquirida*precoUnitarioProduto;
            

            if (quantidadeAdquirida<=5){
                Console.WriteLine($"O nome do produto é {nomeProduto}. O preço sem desconto é de {precoSemDesconto} reais. O preço final com desconto é de {precoSemDesconto*.98} reais");
            }

            else if (quantidadeAdquirida<=10){
                Console.WriteLine($"O nome do produto é {nomeProduto}. O preço sem desconto é de {precoSemDesconto} reais. O preço final com desconto é de {precoSemDesconto*.97} reais");
            }

            else {
                Console.WriteLine($"O nome do produto é {nomeProduto}. O preço sem desconto é de {precoSemDesconto} reais. O preço final com desconto é de {precoSemDesconto*.95} reais");
            }
        }
    }
}
