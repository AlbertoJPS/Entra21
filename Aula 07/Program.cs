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

            Program prog = new();
            Console.WriteLine("Insira suas 3 notas:");
            double n1 = prog.CRD();
            double n2 = prog.CRD();
            double n3 = prog.CRD();
            /*prog.Media() = */ 

            Console.WriteLine("\nQual operação deseja fazer? \n  M - Média\n  P - Média Ponderada\n  M - Nota mediana\n");

            char escolha5 = prog.CRC();
            
            Media(n1, n2, n3, escolha5);

            
            switch (escolha5)
            {
                case 'a': // média
                    x = prog.Media(media);
                    Console.WriteLine("Sua média é: " + x);
                    break;
                case 'p': // ponderação
                    x = prog.MPonderada(mPonderada);
                    Console.WriteLine("Sua média ponderada é: " + x);
                    break; 
                case 'm': // nota mediana
                    x = prog.NMediana(nMediana);
                    Console.WriteLine("Sua nota mediana é: " +  x);
                    break;

            }
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
            return Convert.ToChar(Console.ReadLine());
        }
        public int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public double CRD()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public double CToF(double f)
        {
            double c = CRD();
            f = (c * 9 / 5) + 32;
            return f;
        }
       

        public double Media(double media, double mPonderada, double nMediana, double n1, double n2, double n3, char escolha5)
        {
            

            //return media;

            

            //return mPonderada;

            
            switch (escolha5)
            {
                case 'a': // média
                    media = n1 + n2 + n3 / 3;
                    Console.WriteLine("Sua média é: " + media);
                    break;
                case 'p': // ponderação
                    mPonderada = (n1 * 5 + n2 * 3 + n3 * 2) / 5 + 3 + 2;
                    Console.WriteLine("Sua média ponderada é: " + mPonderada);
                    break;
                case 'm': // nota mediana
                    if (n1 < n2 || n1 > n2 && n1 < n3 || n1 > n3)
                    {
                        nMediana = n1;
                    }
                    else if (n2 < n1 || n2 > n1 && n2 < n3 || n2 > n3)
                    {
                        nMediana = n2;
                    }
                    else
                    {
                        nMediana = n3;
                    }
                    //return nMediana;
                    Console.WriteLine("Sua nota mediana é: " + nMediana);
                    break;

            }




        }
        
       
    } 
}
