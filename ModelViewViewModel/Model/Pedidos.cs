using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ModelViewViewModel.Model
{
    public class Pedidos
    {
        [Key]
        [Required]
        public int PedidoID { get; set; }

        [Required]
        [ForeignKey("Clientes")]
        public int ClienteID { get; set; }
        public Clientes Clientes { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }

        [Required]
        public decimal PrecoPedido { get; set; }
    }
}