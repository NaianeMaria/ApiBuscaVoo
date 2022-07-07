using System.ComponentModel.DataAnnotations;

namespace ApiBuscaVoos.Models
{
    public class Aeroporto
    {
        [Key]
        public int AeroportoId { get; set; }
       
        [Required]
        [StringLength(80)]
        public string Nome { get; set; }
        [Required]
        [StringLength(3)]
        public string Sigla { get; set; }
        [Required]
        [StringLength(80)]
        public string Cidade { get; set; }
    }
}
