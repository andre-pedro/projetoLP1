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
            //cubosBrancos = 11;
            //cilindrosBrancos = 10;
            //cubosVermelhos = 11;
            //cilindrosVermelhos = 10;

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
        }

    }
}