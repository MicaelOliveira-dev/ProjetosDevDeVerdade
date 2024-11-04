using CrudAlunos.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAlunos.Application.Interfaces
{
    public interface IAlunoService
    {
        Task<AlunoDto> CreateAluno(AlunoDto AlunoDto);
        Task<AlunoDto> GetAlunoAsync(Guid NMatricula);
    }
}
