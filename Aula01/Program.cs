using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
        public static string nome, registroOnline;
        public static char resposta;
        public static int numeroRegistro, setor, turno;

        public static void Main(string[] args)
        {

            //var

           
            bool volta = true;


            //body

            while (volta)
            {
                while (volta)
                {

                    Console.WriteLine();
                    Console.WriteLine("Cadastro Online de Funcionário!!");
                    Console.WriteLine();
                    Console.Write("Digite seu nome:  ");
                    nome = Console.ReadLine();

                    if (Regex.IsMatch(nome, @"^[a-zA-Z]+$"))
                    {
                        volta = false;

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("ERRO - Deve conter apenas letras, tente novamente!");
                        Console.ResetColor();
                        Console.WriteLine();
                        int milliseconds = 2000;
                        Thread.Sleep(milliseconds);
                        Console.Clear();



                    }
                }
                Console.WriteLine();
                Console.Write("Bem vindo ");
                Console.WriteLine(nome);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Agora vamos completar seu perfil ");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine();
                Console.Write("Número de registro(sem caracteres especiais):  ");
                numeroRegistro = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Número de Setor:  ");
                setor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Turno (1,2 ou 3): ");
                turno = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Confirma seus dados? ");
                Console.WriteLine();
                Console.WriteLine(nome);
                Console.WriteLine();



                Console.Write("Registro - ");
                Console.WriteLine(numeroRegistro);

                Console.Write("Setor - ");
                Console.WriteLine(setor);

                //while (volta)
                //{
                Console.Write("Turno - ");
                Console.WriteLine(turno);
                //    if ()
                //    {
                //    }
                //    else
                //    {
                //    }
                //}

                Console.WriteLine();
                Console.WriteLine("Aperte Enter para finalizar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine();
                double calculoReg = Math.Pow(numeroRegistro, 2);
                registroOnline = Convert.ToString(calculoReg);
                Console.WriteLine();
                Console.WriteLine("Parabéns, seu número de Registro Online foi cadastrado! ");
                Console.WriteLine();
                Console.WriteLine(registroOnline);
                Console.WriteLine();
                Console.WriteLine("---- não perca esse número ----");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Deseja ser direcionado para o Perfil do Funcionário?");
                Console.Write("Y - Para Sim / ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("N - Para Não");
                Console.ResetColor();
                //resposta = Convert.ToChar(Console.ReadLine());

                String input = Console.ReadLine();

                while((input[0] != 'N') || (input[0] != 'Y'))
                input = Console.ReadLine();
               
                    if (input[0] == 'Y')
                    {
                         Console.Write("Fim, por enquanto.");
                        // redirecionado para a próxima classe
                        Console.ReadKey();
                    }
                    else if (input[0] == 'N')
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Reiniciando..");
                        Console.ResetColor();
                        Console.WriteLine();
                        int milliseconds = 3000;
                        Thread.Sleep(milliseconds);
                        Console.Clear();
                        Console.ReadKey();
                    }

            }
        }

    }
}
