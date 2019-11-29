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
            Console.WriteLine("Estructura switch");

            Console.WriteLine(QueDiaEs(1));
            Console.WriteLine(QueDiaEs(5));
            Console.WriteLine(QueDiaEs(23));
		}
		
		static string GetDay(int diaNum)
        {
            string diaNombre;

            switch (diaNum)
            {
                case 0:
                    diaNombre = "Lunes";
                    break;
                case 1:
                    diaNombre = "Martes";
                    break;
                case 2:
                    diaNombre = "Miercoles";
                    break;
                case 3:
                    diaNombre = "Jueves";
                    break;
                case 4:
                    diaNombre = "Viernes";
                    break;
                case 5:
                    diaNombre = "Sabado";
                    break;
                case 6:
                    diaNombre = "Domingo";
                    break;
                default:
                    diaNombre = "Dato numerico invalido";
                    break;
            }

            return diaNombre;
        }