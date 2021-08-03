using System.Collections.Generic;
using ExemploMVC.Models;
using ExemploMVC.Views;

namespace ExemploMVC.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);

            // produtoView.Listar(produto.Ler());
        }

        public void Cadastrar()
        {
            Produto produto = produtoView.CadastrarProduto();

            produto.Inserir(produto);

            // produto.Inserir(produtoView.CadastrarProduto());
        }
    }
}