using System;
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

            // Chama Start()
            Start();

            //para testar se desenha
            Layout layout = new Layout();
            Board board = new Board();

            // another try
            layout.Desenha(board);

        }

        static private void Start()
        {
            // Var. Misc
            string s1 = "Projeto de Linguagens de Programação 2017/2018";
            string s2 = "André Pedro, André Santos e Tiago Alves";
            string s3 = "Nuno Fachada";
            string s4 = "Prima [ENTER] para começar...";

            // Parametros
            int cubosBrancos;
            int cilindrosBrancos;
            int cubosVermelhos;
            int cilindrosVermelhos;

            // Start
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(s1.PadLeft(s1.Length + 0));
            Console.WriteLine();
            Console.WriteLine("Contribuidores: " + s2.PadLeft(s2.Length + 3));
            Console.WriteLine("Docente: " + s3.PadLeft(s3.Length + 10));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(s4.PadLeft(s4.Length + 0));
            Console.ReadKey();
            // Turnos
            for (int turno = 0; turno <= 1000; turno++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.WriteLine("[Show_World_Test] ");
                Console.WriteLine();
                Console.WriteLine("7      |   |   |   |   |   |   |");
                Console.WriteLine("6      |   |   |   |   |   |   |");
                Console.WriteLine("5      |   |   |   |   |   |   |");
                Console.WriteLine("4      |   |   |   |   |   |   |");
                Console.WriteLine("3      |   |   |   |   |   |   |");
                Console.WriteLine("2      |   |   |   |   |   |   |");
                Console.WriteLine("1      |   |   |   |   |   |   |");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("       1   2   3   4   5   6   7");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("[Jogador 1 - ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Branco");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("]");
                Console.WriteLine();
                Console.WriteLine("Cubos Brancos: " + cubosBrancos);
                Console.WriteLine("Cilindros Brancos: " + cilindrosBrancos);
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("[Jogador 2 - ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Vermelho");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("]");
                Console.WriteLine();
                Console.WriteLine("Cubos Vermelhos: " + cubosVermelhos);
                Console.WriteLine("Cilindros Vermelhos: " + cilindrosVermelhos);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("[Turno: " + turno + "]");
                Console.WriteLine();
            }
        }
    }
}