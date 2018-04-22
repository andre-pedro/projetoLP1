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
        public bool Wincheck(int[,] array, int n)
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
                    //Horizontal verification 
                    /* k is X coord which cycles from actual position to end of row */
                    for (int k = i; k < array.GetLength(0); k++)
                    {
                        /* If number at [X,Y] is equal to n, increment counter */
                        if (array[k, j] == n)
                        {
                            count++;
                        }
                        else
                        {
                            count = 0;
                        }
                        /* If counter is >= 4, four in line is found */
                        if (count >= 4)
                        {
                            teste = true;
                            break;
                        }
                    }

                    /* Vertical verification */
                    /* k is Y coord which cycles from actual position to end of row */
                    for (int k = j; k < array.GetLength(1); k++)
                    {
                        /* If number at [X,Y] is equal to n, increment counter */
                        if (array[i, k] == n)
                        {
                            count++;
                        }
                        else
                        {
                            count = 0;
                        }
                        /* If counter is >= 4, four in line is found */
                        if (count >= 4)
                        {
                            teste = true;
                            break;
                        }
                    }

                    /* Counter is reset before every verification */
                    count = 0;
                }
                diagonal = i; /* diagcounter receives actual X */
                              /* k is Y coord which cycles from actual position to end of row */
                for (int k = j; k < array.GetLength(1); k++)
                {
                    /* When diagcounter (X) value is offgrid, break cycle */
                    if (diagonal == array.GetLength(0))
                    {
                        break;
                    }

                    /* If number at [X,Y] is equal to n, increment counter */
                    if (array[diagonal, k] == n)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }

                    /* If counter is >= 4, four in line is found */
                    if (count >= 4)
                    {
                        teste = true;
                        break;
                    }
                    /* diagcounter (X coord moves 1 to the right) */
                    diagonal++;
                }
                /* Counter is reset before every verification */
                count = 0;

                /* From right to left diagonal (upside down) */
                diagonal = i; /* diagcounter receives actual X */
                              /* k is Y coord which cycles from actual position to end of row */
                for (int k = j; k < array.GetLength(1); k++)
                {
                    /* When diagcounter (X) value is offgrid, break cycle */
                    if (diagonal < 0)
                    {
                        break;
                    }

                    /* If number at [X,Y] is equal to n, increment counter */
                    if (array[diagonal, k] == n)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }

                    /* If counter is >= 4, four in line is found */
                    if (count >= 4)
                    {
                        teste = true;
                        break;
                    }
                    /* diagcounter (X coord moves 1 to the left) */
                    diagonal--;
                }
            }
            return teste;
        }


    }
}

