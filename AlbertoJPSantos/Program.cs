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

            Console.WriteLine("Cargas");
            int[] cargas = new int[Geradores.Qtd()];
            Console.WriteLine(cargas.Length);

            Console.WriteLine("\nEntradas de produtos");
            List<string> entradas = new List<string>();
            int item = 0;

            for (int i = 0; i < cargas.Length; i++)
            {
                entradas = Geradores.GeraEntrada();

                foreach (var iten in entradas)
                {
                    Console.Write(iten);
                    item = Convert.ToInt32(iten);
                }
                Console.WriteLine();
            }
            
            ///2º Mostra estoque
            ///

            Funcoes.Matriz();

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
