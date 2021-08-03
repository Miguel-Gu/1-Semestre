using System;
using System.Collections.Generic;

namespace ProjetoProduto09_06.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set; }
        public List<Produto> listaProduto = new List<Produto>();
        public bool MarcaValida;

        public Produto()
        {

        }

        public Produto(int _codigo, string _nomeProduto, float _preco, Usuario u, Marca marca)
        {
            Codigo = _codigo;
            NomeProduto = _nomeProduto;
            Preco = _preco;
            DataCadastro = DateTime.Now;
            CadastradoPor = u;
            Marca = marca;
        }

        public string Cadastrar(Produto produto, Usuario u, Marca m)
        {

            Console.WriteLine("Digite o código do produto");
            int _codigoP = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do produto");
            string _nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto");
            float _preco = float.Parse(Console.ReadLine());

            m.ListarMarcas();

            do
            {
                Console.WriteLine("Qual a marca desse produto?");
                string MarcaProduto = Console.ReadLine();

                Marca marcaEncontrada = m.listaMarcas.Find( item => item.NomeMarca == MarcaProduto);

                if (marcaEncontrada != null)
                {
                    listaProduto.Add(new Produto(_codigoP, _nomeProduto, _preco, u,marcaEncontrada));
                    MarcaValida = true;
                }
                else
                {
                    Console.WriteLine(@"
            Digite uma marca existente. 
            (Preste atenção se você não digitou o nome da marca diferente daquilo que está registrado)
            ");

                    MarcaValida = false;
                }

            } while (MarcaValida == false);

            return "Produto cadastrado";
        }

        public void ListarProdutos()
        {
            if (listaProduto.Count > 0)
            {
                foreach (Produto produto in listaProduto)
                {
//                     Console.WriteLine($@"
// [CÓDIGO]: {produto.Codigo}
// [NOME PRODUTO]: {produto.NomeProduto}
// [PREÇO]: {produto.Preco}
// [DATA DE CADASTRO]: {produto.DataCadastro}
// [MARCA]: {produto.Marca.NomeMarca}
// [CADASTRADO POR]: {produto.CadastradoPor.Nome}
//                     ");
Console.WriteLine($@"[CÓDIGO]: {produto.Codigo}");
Console.WriteLine($@"[NOME PRODUTO]: {produto.NomeProduto}");
Console.WriteLine($@"[PREÇO]: {produto.Preco}");
Console.WriteLine($@"[DATA DE CADASTRO]: {produto.DataCadastro}");
Console.WriteLine($@"[MARCA]: {produto.Marca.NomeMarca}");
Console.WriteLine($@"[CADASTRADO POR]: {produto.CadastradoPor.Nome}");
                    
                }
            }
            else
            {
                Console.WriteLine("Não há nenhum item na lista");
            }
        }

        public string DeletarProdutos(Produto produto)
        {
            if (listaProduto.Count > 0)
            {
                Console.WriteLine("Digite o código do produto que deseja deletar: ");
                int codigo = int.Parse(Console.ReadLine());

                listaProduto.RemoveAll(objeto => objeto.Codigo == codigo);
                Console.WriteLine($"Produto deletado com sucesso!");
            }
            else
            {
                Console.WriteLine("Não há mais produtos para serem deletados");
            }

            return "Produto deletado";
        }
    }
}