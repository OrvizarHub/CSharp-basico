using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4
{
    class ItalianChef : Chef
    {
        public void PrepararPasta()
        {
            Console.WriteLine("El chef prepara pasta");
        }

        public void PrepararBolognese()
        {
            Console.WriteLine("El chef prepara bolognese");
        }

        public override void PrepararPlatoEspecial()
        {
            Console.WriteLine("The chef makes pizza");
        }
    }
}
