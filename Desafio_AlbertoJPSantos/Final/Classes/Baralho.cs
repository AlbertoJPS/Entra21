using Desafio_AlbertoJPSantos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_AlbertoJPSantos.Final.Classes
{
    class Baralho
    {
        
        public List<Cartas> BaralhoCartas { get; set; }

        public Baralho()
        {
            List<Cartas> baralho = new List<Cartas>();
            string[] nomes = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Valete", "Dama", "Rei", "Ás" };
            string[] naipes = new string[] { " ♠ Espada ♠", " ♦ Ouro ♦", " ♥ Copas ♥", " ♣ Paus ♣" };

            foreach (string item in naipes)
            {
                foreach (string carta in nomes)
                {
                    baralho.Add(new Cartas { Nome = carta, Naipe = item });
                }
            }
            BaralhoCartas = baralho;
            
        }
        public void EmbaralharBaralho()
        {
            List<Cartas> baralho = BaralhoCartas;
            var ran = new Random();
            BaralhoCartas = baralho.OrderBy(item => ran.Next()).ToList();
        }
        public Cartas PegarPrimeiraCarta()
        {
            List<Cartas> baralho = BaralhoCartas;
            var cartaDoTopo = baralho.First();
            baralho.Remove(cartaDoTopo);
            return cartaDoTopo;
        }
        public void ResetarBaralho()
        {
            List<Cartas> baralho = new List<Cartas>();
            baralho = new Baralho().BaralhoCartas;
            BaralhoCartas = baralho;
        }
    }
}
