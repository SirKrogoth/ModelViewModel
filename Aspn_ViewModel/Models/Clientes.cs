using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelViewViewModel.Model
{
    public class Clientes
    {
        [Key]
        [Required]
        public int ClienteId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(80)")]
        [MaxLength(80)]
        public string Nome { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string Endereco { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Telefone { get; set; }
    }
}