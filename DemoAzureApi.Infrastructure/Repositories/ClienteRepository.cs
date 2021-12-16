using DemoAzureApi.Core.Entities;
using DemoAzureApi.Core.Interfaces;
using DemoAzureApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAzureApi.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DemoAzureApiContext _context;

        public ClienteRepository(DemoAzureApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            var clientes = await _context.Clientes.ToListAsync();
            return clientes;
        }

        public async Task<Cliente> GetCliente(int id)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(x=>x.ClienteId == id);
            return cliente;
        }

        public async Task InsertCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }
    }
}
