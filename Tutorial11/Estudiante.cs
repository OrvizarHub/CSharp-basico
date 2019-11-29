using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4
{
    class estudiante
    {
        public string nombre;
        public string carrera;
        public double gpa;

        public estudiante(string _nombre, string _carrera, double _gpa)
        {
            nombre = _nombre;
            carrera = _carrera;
            gpa = _gpa;
        }

        public bool TieneHonores()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
