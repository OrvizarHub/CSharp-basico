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
            Book libro1 = new Libro();
            libro1.titulo = "Don Quijote de la Mancha";
            libro1.autor = "De Cervantes";
            libro1.paginas = 70;

            Book libro2 = new Libro();
            libro2.titulo = "El Senor de los Anillos";
            libro2.autor = "Tolkein";
            libro2.paginas = 700;

            Console.WriteLine(libro1.titulo);
            Console.WriteLine(libro1.paginas);
            Console.WriteLine(libro1.autor + "\n");

            Console.WriteLine(libro2.titulo);
            Console.WriteLine(libro2.paginas);
            Console.WriteLine(libro2.autor);

			// Another class
            Book libro1 = new Libro("Harry Potter", "Rowling", 400);

            Console.WriteLine(libro1.titulo);
            Console.WriteLine(libro1.paginas);
            Console.WriteLine(libro1.autor + "\n");

            libro1.titulo = "El hobbit";

            Console.WriteLine(libro1.titulo);

            Book libro2 = new Book();
            libro2.titulo = "El Senor de los Anillos";
            libro2.autor = "Tolkein";
            libro2.paginas = 700;

            Console.WriteLine(libro2.titulo);
            Console.WriteLine(libro2.paginas);
            Console.WriteLine(libro2.autor);
		}
	}
}
