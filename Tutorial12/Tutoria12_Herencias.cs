using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("__________________________________________\n");
            Console.WriteLine("Herencias");

            Chef chef1 = new Chef();
            chef1.PrepararPlatoEspecial();

            ItalianChef chef2 = new ItalianChef();
            chef2.PrepararPlatoEspecial();

            Console.ReadLine();
        }
    }
}
