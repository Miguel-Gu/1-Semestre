using System;

namespace Ex12_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string senhaCorreta = "123456";
            string cadastrarPassagem;
            string senha;
            int tamanhoArrays = 5;
            int c = 0;
            bool condicao = false;
            string[] nomeDoPassageiro = new string[tamanhoArrays];
            string[] origem = new string[tamanhoArrays];
            string[] destino = new string[tamanhoArrays];
            string[] dataDeVoo = new string[tamanhoArrays];
            
            do
            {
                Console.WriteLine("Insira sua senha:");
                senha = Console.ReadLine();


                if (senha == senhaCorreta)
                {
                    do
                    {

                        Console.WriteLine(@"
|================================|
|              MENU              |
|--------------------------------|
|           Você deseja:         |
|      1 - Cadastrar Passagem    |
|      2 - Listar Passagens      |
|      0 - Sair                  |
|================================|
");
                        string opcaoMenu = Console.ReadLine();

                        switch (opcaoMenu)
                        {
                            case "1":

                                do
                                {
                                    Console.WriteLine("\nInsira seu nome completo:");
                                    nomeDoPassageiro[c] = Console.ReadLine();

                                    Console.WriteLine("\nInsira o local de origem do seu voo:");
                                    origem[c] = Console.ReadLine();

                                    Console.WriteLine("\nInsira o seu destino:");
                                    destino[c] = Console.ReadLine();

                                    Console.WriteLine("\nInsira a data do seu voo:");
                                    dataDeVoo[c] = Console.ReadLine();

                                    Console.WriteLine("\nVocê deseja cadastrar mais uma passagem?  sim(s)  não(n)");
                                    cadastrarPassagem = Console.ReadLine().ToLower();

                                    c++;

                                } while (cadastrarPassagem == "s");
                                break;


                            case "2":

                                Console.Write(@"
|================================================================|
|  Nome              Origem         Destino               Data   |
|----------------------------------------------------------------|
                                ");
                                for (var i = 0; i < c; i++)
                                {
                                    Console.Write($@"
|----------------------------------------------------------------|
| {nomeDoPassageiro[i]}    {origem[i]}    {destino[i]}    {dataDeVoo[i]} |
|----------------------------------------------------------------|
");
                                }
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
                else
                {
                    Console.WriteLine("senha inválida");
                }

            } while (senha != senhaCorreta);
        }
    }
}
