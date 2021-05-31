using System;

namespace Joeslei
{
    class Program
    {
        static void Main(string[] args)
        {


            //Exc 1
            string escolha, joeslei, goblin, orc, troll;
            int dia = 0;
            bool caminho = false;


            Console.WriteLine("Eu sou seu Deus Joeslei, se você quer chegar até a capital,");
            Console.WriteLine("precisará escolher entre passar pela estrada, ou pela floresta.");
            Console.WriteLine("Sabendo que vai se 'fuder' em qualquer um dos caminhos, mas qual você escolhe?");
            Console.WriteLine();
            Console.WriteLine("Estrada < || > Floresta");
            Console.WriteLine("          ||           ");
            Console.WriteLine("          ||           ");
            Console.WriteLine("          ||           "); 
            Console.WriteLine();
            escolha = Console.ReadLine(); Console.WriteLine();

    //escolha

            switch (escolha)
            {
                case "floresta":
                case "Floresta":
                    caminho = true;
                    Console.WriteLine(escolha + " escolhida");
                    break;
                case "estrada":
                case "Estrada":
                    caminho = false;
                    Console.WriteLine(escolha + " escolhida");
                    break;
                default:
                    Console.WriteLine("Esse lugar não é uma opção para você, Heroi");
                    Console.WriteLine("Escolha entre Estrada ou Floresta");
                    escolha = Console.ReadLine();
                    break;
            }
           

            if (caminho == true)
            {
                while (dia == 0)
                {
                    for (int i = 1; i < 2; i++)
                    {
                        Random rnd = new Random();
                        string[] etapa = { "Goblin", "Orc", "Troll" };

                        // Generate random indexes for pet names.
                        int etapaIndex = rnd.Next(etapa.Length);

                        // Display the result.
                        Console.WriteLine();
                        Console.WriteLine("Dia 1");
                        Console.WriteLine();
                        Console.WriteLine("Joeslei seguiu por seu caminho por algums horas, quando de repente ouve um barulho próximo");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Deus: _Algo está se aproximando rápido..");
                        Console.WriteLine();
                        Console.WriteLine("** o som fica mais forte, e sai de um lugar escondido**");
                        Console.WriteLine("   Surge em frete a Joeslei um:     {0}", etapa[etapaIndex]);
                        //Console.WriteLine();
                        //Console.WriteLine("O que você faz?");
                        //switch(rnd.Next(0, 3)

                    }
                }
                while (dia == 1)
                {

                }

            }
            else
            {
                while (dia == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Dia 1");
                    Console.WriteLine();
                    Console.WriteLine("Joeslei seguiu por seu caminho por algums horas, quando de repente ouve um barulho próximo");
                    Console.WriteLine();
                }

            }










        }
    }
}
