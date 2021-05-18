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

            //int[][] matriz = new int[4][];
            //int[][] matrizT = new int[4][];

            //Random rand = new Random();

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //    matrizT[i] = new int[4];

            //}

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = (rand.Next() % 20) + 1;
            //    }

            //}

            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Matriz Original"); Console.WriteLine();

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        if (matriz[i][j] < 10)
            //        {
            //            Console.Write("0" + matriz[i][j]);
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write(matriz[i][j]);
            //            Console.Write(" ");
            //        }


            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.ResetColor();


            //// ----------------------------------------------------------------------
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(); Console.WriteLine();
            //Console.WriteLine("Matriz Transformada"); Console.WriteLine();

            //matrizT = matriz;
            //for (int i = 0; i < matrizT.Length; i++)
            //{
            //    for (int j = 0; j < matrizT[i].Length; j++)
            //    {
            //        if (i < j)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            matrizT[i][j] = 0;
            //        }

            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Green;
            //        }

            //        if (matrizT[i][j] < 10)
            //        {
            //            Console.Write("0" + matrizT[i][j]);
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write(matrizT[i][j]);
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ResetColor(); Console.WriteLine();


            //// exc 10

            //////int[][] matriz = new int[5][];
            //////Random rand = new();

            //////for (int i = 0; i < matriz.Length; i++)
            //////{
            //////    matriz[i] = new int[5];
            //////}

            //////Console.ForegroundColor = ConsoleColor.Yellow;
            //////Console.WriteLine("!!! Bingo !!! ");Console.WriteLine();

            //////for (int i = 0; i < matriz.Length; i++)
            //////{
            //////    for (int j = 0; j < matriz[i].Length; j++)
            //////    {
            //////        matriz[i][j] = (rand.Next() % 99) + 1;
            //-------------------------------------------------------------------------------
            //////        if (matriz[i][j] == matriz[i][j])
            //////        {
            //////            matriz[i][j] = (rand.Next() % 99) + 1;
            //////            if (matriz[i][j] < 10 || matriz[i][j] != matriz[i][j])
            //////            {
            //////                Console.Write("0" + matriz[i][j]);
            //////                Console.Write(" ");
            //////            }
            //////            else
            //////            {
            //////                Console.Write(matriz[i][j]);
            //////                Console.Write(" ");
            //////            }
            //////        }
            //////        else
            //////        {
            //////            if (matriz[i][j] < 10)
            //////            {
            //////                Console.Write("0" + matriz[i][j]);
            //////                Console.Write(" ");
            //////            }
            //////            else
            //////            {
            //////                Console.Write(matriz[i][j]);
            //////                Console.Write(" ");
            //////            }
            //////        }
            /////------------------------------------------------------------------------------
            //////    }
            //////    Console.WriteLine();
            //////}
            //////Console.ResetColor();


            // exc 001


            //int[][] matriz = new int[3][];
            //int[] vetor = new int[3];

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[3];
            //    vetor[i] = 0;
            //}
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Digite os Valores da Matriz:"); Console.WriteLine();

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.Clear();
            //    Console.WriteLine("Digite os Valores da Matriz:"); Console.WriteLine();
            //}

            ////-----------------------

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        Console.Write(matriz[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(); 

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    for (int j = 0; j < matriz[i].Length; j++)
            //    {
            //        vetor[j] += matriz[i][j];
            //    }
            //   // Console.Write(vetor[i] + " ");
            //}
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    Console.Write(vetor[i] + " ");

            //}
            //Console.ResetColor(); Console.WriteLine();

            // exc 002

            //int[][] matriz = new int[5][];

            //for (int i = 0; i < matriz.Length; i++)
            //{
            //    matriz[i] = new int[4];
            //}

            ////a

            //for (int i = 0; i < matriz.Length; i++)
            //{

            //    for (int j = 0; j < matriz[i].Length - 1; j++)
            //    {
            //        if (j == 0)
            //        {
            //            Console.WriteLine("Qual a matricula do " + (i + 1) + "º aluno");
            //            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //        else if (j ==1 )
            //        {
            //            Console.WriteLine("Qual a nota das provas do " + (i + 1) + "º aluno");
            //            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //        else
            //        {
            //            Console.WriteLine("Qual a nota dos trabalhos do " + (i + 1) + "º aluno");
            //            matriz[i][j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }

            ////b

            //    Console.WriteLine(); Console.WriteLine();
            //    matriz[i][matriz[i].Length - 1] = matriz[i][1] + matriz[i][2];
            //}

            ////c

            //int notaFinal = -1, valorNotaFinal = -1;

            //for(int i = 0; i <matriz.Length; i++)
            //{
            //    if (matriz[i][3] > valorNotaFinal)
            //    {
            //        valorNotaFinal = matriz[i][3];
            //        notaFinal = i;
            //    }
            //}
            //Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine();
            //Console.WriteLine("O aluno com a nota maior é o de matrícula:");
            //Console.WriteLine(matriz[notaFinal][0]);

            ////d

            //int mediaFinal = 0;
            //for(int i = 0; i <matriz.Length; i++)
            //{
            //    mediaFinal += matriz[i][3];
            //}
            //Console.WriteLine();
            //Console.WriteLine("A média final de todos os alunos é:");
            //Console.WriteLine(mediaFinal / matriz.Length);

            //Console.ResetColor();

            // exc 003

            double[][] matriz = new double[3][];
            double[] soma = new double[1];

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new double[6];
            }

            //a


            for (int i = 0; i < matriz.Length; i++)
            {

                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = i + j;

                    Console.Write(matriz[i][j] + " ");

                    //if (matriz[i][j] != matriz[i][j] % 2)
                    // {
                    //     soma[i] += matriz[i][j];
                    // }

                }
                Console.WriteLine();
                Console.WriteLine("");
                // Console.Write(soma[i] + " ");
            }





            // exc 004

            //int[][] matrizA = new int[3][];
            //int[][] matrizB = new int[3][];
            //int[][] matrizFinal = new int[3][];
            //Random rand = new();

            //for (int i = 0; i < matrizA.Length; i++)
            //{
            //    matrizA[i] = new int[3];
            //}

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Matriz A"); Console.WriteLine();

            //for (int i = 0; i < matrizA.Length; i++)
            //{
            //    for (int j = 0; j < matrizA[i].Length; j++)
            //    {
            //        matrizA[i][j] = (rand.Next() % 9) + 1;
            //        Console.Write(matrizA[i][j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ResetColor(); Console.WriteLine();

            //// ---------------------------------------------------------

            //for (int i = 0; i < matrizB.Length; i++)
            //{
            //    matrizB[i] = new int[3];
            //}

            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Matriz B"); Console.WriteLine();

            //for (int i = 0; i < matrizB.Length; i++)
            //{
            //    for (int j = 0; j < matrizB[i].Length; j++)
            //    {
            //        matrizB[i][j] = (rand.Next() % 9) + 1;
            //        Console.Write(matrizB[i][j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ResetColor(); Console.WriteLine();

            //// ----------------------------------------------------------

            //for (int i = 0; i < matrizFinal.Length; i++)
            //{
            //    matrizFinal[i] = new int[3];
            //}

            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("A Soma da Matrizes Resulta na Matriz Final"); Console.WriteLine();

            //for (int i = 0; i < matrizFinal.Length; i++)
            //{
            //    for (int j = 0; j < matrizFinal[i].Length; j++)
            //    {
            //        matrizFinal[i][j] = matrizA[i][j] + matrizB[i][j];

            //        if (matrizFinal[i][j] < 10)
            //        {
            //            Console.Write("0" + matrizFinal[i][j]);
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write(matrizFinal[i][j]);
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ResetColor(); Console.WriteLine();
        }

    }
}
