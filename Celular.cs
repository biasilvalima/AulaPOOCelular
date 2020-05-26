namespace AulaPOOCelular
{
    public class Celular
    {
        public string nome;
        public string cor;
        public float tamanho;
        public string modelo;
        public bool ligado;
        public bool ligar;
        public bool desligar;

        public string EnviarMensagem(){
            return "Olá, bom dia!!!";
        }

        public string MensagemRecebida(){
            return "Bom dia, vamos começar os trabalhos";
        }


    }
}