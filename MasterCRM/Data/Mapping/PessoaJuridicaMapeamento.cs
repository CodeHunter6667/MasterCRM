using MasterCRM.Domain.Contato;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterCRM.Data.Mapping;

public class PessoaJuridicaMapeamento : IEntityTypeConfiguration<PessoaJuridica>
{
    public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(p => p.UsuarioCriacao)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.Property(p => p.DataCriacao)
            .IsRequired(true)
            .HasColumnType("DATETIME");

        builder.Property(p => p.DataAlteracao)
            .IsRequired(false)
            .HasColumnType("DATETIME");

        builder.Property(p => p.RazaoSocial)
            .IsRequired(true)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(255);

        builder.Property(p => p.NomeFantasia)
            .IsRequired(true)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(300);

        builder.Property(p => p.IncricaoEstadual)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(30);

        builder.Property(p => p.Cnpj)
            .IsRequired(true)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(15);

        builder.Property(p => p.EhSimplesNacional)
            .IsRequired(true)
            .HasColumnType("BIT");
    }
}
