using Back_end.Models_entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back_end.EntityMap
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
               builder.ToTable("tbPessoa");
               builder.HasKey(x=>x.Id);

               builder.Property(x=>x.Id)
               .ValueGeneratedOnAdd();

               builder.Property(x=>x.Nome)
               .HasColumnName("Nome")
               .HasColumnType("varchar(200)");

                builder.Property(x=>x.Sobrenome)
               .HasColumnName("Sobrenome")
               .HasColumnType("varchar(100)");
               
        }
    }
}