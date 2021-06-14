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

            //  opções_de_ações_no_estoque___________________________________________________
            //  |                                                                            |
            //  | x = 1 (mostra primeiro estoque  )     x = 2 (adiciona um item ao estoque)  |
            //  | x = 3 (retira um item do estoque)     x = 4 (mostra o estoque atual     )  |
            //  |____________________________________________________________________________|


            ///2º Mostra estoque ------------------------------------------------------------------
            ///

            int dia = 1;
            while (dia < 7)
            {
                Console.WriteLine("Dia " + dia + "\n");
                if (dia == 1)
                {
                    Console.WriteLine("Estoque Inicial\n");
                    Funcoes.Estoque1(1); Console.WriteLine("\n");
                    Funcoes.Estoque2(1); Console.WriteLine("\n");
                    Funcoes.Estoque3(1); Console.WriteLine("\n");
                    Funcoes.Estoque4(1); Console.WriteLine("\n");
                    Console.WriteLine("---------------------------------------------------------------------");
                }
                
                ///1º Recebe Carga e organizar estoque -------------------------------------------------
                ///

                Console.WriteLine("\nEntradas de produtos (por carga)\n");
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
                        else if (item == "2")
                        {
                            Funcoes.Estoque2(2);
                        }
                        else if (item == "3")
                        {
                            Funcoes.Estoque3(2);
                        }
                        else
                        {
                            Funcoes.Estoque4(2);
                        }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");

                Console.WriteLine("Estoque após recebmento de todas as cargas \n");

                Funcoes.Estoque1(4); Console.WriteLine("\n");
                Funcoes.Estoque2(4); Console.WriteLine("\n");
                Funcoes.Estoque3(4); Console.WriteLine("\n");
                Funcoes.Estoque4(4); Console.WriteLine("\n");

                Console.WriteLine("Número de cargas despachadas: " + cargasIn + "\n");
                Console.WriteLine("---------------------------------------------------------------------");
                ///3º Envia carga ---------------------------------------------------------------------
                ///
                int cargasOut = Geradores.Qtd();
                Console.WriteLine("\nSaida de produtos (por carga)\n");
                for (int i = 0; i < cargasOut; i++)
                {
                    string saida = Geradores.OrdemDeServico();
                    Console.WriteLine(saida);
                    foreach (var item in saida)
                    {
                        if (item == '1')
                        {
                            Funcoes.Estoque1(3);
                        }
                        else if (item == '2')
                        {
                            Funcoes.Estoque2(3);
                        }
                        else if (item == '3')
                        {
                            Funcoes.Estoque3(3);
                        }
                        else
                        {
                            Funcoes.Estoque4(3);
                        }
                    }
                }
                Console.WriteLine();
                
                ///4º Mostra estoque atualizado ------------------------------------------------------
                ///
                Console.WriteLine("\nEstoque após envio de todas as cargas \n");

                Funcoes.Estoque1(4); Console.WriteLine("\n");
                Funcoes.Estoque2(4); Console.WriteLine("\n");
                Funcoes.Estoque3(4); Console.WriteLine("\n");
                Funcoes.Estoque4(4); Console.WriteLine("\n");

                Console.WriteLine("Número de cargas despachadas: " + cargasOut + "\n");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("\n\nfim do dia Dia " + dia + "\n");
                dia++;
                Console.WriteLine("\nPressione 'Enter' para Prossegir...\n");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.ReadKey();
            }
            Console.WriteLine("\nFim da Semana");
        }
    }
}



//    Após isso, coloque todos esses elementos em um vetor de inteiros para envio, 
//    caso a empresa não tenha algum dos elementosem estoque para fazer a entrega, 
//    deve-se preencher o que der e o que faltar ignora-se ex:string ordemDeServico = “11111111”; 

//    estoque: 
//    1 1 1 1 0 0
//    0 0 0 0 0 0
//    0 0 0 0 0 0
//    0 0 0 0 0 0
//    0 0 0 0 0 0
//    0 0 0 0 0 0

//    Nesse caso faltam quatro 1 para preencher o vetor, mas o vetor final deve ficar assim :
//    vetor[0] = 1,vetor[1] = 1,vetor[2] = 1,vetor[3] = 1,vetor[4] = 0,vetor[5] = 0,vetor[6] = 0, vetor[7] = 0

//    Evite ao máximo criar vetores de tamanho desnecessário, como no caso acima que um vetor de 6 elementos daria conta 
//   (lembre que os vetores tem 6 ou 8 ou 10 elementos)
