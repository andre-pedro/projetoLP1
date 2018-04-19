using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Board
    {
        //var de instancia  da class State que  cria 
        //um array
        private State[,] state;


        // cria o tamanho do tabuleiro
        public Board()
        {
            state = new State[7, 7];

        }

        /*
        //posiçoes
        public State GetState(Position position)
        {
            return state[position.Linha, position.Coluna];
        }
        */


    }
}
