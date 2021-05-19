using System;

namespace AulaPOOCelular
{
    public class celular
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;
        public bool ligar()
        {
            ligado = true;
            return ligado == true;
        }
        public bool desligar()
        {
            ligado = false;
            return ligado == false;
        }
        public void fazerLigacao()
        {
            string contato;
            Console.WriteLine($@"
         ====================
        ======================
        |                    | 
        |Pra quem você deseja| 
        |     telefonar?     | 
        |                    | 
        |     Contato: ...   | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        ======================
         ====================
                    ");
            contato = Console.ReadLine();
            Console.WriteLine($@"
         ====================
        ======================
        |                    | 
        |  Ligando para...   | 
        |                    | 
        |                    | 
        |    {contato}       | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        ======================
         ====================
                    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"
         ====================
        ======================
        |                    | 
        |  Chamada encerrada | 
        |   0hr 0min 0 seg   | 
        |                    | 
        |    {contato}       | 
        |    não atendeu :(  | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        ======================
         ====================
                    ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void enviarMensagem()
        {
            string destinatario;
            string mensagem;
            Console.WriteLine($@"
         ====================
        ======================
        |                    | 
        |Pra quem você deseja| 
        |enviar uma mensagem?| 
        |                    | 
        |  Destinatário: ... | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        ======================
         ====================
                    ");
            destinatario = Console.ReadLine();
            Console.WriteLine($@"
         ====================
        ======================
        |                    | 
        | Qual é a mensagem? | 
        |                    | 
        |                    | 
        |  Dt: {destinatario}| 
        |                    | 
        |  Mensagem: ...     | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        ======================
         ====================
                    ");
            mensagem = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@"
         ====================
        ====================== 
        |                    | 
        |  Dt: {destinatario}| 
        |                    | 
        |  Msg: {mensagem}   | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |      Mensagem      | 
        |      Enviada!      | 
        |                    | 
        ======================
         ====================
                    ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void consultarConfigurações()
        {
            Console.WriteLine($@"
         ====================
        ======================
        |                    | 
        |     Informações    | 
        |Cor: {cor}          | 
        |                    | 
        |Modelo: {modelo}    | 
        |                    | 
        |Tamanho: {tamanho}  | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        ======================
         ====================
                    ");
        }
    }
}