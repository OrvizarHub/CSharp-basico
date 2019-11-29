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
            Console.WriteLine("Metodos ");

            Estudiante est1 = new Estudiante("Jaime", "Negocios", 2.8);
			Estudiante est2 = new Estudiante("Pamela", "Artes", 3.6);

            Console.WriteLine(est1.TieneHonores());
            Console.WriteLine(est2.TieneHonores());
		}
	}
}
