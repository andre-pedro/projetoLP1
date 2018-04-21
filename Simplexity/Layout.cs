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
            {
                for (int column = 0; column < 7; column++)
                {

                    simbolos[row, column] = Pecas(board.GetState(new Position(row, column)));
                    Console.Write($" {simbolos[row, column]} ");
                   
                }
                Console.WriteLine();
            }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    return 'R';
                case State.r:
                    Console.ForegroundColor = ConsoleColor.Red;
                    return 'r';
                case State.W:
                    Console.ForegroundColor = ConsoleColor.White;
                    return 'W';
                case State.w:
                    Console.ForegroundColor = ConsoleColor.White;
                    return 'w';
                default:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    return '|';
            }
        }
    }
}
