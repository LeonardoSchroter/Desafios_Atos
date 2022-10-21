using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Util
    {
        public Util()
        {
        }
       

        public void popularLista(Dictionary<int, Pessoa> lista, Dictionary<int, Aluno> listaAlunos, string nomeArquivo)
        {
            string linha = "";
            string nome = "", telefone = "", cidade = "", RG = "", CPF = "";
            string matricula, codigo_do_curso, nome_do_curso;
            string[] palavrasFrase;
            int c = 0;
            int i = 0;
            StreamReader sr = new StreamReader(nomeArquivo);
            bool verificaLinha = false;
            while (!sr.EndOfStream)
            {
                linha = sr.ReadLine();
                palavrasFrase = linha.Split("-");


                if (linha == null || linha=="") break;
                else if (linha[0] == 'X') continue;


                if (linha[0] == 'Z')
                {

                    nome = palavrasFrase[1];
                    telefone = palavrasFrase[2];
                    cidade = palavrasFrase[3];
                    RG = palavrasFrase[4];
                    CPF = palavrasFrase[5];
                    lista.Add(c, new Pessoa(nome, telefone, cidade, RG, CPF));
                    c++;


                }
                else if (linha[0] == 'Y')
                {
                    matricula = palavrasFrase[1];
                    codigo_do_curso = palavrasFrase[2];
                    nome_do_curso = palavrasFrase[3];
                    verificaLinha = false;
                    lista.Remove(c - 1);
                    c--;
                    listaAlunos.Add(i, new Aluno(nome, telefone, cidade, RG, CPF, matricula, codigo_do_curso, nome_do_curso));
                    i++;

                }

            }



        }



       
    }
}

