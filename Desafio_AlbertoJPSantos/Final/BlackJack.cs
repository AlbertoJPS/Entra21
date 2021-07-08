using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_AlbertoJPSantos.Classes;
using Desafio_AlbertoJPSantos.Final.Classes;

namespace Desafio_AlbertoJPSantos.Final
{
    class BlackJack 
    {
        static void Main(string[] args)
        
       {
            Baralho baralho = new Baralho();
            baralho.EmbaralharBaralho();

            foreach (Cartas cartas in baralho.BaralhoCartas)
            {
                if (cartas.Naipe == " ♦ Ouro ♦" || cartas.Naipe == " ♥ Copas ♥")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(cartas.Nome + " -" + cartas.Naipe + " | Pontos = " + Ponto());
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(cartas.Nome + "-" + cartas.Naipe + " | Pontos = " + cartas.);
                }
                Console.ReadLine();
            }
            Console.WriteLine("");
            Console.WriteLine("->Pega primeira carta");
            Cartas primeira = baralho.PegarPrimeiraCarta();
            Console.WriteLine(primeira.Nome + "-" + primeira.Naipe);
            Console.ReadLine();
        }

    }
}
