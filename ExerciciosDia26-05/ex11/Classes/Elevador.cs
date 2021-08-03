using System;

namespace ex1.Classes
{
    public abstract class Elevador
    {
        public int andarAtual = 0;
        public int andarDestino;
        public int totalAndares;
        public int capacidadeElevador = 10;
        public int pessoasPresentes = 0;
        public int pessoasPresentesEntraram;
        public int pessoasEntrar;
        public int pessoasSair;

        public void Inicializar()
        {
            bool OpcaoValidaInicializar = true;

            do
            {
                Console.WriteLine("\n\nQuantos andares o prédio tem?");
                totalAndares = int.Parse(Console.ReadLine());

                if (totalAndares < 0)
                {
                    Console.WriteLine("Número inválido?");
                }

                else
                {
                    Console.WriteLine($"O prédio tem {totalAndares} andares");
                    OpcaoValidaInicializar = false;
                }
            } while (OpcaoValidaInicializar);

        }
        public void Entrar()
        {
            bool OpcaoValidaEntrar = true;
            do
            {
                if (pessoasPresentes < 10)
                {
                    Console.WriteLine($"\nO elevador tem {pessoasPresentes} pessoas dentro\nQuantas pessoão vão entrar?");
                    pessoasEntrar = int.Parse(Console.ReadLine());

                    pessoasPresentesEntraram = pessoasPresentes + pessoasEntrar;

                    if (pessoasEntrar >= 0)
                    {
                        if (capacidadeElevador >= pessoasPresentesEntraram)
                        {
                            Console.WriteLine($"\nO elevador agora tem {pessoasPresentesEntraram} pessoas");
                            pessoasPresentes = pessoasPresentesEntraram;
                            OpcaoValidaEntrar = false;
                        }
                        else
                        {
                            Console.WriteLine($"\nO elevador não comporta {pessoasPresentesEntraram} pessoas, apenas 10 \nO elevador tem {pessoasPresentes} pessoas no momento");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insira um número válido");
                    }
                }
                else
                {
                    Console.WriteLine("O elevador já está cheio");
                    OpcaoValidaEntrar = false;
                }
            } while (OpcaoValidaEntrar);
        }

        public void Sair()
        {
            if (pessoasPresentes != 0 && pessoasPresentes > -1)
            {
                bool OpcaoValidaSair = true;

                do
                {

                    Console.WriteLine($"\nO elevador tem {pessoasPresentes} pessoas dentro\nQuantas pessoas vão sair?");
                    pessoasSair = int.Parse(Console.ReadLine());

                    if (pessoasSair >= 0)
                    {
                        pessoasPresentes = pessoasPresentes - pessoasSair;

                        if (pessoasPresentes >= 0)
                        {
                            Console.WriteLine($"\nO elevador agora tem {pessoasPresentes} pessoas");
                            OpcaoValidaSair = false;
                        }
                        else
                        {
                            pessoasPresentes = pessoasPresentes + pessoasSair;
                            Console.WriteLine("Impossível sair essa quantidade de pessoas, insira um número válido");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insira um número válido");
                    }
                } while (OpcaoValidaSair);
            }
            else
            {
                Console.WriteLine("O elevador já esta vazio");
            }
        }
        public void Subir()
        {
            if (andarAtual != totalAndares)
            {
                bool opcaoValidaSubir = true;

                do
                {
                    Console.WriteLine($"\nO prédio tem {totalAndares} andares\nPara qual andar você deseja subir?");
                    andarDestino = int.Parse(Console.ReadLine());

                    if (andarDestino > andarAtual && andarDestino <= totalAndares)
                    {
                        andarAtual = andarDestino;
                        Console.WriteLine($"\nSubindo para o {andarAtual}º andar");
                        Console.WriteLine($"\nVocê chegou no {andarAtual}º andar");
                        opcaoValidaSubir = false;
                    }
                    else
                    {
                        Console.WriteLine("Impossível subir para esse andar");
                    }
                } while (opcaoValidaSubir);
            }
            else
            {
                Console.WriteLine("\nVocê já está no último andar");
            }
        }
        public void Descer()
        {
            if (andarAtual != 0)
            {
                bool OpcaoValidaDescer = true;

                do
                {
                    Console.WriteLine($"\nO prédio tem {totalAndares} andares\nPara qual andar você deseja descer?");
                    andarDestino = int.Parse(Console.ReadLine());

                    if (andarDestino >= 0 && andarDestino <= andarAtual)
                    {
                        andarAtual = andarDestino;
                        Console.WriteLine($"\nDescendo para o {andarAtual}º andar");
                        Console.WriteLine($"\nVocê chegou no {andarAtual}º andar");
                        OpcaoValidaDescer = false;
                    }
                    else
                    {
                        Console.WriteLine("Impossível descer para esse andar");
                    }
                } while (OpcaoValidaDescer);
            }
            else
            {
                Console.WriteLine("\nVocê já está no térreo");
            }
        }
        public void Fazer()
        {
            bool opcaoValidaElevador = true;
            do
            {
                Console.WriteLine(@"
    Você deseja:
    1 - Entrar no elevador
    2 - Sair do elevador
    3 - Subir
    4 - Descer 
    5 - Sair do sistema       
            ");
                string opcaoFazerDentro = Console.ReadLine();

                switch (opcaoFazerDentro)
                {
                    case "1":
                        Entrar();
                        opcaoValidaElevador = false;
                        break;
                    case "2":
                        Sair();
                        opcaoValidaElevador = false;
                        break;
                    case "3":
                        Subir();
                        opcaoValidaElevador = false;
                        break;
                    case "4":
                        Descer();
                        opcaoValidaElevador = false;
                        break;
                    case "5":
                        Console.WriteLine("Até mais");
                        opcaoValidaElevador = true;
                        break;
                    default:
                        Console.WriteLine("\nSelecione uma opção válida");
                        opcaoValidaElevador = false;
                        break;
                }
            } while (!opcaoValidaElevador);
        }
    }
}