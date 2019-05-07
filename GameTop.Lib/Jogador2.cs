using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chuta()
        {
            return "Paulo está chutando";
        }

        public string Corre()
        {
            return "Paulo está correndo";
        }

        public string Passe()
        {
            return "Paulo está passando";
        }
    }
}