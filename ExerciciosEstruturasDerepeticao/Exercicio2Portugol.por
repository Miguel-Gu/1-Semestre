programa
{
	cadeia nomeUsuario
	logico senhaValida = falso
	cadeia senhaUsuario
	
	funcao inicio()
	{
		escreva("Insira seu nome de usuário:  ")
		leia(nomeUsuario)

		enquanto (senhaValida == falso)
		{
			escreva("Insira sua senha:  ")
			leia(senhaUsuario)

			se (nomeUsuario!=senhaUsuario)
			{
				escreva("Senha válida")
				senhaValida = verdadeiro
			}
			
			senao
			{
				escreva("Senha inválida  ")
			}
		}
	}
}