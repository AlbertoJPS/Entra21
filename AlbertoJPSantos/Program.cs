using System;
using System.Collections.Generic;

namespace AlbertoJPSantos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva seus códigos Aqui;)
            //Nome: Alberto José Pereira dos Santos

            ///1º Recebe Carga e organiza estoque
            ///

            int cargas = Geradores.Qtd();
            Console.WriteLine("\nEntradas de produtos");

            List<string> entradas = new List<string>();
            int item = 0;
            for (int i = 0; i < cargas; i++)
            {
                entradas = Geradores.GeraEntrada();
                foreach (var iten in entradas)
                {
                    Console.Write(iten);

                    if(iten == "1")
                    {
                        Funcoes.Adiciona(1);
                    }
                    else if(iten == "2")
                    {
                        Funcoes.Adiciona(2);
                    }
                    else if(iten == "3")
                    {
                        Funcoes.Adiciona(3);
                    }
                    else
                    {
                        Funcoes.Adiciona(4);
                    }

                    //como cada numero vem separadamente, preciso colocar a condicional aqui direto para que vá direto para
                    //estoque na matriz.. 
                }
            }

            ///2º Mostra estoque
            ///

            Funcoes.TodasMatrizes();

            ///3º Envia carga
            ///

            Console.WriteLine("\nSaida de produtos");
            string saida = Geradores.OrdemDeServico();
            Console.WriteLine(saida);

            // fazer um vetor que receberá o tamanho do int sida e obter o valor de cada posição

            ///4º Mostra estoque atualizado
            ///

            Console.WriteLine("\n\nPressione 'Enter' para Prossegir...");
            Console.ReadKey();

        }
    }
}
