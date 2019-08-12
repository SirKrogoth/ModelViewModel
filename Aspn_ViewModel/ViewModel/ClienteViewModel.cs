using System;

namespace Aspn_ViewModel.ViewModel
{
    public class ClienteViewModel
    {
        public int ClienteViewModelID { get; set; }
        public string Nome { get; set; }//Cliente
        public string Endereco { get; set; }//Cliente
        public string Email { get; set; }//Cliente


        public DateTime? DataPedido { get; set; }//Pedido
        public Nullable<decimal> PrecoPedido { get; set; }//Pedido
    }
}