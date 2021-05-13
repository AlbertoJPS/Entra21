using System;
using System.Collections.Generic;

namespace Aula_05
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //exc 06

            //string[] nomes = new string[4];
            //string[] cpf = new string[4];
            //int[] idade = new int[4];

            //while (true)
            //{


            //    for (int i = 0; i < nomes.Length; i++)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("Aluno : " + (i + 1));
            //        Console.WriteLine("Nome : " + nomes[i]);
            //        Console.WriteLine("Cpf : " + cpf[i]);
            //        Console.WriteLine("Idade : " + idade[i]);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine("Qual aluno deseja preecher");
            //    int escolha = Convert.ToInt32(Console.ReadLine())/*-1*/;
            //    // escolha--;
            //    Console.WriteLine("Insira o nome:");
            //    nomes[escolha - 1] = Console.ReadLine();
            //    Console.WriteLine("Insira o cpf:");
            //    cpf[escolha - 1] = Console.ReadLine();
            //    Console.WriteLine("Insira a idade:");
            //    idade[escolha - 1] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();
            //    Console.WriteLine("Deseja sair?\n1 - sim | 2 - não");
            //    escolha = Convert.ToInt32(Console.ReadLine());
            //    if (escolha == 1)
            //    {
            //        break;
            //    }

            //}


            //exc 001

            //int[] vetor1 = new int[5];
            //int[] vetor2 = new int[5];
            //int[] vetorSoma = new int[5];

            //for (int i = 0; i < vetor1.Length; i++)
            //{
            //    Console.WriteLine("Digite o primeiro valor: ");
            //    vetor1[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();
            //    Console.WriteLine("Digite do segundo valor: ");
            //    vetor2[i] = Convert.ToInt32(Console.ReadLine());
            //    vetorSoma[i]  = vetor1[i] + vetor2[i];
            //    Console.WriteLine("Resultado da soma n° - " + (i + 1) + " é " + vetorSoma[i]);
            //    Console.WriteLine();

            //}

            //exc 002

            //    string[] produtos = new string[5];
            //    int[] compra = new int[10];


            //Console.WriteLine("Produtos");
            //    Console.WriteLine();
            //    Console.WriteLine("Cuca    - 10 Reais");
            //    Console.WriteLine("Pão     - 1  Real");
            //    Console.WriteLine("Pastel  - 5  Reais");
            //    Console.WriteLine("Coxinha - 4  Reais");
            //    Console.WriteLine("Bolo    - 35 Reais");
            //    Console.WriteLine();
            //    Console.WriteLine("*c - Para consultar do valor total da compra*");
            //    Console.WriteLine("*s - Para finalizar compra*");
            //    Console.WriteLine("vvvvvvvvvvvvvvvv");
            //    Console.WriteLine();


            //    for (int i = 0; i < compra.Length; i++)
            //    {

            //        Console.WriteLine();
            //        Console.WriteLine("Carrinho de Compras");
            //        for (int b = 0; b < compra.Length; b++)
            //        {
            //            produtos[i] = "--";
            //            if (produtos[i] != "--")
            //            { 
            //            Console.WriteLine(produtos[i]);
            //            }
            //        }
            //        Console.WriteLine("Qual produto deseja comprar?");
            //        string escolha = Console.ReadLine();
            //        escolha = escolha.ToLower();
            //        switch(escolha)
            //        {
            //            case "cuca":
            //                compra[i] += 10;
            //                produtos[i] = "Cuca    - 10 Reais";
            //                break;
            //            case "pao":
            //            case "pão":
            //                compra[i] += 1;
            //                produtos[i] = "Pão     - 1  Real";
            //                break;
            //            case "pastel":
            //                compra[i] += 5;
            //                produtos[i] = "Pastel  - 5  Reais";
            //                break;
            //            case "coxinha":
            //                compra[i] += 4;
            //                produtos[i] = "Coxinha - 4  Reais";
            //                break;
            //            case "bolo":
            //                compra[i] += 35;
            //                produtos[i] = "Bolo    - 35 Reais";
            //                break;
            //            case "c":
            //                Console.WriteLine(compra[i]);
            //                i--;
            //                break;
            //            case "s":

            //                break;
            //            default:
            //                i--;
            //                Console.WriteLine("Produto não encontrado");
            //                break;
            //       }

            //    }

            // exc 07

            //int[][] matriz = new int[3][];
            //int valorFinal = 0;

            //for (int i = 0; i < matriz.Length; i ++)
            //{
            //    matriz[i] = new int[3];
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = i + j;

            //        if (i < j)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            valorFinal += matriz[i][j];
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green; 
            //        }

            //        Console.Write(i + "" + j);
            //        Console.Write(" ");

            //    }
            //    Console.ResetColor();
            //    Console.WriteLine();

            //}

            //Console.WriteLine();
            //Console.Write("O valor da soma acima da diagonal é: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(valorFinal);
            //Console.ResetColor();

            //exc 08

            //int[][] matriz = new int[3][];
            //int valorFinal = 0;

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = i + j;

            //        if (i > j)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            valorFinal += matriz[i][j];
            //        }
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //        }

            //        Console.Write(i + "" + j);
            //        Console.Write(" ");

            //    }
            //    Console.ResetColor();
            //    Console.WriteLine();

            //}

            //Console.WriteLine();
            //Console.Write("O valor da soma acima da diagonal é: ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(valorFinal);
            //Console.ResetColor();

            //exc 09

            int[][] matriz = new int[4][];

            Random rand = new Random();

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[4];
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Matriz Transformada");Console.WriteLine();

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = (rand.Next() % 20) + 1;

                    if (i < j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        matriz[i][j] = 0;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    if (matriz[i][j] < 10)
                    {
                        Console.Write("0" + matriz[i][j]);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(matriz[i][j]);
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ResetColor(); Console.WriteLine();
            // ----------------------------------------------------------------------
            int[][] matrizOrignal = matriz;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Matriz Original");Console.WriteLine();

            for (int i = 0; i < matrizOrignal.Length; i++)
            {
                for (int j = 0; j < matrizOrignal[i].Length; j++)
                {
                    //int[][] matrizOrignal = matriz;

                    //matrizOrignal[i][j] = (rand.Next() % 20) + 1;

                    //if (i < j)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Red;
                    //    matrizOrignal[i][j] = 0;
                    //}

                    //else
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Green;
                    //}

                    if (matrizOrignal[i][j] < 10)
                    {
                        Console.Write("0" + matrizOrignal[i][j]);
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(matrizOrignal[i][j]);
                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ResetColor();




            //// exc 10

            //int[][] matriz = new int[5][];
            //Random rand = new();

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[5];
            //}

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("!!! Bingo !!! ");Console.WriteLine();

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = (rand.Next() % 99) + 1;

            //        if (matriz[i][j] == matriz[i][j])
            //        {
            //            matriz[i][j] = (rand.Next() % 99) + 1;
            //            if (matriz[i][j] < 10 || matriz[i][j] != matriz[i][j])
            //            {
            //                Console.Write("0" + matriz[i][j]);
            //                Console.Write(" ");
            //            }
            //            else
            //            {
            //                Console.Write(matriz[i][j]);
            //                Console.Write(" ");
            //            }
            //        }
            //        else
            //        {
            //            if (matriz[i][j] < 10)
            //            {
            //                Console.Write("0" + matriz[i][j]);
            //                Console.Write(" ");
            //            }
            //            else
            //            {
            //                Console.Write(matriz[i][j]);
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ResetColor();
        }
    }
}
