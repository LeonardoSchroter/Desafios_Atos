using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Desafio1
{
    internal class Util2
    {

        public void PpopularLista(List<Pessoa> lista, List<Aluno> listaAlunos, string nomeArquivo)
        {
            var lines = File.ReadAllLines(nomeArquivo);
            string linha, linha2;
            string[] palavrasFrase;
            string[] palavrasFrase2;


            for (int i = 0; i < lines.Count(); i++)
            {
                linha = lines[i];
                if (linha == null) break;
                if (linha[0] == 'X')
                {
                    continue;
                }
                if (linha[0] == 'Y')
                {
                    continue;
                }
                if (linha[0] == 'Z')
                {
                    palavrasFrase = linha.Split("-");
                    if (i == lines.Count() - 2)
                    {
                        lista.Add(new Pessoa(palavrasFrase[1], palavrasFrase[2], palavrasFrase[3], palavrasFrase[4], palavrasFrase[5]));
                        break;
                    }

                    linha2 = lines[i + 1];
                    if (linha2 == null || linha2 == " ")
                    {
                        lista.Add(new Pessoa(palavrasFrase[1], palavrasFrase[2], palavrasFrase[3], palavrasFrase[4], palavrasFrase[5]));
                        break;
                    }
                    else if (linha2[0] == 'Y')
                    {
                        palavrasFrase2 = linha2.Split("-");

                        listaAlunos.Add(new Aluno(palavrasFrase[1], palavrasFrase[2], palavrasFrase[3], palavrasFrase[4], palavrasFrase[5], palavrasFrase2[1], palavrasFrase2[2], palavrasFrase2[3]));
                    }
                    else
                    {
                        lista.Add(new Pessoa(palavrasFrase[1], palavrasFrase[2], palavrasFrase[3], palavrasFrase[4], palavrasFrase[5]));
                    }
                }

            }
        }
    }
}
