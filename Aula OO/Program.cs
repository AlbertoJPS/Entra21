using System;
using System.Collections.Generic;

namespace Aula_OO
{
    class Program
    {
        static void Main(string[] args)
        {
            ///exc 01
            //Pessoa pes = new Pessoa();
            //Console.WriteLine("Preencha esta pessoa");
            //pes.nome = Console.ReadLine();
            //pes.idade = int.Parse(Console.ReadLine());
            //pes.cpf = Console.ReadLine();
            //pes.endereco = Console.ReadLine();
            //Console.WriteLine("-----------//-------------");
            //Console.WriteLine(pes.nome);
            //Console.WriteLine(pes.idade);
            //Console.WriteLine(pes.cpf);
            //Console.WriteLine(pes.endereco);

            ///exc 02
            //List<Cachorro> doginhos = new List<Cachorro>();

            ////preenche a lista
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Insira o doginho");
            //    Cachorro cao = new Cachorro();
            //    cao.nome = Console.ReadLine();
            //    cao.nomeDoDono = Console.ReadLine();
            //    cao.idade = Convert.ToInt32(Console.ReadLine());
            //    doginhos.Add(cao);
            //}
            //Console.WriteLine("-----------//-----------");

            ////mostrar a lista, apenas cachorros velhos
            //foreach (var item in doginhos)
            //{
            //    if (item.idade > 6)
            //    {
            //        Console.WriteLine(item.nome);
            //        Console.WriteLine(item.nomeDoDono);
            //        Console.WriteLine(item.idade);
            //        Console.WriteLine("-----------//-----------");
            //    }
            //}
            //for (int i = 0; i < doginhos.Count; i++)
            //{
            //    if (doginhos[i].idade > 6)
            //    {
            //        Console.WriteLine(doginhos[i].nome);
            //        Console.WriteLine(doginhos[i].nomeDoDono);
            //        Console.WriteLine(doginhos[i].idade);
            //        Console.WriteLine("-----------//-----------");
            //    }

            ///exc 03
            ///
            //List<Pessoa> pes = new List<Pessoa>();
            //int maisVelhoH = 0, maisVelhaM = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Pessoa pessoa = new Pessoa();

            //    Console.Write("\nInsira o Nome: "); pessoa.nome = Console.ReadLine();
            //    Console.Write("Insira a idade: "); pessoa.idade = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Insira o Genero (masculino/feminino): "); pessoa.genero = Console.ReadLine();
            //    pessoa.genero = pessoa.genero.ToLower();

            //    if (pessoa.genero == "masculino")
            //    { 
            //        if(pessoa.idade > maisVelhoH)
            //        {
            //            maisVelhoH = pessoa.idade;
            //        }
            //    }
            //    if (pessoa.genero == "feminino")
            //    {
            //        if (pessoa.idade > maisVelhaM)
            //        {
            //            maisVelhaM = pessoa.idade;
            //        }
            //    }
            //    pes.Add(pessoa);
            //}

            //foreach (var item in pes)
            //{
            //    if (item.idade == maisVelhoH && item.genero == "masculino")
            //    {
            //        Console.WriteLine("\n\nO Homem mais velho é o " + item.nome + ", com " + item.idade + " anos de idade.");
            //    }
            //    if (item.idade == maisVelhaM && item.genero == "feminino")
            //    {
            //        Console.WriteLine("\nA mulher mais velha é a " + item.nome + ", com " + item.idade + " anos de idade.");
            //    }
            //}

            ///exc 04 -------------- não finalizado
            ///
            //List<Animais> animais = new List<Animais>();

            //for (int i = 0; i < 2; i++)
            //{
            //    Animais animal = new Animais();

            //    Console.Write("\nInsira o nome do animal: "); animal.nome = Console.ReadLine();
            //    Console.Write("Insira a idade: "); animal.idade = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Insira sua espécie: "); animal.genero = Console.ReadLine();
            //    Console.Write("Insira o tempo que ele está no Zoo em dias: "); animal.tempoZoo = Convert.ToInt32(Console.ReadLine());
            //    animais.Add(animal);
            //    for (int l = animais.Count - 1; l >= 0; l--)
            //    {
            //        for (int j = 1; j <= l; j++)
            //        {
            //            if (animal.idade[j - 1] > animal.idade[j])
            //            {
            //                var temp = animal.idade[j - 1];
            //                animal.idade[j - 1] = animal.idade[j];
            //                animal.idade[j] = temp;
            //            }
            //        }
            //    }
            //}
            //// fazer o sort manual

            //foreach (var item in animais)
            //{
            //    Console.WriteLine(item.nome + " " + item.idade + " " + item.especie + " " + item.tempoZoo);
            //}

            /// --------------- não finalizado

            ///Exc 05

            //----------------------------------------------------------------------------------------------

            //Exc 00 part 2

            ///Exec 01

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

            ///Exec02

            //List<SerHumano> pessoas = new List<SerHumano>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Insira uma pessoa");
            //    string nome = Console.ReadLine();
            //    int idade = int.Parse(Console.ReadLine());
            //    // H = Homem | M = Mulher
            //    string genero = Console.ReadLine().ToLower();// Tudo o que o usario inserir ficará em letra minuscula
            //    SerHumano ser = new SerHumano(nome, idade, genero);
            //    pessoas.Add(ser);
            //}

            //int indiceHomi = -1, indiceMuie = -1;
            //int idadeHomi = -1, idadeMuie = -1;

            //for (int i = 0; i < pessoas.Count; i++)
            //{
            //    if (pessoas[i].genero == "m")
            //    {
            //        if (idadeMuie < pessoas[i].idade)
            //        {
            //            indiceMuie = i;
            //            idadeMuie = pessoas[i].idade;
            //        }
            //    }
            //    if (pessoas[i].genero == "h")
            //    {
            //        if (idadeHomi < pessoas[i].idade)
            //        {
            //            indiceHomi = i;
            //            idadeHomi = pessoas[i].idade;
            //        }
            //    }
            //    //switch (pessoas[i].genero)
            //    //{
            //    //    case "m":
            //    //        if (idadeMuie < pessoas[i].idade)
            //    //        {
            //    //            indiceMuie = i;
            //    //            idadeMuie = pessoas[i].idade;
            //    //        }
            //    //        break;
            //    //    case "h":
            //    //        if (idadeHomi < pessoas[i].idade)
            //    //        {
            //    //            indiceHomi = i;
            //    //            idadeHomi = pessoas[i].idade;
            //    //        }
            //    //        break;
            //    //    default:
            //    //        break;
            //    //}
            //}
            //Console.WriteLine("-----------//--------------®");
            //try
            //{
            //    Console.WriteLine("Mulher mais velha");
            //    Console.WriteLine(pessoas[indiceMuie].nome);
            //    Console.WriteLine(pessoas[indiceMuie].idade);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Nao existe mulheres na lista");
            //}
            //Console.WriteLine("-----------//--------------®");
            //try
            //{
            //    Console.WriteLine("Homem mais velho");
            //    Console.WriteLine(pessoas[indiceHomi].nome);
            //    Console.WriteLine(pessoas[indiceHomi].idade);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Nao existe homens na lista");
            //}

            ///Exc 03

            //List<Cachorro> cachorro = new List<Cachorro>();

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("\n\nInsira o nome do cachorro");
            //    string nome = Console.ReadLine();
            //    Console.WriteLine("Insira o nome do Dono");
            //    string nomeDoDono = Console.ReadLine();
            //    Console.WriteLine("Insira a Idade do Pet");
            //    int idade = int.Parse(Console.ReadLine());
            //    Cachorro cao = new Cachorro(nome, nomeDoDono, idade);
            //    cachorro.Add(cao);
            //}            //int cont =0;
            //for (int i = 0; i < cachorro.Count; i++)
            //{
            //    if (cachorro[i].idade >= 4)
            //    {
            //        Console.WriteLine("\nPet possui mais de 4 anos:");
            //        cont++;
            //        Console.WriteLine(cachorro[i].nome);
            //        Console.WriteLine(cachorro[i].nomeDoDono);
            //        Console.WriteLine(cachorro[i].idade);
            //    }
            //}
            //if (cont == 0)
            //{
            //    Console.WriteLine("\nNão Possuem cachorros com mais de 4 anos de idade");
            //}
             
            ///Exc 04
            ///

        }
    }
}
