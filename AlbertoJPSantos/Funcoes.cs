using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertoJPSantos
{
    public static class Funcoes
    {
        
        //public static int[][] matriz = new int[6][];

        public static void Matriz1(int x)
        {
            int[][] matriz1 = new int[6][];

            for (int i = 0; i < matriz1.Length; i++)
            {
                matriz1[i] = new int[6];

            }
            for (int i = 0; i < matriz1.Length; i++)
            {
                for (int j = 0; j < matriz1[i].Length; j++)
                {
                    matriz1[i][j] = i + j;

                    // x = 0 (primeiro estoque) 
                    // x = 1 (não faz nada no estoque) 
                    // x = 2 (adiciona um item ao estoque) 
                    // x = 3 (retira um item do estoque)

                    // o laço a seguir fará com que a adição de metade do estoque, ocorra uma unica vez
                    while (x == 0)
                    {
                        if (i < 3)
                        {
                            Console.Write(1);
                            break;
                        }
                        else if (i >= 3)
                        {
                            Console.Write(0);
                            break;
                        }
                        else if (i == 5 && j == 5)
                        {
                            x = 1;
                            //break;
                        }
                    }
                    //vai adicionar um item ao estoque
                    while (x == 2)
                    {
                        if (matriz1[i][j] == 0)
                        {
                            Console.Write(1);
                            x = 1;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Matriz2()
        {
            int[][] matriz = new int[6][];
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
            int[][] matriz = new int[6][];
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
            int[][] matriz = new int[6][];
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