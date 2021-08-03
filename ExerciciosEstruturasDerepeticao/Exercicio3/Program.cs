using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nomeEmBranco = true;
            while (nomeEmBranco == true)
            {
                Console.WriteLine("Insira seu nome: ");
                string nome = Console.ReadLine();

                if (nome!="")
                {
                    Console.WriteLine("Nome válido. Seu nome é " + nome + ".");
                    nomeEmBranco = false;
                }         

                else
                {
                    Console.WriteLine("inválido.");
                }
            }

            bool idadeFalsa = true;
            while (idadeFalsa == true)
            {
                Console.WriteLine("Insira sua idade: ");
                int idade = int.Parse(Console.ReadLine());

                if (idade<150)
                {
                    Console.WriteLine("Idade válida. Sua idade é " + idade + " anos.");
                    idadeFalsa = false;
                }

                // else if (idade<150)
                // {
                //     Console.WriteLine("Idade válida. Sua idade é " + idade + " anos");
                //     idadeFalsa = false;
                // }

                else
                {
                    Console.WriteLine("Idade inválida. ");                    
                }
            }

            bool salarioVazio = true;
            while (salarioVazio == true)
            {
                Console.WriteLine("Insira seu salário: ");
                double salário = double.Parse(Console.ReadLine());

                if(salário>0)
                {
                    Console.WriteLine("Salário válido. Você tem um salário de R$" + salário);
                    salarioVazio = false;
                }

                else{
                    Console.WriteLine("Salário inválido");
                }
            }

            bool estadoInexistente = true;
            while ( estadoInexistente == true)
            {
                Console.WriteLine("Insira seu Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a))");
                string estadoCivil = Console.ReadLine().ToLower();

                switch (estadoCivil)
                {
                    case "s":
                        Console.WriteLine("Você é solteiro(a)");
                        estadoInexistente = false;
                        break;
                    case "c":
                        Console.WriteLine("Você é casado(a)");
                        estadoInexistente = false;
                        break;
                    case "v":
                        Console.WriteLine("Você é viuvo(a)");
                        estadoInexistente = false;
                        break;
                    case "d":
                        Console.WriteLine("Você é divorciado(a)");
                        estadoInexistente = false;
                        break;
                    default:
                        Console.WriteLine("Estado Civil inválido");
                        break;

                }
            }
        }
    }
}
