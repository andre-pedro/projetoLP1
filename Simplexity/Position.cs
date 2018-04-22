using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    /// <summary>
    /// Representar a localização da linha e coluna no tabuleiro.
    /// Esta classe é imutavél. Tudo o que nela pertence é apenas de leitura. 
    /// </summary>
    class Position
    {

        public int Linha { get; }
        public int Coluna { get; }


        /// <summary>
        /// Existem dois constructores "Overload"
        /// nesta classe, enquanto o primeiro recebe linha 
        /// e coluna para poder desenhar, a outra recebe 
        /// só o parametro de coluna para podermos inserir 
        /// a jogada consoante a escolha do jogador 
        /// </summary>
        /// <param name="linha">linha no tabuleiro</param>
        /// <param name="coluna">coluna no tabuleiro</param>
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
