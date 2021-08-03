using System;
using System.Collections.Generic;

namespace ProjetoProduto09_06.Classes
{
    public class Marca
    {

        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Marca> listaMarcas = new List<Marca>();

        public Marca()
        {

        }

        public Marca(int _codigo, string _nomeMarca)
        {
            Codigo = _codigo;
            NomeMarca = _nomeMarca;
            DataCadastro = DateTime.Now;
        }

        public string Cadastrar(Marca marca)
        {
            Console.WriteLine("Digite o código da marca: ");
            int _codigoM = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca: ");
            string _nomeMarca = Console.ReadLine();

            listaMarcas.Add(new Marca(_codigoM, _nomeMarca));

            return "Marca cadastrado";
        }

        public void ListarMarcas()
        {
            if (listaMarcas.Count > 0)
            {
                foreach (Marca marca in listaMarcas)
                {
                    Console.WriteLine($@"
[CÓDIGO]: {marca.Codigo}
[NOME MARCA]: {marca.NomeMarca}
[DATA DE CADASTRO]: {marca.DataCadastro}
                    ");
                }
            }
            else
            {
                Console.WriteLine("Não há nenhum item na lista");
            }
        }

        public string DeletarMarcas(Marca marca)
        {
            if (listaMarcas.Count > 0)
            {
                Console.WriteLine("Digite o código da Marca que deseja deletar: ");
                int codigo = int.Parse(Console.ReadLine());

                listaMarcas.RemoveAll(objeto => objeto.Codigo == codigo);
                Console.WriteLine($"Marca deletada com sucesso!");
            }
            else
            {
                Console.WriteLine("Não há marcas na lista para serem deletadas");
            }



            return "Marca deletada";
        }
    }
}