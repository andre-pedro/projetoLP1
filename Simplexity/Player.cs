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
        ///

        public Position ColumnPosition(Board board)
        {
            Console.Write(" escolha a coluna onde quer jogar: ");
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
        Console.Write(" escolha entre Cubo [1] ou Cilindro [2]: ");
        int pecaescolhida = Convert.ToInt32(Console.ReadLine());
            // prevent play 0 pieces

            if (Program.jogador == 1 && Program.cubosBrancos == 0 && pecaescolhida == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[!] ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("N");
                Console.WriteLine();
                Escolhapecas(board, jogador);
            }
            if (Program.jogador == 1 && Program.cilindrosBrancos == 0 && pecaescolhida == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[!] ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("N");
                Console.WriteLine();
                Escolhapecas(board, jogador);
            }
            if (Program.jogador == 2 && Program.cubosVermelhos == 0 && pecaescolhida == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[!] ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("N");
                Console.WriteLine();
                Escolhapecas(board, jogador);
            }
            if (Program.jogador == 2 && Program.cilindrosVermelhos == 0 && pecaescolhida == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[!] ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("N");
                Console.WriteLine();
                Escolhapecas(board, jogador);
            }
            else
            {
                if (pecaescolhida == 1 && jogador == 1)
                {
                    Program.cubosBrancos--;
                    Console.WriteLine(Program.cubosBrancos);
                }
                if (pecaescolhida == 2 && jogador == 1)
                {
                    Program.cilindrosBrancos--;
                    Console.WriteLine(Program.cilindrosBrancos);
                }
                if (pecaescolhida == 1 && jogador == 2)
                {
                    Program.cubosVermelhos--;
                    Console.WriteLine(Program.cubosVermelhos);
                }
                if (pecaescolhida == 2 && jogador == 2)
                {
                    Program.cilindrosVermelhos--;
                    Console.WriteLine(Program.cilindrosVermelhos);
                }
            }
            if (Program.cubosBrancos < 0)
            {
                Program.cubosBrancos = 0;
            }
            if (Program.cubosVermelhos < 0)
            {
                Program.cubosVermelhos = 0;
            }
            if (Program.cilindrosBrancos < 0)
            {
                Program.cilindrosBrancos = 0;
            }
            if (Program.cilindrosVermelhos < 0)
            {
                Program.cilindrosVermelhos = 0;
            }
            State playerdecision = SetPecas(pecaescolhida, jogador);
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
