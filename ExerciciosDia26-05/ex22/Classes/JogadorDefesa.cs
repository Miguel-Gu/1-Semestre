using System;

namespace ex2.Classes
{
    public class JogadorDefesa : Jogador
    {
        public string Aposentar()
        {
            CalcularIdade();
            if (idade < 40)
            {
                return $"Falta {40 - idade} anos para você se aposentar";
            }
            else
            {
                return "Você já pode se aposentar";
            }
        }
    }
}