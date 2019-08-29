using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class Historico
    {
        private string aluno;
        int c = 0;
        private Disciplina[] disciplina = new Disciplina[10];
        public void SetAluno(string a)
        {
            aluno = a;
        }
        public void Inserir(Disciplina d)
        {
            disciplina[c++] = d;
        }
        public Disciplina[] Listar()
        {
            Disciplina[] di = new Disciplina[c];
            Array.Copy(disciplina, di, c);
            return di;
        }
        public double ira()
        {
            Disciplina i = new Disciplina();
            foreach (Disciplina d in i.GetMedia()) ;
            re


        } 


    }
}
