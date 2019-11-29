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
            Console.WriteLine("Metodos o funciones");

			//Console.WriteLine("Hola " + nombre +  ", tu edad es " + edad);

            Console.WriteLine(Saludar("Miguel", 33));
            Console.WriteLine(Saludar("Juan", 66));
            Console.WriteLine(Saludar("Tomas", 12));
		}
	
		//static void Saludar(string nombre, int edad)
		static int Saludar(string nombre, int edad)
        {
            Console.WriteLine("Hola " + name +  ", tu edad es " + edad);
            
            return edad*edad;
		}
	}
}