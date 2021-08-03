programa
{
		cadeia nomePessoa
		inteiro salario
		inteiro porcentagem
		inteiro salarioReajustado
	
	funcao inicio()
	{

		escreva("Por favor, insira o seu nome: ")
		leia(nomePessoa)
		escreva("Seja bem vindo " +nomePessoa + "!!! ")

		escreva(" Insira o seu salário: " )
		leia(salario)

		porcentagem=(salario/100)*30
		salarioReajustado=salario*porcentagem

		se (salario<500)
		{
			escreva("O valor do seu salário reajustado será: " + salarioReajustado + " reais ")
		}

		senao
		{
			escreva("Você não tem direito ao aumento")
		}
	}
}