using System;

namespace ex2.Classes
{
    public class JogadorAtaque : Jogador
    {
        public string Aposentar()
        {
            CalcularIdade();
            if (idade < 35)
            {
                return $"Falta {35 - idade} anos para você se aposentar";
            }
            else
            {
                return "Você já pode se aposentar";
            }
        }
    }
}