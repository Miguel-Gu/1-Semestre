using System;

namespace _2.Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos litros foram colocados?");
            double LitrosColocados=double.Parse(Console.ReadLine());

            Console.WriteLine("Qual combustível foi colocado? (A-álcol, G-gasolina)");
            string CombustivelColocado=Console.ReadLine().ToLower();

            double ValorSemDescontoAlcool=(LitrosColocados*4.9);
            double ValorSemDescontoGasolina=(LitrosColocados*5.3);

            switch (CombustivelColocado)
            {   
                case "a":
                    if (LitrosColocados<=20){
                        Console.WriteLine($"Você vai pagar: {Desconto3(ValorSemDescontoAlcool)}");
                    }

                    else{
                        Console.WriteLine($"Você vai pagar: {Desconto5(ValorSemDescontoAlcool)}");
                    }
                    break;
                case "g":
                    if (LitrosColocados<=20){
                        Console.WriteLine($"Você vai pagar: {Desconto4(ValorSemDescontoGasolina)}");
                    }

                    else{
                        Console.WriteLine($"Você vai pagar: {Desconto6(ValorSemDescontoGasolina)}");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
        }
        static double Desconto3(double primeiroNumero)
        {
            return primeiroNumero*.97;
        }
        static double Desconto4(double primeiroNumero)
        {
            return primeiroNumero*.96;
        }
        static double Desconto5(double primeiroNumero)
        {
            return primeiroNumero*.95;
        }
        static double Desconto6(double primeiroNumero)
        {
            return primeiroNumero*.94;
        }
    }
}
