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
        char[,] simbolos = new char[5, 5];


        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        public void Desenha(Board board)
        {
            for(int i = 0; i < 5; i++)
                for(int j = 0; i <5;j++)
                    simbolos[i,j] = 
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
