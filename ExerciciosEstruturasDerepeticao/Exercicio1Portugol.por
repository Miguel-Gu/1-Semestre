programa
{
	inteiro numero
	
	funcao inicio()
	{
		escreva("Insira um número entre 0 e 10 ")
		leia(numero)

		enquanto (numero>10)
		{
			escreva("Esse valor é inválido, por favor, insira um valor válido ")
			leia(numero)
		}

		enquanto (numero<0)
		{
			escreva("Esse valor é inválido, por favor, insira um valor válido ")
			leia(numero)
		}		
	}
}
