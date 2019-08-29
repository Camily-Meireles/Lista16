using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Disciplina
    {
        private string nome;
        private string semestre;
        private int media;
        private bool aprovado;
        public void SetNome(string n)
        {
            nome = n;
        }
        public void SetSemestre(string s)
        {
            semestre = s;
        }
        public void  SetMedia(int m)
        {
            media = m;
        }
        public void SetAprovado(bool a)
        {
            aprovado = a;
        }


        public string GetNome()
        {
            return nome;
        }
        public string GetSemestre()
        {
            return semestre;
        }
        public int GetMedia()
        {
            return media;
        }
        public bool Getaprovado()
        {
            return aprovado;
        }





    }
}
