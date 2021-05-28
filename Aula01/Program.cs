using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Aula01
{
    class Program
    {
      //variáveis globais

        public static string nome, snome, registroOnline, turno = "123", verifRegistro, setor;
        public static int numeroRegistro;

        public static void Main(string[] args)
        {
            bool volta = true;

  //Body

      //verificação de Nome


            while (volta)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(); Console.WriteLine("Cadastro Online de Funcionário!!"); Console.WriteLine(); Console.ResetColor();
                
                while (volta)
                {
                    
                    Console.Write("Digite seu Primeiro nome:  "); nome = Console.ReadLine();

                    if (Regex.IsMatch(nome, @"^[a-zA-Z]+$"))
                    {
                        volta = false;

                    }
                    else
                    {
                        Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("ERRO - Deve conter apenas letras, tente novamente!"); Console.ResetColor();  Console.WriteLine();
                        int milliseconds = 2000; Thread.Sleep(milliseconds);
                        Console.Clear();



                    }
                }
                while (volta)
                {

                    Console.Write("Digite seu sobrenome:  "); snome = Console.ReadLine();

                    if (Regex.IsMatch(snome, @"^[a-zA-Z]+$"))
                    {
                        volta = false;

                    }
                    else
                    {
                        Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("ERRO - Deve conter apenas letras, tente novamente!"); Console.ResetColor(); Console.WriteLine();
                        int milliseconds = 2000; Thread.Sleep(milliseconds);
                        Console.Clear();



                    }
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(); Console.WriteLine("-------------------------------------------");
                Console.WriteLine(nome + ", agora vamos completar seu perfil ");
                Console.WriteLine("-------------------------------------------"); Console.WriteLine(); Console.ResetColor();


                //verificação de registro

                volta = true;
                while (volta)
                {

                    Console.Write("Número de registro (de 5 digitos e sem caracteres especiais):  ");
                    numeroRegistro = int.Parse(Console.ReadLine());
                    verifRegistro = numeroRegistro.ToString();
                    Console.WriteLine();

                    int length = verifRegistro.Length;

                    if (length <= 5 && Regex.IsMatch(verifRegistro, "[0-9]"))
                    {
                        volta = false;

                    }

                    else
                    {
                        Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERRO - Deve conter no máximo 5 dígitos e apenas números.");
                        Console.WriteLine("Verifique seu número de registro e tente novamente!");
                        Console.WriteLine(); Console.ResetColor(); Console.WriteLine();
                        int milliseconds = 2000; Thread.Sleep(milliseconds);
                        Console.Clear();

                    }

                }


                //verificação de setor


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔═══════════════════╗ ");
                Console.WriteLine("║ 1 - gerencia      ║"); 
                Console.WriteLine("║ 2 - vendas        ║");
                Console.WriteLine("║ 3 - deposito      ║");
                Console.WriteLine("║ 4 - administracao ║");
                Console.WriteLine("╚═══════════════════╝");
                Console.WriteLine(); Console.ResetColor();
                Console.Write("Número de Setor:  ");

                string set = Console.ReadLine();

                switch (set)
                {
                    case "1":
                    case "gerencia":
                        setor = "gerencia";
                        break;
                    case "2":
                    case "vendas":
                        setor = "vendas";
                        break;
                    case "3":
                    case "deposito":
                        setor = "deposito";
                        break;
                    case "4":
                    case "administracao":
                        setor = "administracao";
                        break;
                    default:
                        Console.WriteLine("Setor inexistente, tente novamente!");
                        break;
                }
                Console.WriteLine();


                //verificção de turno 

                volta = true;
                while (volta)
                {
                    Console.Write("Turno (1,2 ou 3): ");
                    turno = Console.ReadLine();

                    int tamanho = turno.Length;

                    if (tamanho == 1 && Regex.IsMatch(turno, "[1-3]"))
                    {
                        volta = false;

                    }

                    else
                    {
                        Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("ERRO - Deve conter apenas números, tente novamente!"); Console.WriteLine();
                        Console.Write("ERRO - Turno inválido (1 - manhã, 2 - tarde, 3 - noite, tente novamente!"); Console.ResetColor(); Console.WriteLine();
                        int milliseconds = 2000; Thread.Sleep(milliseconds);
                        Console.Clear();

                    }

                }
               
      //confirmação de dados


                Console.Clear(); Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();Console.WriteLine("-------------------------------------");Console.WriteLine();
                Console.WriteLine("Confirma seus dados? "); Console.WriteLine(); Console.WriteLine("-------------------------------------"); Console.WriteLine();
                Console.ResetColor(); Console.Write(nome + " " + snome); Console.WriteLine(); 
                Console.Write("Registro - "); Console.WriteLine(numeroRegistro);
                Console.Write("Setor - ");  Console.WriteLine(setor);
                Console.Write("Turno - "); Console.WriteLine(turno);Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Aperte Enter para finalizar e gerar seu número de Registro Online!");
                Console.ResetColor(); Console.ReadKey(); Console.Clear();


      //finalização de cadastro


                Console.WriteLine();
                double calculoReg = Math.Pow(numeroRegistro, 2);
                registroOnline = Convert.ToString(calculoReg); Console.WriteLine();
                Console.WriteLine("Parabéns, seu número de Registro Online foi cadastrado com Sucesso! "); Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("             " + registroOnline); Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("---- não perca este número ----"); Console.WriteLine(); Console.WriteLine(); 
                Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); 
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Deseja ser direcionado para o Perfil do Funcionário?"); Console.WriteLine();
                Console.Write("Y - Para Sim / "); Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("  N - Para Não"); 
                Console.WriteLine(); Console.ResetColor();


                string output = Console.ReadLine();
                string str = ".....";
                switch (output)
                {
                    
                    case "y":
                    case "Y":

                        Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fim, por enquanto.");
                        Console.Write("Saindo");
                        for (int i = 0; i < str.Length; i++)
                        {
                            Console.Write(".", str[i]); Thread.Sleep(500);
                        }
                        Console.ResetColor(); Environment.Exit(1);
                        break;

                    case "n":
                    case "N":
                        Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Reiniciando"); 
                        for (int i = 0; i < str.Length; i++)
                        {
                            Console.Write(".", str[i]); Thread.Sleep(500);
                        }
                        Console.ResetColor();
                        Console.Clear();
                        break;
                    
                }



                volta = true;
            }
        }

    }
}
