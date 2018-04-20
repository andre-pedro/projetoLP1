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
    class Layout
    {
        char[,] simbolos = new char[7, 7];


        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        public void Desenha(Board board)
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; i < 7; j++)
                    simbolos[i, j] = Pecas(board.GetState(new Position(i,j)));

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
                case default:
                    return '|';
            }
        }
    }
}
