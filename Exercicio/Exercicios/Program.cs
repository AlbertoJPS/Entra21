using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ex10

            //double valor;
            //string fidelidade, quinta;

            //Console.WriteLine("Insira o valor da compra.");
            //valor = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("Possui cartão fidelidade? (S - Sim / N - Não)");
            //fidelidade = Console.ReadLine();
            //fidelidade = fidelidade.ToLower();
            //Console.WriteLine();


            //switch (fidelidade)
            //{
            //    case "s":
            //    case "sim":
            //        valor = valor * 0.85;
            //        break;
            //}


            //Console.WriteLine("Esta é a quinta compra? (S - Sim / N - Não)");
            //quinta = Console.ReadLine();
            // quinta = quinta.ToLower();


            //if (quinta == "s" || quinta == "sim" || quinta == "si")
            //{
            //    valor = valor * 0.90;
            //}

            ////switch (quinta)
            ////{
            ////    case "s":
            ////    case "sim":
            ////        valor = valor * 0.90;
            ////        break;
            ////}

            //Console.WriteLine();

            //if (valor > 400)
            //{
            //    //20%
            //    valor = valor - valor * 0.2;
            //}
            //else if (valor >= 200)
            //{
            //    //10%
            //    valor = valor * 0.9;
            //    // (1 - valor/100) desconto 
            //}

            //Console.WriteLine("O valor com desconto é:");
            ////Console.WriteLine("{0:c}", valor);

            //// tem um erro durante a execução durante a verificação da quinta compra


            //string operador;
            //bool volta = true;
            //double valorX = 0, resultTemp = 0, resultFinal = 0;

            //Console.WriteLine("Calculadora");
            //Console.WriteLine();
            //Console.WriteLine("Operações reconhecidas:");
            //Console.WriteLine("Soma                  +");
            //Console.WriteLine("Subtração             -");
            //Console.WriteLine("Resultado             =");
            //Console.WriteLine();
            //Console.WriteLine("Digite um valor:");

            //valorX = Convert.ToInt32(Console.ReadLine());

            //while (volta == true)
            //{
            //    operador = Console.ReadLine();


            //    switch (operador)
            //    {
            //        case "+":
            //            resultTemp = resultTemp + valorX;
            //            resultFinal = resultFinal + resultTemp;
            //            break;
            //        case "-":
            //            resultTemp = resultTemp - valorX;
            //            resultFinal = resultFinal - resultTemp;
            //            break;
            //        case "=":
            //            Console.WriteLine();
            //            Console.WriteLine("Seu resultado é: " + resultFinal);
            //            volta = false;
            //            break;
            //    }

            //}




            ////EXERCICIO 1 "LISTA 2" - Continuar

            //{

            //    double v1 = 0.0, v2 = 0.0;

            //    char oper, aux;
            //    string cond;

            //    Console.WriteLine("\n\tLISTA DE OPERAÇÕES:");
            //    Console.WriteLine("\n\t soma = +");
            //    Console.WriteLine("\n\tsubtração = -");
            //    Console.WriteLine("\n\tmultiplicação = *");
            //    Console.WriteLine("\n\tdivisão = /");
            //    Console.WriteLine("\n\tquadrado = ^\n\n");
            //    Console.WriteLine("\tPara resetar = c\n");
            //    Console.WriteLine("\tPara finalizar: exit ou close\n");
            //    Console.WriteLine("\t--------------------\n\n");
            //    Console.WriteLine("\n\tCALCULADORA INICIALIZADA.\n\n");

            //    cond = Console.ReadLine();

            //    if (cond == "exit" || cond == "close")
            //    {
            //        Console.WriteLine("\n\tCALCULADORA FINALIZADA\n");

            //    }
            //    else

            //    {

            //        v1 = Convert.ToDouble(cond);
            //        oper = Convert.ToChar(Console.ReadLine());
            //        v2 = Convert.ToDouble(Console.ReadLine());

            //        while (true)
            //        {


            //            switch (oper)
            //            {

            //                case '+':

            //                    v1 += v2;
            //                    Console.WriteLine("\n\tResultado: {0}", v1);

            //                    break;
            //                case '-':

            //                    v1 -= v2;
            //                    Console.WriteLine("\n\tResultado: {0}", v1);

            //                    break;
            //                case '*':

            //                    v1 *= v2;
            //                    Console.WriteLine("\n\tResultado: {0}", v1);

            //                    break;
            //                case '/':

            //                    v1 /= v2;
            //                    Console.WriteLine("\n\tResultado: {0}", v1);

            //                    break;
            //                case '^':

            //                    v1 *= v1;
            //                    Console.WriteLine("\n\tResultado: {0}", v1);

            //                    break;

            //                default:

            //                    Console.WriteLine("\n\tOperacão não computavel.\n\t Informe novamente:\n");
            //                    oper = Convert.ToChar(Console.ReadLine());
            //                    v2 = Convert.ToDouble(Console.ReadLine());
            //                    break;


            //            }
            //            cond = Console.ReadLine();
            //            if (cond == "exit" || cond == "close")
            //            {
            //                Console.WriteLine("\n\tCALCULADORA FINALIZADA.");
            //                break;
            //            }
            //            else
            //            {

            //                aux = Convert.ToChar(cond);
            //                if (aux == '-' || aux == '+' || aux == '*' || aux == '/' || aux == '^' && aux != 'c')
            //                {

            //                    oper = aux;
            //                    v2 = Convert.ToDouble(Console.ReadLine());
            //                }
            //                else if (aux == 'c')
            //                {
            //                    Console.WriteLine("\n\t-----------------------");
            //                    Console.WriteLine("\n\tCALCULADORA REINICIALIZADA\n");
            //                    v1 = Convert.ToDouble(Console.ReadLine());
            //                    oper = Convert.ToChar(Console.ReadLine());
            //                    v2 = Convert.ToDouble(Console.ReadLine());
            //                }
            //                else
            //                {
            //                    v2 = Convert.ToDouble(cond);
            //                }
            //            }
            //        }

            //    }

            // Exc 01 ---- Vetores


            int[] vetor = new int[2];
            Console.WriteLine("Me dia 2 valores que eu te digo qual  maior:");
            //vetor[0] = Convert.ToInt32(Console.ReadLine());
            //vetor[1] = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            if (vetor[0] > vetor[1])
            {
                Console.WriteLine(vetor[1]);
            }
            else
            {
                Console.WriteLine(vetor[0]);
            }






        }

       
    }
}
