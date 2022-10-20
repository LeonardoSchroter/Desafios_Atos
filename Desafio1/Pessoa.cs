using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Pessoa
    {
        protected string _Nome;
        protected string _Telefone;
        protected string _Cidade;
        protected string _Rg;
        protected string _Cpf;

        public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
        {
            _Nome = nome;
            _Telefone = telefone;
            _Cidade = cidade;
            _Rg = rg;
            _Cpf = cpf;
        }

        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        public string Telefone
        {
            get { return _Telefone; }
            set { _Telefone = value; }
        }

        public string Cpf
        {
            get { return _Cpf; }
            set { _Cpf = value; }
        }

        public string Rg
        {
            get { return _Rg; }
            set { _Rg = value; }
        }
        
       public string Cidade
        {
            get { return _Cidade; }
            set { _Cidade = value; }
        }
    }
}
