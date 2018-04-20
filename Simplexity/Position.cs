using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{

    class Position
    {

        /// <summary>
        /// Esta classe irá representar a localização
        /// da linha e coluna no tabuleiro
        /// </summary>

        public int Linha { get; }
        public int Coluna { get; }

        public Position(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
    }
}
