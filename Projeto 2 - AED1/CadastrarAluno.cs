using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___AED1
{
    class CadastrarAluno
    {
        using System.Collections.Generic;
using System.IO;

namespace AgendaAcademia
    {
        public class CadastroAlunos
        {

            private static string CaminhoArquivo = "C:\\AgendaEscolaDanca\\Alunos\\alunos.txt";

            public void CadastrarAluno(Aluno aluno)
            {
                if (!File.Exists(CaminhoArquivo))
                {
                    File.Create(CaminhoArquivo);
                }

                using (StreamWriter streamWriter = new StreamWriter(File.OpenWrite(CaminhoArquivo)))
                {
                    string registroAluno = aluno.nome + "/" + aluno.email ;
                    streamWriter.WriteLine(registroAluno);
                }
            }

            public IList<Aluno> ListarAlunos()
            {
                IList<Aluno> alunos = null;

                if (File.Exists(CaminhoArquivo))
                {
                    alunos = new List<Aluno>();
                    string[] registrosAlunos = File.ReadAllLines(CaminhoArquivo);

                    foreach (string linhaAluno in registrosAlunos)
                    {
                        string[] dadosAluno = linhaAluno.Split("/");
                        string nome = dadosAluno[1];
                        string email = dadosAluno[2];

                        var aluno = new Aluno
                        {
                          
                            Nome = nome,
                            Email = email,
                        };

                        alunos.Add(aluno);
                    }
                }

                return alunos;
            }

            public Aluno ObterPorNome(string nomeBuscado)
            {
                if (File.Exists(CaminhoArquivo))
                {
                    string[] registrosAlunos = File.ReadAllLines(CaminhoArquivo);

                    foreach (string linhaAluno in registrosAlunos)
                    {
                        string[] dadosAluno = linhaAluno.Split("/");
                        string nome = dadosAluno[1];

                        if (nome == nomeBuscado)
                        {
                            string nome = dadosAluno[1];
                            string email = dadosAluno[2];

                            var aluno = new Aluno
                            {
                               
                                Nome = nome,
                                Email = email
                            };

                            return aluno;
                        }
                    }
                }

                return null;
            }
        }
    }
}
}
