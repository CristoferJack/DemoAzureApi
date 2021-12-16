using DemoAzureApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoAzureApi.Core.Interfaces
{
    public interface IClienteService
    {
        Task InsertCliente(Cliente cliente);
        Task<Cliente> GetCliente(int id);
        Task<IEnumerable<Cliente>> GetClientes();

    }
}
