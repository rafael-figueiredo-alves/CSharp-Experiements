using WebApplicationAPI.Models;

namespace WebApplicationAPI.Services
{
    public interface IAlunos
    {
        public List<Aluno> GetAlunos();
        public Aluno? GetAluno(int id);
        public void AddAluno(Aluno aluno);
        public void UpdateAluno(Aluno aluno);
        public void DeleteAluno(int id);
    }
}
