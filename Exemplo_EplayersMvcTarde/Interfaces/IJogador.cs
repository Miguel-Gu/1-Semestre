using System.Collections.Generic;
using Exemplo_EplayersMvcTarde.Models;

namespace Exemplo_EplayersMvc.Interfaces
{
    public interface IJogador
    {
         void Criar (Jogador j);
         List<Jogador> LerTodos();   
         void Alterar (Jogador j);
         void Deletar (int id);
    }
}