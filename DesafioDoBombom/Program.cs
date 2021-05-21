using System;

namespace DesafioDoBombom
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variaveis

            Program prog = new Program();
            double escadaAltura, volumeConcreto;
            int altura, totalDegraus = 0, degraus = 0, escComprim;
            double restanteDeg;
            // 1
            Console.WriteLine();
            Console.WriteLine("Insira o tamanho da escada em centímetros: \n ");
            // altura inserida pelo usuário
            altura = prog.CRI();
            // dividido pela altura de cada degrau para descobrir-mos quantos degraus existirão na matriz
            escadaAltura = altura / 18;
            // é feito um arredondamento para se ter um inteiro e usar em nossa matriz inteira
            escadaAltura = Math.Ceiling(escadaAltura);
            Console.WriteLine();
            // como não temos um valor específico, e sim usaremos a referencia que o usuário vai inserir
            // então vamos pegar aquele resultado da quantidade de degraus e jogamos dentro do indice
            // lembrando de converter essa variavel para inteiro e poder ser lida pela matriz
            int[][] matriz = new int[Convert.ToInt32(escadaAltura)][];

            // matriz para identificar todos os blocos e contar o valor total

            for (int i = 0; i < escadaAltura; i++)
            {
                // ao montar as linhas, teremos o mesmo problema, não temos um valor especifico
                // por isso vamos usar o valorque usamos na criação das clunas para ser capaz de criar uma matriz quadrada (1:1)
                matriz[i] = new int[Convert.ToInt32(escadaAltura)];
            }

            // aqui montamos uma matriz comum para numerar os indices como uma forma de ter a referencia de posicionamento
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    matriz[i][j] = i + j;
                }
            }
            // agora que temos os indices já determinados, vamos montar as condicionais para descobrir quantos degraus vamos ter
            // e qantos blocos vamos ter mara montar ela inteira
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    // se o indice i for igal ao indice j, teremos a diagonal perfeita, e assim poderemos contar os degras
                    if (i == j)
                    {
                        // acrencentando 1 a cada vez q ele ler esse indice (i = j)
                        degraus += 1;
                        Console.Write(degraus + " ");
                    }
                    // como precisamos que essa condição aconteça em paralelo com o if anterior, não usamos o else if, mas sim o if direto
                    if (i <= j)
                    {
                        // e aqui vamos ler todos os blocos
                        totalDegraus += 1;
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine();
            }
            
            // agora que temos a matriz e a contagem de todos os blocos e degraus, precisamos verificar se existe algum degrau menor
            // no inicio , fizemos o calculo de altura / 18, para descobrirmos a quantidade de degraus,
            // vamos fazer o calculo inverso para descobrir se a divisão pela altura total vai ser possivel ter degraus de 18 cm de altura
            // ou se vai dar um restante de sobra , e usar  esse resultado como parametro de comparação

            

            if (18 == altura / degraus)
            {
                // sendo iguais os dois parametros, 
                // precisamos descobrir agora quanto é o comprimento total, pegamos então a quantidade de degraus e multiplicamos pelo comprimento de cada degrau

                escComprim = degraus * 30;
                Console.WriteLine();
                Console.WriteLine(degraus + " degraus");
                Console.WriteLine(escComprim + " cm de Comprimento");
                //e para o volume fazemos a altura

                volumeConcreto = (totalDegraus * (18 * 30 * 50)) * 1.3246;
                Console.WriteLine(volumeConcreto + " cm³ de Concreto");
                Console.WriteLine();
            }
            else
            {
                degraus = degraus + 1;
                escComprim = degraus * 30 + 30;
                Console.WriteLine();
                Console.WriteLine(degraus + " degraus");
                Console.WriteLine(escComprim + " cm de Comprimento");
                restanteDeg = (altura * 1500);
                volumeConcreto = (totalDegraus * (18 * 30 * 50) + restanteDeg) * 1.3246;
                Console.WriteLine(volumeConcreto + " cm³ de Concreto");
                Console.WriteLine();
            }
            
        }
        // funções
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
    }
}
