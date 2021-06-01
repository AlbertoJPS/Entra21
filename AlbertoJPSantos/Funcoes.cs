using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertoJPSantos
{
    public static class Funcoes
    {
        
        public static int[][] matriz = new int[6][];

        public static void Matriz1()
        {
           // int[][] matriz = new int[6][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[6];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = i + j;

                    if (i < 3)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Matriz2()
        {
            //int[][] matriz = new int[6][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[6];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = i + j;

                    if (i < 3)
                    {
                        Console.Write(2);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Matriz3()
        {
            //int[][] matriz = new int[6][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[6];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = i + j;

                    if (i < 3)
                    {
                        Console.Write(3);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Matriz4()
        {
            //int[][] matriz = new int[6][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[6];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = i + j;

                    if (i < 3)
                    {
                        Console.Write(4);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
        }
        public static void TodasMatrizes()
        {
            Console.WriteLine("\n");
            Matriz1(); Console.WriteLine("\n");
            Matriz2(); Console.WriteLine("\n");
            Matriz3(); Console.WriteLine("\n");
            Matriz4(); Console.WriteLine("\n");
        }
        public static void Adiciona(int id)
        {
            //int[][] matriz = new int[6][];
           
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (matriz[i][j] == 0 && id == 1)
                    { 
                        Console.Write(1);
                    }
                    else if (matriz[i][j] == 0 && id == 2)
                    {
                        Console.Write(2);
                    }
                    else if (matriz[i][j] == 0 && id == 3)
                    {
                        Console.Write(3);
                    }
                    else if (matriz[i][j] == 0 && id == 4)
                    {
                        Console.Write(4);
                    }
                }
            }
        }
    }
        // achar um modo de fazer a condicional do Adicionar localizar a matriz especifica a ser mudada
        // descobrir qual propriedade poderia ser adicionada, e se deixaria o tipo como void
        //fazer uma função que varre a matriz a procura de um 0 e da break assim q acha, se n achar, fazer o discarte

}
            // 0.0 0.1 0.2 0.3 0.4 0.5 
            // 1.0 1.1 1.2 1.3 1.4 1.5 
            // 2.0 2.1 2.2 2.3 2.4 2.5 
            // 3.0 3.1 3.2 3.3 3.4 3.5 
            // 4.0 4.1 4.2 4.3 4.4 4.5 
            // 5.0 5.1 5.2 5.3 5.4 5.5