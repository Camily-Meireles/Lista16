using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Numeros
    {
        private int inicio, fim;
        public void SetInicio(int i)
        {
            inicio = i;
        }
        public void SetFim(int f)
        {
            fim = f;
        }
        public int GetInicio()
        {
            return inicio;

        }
        public int GetFim()
        {
            return fim;

        }
        public int[] Calcular(bool pares, bool impares)
        {
            int[] intervalo = new int[fim - inicio + 1];
            int c = 0;
            for (int x = inicio; x <= fim; x++)
            {
                if (x % 2 == 0 && pares == true && impares == false)
                {
                    intervalo[c] = x;
                    c++;

                }
                if (x % 2 != 0 && impares == true && pares == false)
                {
                    intervalo[c] = x;
                    c++;
                }

                if (pares == true && impares == true)
                {
                    intervalo[c] = x;
                    c++;
                }
            }
            int[] intervalo2 = new int[c];
            Array.Copy(intervalo, intervalo2, c); 
            return intervalo2;
            

            }

    }
}
