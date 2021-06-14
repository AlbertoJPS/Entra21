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
        public static int[][] matriz2 = new int[6][];
        public static int[][] matriz3 = new int[6][];
        public static int[][] matriz4 = new int[6][];
        public static int[][] Matriz1()
        { 
            for (int i = 0; i<matriz1.Length; i++)
            {
                matriz1[i] = new int[6];
            }
            return matriz1;
        }
        public static int[][] Matriz2()
        {
            for (int i = 0; i < matriz2.Length; i++)
            {
                matriz2[i] = new int[6];
            }
            return matriz2;
        }
        public static int[][] Matriz3()
        {
            for (int i = 0; i < matriz3.Length; i++)
            {
                matriz3[i] = new int[6];
            }
            return matriz3;
        }
        public static int[][] Matriz4()
        {
            for (int i = 0; i < matriz4.Length; i++)
            {
                matriz4[i] = new int[6];
            }
            return matriz4;
        }

        //  opções_de_ações_no_estoque___________________________________________________
        //  |                                                                            |
        //  | x = 1 (mostra primeiro estoque  )     x = 2 (adiciona um item ao estoque)  |
        //  | x = 3 (retira um item do estoque)     x = 4 (mostra o estoque atual     )  |
        //  |____________________________________________________________________________|

        public static void Estoque1(int x)
        {
            if (x == 1)
            {
                Matriz1();
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
                int temp = 0;
                for (int i = 0; i < matriz1.Length; i++)
                {
                    for (int j = 0; j < matriz1[i].Length; j++)
                    {
                        if (matriz1[i][j] == 0)
                        {
                            j--;
                            if(j == -1)
                            {
                                j = 5;
                                i--;
                                if (i == -1)
                                {
                                   // Console.Write(0);
                                    temp = 1;
                                    break;
                                }
                            }
                            Console.Write(1);
                            matriz1[i][j] = 0;
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
        public static void Estoque2(int x)
        {
            if (x == 1)
            {
                Matriz2();
                for (int i = 0; i < matriz2.Length; i++)
                {
                    for (int j = 0; j < matriz2[i].Length; j++)
                    {
                        if (i < 3)
                        {
                            matriz2[i][j] = 2;
                            Console.Write(2);
                        }
                        else if (i >= 3)
                        {
                            matriz2[i][j] = 0;
                            Console.Write(0);
                        }
                    }
                    Console.WriteLine();
                }
            }
            if (x == 2)
            {
                int temp = 0;
                for (int i = 0; i < matriz2.Length; i++)
                {
                    for (int j = 0; j < matriz2[i].Length; j++)
                    {
                        if (matriz2[i][j] == 0)
                        {
                            matriz2[i][j] = 2;
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
                int temp = 0;
                for (int i = 0; i < matriz2.Length; i++)
                {
                    for (int j = 0; j < matriz2[i].Length; j++)
                    {
                        if (matriz2[i][j] == 0)
                        {
                            j--;
                            if (j == -1)
                            {
                                j = 5;
                                i--;
                                if (i == -1)
                                {
                                   // Console.Write(0);
                                    temp = 1;
                                    break;
                                }
                            }
                            Console.Write(2);
                            matriz2[i][j] = 0;
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
            if (x == 4)
            {
                for (int i = 0; i < matriz2.Length; i++)
                {
                    for (int j = 0; j < matriz2[i].Length; j++)
                    {
                        Console.Write(matriz2[i][j]);
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void Estoque3(int x)
        {
            if (x == 1)
            {
                Matriz3();
                for (int i = 0; i < matriz3.Length; i++)
                {
                    for (int j = 0; j < matriz3[i].Length; j++)
                    {
                        if (i < 3)
                        {
                            matriz3[i][j] = 3;
                            Console.Write(3);
                        }
                        else if (i >= 3)
                        {
                            matriz3[i][j] = 0;
                            Console.Write(0);
                        }
                    }
                    Console.WriteLine();
                }
            }
            if (x == 2)
            {
                int temp = 0;
                for (int i = 0; i < matriz3.Length; i++)
                {
                    for (int j = 0; j < matriz3[i].Length; j++)
                    {
                        if (matriz3[i][j] == 0)
                        {
                            matriz3[i][j] = 3;
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
                int temp = 0;
                for (int i = 0; i < matriz3.Length; i++)
                {
                    for (int j = 0; j < matriz3[i].Length; j++)
                    {
                        if (matriz3[i][j] == 0)
                        {
                            j--;
                            if (j == -1)
                            {
                                j = 5;
                                i--;
                                if (i == -1)
                                {
                                   // Console.Write(0);
                                    temp = 1;
                                    break;
                                }
                            }
                            Console.Write(3);
                            matriz3[i][j] = 0;
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
            if (x == 4)
            {
                for (int i = 0; i < matriz3.Length; i++)
                {
                    for (int j = 0; j < matriz3[i].Length; j++)
                    {
                        Console.Write(matriz3[i][j]);

                    }
                    Console.WriteLine();
                }
            }
        }
        public static void Estoque4(int x)
        {
            if (x == 1)
            {
                Matriz4();
                for (int i = 0; i < matriz4.Length; i++)
                {
                    for (int j = 0; j < matriz4[i].Length; j++)
                    {
                        if (i < 3)
                        {
                            matriz4[i][j] = 4;
                            Console.Write(4);
                        }
                        else if (i >= 3)
                        {
                            matriz4[i][j] = 0;
                            Console.Write(0);
                        }
                    }
                    Console.WriteLine();
                }
            }
            if (x == 2)
            {
                int temp = 0;
                for (int i = 0; i < matriz4.Length; i++)
                {
                    for (int j = 0; j < matriz4[i].Length; j++)
                    {
                        if (matriz4[i][j] == 0)
                        {
                            matriz4[i][j] = 4;
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
                int temp = 0;
                for (int i = 0; i < matriz4.Length; i++)
                {
                    for (int j = 0; j < matriz4[i].Length; j++)
                    {
                        if (matriz4[i][j] == 0)
                        {
                            j--;

                            if (j == -1)
                            {
                                j = 5;
                                i--;
                                if (i == -1)
                                {
                                   // Console.Write(0);
                                    temp = 1;
                                    break;
                                }
                            }
                            Console.Write(4);
                            matriz4[i][j] = 0;
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
            if (x == 4)
            {
                for (int i = 0; i < matriz4.Length; i++)
                {
                    for (int j = 0; j < matriz4[i].Length; j++)
                    {
                        Console.Write(matriz4[i][j]);

                    }
                    Console.WriteLine();
                }
            }
        }
    }
} 