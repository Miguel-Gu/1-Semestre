programa
{
	cadeia nomePessoa
	inteiro idadePessoa
	inteiro meses
	inteiro dias
	inteiro horas
	inteiro minutos
	
	funcao inicio()
	{
		
		escreva("Por favor, insira o seu nome:")
		leia(nomePessoa)
		escreva("Seja bem vindo " +nomePessoa + "!!!")

		escreva("Quantos anos você tem?")
		leia(idadePessoa)

		meses=idadePessoa*12
		dias=idadePessoa*365
		horas=idadePessoa*8760
		minutos=idadePessoa*525600

		escreva("A sua idade em: ")
		escreva("Meses: " +meses+ " meses. ")
		escreva("Dias: "+dias+" dias. ")
		escreva("Horas: "+horas+" horas. ")
		escreva("Minutos: "+minutos+" minutos. ")
	}
}