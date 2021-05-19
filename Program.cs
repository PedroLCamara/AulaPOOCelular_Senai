using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            bool celular = true;
            bool resposta_correta = false;
            celular celular1 = new celular();
            celular1.modelo = "Xiaomi - Redmi Note 8";
            celular1.cor = "Preto";
            celular1.tamanho = "7,5 x 16cm";
            celular1.ligado = false;
            do
            {
                while(celular1.ligado==false && celular== true){
                do
                {
                    Console.WriteLine($@"
         ====================
        ======================
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |       Ligar?       | 
        |      1- Sim        | 
        |      2- Não        | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        ======================
         ====================
                    ");
                    resposta = Console.ReadLine();
                    if (resposta == "1")
                    {
                        celular1.ligar();
                        resposta_correta = true;
                    }
                    else if (resposta == "2")
                    {
                        Console.WriteLine("Certo, desligando...");
                        celular= false;
                        resposta_correta = true;
                    }
                    else
                    {
                        Console.WriteLine("Erro 001: Resposta inválida, digite '1' para ligar e '2' para não ligar.");
                        resposta_correta = false;
                        Console.WriteLine();
                    }
                } while (resposta_correta == false);
                }
                while (celular1.ligado == true && celular== true)
                {
                    Console.WriteLine($@"
         ====================
        ======================
        |                    | 
        |                    | 
        |                    | 
        |                    | 
        |O que deseja fazer? | 
        |1-Exibir informações| 
        |do aparelho         | 
        |2- Fazer ligação    | 
        |3- Enviar mensagem  | 
        |4- Desligar         | 
        |                    | 
        |                    | 
        |                    | 
        ======================
         ====================
                    ");
                    resposta = Console.ReadLine();
                    if (resposta=="1")
                    {
                        celular1.consultarConfigurações();
                    }
                    else if (resposta=="2")
                    {
                        celular1.fazerLigacao();
                    }
                    else if (resposta=="3")
                    {
                        celular1.enviarMensagem();
                    }
                    else if (resposta=="4")
                    {
                        celular1.desligar();
                    }
                    else
                    {
                       Console.WriteLine("Erro 001: Resposta inválida, digite '1' para exibir informações, '2' fazer uma ligação, '3' para enviar uma mensagem e '4' para desligar o aparelho");
                        Console.WriteLine(); 
                    }
                }
            } while (celular == true);
        }
    }
}
