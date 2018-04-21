using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    /// <summary>
    /// e a skin do jogo by: Tiago alves
    /// </summary>
    class Layout
    {
        char[,] simbolos = new char[7, 7];


        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        public void Render(Board board)
        {
            for (int row = 0; row < 7; row++)
                for (int column = 0; column < 7; column++)
                    simbolos[row, column] = Pecas(board.GetState(new Position(row, column)));

            Console.WriteLine($"{simbolos[0, 0]}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        private char Pecas(State state)
        {
            switch (state)
            {
                case State.R:
                    return 'R';
                case State.r:
                    return 'r';
                case State.W:
                    return 'W';
                case State.w:
                    return 'w';
                default:
                    return '|';
            }
        }
    }
}
