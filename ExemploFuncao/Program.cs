using System;

namespace ExemploFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Qual operação matemática você deseja realizar? adição(+), subtração(-), multiplicação(*), divisão(/)");
            string OperacaoMatematica = Console.ReadLine();


            switch (OperacaoMatematica)
            {
                case "+":
                    Console.WriteLine("Insira o primeiro número que você deseja somar: ");
                    double n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo número que você deseja somar: ");
                    double n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O resultado da soma é: {Somar(n1, n2)}");

                    break;
                case "-":
                    Console.WriteLine("Insira o primeiro número que você deseja subtrair: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo número que você deseja subtrair: ");
                    n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O resultado da subtração é: {Substrair(n1, n2)}");

                    break;
                case "*":
                    Console.WriteLine("Insira o primeiro número que você deseja multiplicar: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo número que você deseja multiplicar: ");
                    n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O resultado da multiplicação é: {Multiplicar(n1, n2)}");

                    break;
                case "/":
                    Console.WriteLine("Insira o primeiro número que você deseja dividir: ");
                    n1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o segundo número que você deseja dividir: ");
                    n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"O resultado da divisão é: {Dividir(n1, n2)}");

                    break;
                default:
                    Console.WriteLine("Você não inseriu uma opcão válida.");
                    break;
            }
        }

        static double Somar(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }

        static double Substrair(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }

        static double Multiplicar(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }

        static double Dividir(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }
    }
}
