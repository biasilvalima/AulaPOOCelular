using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
           Celular iphone = new Celular();
           iphone.nome = "iPHONE";
           iphone.cor = "cinza";
           iphone.modelo = "Iphone 8 plus";
           iphone.tamanho = 158f ;
           iphone.ligado = true;
           iphone.desligar = false;

           if(iphone.ligado==true){
               Console.WriteLine(iphone.EnviarMensagem());
           Console.WriteLine(iphone.MensagemRecebida());
           }else{
               Console.WriteLine(iphone.MensagemNaoEnviada());
           }
        }
    }
}





