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
                new Aluno() { Id = 1, Nome = "Davi Alves", Idade = 11, Ativo = true },
                new Aluno() { Id = 2, Nome = "Rafaela Alves", Idade = 14, Ativo = true },
                new Aluno() { Id = 3, Nome = "Jailza Rocha Alves", Idade = 45, Ativo = true },
                new Aluno() { Id = 4, Nome = "Rafael Alves", Idade = 38}
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
