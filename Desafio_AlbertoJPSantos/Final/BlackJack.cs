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
            int p = 0;
            foreach (Cartas cartas in baralho.BaralhoCartas)
            {
                Console.WriteLine("\nVocê deseja pegar uma carta? Sim = S / Não = N");
                string escolha = Console.ReadLine();
                if (escolha == "s" || escolha == "S")
                {
                    if (cartas.Naipe == " ♦ Ouro ♦  " || cartas.Naipe == " ♥ Copas ♥  ")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(cartas.Nome + " -" + cartas.Naipe);
                        Console.ResetColor();
                        p = baralho.Pontos(cartas);
                        Console.WriteLine(" | Pontos = " + p);
                        Cartas primeira = baralho.PegarPrimeiraCarta();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(cartas.Nome + "-" + cartas.Naipe);
                        Console.ResetColor();
                        p = baralho.Pontos(cartas);
                        Console.WriteLine(" | Pontos = " + p);
                        Cartas primeira = baralho.PegarPrimeiraCarta();
                    }
                }
                if (escolha == "n" || escolha == "N")
                {
                    break;                
                }
            }
           
            Console.ReadLine();
        }

    }
}
