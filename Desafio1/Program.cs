namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();
            List<Aluno> listaAlunos = new List<Aluno>();
            StreamWriter sw;
            StreamReader sr;
            Util2 util = new Util2();
            string nomeArquivo = @"C:\Users\leosc\OneDrive\Área de Trabalho\Academia_DotNet_Atos\Arquivos\Desafio_1.txt";
            util.PpopularLista(lista, listaAlunos, nomeArquivo);


            Console.WriteLine("Foram criados " + listaAlunos.Count + " objetos aluno e " + lista.Count + " objetos pessoa");
            Console.WriteLine("-----------------------------------------------------");
            foreach (Aluno aluno in listaAlunos)
            {
                Console.WriteLine(" Nome:" + aluno.Nome + " Curso: " + aluno.NomeDoCurso);
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}