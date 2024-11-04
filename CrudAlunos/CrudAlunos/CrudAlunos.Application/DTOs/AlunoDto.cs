using System;
using System.ComponentModel.DataAnnotations;

namespace CrudAlunos.Application.DTOs
{
    public class AlunoDto
    {
        [Required(ErrorMessage = "Nome é Obrigatório")]
        public string NomeAluno { get; set; }

        [Required(ErrorMessage = "Nome do Responsável é Obrigatório")]
        public string NomeResponsavel { get; set; }

        [Required(ErrorMessage = "Senha é Obrigatório")]
        public string SenhaHash { get; set; }

        [Required(ErrorMessage = "Telefone é Obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é Obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Cpf é Obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Cep é Obrigatório")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Endereço é Obrigatório")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Bairro é Obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é Obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Número da Casa é Obrigatório")]
        public int NumeroCasa { get; set; }
    }
}
