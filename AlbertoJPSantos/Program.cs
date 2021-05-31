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

            Console.WriteLine("cargas");
            int cargas = Geradores.Qtd();
            Console.WriteLine(cargas);


            Console.WriteLine("\nentradas de produtos");
            List<string> entradas = new List<string>();
            for (int i = 0; i < cargas; i++)
            {
                entradas = Geradores.GeraEntrada();

                foreach (var iten in entradas)
                {
                    Console.Write(iten);
                }
            }
            

            Console.WriteLine("\n\nestoque");
            Funcoes.Matriz();


            Console.WriteLine("\nsaida de produtos");
            string saida = Geradores.OrdemDeServico();
            Console.WriteLine(saida);
            
        }
    }
}
