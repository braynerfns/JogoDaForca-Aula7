using System;

namespace Jogo_da_Forca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = new string[10];
            valores[0] = "kazaquistao";
            valores[1] = "suriname";
            valores[2] = "hungria";
            valores[3] = "botsuana";
            valores[4] = "tuvualu";
            valores[5] = "sudao";
            valores[6] = "letonia";
            valores[7] = "madagascar";
            valores[8] = "andorra";
            valores[9] = "bahrein";

            Random rand = new Random();
            int indice = rand.Next(0, 10);
            string valorGeradoIA = valores[indice];
            char[] palavraAux = new char[valorGeradoIA.Length];
            char letra;
            int tentativas = 0;
            int maximoTentativas = 11;

            for (int i = 0; i < valorGeradoIA.Length; i++)
            {
                palavraAux[i] = '*';
            }
            while (tentativas < maximoTentativas)
            {
                Console.WriteLine("Estou pensando em um pais adivinhe...");
                Console.WriteLine(palavraAux);
                letra = Console.ReadLine()[0];
                for (int i = 0; i < valorGeradoIA.Length; i++)
                {
                    if (letra == valorGeradoIA[i] && letra != palavraAux[i])
                    {
                        palavraAux[i] = letra;
                        tentativas--;
                    }
                }

                tentativas++;
                if (checkWin())
                {
                    tentativas = maximoTentativas;
                    Console.WriteLine(palavraAux);
                }
            }

            for (int i = 0; i < palavraAux.Length; i++)
            {
                if (palavraAux[i] == '*')
                {
                    Console.WriteLine("Vc perdeu! A resposta era: " + valorGeradoIA);
                    return;
                }
            }
            Console.WriteLine("Boa vc ganhou!");
            bool checkWin()

            {

                for (int i = 0; i < palavraAux.Length; i++)
                {
                    if (palavraAux[i] == '*')
                    {
                        return false;
                    }

                }
                return true;
            }
        }





    }
}