using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Esfera
    {
        private double raio;
        public void SetRaio(double r)
        {
            if (r > 0) raio = r;
        }
        public double GetRaio()
        {
            return raio;
        }
        public double CalcArea()
        {
            return 2 * 3.14 * raio;
        }
        public double CalcVol()
        {
            return 4 / 3.0 * 3.14 * Math.Pow(raio, 3);
        }
    }
}
