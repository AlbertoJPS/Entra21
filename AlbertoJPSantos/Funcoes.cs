using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertoJPSantos
{
    public static class Funcoes
    {
        public static int[][] matriz1 = new int[6][];
        public static int[][] Matriz()
        { 
            for (int i = 0; i<matriz1.Length; i++)
            {
                matriz1[i] = new int[6];
            }
            return matriz1;
        }

        //  opções_______________________________________________________________________
        //  |                                                                            |
        //  | x = 1 (cria primeiro estoque    )     x = 2 (adiciona um item ao estoque)  |
        //  | x = 3 (retira um item do estoque)     x = 4 (mostra o estoque atual     )  |
        //  |____________________________________________________________________________|
        
        public static void Estoque1(int x)
        {
            if (x == 1)
            {
                Matriz();
                for (int i = 0; i < matriz1.Length; i++)
                {
                    for (int j = 0; j < matriz1[i].Length; j++)
                    {
                        if (i < 3)
                        {
                            matriz1[i][j] = 1;
                            Console.Write(1);
                        }
                        else if (i >= 3)
                        {
                            matriz1[i][j] = 0;
                            Console.Write(0);
                        }
                    }
                    Console.WriteLine();
                }
            }
            if (x == 2)
            {
                int temp = 0;
                for (int i = 0; i < matriz1.Length; i++)
                {
                    for (int j = 0; j < matriz1[i].Length; j++)
                    {
                        if (matriz1[i][j] == 0)
                        {
                            matriz1[i][j] = 1;
                            temp = 1;
                            break;
                        }
                    }
                    if (temp == 1)
                    {
                        break;
                    }
                }
            }
            if (x == 3)
            {

            }
            if (x == 4)
            {
                for (int i = 0; i < matriz1.Length; i++)
                {
                    for (int j = 0; j < matriz1[i].Length; j++)
                    {
                        Console.Write(matriz1[i][j]);
                        
                    }
                    Console.WriteLine();
                }
            }





        }
        














        //public static void Matriz2(int x)
        //{
        //    int[][] matriz2 = new int[6][];
        //    for (int i = 0; i < matriz2.Length; i++)
        //    {
        //        matriz2[i] = new int[6];

        //    }
        //    for (int i = 0; i < matriz2.Length; i++)
        //    {
        //        for (int j = 0; j < matriz2[i].Length; j++)
        //        {
        //            matriz2[i][j] = i + j;
        //            // o laço a seguir fará com que a adição de metade do estoque, ocorra uma unica vez
        //            while (x == 0)
        //            {
        //                if (i < 3)
        //                {
        //                    Console.Write(2);
        //                    break;
        //                }
        //                else if (i >= 3)
        //                {
        //                    Console.Write(0);
        //                    break;
        //                }
        //                else if (i == 5 && j == 5)
        //                {
        //                    x = 1;
        //                }
        //            }
        //            //vai adicionar um item ao estoque
        //            while (x == 2)
        //            {
        //                if (matriz2[i][j] == 0)
        //                {
        //                    Console.Write(2);
        //                    x = 1;
        //                }
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //public static void Matriz3(int x)
        //{
        //    int[][] matriz3 = new int[6][];
        //    for (int i = 0; i < matriz3.Length; i++)
        //    {
        //        matriz3[i] = new int[6];

        //    }
        //    for (int i = 0; i < matriz3.Length; i++)
        //    {
        //        for (int j = 0; j < matriz3[i].Length; j++)
        //        {
        //            matriz3[i][j] = i + j;
        //            // o laço a seguir fará com que a adição de metade do estoque, ocorra uma unica vez
        //            while (x == 0)
        //            {
        //                if (i < 3)
        //                {
        //                    Console.Write(3);
        //                    break;
        //                }
        //                else if (i >= 3)
        //                {
        //                    Console.Write(0);
        //                    break;
        //                }
        //                else if (i == 5 && j == 5)
        //                {
        //                    x = 1;
        //                }
        //            }
        //            //vai adicionar um item ao estoque
        //            while (x == 2)
        //            {
        //                if (matriz3[i][j] == 0)
        //                {
        //                    Console.Write(3);
        //                    x = 1;
        //                }
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //public static void Matriz4(int x)
        //{
        //    int[][] matriz4 = new int[6][];
        //    for (int i = 0; i < matriz4.Length; i++)
        //    {
        //        matriz4[i] = new int[6];
        //    }
        //    for (int i = 0; i < matriz4.Length; i++)
        //    {
        //        for (int j = 0; j < matriz4[i].Length; j++)
        //        {
        //            matriz4[i][j] = i + j;
        //            // o laço a seguir fará com que a adição de metade do estoque, ocorra uma unica vez
        //            while (x == 0)
        //            {
        //                if (i < 3)
        //                {
        //                    Console.Write(4);
        //                    break;
        //                }
        //                else if (i >= 3)
        //                {
        //                    Console.Write(0);
        //                    break;
        //                }
        //                else if (i == 5 && j == 5)
        //                {
        //                    x = 1;
        //                }
        //            }
        //            //vai adicionar um item ao estoque
        //            while (x == 2)
        //            {
        //                if (matriz4[i][j] == 0)
        //                {
        //                    Console.Write(4);
        //                    x = 1;
        //                }
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}

    }
} 
        // achar um modo de fazer a condicional do Adicionar localizar a matriz especifica a ser mudada
        // descobrir qual propriedade poderia ser adicionada, e se deixaria o tipo como void
        //fazer uma função que varre a matriz a procura de um 0 e da break assim q acha, se n achar, fazer o discarte
            // 0.0 0.1 0.2 0.3 0.4 0.5 
            // 1.0 1.1 1.2 1.3 1.4 1.5 
            // 2.0 2.1 2.2 2.3 2.4 2.5 
            // 3.0 3.1 3.2 3.3 3.4 3.5 
            // 4.0 4.1 4.2 4.3 4.4 4.5 
            // 5.0 5.1 5.2 5.3 5.4 5.5