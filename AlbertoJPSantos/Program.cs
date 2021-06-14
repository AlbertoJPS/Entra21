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

            ///2º Mostra estoque 
            ///
            Console.WriteLine("Estoque\n");
            Funcoes.Estoque1(1); Console.WriteLine("\n");
            //Funcoes.Matriz2(0); Console.WriteLine("\n");
            //Funcoes.Matriz3(0); Console.WriteLine("\n");
            //Funcoes.Matriz4(0); Console.WriteLine("\n");

            ///1º Recebe Carga e organiza estoque
            ///

            
            Console.WriteLine("\nEntradas de produtos");
            int cargasIn = Geradores.Qtd();
            List<string> entradas = new List<string>();
            for (int i = 0; i < cargasIn; i++)
            {
                entradas = Geradores.GeraEntrada();
                foreach (var item in entradas)
                {
                    Console.Write(item);

                    if (item == "1")
                    {
                        Funcoes.Estoque1(2);
                    }
                    //    else if (iten == "2")
                    //    {
                    //        Funcoes.Adiciona(2);
                    //    }
                    //    else if (iten == "3")
                    //    {
                    //        Funcoes.Adiciona(3);
                    //    }
                    //    else
                    //    {
                    //        Funcoes.Adiciona(4);
                    //    }

                    //como cada numero vem separadamente, preciso colocar a condicional aqui direto para que vá direto para
                    //estoque na matriz.. 
                    //}
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /// mostra matriz
            /// 
            Funcoes.Estoque1(4); 


            ///3º Envia carga
            ///
            Console.WriteLine("\n");
            int cargasOut = Geradores.Qtd();
            Console.WriteLine("\nSaida de produtos");
            for (int i = 0; i < cargasOut; i++)
            {
                string saida = Geradores.OrdemDeServico();
                foreach(var item in saida)
                {
                    Console.WriteLine(saida);
                    if (item == '1')
                    {
                        Funcoes.Estoque1(3);
                    }

                }
           




            }
            
            // fazer um vetor que receberá o tamanho do int sida e obter o valor de cada posição

            ///4º Mostra estoque atualizado
            ///

            Console.WriteLine("\n\nPressione 'Enter' para Prossegir...");
            Console.ReadKey();

        }
    }
}
