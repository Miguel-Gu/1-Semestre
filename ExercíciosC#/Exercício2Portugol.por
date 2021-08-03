programa
{
	cadeia nomePessoa
	inteiro anoNascimento
	inteiro anoAtual
	inteiro idade
	inteiro semanas
	
	funcao inicio()
	{
		
		escreva("Por favor, insira o seu nome:")
		leia(nomePessoa)
		escreva("Seja bem vindo " +nomePessoa + "!!!")
		
		escreva("Em que ano você nasceu? ")
		leia(anoNascimento)

		escreva("Qual o ano em que estamos? ")
		leia(anoAtual)

		idade=anoAtual-anoNascimento
		semanas=idade*52

		escreva("Você tem " + idade + " anos, ou seja, " + semanas + " semanas")
		
	}
}