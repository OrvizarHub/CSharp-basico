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
            Console.WriteLine("Exepciones");

			//Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1 / num2);


            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }

			// More complete
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
			}
		}
	}
}
		