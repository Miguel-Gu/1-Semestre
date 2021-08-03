programa
{
	logico nomeEmBranco = verdadeiro
	cadeia nome
	logico idadeFalsa =  verdadeiro
	inteiro idade
	logico salarioVazio = verdadeiro
	real salario
	logico estadoInexistente = verdadeiro
	caracter estadoCivil
	
	funcao inicio()
	{
		enquanto (nomeEmBranco == verdadeiro)
		{
			escreva("Insira seu nome:  ")
			leia(nome)

			se (nome != "")
			{
				escreva("Nome válido. Seu nome é " + nome + ".  ")
				nomeEmBranco = falso
			}

			senao
			{
				escreva("inválido.  ")
			}
		}


		enquanto (idadeFalsa == verdadeiro)
		{
			escreva("Insira sua idade:  ")
			leia(idade)

			se (idade<150)
			{
				escreva("Idade válida. Sua idade é " + idade + " anos.  ")
				idadeFalsa = falso
			}

			senao
			{
				escreva("Idade inválida.  ")
			}
		}


		enquanto (salarioVazio == verdadeiro)
		{
			escreva("Insira seu salário:  ")
			leia(salario)

			se (salario>0)
			{
				escreva("Salário válido. Você tem um salário de R$" + salario + "  ")
				salarioVazio = falso
			}

			senao
			{
				escreva("Salário inválido.  ")
			}
		}	


		enquanto (estadoInexistente == verdadeiro)
		{
			escreva("Insira seu Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a))")
			leia(estadoCivil)

			escolha (estadoCivil)
			{
				caso  "s" :
					escreva("Você é solteiro(a)")
					estadoInexistente = falso
				
				caso "c" :
					escreva("Você é casado(a)")
					estadoInexistente = falso

				caso "v" :
					escreva("Você é viuvo(a)")
					estadoInexistente = falso

				caso "d" :
					escreva("Você é divorciado(a)")
					estadoInexistente = falso

				outrocaso :
					escreva("Estado Civil Inválido")

				fimescolha
			}
		}			
	}
}