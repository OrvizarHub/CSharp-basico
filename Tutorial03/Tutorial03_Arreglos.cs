using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("\n_________________________________\n");
            Console.WriteLine("Arreglos");

            int[] numerosSuerte  = {4, 8, 15, 16, 23, 42};
            Console.WriteLine(numerosSuerte[1]);
            numerosSuerte[1] = 12;
            Console.WriteLine(numerosSuerte);

            string[] amigos = new string[5];
            friends[0] = "Jaime";
            friends[1] = "Johana";
			
			Console.WriteLine("\n___________________________\n");
            Console.WriteLine("Arreglos 2D");

            int[,] matriz = {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };

            Console.WriteLine(matriz[0, 1]);
            Console.WriteLine(matriz[1, 1]);
            Console.WriteLine(matriz[2, 1]);

            int[,] matriz = new int[3, 2];
		}
	}
}