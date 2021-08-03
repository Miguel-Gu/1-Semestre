using System.Collections.Generic;
using Exemplo_EplayersMvcTarde.Models;

namespace Exemplo_EplayersMvcTarde.Interfaces
{
    public interface IEquipe
    {
        void Criar(Equipe e);
        List<Equipe> LerTodas();
        void Alterar(Equipe e);
        void Deletar(int id);
    }
}