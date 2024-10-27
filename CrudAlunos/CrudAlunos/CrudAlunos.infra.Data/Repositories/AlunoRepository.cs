using CrudAlunos.Domain.Entities;
using CrudAlunos.Domain.Interfaces;
using CrudAlunos.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CrudAlunos.Infra.Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AppDbContext _context;
        public AlunoRepository(AppDbContext context) 
        {
            _context = context;
        }
        public async Task CreateAluno(Aluno Aluno)
        {
            await _context.Alunos.AddAsync(Aluno);
            await _context.SaveChangesAsync();
        }
        public async Task<Aluno> GetAluno(Guid numeroMatricula)
        {
            return await _context.Alunos
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.NMatricula == numeroMatricula);
               
        }
        public async Task<List<Aluno>> GetAllAlunos()
        {
            return await _context.Alunos
                .AsNoTracking()
                .ToListAsync();
        }       

        public async Task UpdateAluno(Aluno Aluno)
        {
            _context.Alunos.Update(Aluno);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAluno(Guid numeroMatricula)
        {
            Aluno Aluno =  await _context.Alunos.FindAsync(numeroMatricula);
            _context.Alunos.Remove(Aluno);
        }
    }
}
