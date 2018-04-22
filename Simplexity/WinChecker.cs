using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    /// <summary>
    /// Esta classe é responsavél por verificar
    /// se existe vitoria. A verificação é feita
    /// na diagonal, horizontal e vertical.
    /// </summary>
    class WinChecker
    {

        public State Check(Board board)
        {
            if (CheckForWin(board, State.R)) return State.R;
            if (CheckForWin(board, State.r)) return State.r;
            if (CheckForWin(board, State.W)) return State.W;
            if (CheckForWin(board, State.w)) return State.w;
            return State.Undecided;
        }

        private bool CheckForWin(Board board, State player)
        {
            for (int row = 0; row < 7; row++)
                if (AreAll(board, new Position[] { new Position(row, 0), new Position(row, 1), new Position(row, 2), new Position(row, 3), }, player))
                    return true;
            for (int column = 0; column < 7; column++)
                if (AreAll(board, new Position[] { new Position(column, 0), new Position(column, 1), new Position(column, 2), new Position(column, 3), }, player))
                    return true;

            if (AreAll(board, new Position[] { new Position(0, 0), new Position(1, 1), new Position(2, 2), new Position(3, 3), new Position(4, 4), new Position(5, 5), new Position(6, 6) }, player))
                return true;
            if (AreAll(board, new Position[] { new Position(6, 0), new Position(5, 1), new Position(4, 2), new Position(3, 3), new Position(2, 4), new Position(1, 5), new Position(0, 6), }, player))
                return false;
        }

        private bool AreAll(Board board, Position[] positions, State state)
        {
            foreach (Position position in positions)
                if (board.GetState(position) != state) return false;
            return true;
        }























        /*
        /// <summary>
        /// Metódo de verificação da vitoria
        /// </summary>
        /// <param name="array">linhas e colunas do tabuleiro</param>
        /// <param name="n">pelas a verificar</param>
        /// <returns></returns>
        public bool Wincheck(state, int n)
        {
            bool teste;
            teste = false;
            int count;
            int diagonal;

            
            //verifica no array bidimensional
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (teste == true) break;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (teste == true)
                        break;

                    count = 0;



                    

                    for (int k = i; k < array.GetLength(0); k++)
                    {
                        /* Se o numero em [X,Y] e' igual a n, o contador incrementa */
        /*     if (array[k, j] == n)
             {
                 count++;
             }
             else
             {
                 count = 0;
             }
             /* Se o contador e' >= 4, uma sequencia de 4 e' encontrada */
        /*  if (count >= 4)
          {
              teste = true;
              break;
          }
      }




      /* Verificacao Vertical */
        /* k e' a coordenada Y que vai desde a posicao atual ao fim da linha */
        /*      for (int k = j; k < array.GetLength(1); k++)
          /*    {
                  /* Se o numero em [X,Y] e' igual a n, o contador incrementa */
        /*           if (array[i, k] == n)
                   {
                       count++;
                   }
                   else
                   {
                       count = 0;
                   }
                   /* Se o contador e' >= 4, uma sequencia de 4 e' encontrada */
        /*            if (count >= 4)
                    {
                        teste = true;
                        break;
                    }
                }

                /* O Contador e' reiniciado antes de cada verificacao */
        /*             count = 0;


                     diagonal = i; /* diagcounter recebe do X atual */
        /* k e' a coordenada Y, que vai desde a posicao atual ate' ao fim da linha */

        /*           for (int k = j; k < array.GetLength(1); k++)
                   {
                       /* Quando o valor de diagcounter (X) esta' fora da grid, quebra o processo */
        /*                if (diagonal == array.GetLength(0))
                        {
                            break;
                        }

                        /* Se o numero e' [X,Y] e igual a n, o contador incrementa */
        /*              if (array[diagonal, k] == n)
                      {
                          count++;
                      }
                      else
                      {
                          count = 0;
                      }

                      /* Se o contador for >= 4, uma sequencia de 4 e' encontrada */
        /*                     if (count >= 4)
                             {
                                 teste = true;
                                 break;
                             }
                             /* diagcounter (coordenada X move-se 1 posicao para a direita) */
        /*                  diagonal++;
                      }
                      /* Contador e' reiniciado antes de cada verificacao */
        /*     count = 0;



             /* Diagonal da direita para a esquerda (de baixo para cima) */
        /*              diagonal = i; /* diagcounter recebe o X atual */
        /* k e' a coordenada Y, que percorre da posicao atual ate ao fim da linha */
        /*               for (int k = j; k < array.GetLength(1); k++)
                       {
          /*                 /* Quando o valor diagcounter (X) esta' fora da grid, quebra o processo */
        /*              if (diagonal < 0)
                      {
                          break;
                      }

                      /* Se o numero em [X,Y] for igual a n, o contador incrementa */
        /*            if (array[diagonal, k] == n)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }

                    /* Se o contador for >= 4, uma sequencia de 4 e' encontrada */
        /*           if (count >= 4)
                   {
                       teste = true;
                       break;
                   }
                   /* diagcounter (coordenada X move-se 1 posicao para a esquerda) */
        /*              diagonal--;
                  }
              }
          }
          return teste;
      }*/
    }
}

