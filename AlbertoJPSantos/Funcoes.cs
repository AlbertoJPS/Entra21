using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertoJPSantos
{
    public static class Funcoes
    {

        public static void Entradas()
        {
            
            
        }
        public static void Matriz()
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
                }
            }

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (i < 3)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                    

                    // 0.0 0.1 0.2 0.3 0.4 0.5 
                    // 1.0 1.1 1.2 1.3 1.4 1.5 
                    // 2.0 2.1 2.2 2.3 2.4 2.5 
                    // 3.0 3.1 3.2 3.3 3.4 3.5 
                    // 4.0 4.1 4.2 4.3 4.4 4.5 
                    // 5.0 5.1 5.2 5.3 5.4 5.5
                }
                Console.WriteLine();
            }
        }









    }
}
