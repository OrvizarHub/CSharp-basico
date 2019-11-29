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
            Console.WriteLine("While loop");

            string palabraSecreta = "Jirafa";
            string palabraTest = "";
            int contIntentos = 1;
            int limIntentos = 3;
            bool sinIntentos = false;

            while (palabraTest != palabraSecreta && !sinIntentos)
            {
                if(contIntentos <= limIntentos)
                {
                    Console.Write("Adivina la palabara: ");
                    palabraTest = Console.ReadLine();
                    contIntentos++;
                }
                else
                {
                    sinIntentos = true;
                }
            }

            if (sinIntentos)
            {
                Console.WriteLine("Perdiste!");
            }
            else
            {
                Console.WriteLine("Ganaste!");
            }
		}
	}
}