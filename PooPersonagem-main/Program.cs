using System;

namespace AulaPooPersonagem
{
    class Program
    {

        static void Main(string[] args)
        {
            Personagem personagem1 = new Personagem();
            personagem1.nome = "Cap";
            personagem1.idade = 103;
            personagem1.armadura = "Escudo";
            personagem1.pontoVida = 75;

            Personagem personagem2 = new Personagem();
            personagem2.nome = "Visão";
            personagem2.idade = 6;
            personagem2.armadura = "Capa";
            personagem2.pontoVida = 100;

            Personagem personagem3 = new Personagem();
            personagem3.nome = "Homem de ferro";
            personagem3.idade = 51;
            personagem3.armadura = "Bleding Edge";
            personagem3.pontoVida = 85;

            Console.WriteLine(@"
Escolha o Primeiro Personagem:
    1 - Capitão América
    2 - Visão
    3 - Homem de Ferro
            ");
            int personagemEscolhido1 = int.Parse(Console.ReadLine());

            Console.WriteLine(@"
Escolha o Segundo Personagem:
    1 - Capitão América
    2 - Visão
    3 - Homem de Ferro
            ");
            int personagemEscolhido2 = int.Parse(Console.ReadLine());

            //
            // Capitão América X Visão
            //
            if (personagemEscolhido1 == 1 && personagemEscolhido2 == 2)
            {
                do
                {
                    Console.WriteLine(@"
Selecione a opção do personagem 1
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP1 = int.Parse(Console.ReadLine());


                    Console.WriteLine(@"
Selecione a opção do personagem 2
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP2 = int.Parse(Console.ReadLine());

                    if (opcaoP1 == 1 && opcaoP2 == 1)
                    {
                        personagem1.pontoVida = personagem1.pontoVida - personagem2.Atacar();
                        personagem2.pontoVida = personagem2.pontoVida - personagem1.Atacar();

                    }
                    else if (opcaoP1 == 1 && opcaoP2 == 2)
                    {
                        personagem2.pontoVida = personagem2.pontoVida - (personagem1.Atacar() - personagem2.Defender());

                    }
                    else if (opcaoP1 == 2 && opcaoP2 == 1)
                    {
                        personagem1.pontoVida = personagem1.pontoVida - (personagem2.Atacar() - personagem1.Defender());

                    }


                    Console.WriteLine($"Vida do Cap {personagem1.pontoVida}");
                    Console.WriteLine($"Vida do Visão {personagem2.pontoVida}");

                } while (personagem1.pontoVida != 0 & personagem2.pontoVida != 0);
            }



            //
            // Capitão América X Homem de Ferro
            //
            if (personagemEscolhido1 == 1 && personagemEscolhido2 == 3)
            {
                do
                {
                    Console.WriteLine(@"
Selecione a opção do personagem 1
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP1 = int.Parse(Console.ReadLine());


                    Console.WriteLine(@"
Selecione a opção do personagem 2
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP2 = int.Parse(Console.ReadLine());

                    if (opcaoP1 == 1 && opcaoP2 == 1)
                    {
                        personagem1.pontoVida = personagem1.pontoVida - personagem3.Atacar();
                        personagem3.pontoVida = personagem3.pontoVida - personagem1.Atacar();

                    }
                    else if (opcaoP1 == 1 && opcaoP2 == 2)
                    {
                        personagem3.pontoVida = personagem3.pontoVida - (personagem1.Atacar() - personagem3.Defender());

                    }
                    else if (opcaoP1 == 2 && opcaoP2 == 1)
                    {
                        personagem3.pontoVida = personagem1.pontoVida - (personagem3.Atacar() - personagem1.Defender());

                    }


                    Console.WriteLine($"Vida do Cap {personagem1.pontoVida}");
                    Console.WriteLine($"Vida do Homem de Ferro {personagem3.pontoVida}");

                } while (personagem1.pontoVida != 0 & personagem3.pontoVida != 0);
            }   



            //
            // Visão X Capitão América
            //
            if (personagemEscolhido1 == 2 && personagemEscolhido2 == 1)
            {
                do
                {
                    Console.WriteLine(@"
Selecione a opção do personagem 1
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP1 = int.Parse(Console.ReadLine());


                    Console.WriteLine(@"
Selecione a opção do personagem 2
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP2 = int.Parse(Console.ReadLine());

                    if (opcaoP1 == 1 && opcaoP2 == 1)
                    {
                        personagem2.pontoVida = personagem2.pontoVida - personagem1.Atacar();
                        personagem1.pontoVida = personagem1.pontoVida - personagem2.Atacar();

                    }
                    else if (opcaoP1 == 1 && opcaoP2 == 2)
                    {
                        personagem1.pontoVida = personagem1.pontoVida - (personagem2.Atacar() - personagem1.Defender());

                    }
                    else if (opcaoP1 == 2 && opcaoP2 == 1)
                    {
                        personagem2.pontoVida = personagem2.pontoVida - (personagem1.Atacar() - personagem2.Defender());

                    }


                    Console.WriteLine($"Vida do Cap {personagem1.pontoVida}");
                    Console.WriteLine($"Vida do Visão {personagem2.pontoVida}");

                } while (personagem1.pontoVida != 0 & personagem2.pontoVida != 0);
            }



            //
            // Visão X Homem de Ferro
            //
            if (personagemEscolhido1 == 2 && personagemEscolhido2 == 3)
            {
                do
                {
                    Console.WriteLine(@"
Selecione a opção do personagem 1
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP1 = int.Parse(Console.ReadLine());


                    Console.WriteLine(@"
Selecione a opção do personagem 2
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP2 = int.Parse(Console.ReadLine());

                    if (opcaoP1 == 1 && opcaoP2 == 1)
                    {
                        personagem2.pontoVida = personagem2.pontoVida - personagem3.Atacar();
                        personagem3.pontoVida = personagem3.pontoVida - personagem2.Atacar();

                    }
                    else if (opcaoP1 == 1 && opcaoP2 == 2)
                    {
                        personagem3.pontoVida = personagem3.pontoVida - (personagem2.Atacar() - personagem3.Defender());

                    }
                    else if (opcaoP1 == 2 && opcaoP2 == 1)
                    {
                        personagem2.pontoVida = personagem2.pontoVida - (personagem3.Atacar() - personagem2.Defender());

                    }


                    Console.WriteLine($"Vida do Visão {personagem2.pontoVida}");
                    Console.WriteLine($"Vida do Homem de Ferro {personagem3.pontoVida}");

                } while (personagem2.pontoVida != 0 & personagem3.pontoVida != 0);
            }



            //
            // Homem de Ferro X Capitão América
            //
            if (personagemEscolhido1 == 3 && personagemEscolhido2 == 1)
            {
                do
                {
                    Console.WriteLine(@"
Selecione a opção do personagem 1
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP1 = int.Parse(Console.ReadLine());


                    Console.WriteLine(@"
Selecione a opção do personagem 2
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP2 = int.Parse(Console.ReadLine());

                    if (opcaoP1 == 1 && opcaoP2 == 1)
                    {
                        personagem3.pontoVida = personagem3.pontoVida - personagem1.Atacar();
                        personagem3.pontoVida = personagem1.pontoVida - personagem3.Atacar();

                    }
                    else if (opcaoP1 == 1 && opcaoP2 == 2)
                    {
                        personagem1.pontoVida = personagem1.pontoVida - (personagem3.Atacar() - personagem1.Defender());

                    }
                    else if (opcaoP1 == 2 && opcaoP2 == 1)
                    {
                        personagem3.pontoVida = personagem3.pontoVida - (personagem1.Atacar() - personagem3.Defender());

                    }


                    Console.WriteLine($"Vida do Homem de ferro {personagem3.pontoVida}");
                    Console.WriteLine($"Vida do Cap {personagem1.pontoVida}");

                } while (personagem3.pontoVida != 0 & personagem1.pontoVida != 0);
            }



            //
            // Homem de Ferro X Visão
            //
            if (personagemEscolhido1 == 3 && personagemEscolhido2 == 2)
            {
                do
                {
                    Console.WriteLine(@"
Selecione a opção do personagem 1
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP1 = int.Parse(Console.ReadLine());


                    Console.WriteLine(@"
Selecione a opção do personagem 2
    1 - Atacar
    2 - Defender            
            ");
                    int opcaoP2 = int.Parse(Console.ReadLine());

                    if (opcaoP1 == 1 && opcaoP2 == 1)
                    {
                        personagem3.pontoVida = personagem3.pontoVida - personagem2.Atacar();
                        personagem2.pontoVida = personagem2.pontoVida - personagem3.Atacar();

                    }
                    else if (opcaoP1 == 1 && opcaoP2 == 2)
                    {
                        personagem2.pontoVida = personagem2.pontoVida - (personagem3.Atacar() - personagem2.Defender());

                    }
                    else if (opcaoP1 == 2 && opcaoP2 == 1)
                    {
                        personagem3.pontoVida = personagem3.pontoVida - (personagem2.Atacar() - personagem3.Defender());

                    }

                    Console.WriteLine($"Vida do Homem de ferro {personagem3.pontoVida}");
                    Console.WriteLine($"Vida do Visão {personagem2.pontoVida}");

                } while (personagem1.pontoVida != 0 & personagem3.pontoVida != 0);
            }
        }
    }
}
