using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio_AlbertoJPSantos.Final.Classes;

namespace Desafio_AlbertoJPSantos.Classes
{
    class Jogo
    {
        public Baralho BaralhoDeCartas { get; set; }
        public int Jogador { get; set; }
        public int Robot { get; set; }

        public Jogo()
        {
            Baralho baralho = new Baralho();
            baralho.EmbaralharBaralho();
            BaralhoDeCartas = baralho;
            Jogador = 0;
            Robot = 0;
        }
        public void CartasJogador(Cartas carta)
        {
            Jogador =+ Pontos(carta);
        }

        public void CartasRobot(Cartas carta)
        {
            Robot =+ Pontos(carta);
        }
        public int Pontos(Cartas carta)
        {
            int pontos = 0;
            if (carta.Nome != "Ás" || carta.Nome != "Rei" || carta.Nome != "Dama" || carta.Nome != "Valete" || carta.Nome != "10")
            {
                switch (carta.Nome)
                {
                    case "2":
                        pontos = 2;
                        break;
                    case "3":
                        pontos = 3;
                        break;
                    case "4":
                        pontos = 4;
                        break;
                    case "5":
                        pontos = 5;
                        break;
                    case "6":
                        pontos = 6;
                        break;
                    case "7":
                        pontos = 7;
                        break;
                    case "8":
                        pontos = 8;
                        break;
                    case "9":
                        pontos = 9;
                        break;
                }
            }
            else
            {
                pontos = 10;
            }
            return pontos;
        }

    }
}
