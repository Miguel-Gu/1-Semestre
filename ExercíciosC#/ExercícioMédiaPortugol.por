programa
{
	
	funcao inicio()
	{
		cadeia nomePessoa
		
		escreva("Por favor, insira o seu nome: ")
		leia(nomePessoa)
		escreva("Seja bem vindo " +nomePessoa + "!!!")

		real primeiroNumero		
		real segundoNumero
		real terceiroNumero

		escreva("Insira o valor da nota 1 ")
		leia(primeiroNumero)

		escreva("Insira o valor da nota 2 ")
		leia(segundoNumero)
		
		escreva("Insira o valor da nota 3 ")
		leia(terceiroNumero)

		real soma = primeiroNumero + segundoNumero + terceiroNumero
		real media = soma/3

		escreva("A sua média foi: " + media)

		se (media>5)
		{
			escreva(" Você foi aprovado!!!")
		}

		senao
		{
			escreva(" Você foi reprovado!!!")
		}
	}
}