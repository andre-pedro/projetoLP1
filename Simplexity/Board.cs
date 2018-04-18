using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Board
    {
        //Esta classe irá conter um array de 7x7, onde serão inseridos os elementos do jogo
        private State[,] state;
        public State NextTurn { get; private set; }


        // cria o tamanho do tabuleiro
        public Board()
        {
            state = new State[7, 7];

            //pede ao jogador 1 para jogar cubo ou cilindro da cor branca
            NextTurn = State.W | State.w;
        }
    }
}
