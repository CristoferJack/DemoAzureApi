using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DemoAzureApi.Api.Responses;
using DemoAzureApi.Core.DTOs;
using DemoAzureApi.Core.Entities;
using DemoAzureApi.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoAzureApi.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;
        public ClienteController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        /// <summary>
        /// Permite obtener todos los clientes registrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            var clientes = await _clienteService.GetClientes();
            var clientesDto = _mapper.Map<IEnumerable<ClienteDto>>(clientes);
            var response = new ApiResponse<IEnumerable<ClienteDto>>(clientesDto);
            return Ok(response);
        }

        /// <summary>
        /// Permite obtener solo un cliente por su id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCliente(int id)
        {
            var cliente = await _clienteService.GetCliente(id);

            var clientesDto = _mapper.Map<ClienteDto>(cliente);

            var response = new ApiResponse<ClienteDto>(clientesDto);

            return Ok(response);
        }

        /// <summary>
        /// Permite registrar un cliente 
        /// El Campo "ClienteId" y "Edad" no son necesarios
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Cliente(ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);

            await _clienteService.InsertCliente(cliente);

            clienteDto = _mapper.Map<ClienteDto>(cliente);

            var response = new ApiResponse<ClienteDto>(clienteDto);

            return Ok(response);
        }
    }
}
