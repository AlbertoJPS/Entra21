﻿using System;
using System.Collections.Generic;


namespace Aula_08
{
    public class Produto
    {

        public string Nome { get; set; }        
        public string Quantidade { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            ///exc 01

            ////criando a lista

            //List<string> listaDeString = new List<string>();

            ////pedir dados

            //Console.WriteLine("Insira 2 entradas quaisquer");

            //string entrada = Program.CR();

            //listaDeString.Add(entrada);

            //entrada = CR();

            //listaDeString.Add(entrada);

            //// mostrar na tela

            //Console.WriteLine("------------//--------------");

            //for (int i = 0; i < listaDeString.Count; i++)

            //{

            //    Console.WriteLine(listaDeString[i]);

            //}

            //Console.WriteLine("------------//--------------");

            //foreach (var item in listaDeString)

            //{

            //    Console.WriteLine(item);

            //}

            ////exec 02

            //// cria a lista

            //List<double> notas = new List<double>();

            //// Pede dados

            //Console.WriteLine("insira as 3 notas");

            ////for (int i = 0; i < 3; i++)

            ////{

            //// var nota = CRD(); // CRD é uma função que chama Convert.ToDouble(Console.ReadLine())

            //// notas.Add(nota);

            ////}

            //var nota = CRD(); // CRD é uma função que chama Convert.ToDouble(Console.ReadLine())

            //notas.Add(nota);

            //nota = CRD(); // CRD é uma função que chama Convert.ToDouble(Console.ReadLine())

            //notas.Add(nota);

            //nota = CRD(); // CRD é uma função que chama Convert.ToDouble(Console.ReadLine())

            //notas.Add(nota);

            //// mostra

            //double resultado = 0;

            //foreach (var item in notas)

            //{

            //    resultado += item;

            //}

            //Console.WriteLine("Média ► " + (resultado / 3));

            ///exc 02

            ///exc 03

            ///exc 04

            ///exc 05

            ///exc 06

            //List<string> logins = new List<string>();
            //List<string> senhas = new List<string>();
            //// preenche as lista com letras de 'a' a 'e'
            //for (int i = 97; i < 102; i++) // preenche com letras
            //{
            //    char letra = Convert.ToChar(i);
            //    logins.Add(letra.ToString());
            //    letra = Convert.ToChar(i - 32);
            //    senhas.Add(Convert.ToString(letra));
            //}
            //while (true)
            //{
            //    Console.WriteLine("Insira o login ou sair ou ver");
            //    string tempL = CR(); // CR() == Console.ReadLine
            //    if (tempL == "sair")
            //    {
            //        break;
            //    }
            //    else if (tempL == "ver")
            //    {
            //        MostraLista(logins);
            //        MostraLista(senhas);
            //    }
            //    else if (tempL == "Admin")
            //    {
            //        Console.WriteLine("Senha do Admin");
            //        string tempS = CR();
            //        if (tempS == "@Senac")
            //        {
            //            int a = 0;
            //            while (a == 0)
            //            {
            //                Console.WriteLine("\t\t***Menu Do Admin***");
            //                Console.WriteLine("1 - Criar Conta");
            //                Console.WriteLine("2 - Deletar Conta");
            //                Console.WriteLine("3 - LogOut");
            //                int escolha = CRI();// CRI() == Convert.ToInt32(Console.ReadLine());
            //                switch (escolha)
            //                {
            //                    case 1:
            //                        Console.WriteLine("Qual o login desta conta?");
            //                        string entrada = CR();
            //                        if (BuscaEmLista(logins, entrada) == -1)
            //                        {
            //                            logins.Add(entrada);
            //                            Console.WriteLine("Qual a senha deste login?");
            //                            entrada = CR();
            //                            senhas.Add(entrada);
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Login ja existente");
            //                        }
            //                        break;
            //                    case 2:
            //                        int cont = 0;
            //                        foreach (var item in logins)
            //                        {
            //                            cont++;
            //                            Console.WriteLine(cont + " -> " + item);
            //                        }
            //                        Console.WriteLine("\nQual deseja remover?");
            //                        cont = CRI();
            //                        logins.RemoveAt(cont);
            //                        senhas.RemoveAt(cont);
            //                        break;
            //                    case 3:
            //                        a = 1;
            //                        Console.WriteLine("Log Out efetuado");
            //                        break;
            //                    default:
            //                        Console.WriteLine("Opção inválida");
            //                        break;
            //                }
            //                Console.WriteLine("Pressione enter para progredir");
            //                Console.ReadLine();
            //                Console.Clear();
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Senha incorreta");
            //        }
            //    }
            //    else
            //    {
            //        int indice = BuscaEmLista(logins, tempL);
            //        if (indice != -1)
            //        {
            //            Console.WriteLine("Qual a senha?");
            //            string tempS = CR();
            //            if (senhas[indice] == tempS)
            //            {
            //                Console.WriteLine("Login efetuado");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Senha incorreta");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Login não encontrado");
            //        }
            //    }
            //    Console.WriteLine("Pressione enter para progredir");
            //    Console.ReadLine();
            //    Console.Clear();
            //}
            //// mostra as listas
            ////foreach (var item in logins)
            ////{
            //// Console.Write(item + " ");
            ////}
            ////Console.WriteLine();
            ////foreach (var item in senhas)
            ////{
            //// Console.Write(item + " ");

            ////}

            /// = ===================================================================================================
            /// 

            ///exc 01

            //List<Produto> listaProdutos = new List<Produto>(5);
            //Console.WriteLine("Digite '-' a qualquer momento para finalizar e vizualizar lista \n");
            //for (int i = -1; i < listaProdutos.Count; i++)
            //{
            //    Produto produto = new Produto();
            //    Console.Write("Produto: ");
            //    produto.Nome = CR();
            //    var verifn = produto.Nome;
            //    Console.Write("Qantidade: ");
            //    produto.Quantidade = CR();
            //    var verifq = Convert.ToString(produto.Quantidade);
            //    if (verifn == "-" || verifq == "-")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        listaProdutos.Add(produto);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("\n\n Lista de produtos registrados:\n");
            //foreach (var produto in listaProdutos)
            //{
            //    Console.Write(produto.Nome + " - ");
            //    Console.WriteLine(produto.Quantidade);
            //}


            // ======================================================================================

            ///exc 002
            ///
            //Console.WriteLine("Insira um número");
            //int a = 0;
            //while (true)
            //{
            //    Console.WriteLine("Insira um número");
            //    try
            //    {
            //        a = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Deu Certo!!!");
            //        break;
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.WriteLine("Número Gigantesco");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Apenas Números");
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("**Erro**");
            //    }
            //}

            ///exc 003
            ///

            //while (true)
            //{
            //    Console.WriteLine("Digite 3 números entre 0 e 10\n");
            //    try
            //    {
            //        double n2 = 0;
            //        Console.WriteLine("Digite o 1º número:");
            //        double n1 = CRD();
            //        if (n1 <= 10 && n1 > 0)
            //        { 
            //            n2 = n2 + n1;
            //        }
            //        else
            //        {
            //            throw new OverflowException();
            //        }
            //        Console.WriteLine("Digite o 2º número:");
            //        n1 = CRD();
            //        if (n1 <= 10 && n1 > 0)
            //        {
            //            n2 = n2 + n1;
            //        }
            //        else
            //        {
            //            throw new OverflowException();
            //        }
            //        Console.WriteLine("Digite o 3º número:");
            //        n1 = CRD();
            //        if (n1 <= 10 && n1 > 0)
            //        {
            //            n2 = n2 + n1;
            //        }
            //        else
            //        {
            //            throw new OverflowException();
            //        }
            //        n1 = n2 / 3;
            //            Console.WriteLine("\nA média entre os 3 números informados é de " + n1.ToString("F"));
            //            break;
            //    }
            //    catch (OverflowException)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("\nNúmero Gigantesco\n\n");
            //    }
            //    catch (FormatException)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("\nApenas Números\n\n");
            //    }
            //    catch (Exception)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("\n**Erro**\n\n");
            //    }
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Tente novamente\n");
            //    Console.ResetColor();
            //    Console.WriteLine("-------------------------------\n");
            //}

            ///exc 004
            ///



            // ===========================================================================================================

            ///exc 0001
            ///

            //Console.WriteLine("Insira um número");
            //int x = CRI();
            //Console.WriteLine(Exc01(x));

            ///exc 0002
            ///

            //Exc02();

            ///exc 0003
            ///

            //Console.WriteLine("Insira um número");
            //int numero1 = CRI();
            //Console.WriteLine("Insira mais um número");
            //int numero2 = CRI();
            //Console.WriteLine("\n" + Exc03(numero1, numero2));

            ///exc 0004
            ///

            //Console.WriteLine("Insira um número");
            //int numero1 = CRI();
            //Console.WriteLine("Insira mais um número");
            //int numero2 = CRI();
            //Console.WriteLine("\nA soma resulta em " + Exc04(numero1, numero2) + ".");

            ///exc 0005
            ///


            List<double> lista = new List<double>(4);
            Random rnd = new Random();
            lista.Add(rnd.Next(int.MaxValue));
            Console.WriteLine(Exc05(lista));

            ///exc 0006
            ///

            //Console.WriteLine("Insira um número");
            //int x = CRI();
            //Console.WriteLine("\n" + Exc06(x));
        }

        ///Funções

        public static string CR()

            {

                return Console.ReadLine();

            }
        public static int CRI()

            {

                return Convert.ToInt32(Console.ReadLine());

            }
        public static double CRD()

            {

                return Convert.ToDouble(Console.ReadLine());

            }
        public static int BuscaEmLista(List<string> elementos, string verificador)

        {

            for (int i = 0; i < elementos.Count; i++)

            {

                if (elementos[i] == verificador)

                {

                    return i;

                }

            }

            return -1;

        }
        public static void MostraLista(List<string> elementos)

        {

            foreach (var item in elementos)

            {

                Console.Write(item + " ");

            }

            Console.WriteLine();

        }
        public static int Exc01(int numero)
        {
            if (numero > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public static void Exc02() 
        { 
            while (true) 
            { 
                Console.WriteLine("Insira um numero ou sair"); 
                string entrada = Console.ReadLine();
                if (entrada == "sair" || entrada == "Sair") 
                { 
                    break; 
                } 
                else 
                { 
                    Console.WriteLine("\n" + entrada); 
                } 
            } 
        }
        public static bool Exc03(int numero1, int numero2)  
        { 
            if (numero1 > numero2) 
            { 
                return true; 
            } 
            else 
            { 
                return false; 
            } 
        }
        public static string Exc04(int numero1, int numero2) 
        { 
            if (numero1 > numero2) 
            {
                string x = Convert.ToString(numero1 + numero2);
                return x; 
            } 
            else 
            { 
                return "Não computável"; 
            } 
        }
        public static double Exc05(List<double> lista) 
        {
            double maior = int.MaxValue;

            // pode add um random?
            // não está se fazendo uma lista, apenas declarando o valr da variável "maior"
            //lista = new List<double>(4);
            //Random rnd = new Random();
            //lista.Add(rnd.Next(int.MaxValue));

            for (int i = 0; i <= 3; i++)
            {
                foreach (var item in lista)
                {
                    
                    if (item > maior)
                    {
                        maior = item;
                    }
                    
                    Console.WriteLine(maior + " - " + item + "\n");
                }

            }
                return maior;
            
        }
        public static int Exc06(int numero) 
        { 
            if (numero > 0 && numero < 10) 
            { 
                return 1; 
            } 
            else 
            { 
                return 0; 
            } 
        }
    }
}
