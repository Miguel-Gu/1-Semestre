using System;
using ex1.Classes;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = true;
            do
            {
                Console.WriteLine(@"
    Você deseja usar o:
    1 - Elevador Social
    2 - Elevador de Serviço
            ");
                string opcaoElevador = Console.ReadLine();

                switch (opcaoElevador)
                {
                    case "1":
                        ElevadorSocial eSo = new ElevadorSocial();
                        eSo.Inicializar();
                        eSo.Entrar();
                        eSo.Subir();
                        eSo.Fazer();
                        opcaoValida = false;

                        break;
                    case "2":
                        ElevadorServico eSe = new ElevadorServico();
                        eSe.Inicializar();
                        eSe.Entrar();
                        eSe.Subir();
                        eSe.FazerServico();
                        opcaoValida = false;
                        
                        break;
                    default:
                        Console.WriteLine("Selecione uma opção válida");
                        opcaoValida = true;
                        break;
                }
            } while (opcaoValida);
        }
    }
}
