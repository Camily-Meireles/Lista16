using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Viagem
    {
        private double distancia, tempo;
        public void SetDist(double d)
        {
            distancia = d;
        }
        public void SetTemp(double t)
        {
            tempo = t;
        }

        public double GetDistancia()
        {
            return distancia;
        }
        public double GetTempo()
        {
            return tempo;
        }
        public double CalcVel()
        {
            return distancia * tempo;
        }
    }
}
