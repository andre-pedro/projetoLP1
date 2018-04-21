using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    /// <summary>
    /// 
    /// </summary>
    class Player
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <returns>a coordenada em que o jogador quer jogar </returns>
        public Position ColumnPosition(Board board)
        {
            Console.WriteLine("Escolha a coluna onde quer jogar");
            int colInput = Convert.ToInt32(Console.ReadLine());
            Position coordenada = NumberPosition(colInput);
            return coordenada;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="colInput">Recolhe o inteiro que o jogador inseriu</param>
        /// <returns>Posição (de 1 a 7) na qual o jogador escolheu jogar</returns>
        private Position NumberPosition(int colInput)
        {
            switch (colInput)
            {
                case 1:
                    return new Position(1);
                case 2:
                    return new Position(2);
                case 3:
                    return new Position(3);
                case 4:
                    return new Position(4);
                case 5:
                    return new Position(5);
                case 6:
                    return new Position(6);
                case 7:
                    return new Position(7);
                default:
                    return null;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <param name="jogador"></param>
        /// <returns></returns>
        public State Escolhapecas(Board board, int jogador)
        {
            Console.WriteLine("Escolha entre cubo [1] ou cilindro [2]");
            int pecaescolhida = Convert.ToInt32(Console.ReadLine());
            State playerdecision = SetPecas(pecaescolhida, ChoosePlayer.none);
            return playerdecision;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pecaescolhida"></param>
        /// <param name="jogador"></param>
        /// <returns></returns>
        private State SetPecas(int pecaescolhida,int jogador)
        {

            if (jogador == 1)
            {

                switch (pecaescolhida)
                {
                    case 1:
                        return State.W;
                    case 2:
                        return State.w;
                }
            }

            if (jogador == 2)
            {

                switch (pecaescolhida)
                {
                    case 1:
                        return State.R;
                    case 2:
                        return State.r;
                }
            }
            return 0;
        }
    }
}
