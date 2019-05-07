using System;
using GameTop.Interface;

namespace GameTOP
{
    public class Jogo
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;
        public Jogo(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }
       
        public void IniciarJogo()
        {
            Console.WriteLine(_jogadorA.Corre());
            Console.WriteLine(_jogadorA.Chuta());
            Console.WriteLine(_jogadorA.Passe());
            Console.WriteLine("Proximo Jogador...");
            Console.WriteLine(_jogadorB.Corre());
            Console.WriteLine(_jogadorB.Chuta());
            Console.WriteLine(_jogadorB.Passe());

        }
    }
}