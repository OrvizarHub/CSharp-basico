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
            Console.WriteLine("Estructura if");

            bool esHombre = true;
            bool esAlto = true;

            if (esHombre || esAlto)
            {
                Console.WriteLine("Eres un hombre alto");
            }
            else if(esHombre && !esAlto)
            {
                Console.WriteLine("Tu eres un hombre pequeno");
            }
            else
            {
                Console.WriteLine("Tu no eres ni hombre, ni tampoco alto");
            }

            Console.WriteLine("\n_________________________________\n");
            Console.WriteLine("Estructura if + funciones");

            Console.WriteLine(Maximo(2, 3, 4));
            Console.WriteLine(Maximo(4, 3, 2));
            Console.WriteLine(Maximo(3, 4, 2));
            Console.WriteLine(Maximo(3, 3, 3));
			
			Console.WriteLine("\n_________________________________\n");
			Console.WriteLine("Calculadora");
			
			Console.Write("Ingrese un numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese otro numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese operador: ");
            string op = Console.ReadLine();

            Console.WriteLine(Calcular(num1, num2, op));
			
		}
		
		//static int Maximo(int num1, int num2)
		static int Maximo(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
		
		static double Calcular(double a, double b, string op)
        {
            double resultado;

            if (op == "+")
            {
                resultado = a + b;
            }
            else if(op == "-")
            {
                resultado = a - b;
            }
            else if (op == "*")
            {
                resultado = a * b;
            }
            else if (op == "/")
            {
                resultado = a / b;
            }
            else
            {
                Console.WriteLine("Operator invalido");
                resultado = 0;
            }

            return resultado;
        }
	}
}