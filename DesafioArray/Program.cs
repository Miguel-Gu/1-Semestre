using System;

namespace DesafioArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int quantidadeDeProdutos;
            string[] nomeProdutos = null;
            int[] quantidadeCadaProduto = null;
            double[] valorProduto = null;

            Console.WriteLine("Quantas produtos você deseja cadastrar?");
            quantidadeDeProdutos = int.Parse(Console.ReadLine());

            nomeProdutos = new string[quantidadeDeProdutos];
            for (var i = 0; i < quantidadeDeProdutos; i++)
            {
                Console.WriteLine("Digite o nome do " + (i + 1) + "º produto");
                nomeProdutos[i] = Console.ReadLine();
            }

            quantidadeCadaProduto = new int[quantidadeDeProdutos];
            for (var i = 0; i < quantidadeDeProdutos; i++)
            {
                Console.WriteLine("Qual a quantidade do " + (i + 1) + "º produto?");
                quantidadeCadaProduto[i] = int.Parse(Console.ReadLine());                
            }

            valorProduto = new double[quantidadeDeProdutos];
            for (var i = 0; i < quantidadeDeProdutos; i++)
            {
                Console.WriteLine("Qual o valor do " + (i + 1) + "º produto?");
                valorProduto[i] = double.Parse(Console.ReadLine());                
            }

            // int c = 1;
            // foreach (var item in nomeProdutos)
            // {
            //     Console.WriteLine($"Nome do {c}º produto é {item}.");
            //     c++;
            // }

            // foreach (var item in quantidadeCadaProduto)
            // {
            //     Console.WriteLine($"A quantidade do {c}º produto é {item}.");
            //     c++;
            // }

            // foreach (var item in valorProduto)
            // {
            //     Console.WriteLine($"O valor do {c}º produto é {item} reais.");
            //     c++;
            // }

            Console.WriteLine($@"
             |----------------------------------------------------------------------------------------------------------------------------------------|
             |   Nome                                                        Quantidade                                                      Valor    |
             |----------------------------------------------------------------------------------------------------------------------------------------|");
            for (var i = 0; i < quantidadeDeProdutos; i++)
            {
            Console.WriteLine($@"
             | {nomeProdutos[i]}                                                               {quantidadeCadaProduto[i]}                                                                {valorProduto[i]} |
             |----------------------------------------------------------------------------------------------------------------------------------------|"); 
            }
        }
    }
}
