using CrudAlunos.Domain.Entities;

namespace CrudAlunos.Domain.Interfaces
{
    public interface IAlunoRepository
    {
        Task CreateAluno(Aluno Aluno);
        Task<Aluno> GetAluno(Guid numeroMatricula);
        Task<List<Aluno>> GetAllAlunos();
        Task UpdateAluno(Aluno Aluno);
        Task DeleteAluno(Guid numeroMatricula);
    }
}
