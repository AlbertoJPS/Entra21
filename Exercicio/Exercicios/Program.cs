using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex10

            double valor;
            string fidelidade, quinta;

            Console.WriteLine("Insira o valor da compra.");
            valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Possui cartão fidelidade? (S - Sim / N - Não)");
            fidelidade = Console.ReadLine();
            fidelidade = fidelidade.ToLower();
            Console.WriteLine();


            switch (fidelidade)
            {
                case "s":
                case "sim":
                    valor = valor * 0.85;
                    break;
            }


            Console.WriteLine("Esta é a quinta compra? (S - Sim / N - Não)");
            quinta = Console.ReadLine();
             quinta = quinta.ToLower();


            if (quinta == "s" || quinta == "sim" || quinta == "si")
            {
                valor = valor * 0.90;
            }

            //switch (quinta)
            //{
            //    case "s":
            //    case "sim":
            //        valor = valor * 0.90;
            //        break;
            //}

            Console.WriteLine();

            if (valor > 400)
            {
                //20%
                valor = valor - valor * 0.2;
            }
            else if (valor >= 200)
            {
                //10%
                valor = valor * 0.9;
                // (1 - valor/100) desconto 
            }

            Console.WriteLine("O valor com desconto é:");
            Console.WriteLine("{0:c}", valor);

            // tem um erro durante a execução durante a verificação da quinta compra


        }
    }
}
