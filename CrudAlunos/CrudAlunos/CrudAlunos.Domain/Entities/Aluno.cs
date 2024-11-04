using System;
using System.ComponentModel.DataAnnotations;

namespace CrudAlunos.Domain.Entities
{
    public class Aluno
    {
        [Key]
        public Guid NMatricula { get; set; }

        [Required(ErrorMessage = "Nome é Obrigatório")]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres")]
        public string NomeAluno { get; set; }

        [Required(ErrorMessage = "Nome do responsavel é Obrigatório")]
        [StringLength(100, ErrorMessage = "O nome do responsavel não pode ter mais de 100 caracteres")]
        public string NomeResponsavel { get; set; }

        [Required(ErrorMessage = "Senha é Obrigatório")]
        [StringLength(100, ErrorMessage = "A Senha não pode ter mais de 100 caracteres")]
        public string SenhaHash { get; set; }

        [Required(ErrorMessage = "Telefone é Obrigatório")]
        [StringLength(50, ErrorMessage = "O telefone não pode ter mais de 50 caracteres")]
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "Telefone em formato inválido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é Obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Cpf é Obrigatório")]
        [StringLength(14, ErrorMessage = "O cpf não pode ter mais de 14 caracteres")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF deve estar no formato xxx.xxx.xxx-xx")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Cep é Obrigatório")]
        [StringLength(10, ErrorMessage = "O cep não pode ter mais de 10 caracteres")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP deve estar no formato xxxxx-xxx")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Endereco é Obrigatório")]
        [StringLength(100, ErrorMessage = "O Endereco não pode ter mais de 100 caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Bairro é Obrigatório")]
        [StringLength(100, ErrorMessage = "O Bairro não pode ter mais de 100 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é Obrigatório")]
        [StringLength(100, ErrorMessage = "O Cidade não pode ter mais de 100 caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "NumeroCasa é Obrigatório")]
        public int NumeroCasa { get; set; }
    }
}
