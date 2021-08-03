using System;

namespace ex2
{
    public abstract class Jogador
    {
        protected string nome;
        protected int data;
        protected string nacionalidade;
        protected double altura;
        protected int peso;
        protected int idade;
        public string Dados()
        {
            Console.WriteLine("\nQual o nome do jogador?");
            nome = Console.ReadLine();

            Console.WriteLine("\nEm que ano o jogador nasceu?");
            data = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQual a nacionalidade do jogador?");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("\nQual a altura do jogador? (Em centímetros)");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("\nQual o peso do jogador? (Em kilos e apenas o número inteiro)");
            peso = int.Parse(Console.ReadLine());

            return $@"
    Nome: {nome}
    Ano de nascimento: {data}
    Nacionalidade: {nacionalidade}
    Altura: {altura} centímetros
    Peso : {peso} kilos
            ";
        }
        public int CalcularIdade()
        {
           return idade = (DateTime.Now.Date.Year) - data;
        }
    }
}