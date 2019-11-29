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
            Console.Write("\n_________________________________\n");
            Console.Write("Calculadora: ");

            Console.Write("Ingrese un numero: ");
            string num1T = Console.ReadLine()
            double num1 = Convert.ToDouble(num1T);

            Console.Write("Ingrese otro numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.WriteLine("\n_________________________________\n");
            Console.WriteLine("Juego de palabras: ");

            string color, pluralNoun, celebrity;

            Console.Write("Ingrese un color: ");
            color = Console.ReadLine();

            Console.Write("Ingrese un sustantivo plural: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Ingrese un animal: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Rosas son " + color);
            Console.WriteLine(pluralNoun + " son azules");
            Console.WriteLine("Yo amo los " + celebrity);
		}
	}
}