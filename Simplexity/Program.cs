using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Program
    {
        public static int cubosVermelhos = 2;
        public static int cubosBrancos = 2;
        public static int cilindrosVermelhos = 10;
        public static int cilindrosBrancos = 10;
        public static int jogador;

        static void Main(string[] args)
        {
            // Var. Misc
            string s1 = "Projeto de Linguagens de Programação 2017/2018";
            string s2 = "André Pedro, André Santos e Tiago Alves";
            string s3 = "Nuno Fachada";
            string s4 = "Prima [ENTER] para começar...";

            // Var. Board / layout /player
            Board board = new Board();
            Layout layout = new Layout();
            Player white = new Player();
            Player red = new Player();
            State estado = new State();

            // Start
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(s1.PadLeft(s1.Length + 0));
            Console.WriteLine();
            Console.WriteLine("Contribuidores: " + s2.PadLeft(s2.Length + 3));
            Console.WriteLine("Docente: " + s3.PadLeft(s3.Length + 10));
            Console.WriteLine();
            Console.Write(s4.PadLeft(s4.Length + 0));
            Console.ReadKey();


            // Turnos
            for (int turno = 0; turno <= 1000; turno++)
            {
                for (int vez = 0; vez <= 1; vez++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    layout.Render(board);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" 1  2  3  4  5  6  7 ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();

                    // info jogador 1
                    Console.Write("Jogador 1 - ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Branco");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Cubos Brancos: " + cubosBrancos);
                    Console.WriteLine("Cilindros Brancos: " + cilindrosBrancos);
                    Console.WriteLine();
                    // info jogador 2
                    Console.Write("Jogador 2 - ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Vermelho");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Cubos Vermelhos: " + cubosVermelhos);
                    Console.WriteLine("Cilindros Vermelhos: " + cilindrosVermelhos);
                    Console.WriteLine();
                    // info turnos
                    Console.WriteLine("Turno: " + turno);
                    Console.WriteLine();
                    // info vez do jogador 1 || 2
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("[!] ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Jogador ");
                    if (vez == 0)
                    {
                        jogador = 1;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Branco");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        // play
                        Position next;

                        // pedir colunas
                        next = white.ColumnPosition(board);


                        // info vez do jogador 1 || 2
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[!] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Jogador ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Branco");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        // pedir pecas
<<<<<<< HEAD
                        estado = white.Escolhapecas(board, jogador);
                        board.SetState(next, estado);

                        int full;
                            full = 0;
                            for (int i = 1; i <= 7; i++)
                            {
                                if (estado != State.Undecided)
                                    ++full;
                            
                        }
                          //  Console.WriteLine("full");
                        if(full==7) Console.WriteLine("full");
                        else board.SetState(next, estado);



                        // board.SetState(next, estado);

=======
                            estado = white.Escolhapecas(board, jogador);
                            board.SetState(next, estado);
>>>>>>> b1a1fc72af92f703e455f6330ab4ae95603c78b4
                    }

                    if (vez == 1)
                    {
                        jogador = 2;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Vermelho");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        // play
                        Position next;
                        // pedir colunas
                        next = red.ColumnPosition(board);
                        // info vez do jogador 1 || 2
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("[!] ");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write("Jogador ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Vermelho");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        // pedir pecas
                            estado = red.Escolhapecas(board, jogador);
                            board.SetState(next, estado);
                    }
                }
                if (cubosVermelhos == 0 && cubosBrancos == 0 && cilindrosVermelhos == 0 && cilindrosBrancos == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Clear();
                    Console.WriteLine("Fim de jogo: Empate!");
                    Console.WriteLine();
                    Environment.Exit(0);
                }
            }
        }
    }
}