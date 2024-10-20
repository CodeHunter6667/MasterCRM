using MasterCRM.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterCRM.Data.Mapping;

public class EnderecoMapeamento : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(p => p.UsuarioCriacao)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.Property(p => p.DataCriacao)
            .IsRequired(true)
            .HasColumnType("TIMESTAMP WITHOUT TIME ZONE");

        builder.Property(p => p.DataAlteracao)
            .IsRequired(false)
            .HasColumnType("TIMESTAMP WITHOUT TIME ZONE");

        builder.Property(e => e.Rua)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(255);

        builder.Property(e => e.Numero)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(10);

        builder.Property(p => p.Cidade)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(100);

        builder.Property(e => e.UF)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(2);
    }
}
