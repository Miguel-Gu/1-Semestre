programa
{
	inteiro numero1 = 0
	inteiro numero2 = 1
	inteiro auxiliar
	inteiro i
	
	funcao inicio()
	{
		para (i = 0; i <14; i++)
		{
			auxiliar = numero1
			numero1 = numero2
			numero2 = numero1 + auxiliar

			escreva("{0}", numero2)
		}
	}
}