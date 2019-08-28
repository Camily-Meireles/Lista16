using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    class Retangulo
    {
        private double Base, Altura;
        public void SetBase(double b)
        {
            Base = b;
        }
        public void SetAltura(double h)
        {
            Altura = h;
        }
        public double GetBase()
        {
            return Base;
        }
        public double GetAltura()
        {
            return Altura;
        }
        public double CalcArea()
        {
            return Base * Altura;
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
        }
    }
}
