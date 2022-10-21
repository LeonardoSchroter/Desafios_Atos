namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Pessoa> dic = new Dictionary<int, Pessoa>();
            Dictionary<int, Aluno> dicAlunos = new Dictionary<int, Aluno>();
            Util util = new Util();
            string nomeArquivo = @"C:\Users\leosc\OneDrive\Área de Trabalho\Academia_DotNet_Atos\Arquivos\Desafio_1.txt";
            util.popularLista(dic, dicAlunos, nomeArquivo);


            Console.WriteLine("Foram criados " + dicAlunos.Count + " objetos aluno e " + dic.Count + " objetos pessoa");
            Console.WriteLine("-----------------------------------------------------");
            foreach (var item in dicAlunos)
            {
                Console.WriteLine(" Nome:" + item.Value.Nome + " Curso: " + item.Value.NomeDoCurso);
                Console.WriteLine("-----------------------------------------------------");
            }

        }
    }
}