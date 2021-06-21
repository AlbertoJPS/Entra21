using System;
using System.Collections.Generic;

namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Exec 01

            //Console.WriteLine("insira uma pessoa");
            //string nome, cpf, endereco;
            //int idade;

            //nome = Console.ReadLine();
            //cpf = Console.ReadLine();
            //endereco = Console.ReadLine();
            //idade = int.Parse(Console.ReadLine());

            //Pessoa pes = new Pessoa(nome,cpf,endereco,idade);
            //Console.WriteLine("----------//------------®");
            //Console.WriteLine(pes.nome);
            //Console.WriteLine(pes.cpf);
            //Console.WriteLine(pes.endereco);
            //Console.WriteLine(pes.idade);

            //string[] vetor = { "Julia", "89915788551", "Rua das missoes" };
            //Pessoa pes = new Pessoa(vetor, 37);
            //for (int i = 0; i < pes.valores.Length; i++)
            //{
            //    Console.WriteLine(pes.valores[i]);
            //}

            //Console.WriteLine(pes.valores[0]);
            //Console.WriteLine(pes.valores[1]);
            //Console.WriteLine(pes.valores[2]);

            //Exec02

            List<SerHumano> pessoas = new List<SerHumano>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Insira uma pessoa");
                string nome = Console.ReadLine();
                int idade = int.Parse(Console.ReadLine());
                // H = Homem | M = Mulher
                string genero = Console.ReadLine().ToLower();// Tudo o que o usario inserir ficará em letra minuscula
                SerHumano ser = new SerHumano(nome, idade, genero);
                pessoas.Add(ser);
            }

            int indiceHomi = -1, indiceMuie = -1;
            int idadeHomi = -1, idadeMuie = -1;

            for (int i = 0; i < pessoas.Count; i++)
            {
                if (pessoas[i].genero == "m")
                {
                    if (idadeMuie < pessoas[i].idade)
                    {
                        indiceMuie = i;
                        idadeMuie = pessoas[i].idade;
                    }
                }

                if (pessoas[i].genero == "h")
                {
                    if (idadeHomi < pessoas[i].idade)
                    {
                        indiceHomi = i;
                        idadeHomi = pessoas[i].idade;
                    }
                }
                //switch (pessoas[i].genero)
                //{
                //    case "m":
                //        if (idadeMuie < pessoas[i].idade)
                //        {
                //            indiceMuie = i;
                //            idadeMuie = pessoas[i].idade;
                //        }
                //        break;
                //    case "h":
                //        if (idadeHomi < pessoas[i].idade)
                //        {
                //            indiceHomi = i;
                //            idadeHomi = pessoas[i].idade;
                //        }
                //        break;
                //    default:
                //        break;
                //}
            }
            Console.WriteLine("-----------//--------------®");
            try
            {
                Console.WriteLine("Mulher mais velha");
                Console.WriteLine(pessoas[indiceMuie].nome);
                Console.WriteLine(pessoas[indiceMuie].idade);
            }
            catch (Exception)
            {
                Console.WriteLine("Nao existe mulheres na lista");
            }
            Console.WriteLine("-----------//--------------®");
            try
            {
                Console.WriteLine("Homem mais velho");
                Console.WriteLine(pessoas[indiceHomi].nome);
                Console.WriteLine(pessoas[indiceHomi].idade);
            }
            catch (Exception)
            {
                Console.WriteLine("Nao existe homens na lista");
            }
        }
    }
}
