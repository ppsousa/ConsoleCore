using System;
using GameTop.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo( new Jogador1("Ronaldo"),  new Jogador2());
            jogo.IniciarJogo();
        }
    }

}
