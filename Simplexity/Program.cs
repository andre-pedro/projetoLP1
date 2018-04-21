using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Program
    {
        private static readonly Player jogador1;

        static void Main(string[] args)
        {

            // Chama Start()
            //Start();

            Board board = new Board();
            Layout layout = new Layout();
            Player white = new Player();
            Player red = new Player();
            int turn = 0;


            while (turn < 5)
            {
                layout.Render(board);
                Position next;

               if (board.NextTurn == jogador1)
                   next = white.ColumnPosition(board);
                else
                   next = red.ColumnPosition(board);
            }
            layout.Render(board);
            Console.ReadKey();
            turn++;
        }
         


        /* TIAGOOO EU COMENTEI O TEU CODIGO PARA TESTAR ISTO EM CIMA
         * 
         se por acaso esqueci.me de descomentar algo toma atencao podes 
         comentar o codigo em cima visto que ainda nao fucniona a 100%
         baseado no jogo tic toe*/


        /*
        static private void Start()
        {
            // Var. Misc
            string s1 = "Projeto de Linguagens de Programação 2017/2018";
            string s2 = "André Pedro, André Santos e Tiago Alves";
            string s3 = "Nuno Fachada";
            string s4 = "Prima [ENTER] para começar...";

            // Start
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(s1.PadLeft(s1.Length + 0));
            Console.WriteLine();
            Console.WriteLine("Contribuidores: " + s2.PadLeft(s2.Length + 3));
            Console.WriteLine("Docente: " + s3.PadLeft(s3.Length + 10));
            Console.WriteLine();
            Console.WriteLine(s4.PadLeft(s4.Length + 0));
            Console.ReadKey();
            // Turnos
            for (int turno = 0; turno <= 10; turno++)
            {
                for (int vez = 0; vez <= 1; vez++)
                {
                    // Parametros simulados
                    int cubosBrancos = 11;
                    int cilindrosBrancos = 10;
                    int cubosVermelhos = 11;
                    int cilindrosVermelhos = 10;

                    /*
                    [SetPecas goes here?]
                    */
                    
                   /* Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.WriteLine("[Board_Goes_Here] ");

                    /*
                    // para testar se desenha
                    Layout layout = new Layout();
                    Board board = new Board();

                    // another try
                    layout.Desenha(board);
                    */

                /*    Console.WriteLine();
                    // info jogador 1
                    Console.Write("[Simulated_Jogador 1 - ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Branco");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("]");
                    Console.WriteLine();
                    Console.WriteLine("Simulated_Cubos Brancos: " + cubosBrancos);
                    Console.WriteLine("Simulated_Cilindros Brancos: " + cilindrosBrancos);
                    Console.WriteLine();
                    // info jogador 2
                    Console.Write("[Simulated_Jogador 2 - ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Vermelho");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("]");
                    Console.WriteLine();
                    Console.WriteLine("Simulated_Cubos Vermelhos: " + cubosVermelhos);
                    Console.WriteLine("Simulated_Cilindros Vermelhos: " + cilindrosVermelhos);
                    Console.WriteLine();
                    // info vez do jogador 1 || 2
                    Console.Write("[Vez do Jogador: ");
                    if (vez == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Branco");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("]");
                        Console.WriteLine();
                        Console.WriteLine();
                        // info turnos
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Turno: " + turno + "]");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        AskPlay();
                    }
                    if (vez == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Vermelho");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("]");
                        Console.WriteLine();
                        Console.WriteLine();
                        // info turnos
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("[Turno: " + turno + "]");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        AskPlay();
                    }
                    Console.ReadKey();
                }
            }

            // Fim de jogo
            Console.Clear();
            Console.WriteLine("Game Over!");
            Console.ReadKey();
            // Restart
            Start();
        }

        private static void AskPlay()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.Write("[!]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Indicar coluna (1-7): ");
            string askColuna = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("[!]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Indicar peça (R / r ou W / w: ");
            string askPeca = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("[!]");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Jogada lida: " + askColuna + " " + askPeca);
        }*/
    }
}