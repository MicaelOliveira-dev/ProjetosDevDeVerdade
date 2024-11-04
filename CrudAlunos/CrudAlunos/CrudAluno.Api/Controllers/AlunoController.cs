using CrudAlunos.Application.DTOs;
using CrudAlunos.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CrudAluno.Api.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpPost("CreateAluno")]
        public async Task<IActionResult> CreateAluno([FromBody] AlunoDto AlunoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var aluno = await _alunoService.CreateAluno(AlunoDto);
                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
