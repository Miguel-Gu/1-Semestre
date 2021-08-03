using System;

namespace projeto24.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoDeBarras;

        Random r = new Random();

        public void Registar(){
            CodigoDeBarras = r.Next(3000000).ToString();

            Console.WriteLine($"Boleto gerado com o código {CodigoDeBarras}");
            Console.WriteLine($"Boleto registrado, o valor com desconto agora é de {this.Valor * 0.88:C2}");
        }
    }
}