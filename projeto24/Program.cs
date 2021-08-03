using System;
using projeto24.Classes;

namespace projeto24
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;
            do
            {
                Console.WriteLine($@"
Escolha um método de pagamento:

B - boleto
C - crédito
D - Débito
X - Cancelar pagamento
            ");

                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "b":
                        Boleto b = new Boleto();
                        b.Registar();
                        opcaoValida = true;
                        break;
                    case "c":
                        Credito c = new Credito();
                        Console.WriteLine(c.SalvarCartao());
                        c.Pagar();
                        opcaoValida = true;
                        break;
                    case "d":
                        Debito d = new Debito();
                        Console.WriteLine(d.SalvarCartao());
                        d.Pagar();
                        opcaoValida = true;
                        break;
                    case "x":
                        Pagamento p = new Pagamento();
                        Console.WriteLine(p.Cancelar());
                        opcaoValida = true;
                        break;
                    default:
                        Console.WriteLine("Digite uma opção valida");
                        opcaoValida = false;
                        break;
                }
            } while (!opcaoValida);
        }
    }
}
