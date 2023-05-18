using WebApplicationAPI.Models;

namespace WebApplicationAPI.Services
{
    public class Alunos : IAlunos
    {
        private List<Aluno>? alunos;

        public Alunos()
        {
            alunos = new List<Aluno>()
            {
                new Aluno() { Id = 1, Nome = "Davi Alves" },
                new Aluno() { Id = 2, Nome = "Rafaela Alves" },
                new Aluno() { Id = 3, Nome = "Jailza Rocha Alves" }
            };
        }
        public void AddAluno(Aluno aluno)
        {
            alunos!.Add(aluno);
        }

        public void DeleteAluno(int id)
        {
            Aluno AlunoRemover = GetAluno(id)!;
            if (AlunoRemover != null)
            {
                _ = alunos!.Remove(AlunoRemover);
            }
        }

        public Aluno? GetAluno(int id)
        {
            return alunos!.FirstOrDefault(Al => Al.Id == id);
        }

        public List<Aluno> GetAlunos()
        {
            return alunos!;
        }

        public void UpdateAluno(Aluno aluno)
        {
            DeleteAluno(aluno.Id);
            AddAluno(aluno);
        }
    }
}
