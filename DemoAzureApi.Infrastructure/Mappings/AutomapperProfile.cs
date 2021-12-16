using AutoMapper;
using DemoAzureApi.Core.DTOs;
using DemoAzureApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAzureApi.Infrastructure.Mappings
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Cliente, ClienteDto>()
                .ForMember(x => x.Edad, opt => opt.MapFrom(src => DateTime.Today.Year - src.FechaNacimiento.Year));

            CreateMap<ClienteDto, Cliente>();
        }
    }
}
