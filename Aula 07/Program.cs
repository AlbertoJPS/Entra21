using System;

namespace Aula_07
{
    class Program
    {
        static void Main(string[] args)
        {
            ///exc 01

            //Program prog = new();
            //int entrada1, entrada2, resultado;
            //Console.WriteLine("Insira 2 números");
            //entrada1 = Convert.ToInt32(Console.ReadLine());
            //entrada2 = Convert.ToInt32(Console.ReadLine());
            //resultado = prog.Compara(entrada1, entrada2);
            //Console.WriteLine();
            //Console.WriteLine(resultado);
            //}
            //

            ///exc 02

            //Program prog = new();
            //Console.WriteLine("Insira 1 número");
            //int x = prog.CRI();
            //x = prog.ParOuImpar(x);
            //Console.WriteLine(x);

            /// exc 03

            /// exc 04

            //Program prog = new();
            //Console.WriteLine("Insira os Graus em Celsius:");
            //double fx = prog.CToF(0);
            //Console.WriteLine("O resultado da conversão em Fahrenheit é:");
            //Console.WriteLine(fx + " °F");
            //Console.WriteLine();

            /// exc 05

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

            ///exc 06

            //Program prog = new Program();
            //Console.WriteLine("Equação: \n\n   a + b + c\n   _________\n\n     d * e\n\n");
            //Console.WriteLine("Insira os valores de 'a', 'b', e 'c':\n");
            //double valorA = prog.CRD();
            //double valorB = prog.CRD();
            //double valorC = prog.CRD();
            //Console.WriteLine("Agora os valores de 'd', e 'e':\n");
            //double valorD = prog.CRD();
            //double valorE = prog.CRD();
            //double resultado = prog.Formula6(valorA, valorB, valorC, valorD, valorE);
            //Console.WriteLine("\n\nO resultado da equação é:\n" + resultado);


            ///exc 07

            ///exc 08

            //Program prog = new Program();
            //Console.WriteLine("Insira o tamanho do vetor:");
            //Console.WriteLine();
            //int tamanho = prog.CRI();
            //int[] numeros = new int[tamanho];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = prog.CRI();
            //}
            //// Array.Sort(numeros);    -   alternativa para Sort
            //numeros = prog.SortManual(numeros);
            //for(int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros);
            //}

            //---------------------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------------------

            ///exc 001

            //Program prog = new Program();

            //Console.WriteLine("Digite 2 números:\n");
            //int valor1 = prog.CRI();
            //int valor2 = prog.CRI();
            //int resultado = prog.Maior(valor1, valor2);
            //Console.WriteLine("\nO maior numero entre os 2 é o:\n");
            //Console.WriteLine(resultado);
            //Console.WriteLine("Digite mais 1 número\n");
            //int valor3 = prog.CRI();
            //resultado = prog.Maior(resultado, valor3);
            //Console.WriteLine("\nO maior numero entre os 2 é o:\n");
            //Console.WriteLine(resultado);
            //Console.WriteLine("Digite mais 1 número:\n");
            //int valor4 = prog.CRI();
            //resultado = prog.Maior(resultado, valor4);
            //Console.WriteLine("\nO maior numero entre todos os informados é 0:\n");
            //Console.WriteLine(resultado);

            ///exc 002

            //Program prog = new Program();
            //Random ran = new Random();
            //int[] vetor = new int[10];
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    vetor[i] = ran.Next(0, 9 + 1);
            //    Console.Write(vetor[i] + " ");
            //}
            //Console.WriteLine("\n \n");
            //Console.WriteLine("Sr. Usuário, qual elemento deseja ver? 1 à 10");
            //int escolha = prog.CRI();
            //escolha--;
            //int resultado = prog.Vetor10(vetor, escolha);
            //Console.WriteLine(resultado);

            ///exc 003

            ///exc 004

            ///exc 005

            //Program prog = new Program();
            //string[] logins = { "a", "b", "c", "d", "e" };
            //string[] senhas = { "A", "B", "C", "D", "E" };
            //Console.WriteLine("Login");
            //string login = prog.CR();
            //Console.WriteLine("senha");
            //string senha = prog.CR();
            //string resposta = prog.Autentica(logins, senhas, login, senha);
            //Console.WriteLine(resposta);


            ///exc 0001
            ///exc 0002
            ///exc 0003



        }


        // Funções lista 1

        public string CR()
        {
            return Console.ReadLine();
        }
        public int CRI()
        {
            return Convert.ToInt32(CR());
        }
        public double CRD()
        {
            return Convert.ToDouble(CR());
        }
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
        public double CToF(double f)
        {
            double c = CRD();
            f = (c * 9 / 5) + 32;
            return f;
        }
        public double Formula6(double valorA, double valorB, double valorC, double valorD, double valorE)
        {
            double resultado = (valorA + valorB + valorC) / (valorD * valorE);
            return resultado;
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
        public int[] SortManual(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = i; j > 0; j++)
                {
                    if (vetor[j - 1] > vetor[j])
                    {
                        int temp = vetor[j];
                        vetor[j] = vetor[j - 1];
                        vetor[j - 1] = temp;
                    }
                }
            }
            return vetor;
        }

        // Funções lista 2

        public int Maior(int x, int y)
        {
            if (x < y)
            {
                int maior = y;
                return maior;
            }
            else
            {
                int maior = x;
                return maior;
            }

        }
        public int Vetor10(int[] vetor, int n)
        {
            return vetor[n];
        }
        public string Autentica(string[] logins, string[] senhas, string login, string senha)
        {
            for (int i = 0; i < logins.Length; i++)
            {
                if (logins[i] == login && senhas[i] == senha)
                {
                    return "Login Efetuado";
                }
            }
            return "Login Inválido";
        }
    }
}
