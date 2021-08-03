programa
{
	cadeia nomePessoa
	inteiro idade
	
	funcao inicio()
	{

		
		escreva("Por favor, insira o seu nome: ")
		leia(nomePessoa)
		escreva("Seja bem vindo " +nomePessoa + "!!!")

		escreva("Quantos anos você tem? ")
		leia(idade)

		se (idade<5)
		{
			escreva("Que pena, você ainda não pode participar")
		}

		senao
		{
			se (idade<8)
			{
				escreva("Você vai participar da Categoria: Infantil A")
			}

			senao
			{
				se (idade<11)
				{
					escreva("Você vai participar da Categoria: Infantil B")
				}

				senao
				{
					se (idade<14)
					{
						escreva("Você vai participar da Categoria: Juvenil A")
					}

					senao
					{
						se (idade<18)
						{
							escreva("Você vai participar da Categoria: Juvenil B")
						}

						senao
						{
							se (idade>=18)
							{
								escreva("Você vai participar da Categoria: Sênior")
							}
						}
					}
				}
			}
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 309; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */