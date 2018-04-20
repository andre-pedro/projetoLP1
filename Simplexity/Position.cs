using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    /// <summary>
    /// Esta classe irá representar a localização
    /// da linha e coluna no tabuleiro
    /// </summary>
    class Position
    {

        public int Linha { get; }
        public int Coluna { get; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="coluna"></param>
        public Position(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }


        public Position(int coluna)
        {
            Coluna = coluna;
        }
    }
}
