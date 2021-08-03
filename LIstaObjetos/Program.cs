using System;
using System.Collections.Generic;
using LIstaObjetos.Classes;

namespace LIstaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            // CRUD - Create, Read, Update, Delete

            // Create
            // Adicionando usando o método construtor de Produto
            produtos.Add(new Produto(1, "Apple Watch", 3522.65f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.65f));
            produtos.Add(new Produto(3, "Zenfone Asus", 2522.65f));
            produtos.Add(new Produto(4, "Samsung S20", 2522.65f));
            produtos.Add(new Produto(5, "Motorola G8", 2522.65f));

            //  Instanciando com o método construtor simples
            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone 12";
            iphone.Preco = 9552.34f;

            produtos.Add(iphone);

            // Read
            // Exibir o conteúdo da lista
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }
            Console.WriteLine("");

            // Delete
            // Remove o item no índice 5
            produtos.RemoveAt(5);

            // Remove todos os itens que se adequam na expressão lambda
            produtos.RemoveAll(item => item.Nome == "Apple Watch");

            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }
            Console.WriteLine("");


            // Update
            // Encontro o produto a atualizar
            Produto atualizar = produtos.Find(item => item.Codigo == 4);

            // Mudo o valor do produto
            atualizar.Preco = 1200.47f;

            // Remover o item antigo
            produtos.RemoveAll(item => item.Codigo == 4);

            // Inserir o item atualizado
            produtos.Insert(3, atualizar);

            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }
            Console.WriteLine("");
        }
    }
}
