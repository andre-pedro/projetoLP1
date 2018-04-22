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

            for (int i=0; i<array.GetLength(0);i++)
            {
                if (teste == true) break;
                for(int j=0; j<array.GetLength(1);j++)
                {
                    if (teste == true)
                        break;  
                }
                count = 0;
            }
            return true;
        }
    }
}