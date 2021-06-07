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

            ///exc 04
            ///
            List<Animais> animais = new List<Animais>();

            for (int i = 0; i < 2; i++)
            {
                Animais animal = new Animais();

                Console.Write("\nInsira o nome do animal: "); animal.nome = Console.ReadLine();
                Console.Write("Insira a idade: "); animal.idade = Convert.ToInt32(Console.ReadLine());
                Console.Write("Insira sua espécie: "); animal.genero = Console.ReadLine();
                Console.Write("Insira o tempo que ele está no Zoo em dias: "); animal.tempoZoo = Convert.ToInt32(Console.ReadLine());
                animais.Add(animal);
            }
            // fazer o sort manual
            foreach (var item in animais)
            {
                Console.WriteLine(item.nome + " " + item.idade + " " + item.especie + " " + item.tempoZoo);
            }
        }
    }
}
