using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Modelo;
using System.Data;


namespace Persistencia
{
    public class EFContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<ContasAReceber> Contas { get; set; }
        public DbSet<Caixa> Caixa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ProjetoFinal;Trusted_Connection=True;");
        }
    }
}
