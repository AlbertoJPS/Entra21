using System;
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

            List<Produto> listaProdutos = new List<Produto>(5);
            Console.WriteLine("Digite '-' a qualquer momento para finalizar e vizualizar lista \n");

            for (int i = -1; i < listaProdutos.Count; i++)
            {
                Produto produto = new Produto();
                
                Console.Write("Produto: ");
                produto.Nome = CR();
                var verifn = produto.Nome;
                Console.Write("Qantidade: ");
                produto.Quantidade = CR();
                var verifq = Convert.ToString(produto.Quantidade);
                
                if (verifn == "-" || verifq == "-")
                {
                    break;
                }
                else
                {
                    listaProdutos.Add(produto);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n Lista de produtos registrados:\n");
            foreach (var produto in listaProdutos)
            {
                
                Console.Write(produto.Nome + " - ");
                Console.WriteLine(produto.Quantidade);
            }

            //listaProdutos.Remove(produto2);
        }
        ///Funcoes
        
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
    }
}
