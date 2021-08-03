using System;

namespace ExMercado1305
{
    class Program
    {
        static int tamanhoArrays = 10;
        static string[] nome = new string[tamanhoArrays];
        static float[] preco = new float[tamanhoArrays];
        static int[] contador = new int[tamanhoArrays];
        static bool[] promocao = new bool[tamanhoArrays];
        static string[] promocaoson = new string[tamanhoArrays];
        static bool condicao = false;
        static int c = 0;
        static string cadastrarProduto;
        static string[] mostrarPromocao = new string[tamanhoArrays];
        static int totalProdutos;

        static void Main(string[] args)
        {
            do
            {
                MostrarMenu();
                string opcaoMenu = Console.ReadLine();

                switch (opcaoMenu)
                {
                    case "1":
                        CadastrarProduto();
                        break;
                    case "2":
                        ListarProduto();
                        break;
                    case "0":
                        Console.WriteLine("\nObrigado por utilizar nosso sistema!\n");
                        condicao = true;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Por favor, selecione uma opçaõ válida\n");
                        break;
                }
            } while (!condicao);
        }



        // Funções
        // Funções
        // Funções
        // Funções



        static void MostrarMenu()
        {
            Console.WriteLine(@"
|================================|
|              MENU              |
|--------------------------------|
|           Você deseja:         |
|      1 - Cadastrar Produtos    |
|      2 - Listar Produtos       |
|      0 - Sair                  |
|================================|
");
        }
        static void CadastrarProduto()
        {
            do
            {
                do
                {
                    Console.WriteLine("Qual o nome do produto?");
                    nome[c] = Console.ReadLine();

                    Console.WriteLine("Qual o preço do produto?");
                    preco[c] = float.Parse(Console.ReadLine());

                    Console.WriteLine("O produto está em promoção? s/n");
                    promocaoson[c] = Console.ReadLine().ToLower();

                    if (promocaoson[c] == "s")
                    {
                        promocao[c] = true;
                    }
                    else if (promocaoson[c] == "n")
                    {
                        promocao[c] = false;
                    }

                    Console.WriteLine("Você deseja cadastrar mais um produto? s/n");
                    cadastrarProduto = Console.ReadLine().ToLower();

                    c++;

                } while (cadastrarProduto == "s" && c < 10);

                if (cadastrarProduto == "s" && c == 10)
                {
                    Console.WriteLine($"Você já cadastrou 10 produtos. Deseja cadastrar quantos produtos no total?");
                    totalProdutos = int.Parse(Console.ReadLine());
                    Array.Resize(ref nome, totalProdutos);
                    Array.Resize(ref preco, totalProdutos);
                    Array.Resize(ref promocao, totalProdutos);
                    Array.Resize(ref promocaoson, totalProdutos);
                    Array.Resize(ref mostrarPromocao, totalProdutos);
                }
            } while (cadastrarProduto == "s");
        }
        static void ListarProduto()
        {
            Console.Write(@"
|================================================================|
|  Nome                      Preço                     Promoção  |
|================================================================|
                                ");
            for (var i = 0; i < c; i++)
            {
                if (promocao[i] == true)
                {
                    mostrarPromocao[i] = "Está em promoção";
                }
                else if (promocao[i] == false)
                {
                    mostrarPromocao[i] = "Não está em promoção";
                }
                Console.Write($@"
|----------------------------------------------------------------|
| {nome[i]}    R${preco[i]}    {mostrarPromocao[i]}    |
|----------------------------------------------------------------|
");
            }
        }
    }
}
