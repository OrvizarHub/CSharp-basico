using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n______________________________\n");
            Console.WriteLine("Hola mundo");
			Console.ReadLine();

            Console.WriteLine("______");
            Console.WriteLine("\\    |");
            Console.WriteLine(" \\   |");
            Console.WriteLine("  \\  |");
            Console.WriteLine("   \\ |");
            Console.WriteLine("    \\|");

            Console.WriteLine("\n______________________________\n");
            Console.WriteLine("VARIABLES");

            int edad = 70;
            string nombre;

            nombre = "Juan";
            Console.WriteLine("Hay un hombre llamado " + nombre);
            Console.WriteLine("El tiene " + edad + " de edad.");

            nombre = "Victoria";
            Console.WriteLine("Realmente le agrada " + nombre);
            Console.WriteLine("Que tambien tiene " + edad);

            Console.WriteLine("\n______________________________\n");
            Console.WriteLine("TIPOS DE DATOS");

            string frase = "Mi esculela";
            char nota = 'A';
            int edad = 30;
            double gpa = 3.2; //float, double, decimal 
            bool esHombre = true; //true, false

            Console.WriteLine("\n__________________________________________________________\n");
            Console.WriteLine("STRINGS o CADENA DE CARACTERES");

            string titulo = "Mi\n\"Escuela\"";
            Console.WriteLine(titulo + " it's cool!");
            Console.WriteLine(titulo.Length);
            Console.WriteLine(titulo.ToUpper());
            Console.WriteLine(titulo.Contains("Academy"));
            Console.WriteLine(titulo[0]);
            Console.WriteLine(titulo.IndexOf("o"));
            Console.WriteLine(titulo.Substring(8, 6));

            Console.WriteLine("\n__________________________________________________________\n");
            Console.WriteLine("NUMEROS");

            Console.WriteLine(50);
            Console.WriteLine(5 + 8);
            Console.WriteLine(6 - 8);
            Console.WriteLine(6 * 8);
            Console.WriteLine(6 / 8);
            Console.WriteLine(7 % 2);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);

            Console.WriteLine(5/2);
            Console.WriteLine(5/2.0);

            int num = 6;
            num++;
            Console.WriteLine(num);
            num--;
            num--;
            Console.WriteLine(num);

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3,2));
            Console.WriteLine(Math.Sqrt(3));
            Console.WriteLine(Math.Max(4, 90));
            Console.WriteLine(Math.Min(4, 90));
            Console.WriteLine(Math.Round(4.56456, 3));

            Console.WriteLine("\n__________________________________________________________\n");
            Console.WriteLine("USUARIO INTERFACE");

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            string edad = Console.ReadLine();
            Console.WriteLine("Hola " + name + ", tu tienes " + edad);

            Console.ReadLine();
        }
    }
}
