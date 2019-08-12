using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelViewViewModel.Models;
using Aspn_ViewModel.ViewModel;

namespace Aspn_ViewModel.Controllers
{
    public class ClientePedidoController : Controller
    {
        public IActionResult Index()
        {
            //Criando estancia da classe
            VendasContext db = new VendasContext();

            List<ClienteViewModel> listaClientesVM = new List<ClienteViewModel>();

            //consulta os dados do banco de dados
            //fazendo a junção da duas tabelas
            //e armazenando as informações em listaClientes
            var listaClientes = (from Cli in db.Clientes
                                join Ped in db.Pedidos
                                    on Cli.ClienteId equals Ped.ClienteID
                                select new {Cli.Nome, Cli.Email, Cli.Endereco, Ped.DataPedido, Ped.PrecoPedido}).ToList();

            //percorre a lista de clientes e preenche
            //a ViewModel com os dados que serão exibidos na view
            
            foreach (var itemListaCliente in listaClientes)
            {
                ClienteViewModel clienteViewModel = new ClienteViewModel();

                clienteViewModel.Nome = itemListaCliente.Nome;
                clienteViewModel.Email = itemListaCliente.Email;
                clienteViewModel.Endereco = itemListaCliente.Endereco;
                clienteViewModel.DataPedido = itemListaCliente.DataPedido;
                clienteViewModel.PrecoPedido = itemListaCliente.PrecoPedido;

                listaClientesVM.Add(clienteViewModel);
            }

            return View(listaClientesVM);
        }
    }
}