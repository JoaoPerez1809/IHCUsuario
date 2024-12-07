using System.ComponentModel.DataAnnotations;

namespace IHCUsuario.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "O Nome é Obrigatorio!!!")]
        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage = "O Nome deve ter no máximo 100 caracteres.")]
        public required string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Data de Nascimento é Obrigatorio!!!")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data de Nascimento")]
        public required DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O RG é Obrigatorio!!!")]
        [Display(Name = "RG")]
        [StringLength(20,ErrorMessage = "O RG deve ter no máximo 20 caracteres.")]
        [RegularExpression(@"^\d{1,2}\.\d{3}\.\d{3}-\d{1}$", ErrorMessage = "O RG tem que estar no formato XX.XXX.XXX-X.")]
        public required string RG { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é Obrigatorio!!!")]
        [Display(Name = "CPF")]
        [StringLength(14, ErrorMessage = "O CPF deve ter no máximo 14 caracteres.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF tem que estar no formato XXX.XXX.XXX-XX.")]
        public required string CPF { get; set; } = string.Empty;

        // Endereço residencial
        [Required(ErrorMessage = "O Logradouro é Obrigatorio!!!")]
        [Display(Name = "Logradouro")]
        [StringLength(200, ErrorMessage = "O Logradouro deve ter no máximo 200 caracteres.")]
        public required string Logradouro { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Bairro é Obrigatorio!!!")]
        [Display(Name = "Bairro")]
        [StringLength(100, ErrorMessage = "O Bairro deve ter no máximo 100 caracteres.")]
        public required string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Cidade é Obrigatorio!!!")]
        [Display(Name = "Cidade")]
        [StringLength(100, ErrorMessage = "A Cidade deve ter no máximo 100 caracteres.")]
        public required string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Complemento é Obrigatorio!!!")]
        [Display(Name = "Complemento")]
        [StringLength(100, ErrorMessage = "O Complemento deve ter no máximo 100 caracteres.")]
        public required string Complemento { get; set; } = string.Empty;

        [Required(ErrorMessage = "O UF é Obrigatorio!!!")]
        [Display(Name = "UF")]
        [StringLength(2, ErrorMessage = "O UF deve ter no máximo 2 caracteres.")]
        public required string UF { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CEP é Obrigatorio!!!")]
        [Display(Name = "CEP")]
        [StringLength(9, ErrorMessage = "O CEP deve ter no máximo 9 caracteres.")]
        public required string CEP { get; set; } = string.Empty;
        // fim do Endereço Residencial

        [Required(ErrorMessage = "O Estado Civil é Obrigatorio!!!")]
        [Display(Name = "Estado Civil")]
        public required EstadoCivil EstadoCivil { get; set; }

        [Required(ErrorMessage = "O Nome do Pai é Obrigatorio!!!")]
        [Display(Name = "Nome do Pai")]
        [StringLength(100, ErrorMessage = "O Nome do Pai deve ter no máximo 100 caracteres.")]
        public required string NomePai { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Nome da Mãe é Obrigatorio!!!")]
        [Display(Name = "Nome da Mãe")]
        [StringLength(100, ErrorMessage = "O Nome da Mãe deve ter no máximo 100 caracteres.")]
        public required string NomeMae { get; set; } = string.Empty;
    }
    public enum EstadoCivil
    {
        Solteiro = 0,
        Casado = 1,
        Divorciado = 2,
        Viuvo = 3
    }

}
