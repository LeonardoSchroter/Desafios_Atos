using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Aluno:Pessoa
    {
        private string _Matricula;
        private string _CodigoDoCurso;
        private string _NomeDoCurso;

        public Aluno(string nome, string telefone, string cidade, string rg, string cpf, string Matricula, string Codigo, string NomeDoCurso) : base(nome, telefone, cidade, rg, cpf)
        {
            this.Matricula = Matricula;
            CodigoDoCurso = Codigo;
            this.NomeDoCurso = NomeDoCurso;
        }

        public string Matricula { get => _Matricula; set => _Matricula = value; }
        public string CodigoDoCurso { get => _CodigoDoCurso; set => _CodigoDoCurso = value; }
        public string NomeDoCurso { get => _NomeDoCurso; set => _NomeDoCurso = value; }
    }
}
