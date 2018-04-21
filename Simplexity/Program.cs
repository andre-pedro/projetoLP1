﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Var. Misc
            string s1 = "Projeto de Linguagens de Programação 2017/2018";
            string s2 = "André Pedro, André Santos e Tiago Alves";
            string s3 = "Nuno Fachada";
            string s4 = "Prima [ENTER] para começar...";

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

            Board board = new Board();
            Layout layout = new Layout();
            Player white = new Player();
            Player red = new Player();
            State estado = new State();
            int jogador;

            // Turnos
            for (int turno = 0; turno <= 10; turno++)
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
                    Console.WriteLine("Cubos Brancos: ");
                    Console.WriteLine("Cilindros Brancos: ");
                    Console.WriteLine();
                    // info jogador 2
                    Console.Write("Jogador 2 - ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Vermelho");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Cubos Vermelhos: ");
                    Console.WriteLine("Cilindros Vermelhos: ");
                    Console.WriteLine();
                    // info vez do jogador 1 || 2
                    Console.Write("Vez do Jogador: ");
                    if (vez == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Branco");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine();
                        Console.WriteLine();
                        // info turnos
                        Console.WriteLine("Turno: " + turno);
                        // play
                        Position next;
                        jogador = 1;
                        next = white.ColumnPosition(board);
                        estado = white.Escolhapecas(board, jogador);
                        board.SetState(next, estado);
                    }
                    if (vez == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Vermelho");
                        Console.ForegroundColor = ConsoleColor.Gray;
 
                        Console.WriteLine();
                        Console.WriteLine();
                        // info turnos
                        Console.WriteLine("Turno: " + turno);
                        // play
                        Position next;
                        jogador = 2;
                        next = red.ColumnPosition(board);
                        estado = red.Escolhapecas(board, jogador);
                        board.SetState(next, estado);
                    }
                }
            }
        }
    }
}