using DemoAzureApi.Core.Entities;
using DemoAzureApi.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoAzureApi.Infrastructure.Data
{
    public class DemoAzureApiContext: DbContext
    {
        public DemoAzureApiContext()
        {

        }

        public DemoAzureApiContext(DbContextOptions<DemoAzureApiContext> options) : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        }
    }
}
