using Back_end.Models_entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Back_end.EntityMap
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("tbUsuario");
            builder.HasKey(x => x.IdUsuario);

            builder.Property(x => x.IdUsuario)
            .ValueGeneratedOnAdd();

            builder.Property(x => x.Login)
            .HasColumnName("Login")
            .HasColumnType("varchar(100)");

            builder.Property(x => x.Senha)
          .HasColumnName("Senha")
          .HasColumnType("varchar(100)");

        }

    }
}