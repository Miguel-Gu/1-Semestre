using System;

namespace ex2.Classes
{
    public class JogadorMeio : Jogador
    {
        public string Aposentar()
        {
            CalcularIdade();
            if (idade < 38)
            {
                return $"Falta {38 - idade} anos para você se aposentar";
            }
            else
            {
                return "Você já pode se aposentar";
            }
        }
    }
}