using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("\n___________________________\n");
            Console.WriteLine("For loop");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            int[] numerosSuerte = { 4, 8, 15, 16, 23, 42 };

            for (int i = 0; i < numerosSuerte.Length; i++)
            {
                Console.WriteLine(numerosSuerte[i]);
            }

            Console.WriteLine("\n");

			// Another example
            Console.WriteLine(Potencia(2, 4));
		}
		
		static int Potencia(int baseNum, int potNum)
        {
            int resultado = 1;

            for(int i = 0; i < potNum; i++)
            {
                resultado = resultado * baseNum;
            }

            return resultado;
        }
	}
}

		
		