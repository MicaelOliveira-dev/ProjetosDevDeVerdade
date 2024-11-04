using CrudAlunos.Application.Autentication;
using CrudAlunos.Application.DTOs;
using CrudAlunos.Application.Interfaces;
using CrudAlunos.Domain.Entities;
using CrudAlunos.Domain.Interfaces;
using System.Formats.Asn1;
namespace CrudAlunos.Application.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoService(IAlunoRepository alunoRepository) 
        {
            _alunoRepository = alunoRepository;
        }

        public async Task<AlunoDto> CreateAluno(AlunoDto AlunoDto)
        {
            var aluno = new Aluno
            {
                NomeAluno = AlunoDto.NomeAluno,
                Email = AlunoDto.Email,
                NomeResponsavel = AlunoDto.NomeResponsavel,
                SenhaHash = PasswordHelper.HashPassword(AlunoDto.SenhaHash),
                Telefone = AlunoDto.Telefone,
                DataNascimento = AlunoDto.DataNascimento,
                Cpf = AlunoDto.Cpf,
                Cep = AlunoDto.Cep,
                Endereco = AlunoDto.Endereco,
                Bairro = AlunoDto.Bairro,
                Cidade = AlunoDto.Cidade,
                NumeroCasa = AlunoDto.NumeroCasa,
            };

            await _alunoRepository.CreateAluno(aluno);

            return new AlunoDto
            {
                NomeAluno = aluno.NomeAluno,
                Email = aluno.Email,
                NomeResponsavel = aluno.NomeResponsavel,
                Telefone = aluno.Telefone,
                DataNascimento = aluno.DataNascimento,
                Cpf = aluno.Cpf,
                Cep = aluno.Cep,
                Endereco = aluno.Endereco,
                Bairro = aluno.Bairro,
                Cidade = aluno.Cidade,
                NumeroCasa = aluno.NumeroCasa,
            };
        }

        public async Task<AlunoDto> GetAlunoAsync(Guid NMatricula)
        {
            var aluno = await _alunoRepository.GetAluno(NMatricula);
            return new AlunoDto
            {
                NomeAluno = aluno.NomeAluno,
                Email = aluno.Email,
                NomeResponsavel = aluno.NomeResponsavel,
                Telefone = aluno.Telefone,
                DataNascimento = aluno.DataNascimento,
                Cpf = aluno.Cpf,
                Cep = aluno.Cep,
                Endereco = aluno.Endereco,
                Bairro = aluno.Bairro,
                Cidade = aluno.Cidade,
                NumeroCasa = aluno.NumeroCasa,
            };
        }
    }
}
