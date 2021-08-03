using System;

namespace ex33
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 100;
        public int quantidadeEscolhida;

        public void FazerCafe()
        {

            if (acucarDisponivel >= 10)
            {
                Console.WriteLine("Você não informou nenhum valor, por padrão um café com 10 gramas de açúcar foi feito");
                acucarDisponivel = acucarDisponivel - 10;
            }
            else
            {
                Console.WriteLine("Café sem acúcar feito pois a máquina está sem açúcar suficiente");
            }
        }

        public void FazerCafe(string querOuNao = "s")
        {
            bool opcaoValida = true;
            do
            {
                Console.WriteLine($"Quantas gramas de acúcar você deseja? ({acucarDisponivel} gramas de açúcar disponível) ");
                quantidadeEscolhida = int.Parse(Console.ReadLine());

                if (quantidadeEscolhida >= 0)
                {
                    if (acucarDisponivel >= quantidadeEscolhida)
                    {
                        Console.WriteLine($"Café com {quantidadeEscolhida} gramas de açúcar feito");
                        acucarDisponivel = acucarDisponivel - quantidadeEscolhida;
                    }
                    else
                    {
                        Console.WriteLine($"Café sem acúcar feito pois a máquina está sem açúcar suficiente para um café com {quantidadeEscolhida} gramas.\nA máquina tem {acucarDisponivel} gramas de açúcar disponível.");
                    }
                    opcaoValida = false;
                } else
                {
                    Console.WriteLine("Insira um valor válido");
                }

            } while (opcaoValida);
        }
    }
}