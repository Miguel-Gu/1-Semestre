using System;

namespace ProjetoProduto09_06.Classes
{
    public class Login
    {
        public bool Logado { get; set; }
        Usuario u1 = new Usuario();
        Produto p = new Produto();
        Marca m = new Marca();

        public Login()
        {
            string desejaCadastrar;
            do
            {
                Console.WriteLine($@"
Seja bem vindo
Para acessar nosso menu, você deve se cadastrar e logar sua conta.
Deseja fazer isso? (s/n)
            ");
                desejaCadastrar = Console.ReadLine().ToLower();

                if (desejaCadastrar == "s")
                {
                    Console.WriteLine(u1.Cadastrar(u1));
                    Console.WriteLine(Logar(u1));
                }
                else if (desejaCadastrar == "n")
                {
                    Console.WriteLine("Até mais");
                    Logado = false;
                }
                else
                {
                    Console.WriteLine("Digite uma opção válida");
                }
            } while (desejaCadastrar != "s" && desejaCadastrar != "n");


            do
            {
                if (Logado == true)
                {
                    Console.WriteLine($@"
    Você deseja:
1 - Cadastrar Produto
2 - Listar Produtos
3 - Deletar Produtos
4 - Cadastrar Marca
5 - Listar Marca
6 - Deletar Marca
7 - Sair do Sistema
            ");

                    string opcaoMenu = Console.ReadLine();

                    switch (opcaoMenu)
                    {
                        case "1":

                            if (m.listaMarcas.Count > 0)
                            {
                                Console.WriteLine(p.Cadastrar(p, u1, m));
                            }
                            else
                            {
                                Console.WriteLine("Você não tem nenhuma marca cadastrada. cadastre uma marca antes de cadastrar um produto.");
                            }

                            break;
                        case "2":
                            p.ListarProdutos();
                            break;
                        case "3":
                            Console.WriteLine(p.DeletarProdutos(p));
                            break;
                        case "4":
                            Console.WriteLine(m.Cadastrar(m));
                            break;
                        case "5":
                            m.ListarMarcas();
                            break;
                        case "6":
                            Console.WriteLine(m.DeletarMarcas(m));
                            break;
                        case "7":
                            Console.WriteLine("Até mais");
                            Logado = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Insira uma opção válida");
                            break;
                    }
                }
            } while (Logado == true);
        }

        public string Logar(Usuario usuario)
        {
            Console.WriteLine("\nLogar");
            do
            {
                Console.WriteLine("\n\nInsira seu email");
                string Email = Console.ReadLine();

                Console.WriteLine("\nInsira sua senha");
                string Senha = Console.ReadLine();

                if (Email == usuario.Email && Senha == usuario.Senha)
                {
                    Logado = true;
                }
                else
                {
                    Logado = false;
                    Console.WriteLine("\nEmail e/ou senha incorreto.");
                }

            } while (Logado == false);

            return $"\nUsuario {usuario.Nome} logado. Seja bem vindo.";
        }
        public string Deslogar(Usuario usuario)
        {
            Logado = false;
            return $"Usuario {usuario} deslogado. Até mais.";
        }
    }
}