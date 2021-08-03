using System;
using Exemplo_EplayersMvcTarde.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo_EplayersMvc.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        Jogador JogadorModel = new Jogador();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogadores = JogadorModel.LerTodos();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();
            novoJogador.IdJogador = Int32.Parse(form["IdJogador"]);
            novoJogador.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novoJogador.Nome = form["Nome"];
            novoJogador.Email = form["Email"];
            novoJogador.Senha = form["Senha"];

            JogadorModel.Criar(novoJogador);
            ViewBag.Jogadores = JogadorModel.LerTodos();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            JogadorModel.Deletar(id);
            ViewBag.Equipe = JogadorModel.LerTodos();
            return LocalRedirect("~/Jogador/Listar");
        }

    }
}