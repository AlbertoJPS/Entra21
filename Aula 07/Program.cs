using System;

namespace Aula_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //    // exc 01

            //    Program prog = new();
            //    int entrada1, entrada2, resultado;
            //    Console.WriteLine("Insira 2 números");
            //    entrada1 = Convert.ToInt32(Console.ReadLine());
            //    entrada2 = Convert.ToInt32(Console.ReadLine());
            //    resultado = prog.Compara(entrada1, entrada2);
            //    Console.WriteLine();
            //    Console.WriteLine(resultado);

            //}
            //

            //exc 02

            //Program prog = new();
            //Console.WriteLine("Insira 1 número");
            //int x = prog.CRI();
            //x = prog.ParOuImpar(x);
            //Console.WriteLine(x);

            // exc 03

            // exc 04

            //Program prog = new();
            //Console.WriteLine("Insira os Graus em Celsius:");
            //double fx = prog.CToF(0);
            //Console.WriteLine("O resultado da conversão em Fahrenheit é:");
            //Console.WriteLine(fx + " °F");
            //Console.WriteLine();

            // exc 05

            //Program prog = new();
            //Console.WriteLine("Insira suas 3 notas:");
            //double n1 = prog.CRD();
            //double n2 = prog.CRD();
            //double n3 = prog.CRD();
            //Console.WriteLine("\nQual operação deseja fazer? \n  A - Média\n  P - Média Ponderada\n  M - Nota mediana\n");
            //string escolha = prog.CR();
            //double retorno = prog.Escola(n1, n2, n3, escolha);
            //if (retorno == -1)
            //{
            //    Console.WriteLine("\nDeu Ruim, opção inválida");
            //}
            //else
            //{
            //    Console.WriteLine("\n" + retorno);
            //}

            //exc 06

            //exc 07

            //exc 08

            // Program prog = new Program();
            // Console.WriteLine("Insira o tamanho do vetor:");
            // Console.WriteLine();
            // int tamanho = prog.CRI();
            // int[] numeros = new int[tamanho];
            // for (int i = 0; i < numeros.Length; i++)
            // {
            //     numeros[i] = prog.CRI();
            // }
            //// Array.Sort(numeros);    -   alternativa para Sort
            // numeros = prog.SortManual(numeros);
            // for(int i = 0; i < numeros.Length; i++)
            // {
            //     Console.WriteLine(numeros);
            // }

        }


        // Funções
        public int ParOuImpar(int entrada)
        {
            if (entrada % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int Compara(int x, int y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }

        }
        public string CR()
        {
            return Console.ReadLine();
        }
        public char CRC()
        {
            return Convert.ToChar(CR());
        }
        public int CRI()
        {
            return Convert.ToInt32(CR());
        }
        public double CRD()
        {
            return Convert.ToDouble(CR());
        }
        public double CToF(double f)
        {
            double c = CRD();
            f = (c * 9 / 5) + 32;
            return f;
        }
        public int[] SortManual(int[] vetor)
        {
            for(int i = 0; i < vetor.Length; i++)
            {
                for (int j = i; j > 0 ; j++)
                {
                    if(vetor[j - 1] > vetor[j])
                    {
                        int temp = vetor[j];
                        vetor[j] = vetor[j - 1];
                        vetor[j - 1] = temp;
                    }
                }
            }
            return vetor;
        }
        public double Escola(double n1, double n2, double n3, string escolha5)
        {
            double resultado = 0;

            switch (escolha5)
            {
                case "A": // média
                case "a":
                    resultado = n1 + n2 + n3 / 3;
                    return resultado;
                case "P": // ponderação
                case "p":
                    resultado = (n1 * 5 + n2 * 3 + n3 * 2) / (5 + 3 + 2);
                    return resultado;
                case "M": // nota mediana
                case "m":
                    double[] notas = new double[3];
                    notas[1] = n1;
                    notas[2] = n2;
                    notas[3] = n3;
                    Array.Sort(notas);
                    resultado = notas[1];
                    return resultado;
                default:
                    return -1;
            }
        }
    } 
}
