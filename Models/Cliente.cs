using System.ComponentModel.DataAnnotations;

namespace IHCUsuario.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public string? Nome { get; set; }

        [Required]
        [Display(Name = "Nome do Pai")]
        [StringLength(100)]
        public string? NomePai { get; set;}

        [Required]
        [Display(Name = "Nome da Mãe")]
        [StringLength(100)]
        public string? NomeMae { get; set; }
        
                
    }
}
