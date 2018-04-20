using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Player
    {
        //Esta classe irá obter o input inserido pelo jogador
        public Position ColumnPosition(Board board)
        {
            Console.WriteLine("Escolha a coluna onde quer jogar");
            int colInput = Convert.ToInt32(Console.ReadLine());
            return colInput;
        }

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
                    return ;
            }
        }
    }

}

}
