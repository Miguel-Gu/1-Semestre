namespace AulaPOOCelular
{
    public class Celular
    {
        public string modelo;
        public string cor;
        public int tamanhoCm;
        public bool ligado;
        public bool Ligar(){
            return ligado = true;
        }
        public bool Desligar(){
            return ligado = false;
        }
        public string FazerLigacao(){
            return "LIGAR";
        }
        public string EnviarMensagem(){
            return "MENSAGEM";
        }

    }
}