using System;
using ex33;

namespace ex33
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            string opcaoCafe;
            bool opcaoValida = true;
            bool querMaisCafe = true;
            do
            {
                Console.WriteLine(@"
Quer o seu café com uma quantidade específica de açúcar?
Aperte 's' caso queria informar e enter caso não queira informar. 
O café será feito sem açúcar caso a máquina esteja sem.
            ");
                string querOuNao = Console.ReadLine().ToLower();

                switch (querOuNao)
                {
                    case "":
                        m.FazerCafe();
                        do
                        {
                            Console.WriteLine("Deseja mais um café? s/n");
                            opcaoCafe = Console.ReadLine();

                            if (opcaoCafe == "s")
                            {
                                querMaisCafe = true;
                                opcaoValida = false;
                            }
                            else if (opcaoCafe == "n")
                            {
                                Console.WriteLine("Até mais");
                                querMaisCafe = false;
                                opcaoValida = false;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                opcaoValida = false;
                            }
                        } while (opcaoValida);
                        break;
                    case "s":
                        m.FazerCafe(querOuNao = "s");
                        do
                        {
                            Console.WriteLine("Deseja mais um café? s/n");
                            opcaoCafe = Console.ReadLine();

                            if (opcaoCafe == "s")
                            {
                                querMaisCafe = true;
                                opcaoValida = false;
                            }
                            else if (opcaoCafe == "n")
                            {
                                Console.WriteLine("Até mais");
                                querMaisCafe = false;
                                opcaoValida = false;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                opcaoValida = false;
                            }
                        } while (opcaoValida);
                        break;
                    default:
                        m.FazerCafe();
                        do
                        {
                            Console.WriteLine("Deseja mais um café? s/n");
                            opcaoCafe = Console.ReadLine();

                            if (opcaoCafe == "s")
                            {
                                querMaisCafe = true;
                                opcaoValida = false;
                            }
                            else if (opcaoCafe == "n")
                            {
                                Console.WriteLine("Até mais");
                                querMaisCafe = false;
                                opcaoValida = false;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida");
                                opcaoValida = false;
                            }
                        } while (opcaoValida);
                        break;
                }
            } while (querMaisCafe);
        }
    }
}
