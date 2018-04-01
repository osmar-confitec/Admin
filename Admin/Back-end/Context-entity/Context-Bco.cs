using Back_end.EntityMap;
using Back_end.Models_entity;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Context_entity
{
    public class ContextBco : DbContext
    {

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public ContextBco(DbContextOptions<ContextBco> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
    }
}