using DemoAzureApi.Core.Entities;
using DemoAzureApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoAzureApi.Core.Services
{
    public class ClienteService: IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> GetCliente(int id)
        {
            return await _clienteRepository.GetCliente(id);
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await _clienteRepository.GetClientes();
        }

        public async Task InsertCliente(Cliente cliente)
        {
            await _clienteRepository.InsertCliente(cliente);
        }
    }
}
