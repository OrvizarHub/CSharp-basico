using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4
{
    class Chef
    {
        public void PrepararPollo()
        {
            Console.WriteLine("El chef prepara pollo");
        }

        public void PrepararEnsalada()
        {
            Console.WriteLine("El chef prepara ensalada");
        }

        public virtual void PrepararPlatoEspecial()
        {
            Console.WriteLine("El chef prepara costillas BBQ");
        }
    }
}
