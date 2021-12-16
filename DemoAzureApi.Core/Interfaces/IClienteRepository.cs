using DemoAzureApi.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoAzureApi.Core.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetCliente(int id);
        Task InsertCliente(Cliente cliente);
    }
}
