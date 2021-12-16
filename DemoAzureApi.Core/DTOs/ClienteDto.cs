using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAzureApi.Core.DTOs
{
    public class ClienteDto
    {
        /// <summary>
        /// Id: Autogenerado por la base de datos al crear el cliente
        /// Edad: Se muestra cada vez que se visualiza un registro de cliente
        /// </summary>
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
    }
}
