using MasterCRM.Domain.Contato;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MasterCRM.Data.Mapping;

public class PessoaFisicaMapeamento : IEntityTypeConfiguration<PessoaFisica>
{
    public void Configure(EntityTypeBuilder<PessoaFisica> builder)
    {
        builder.ToTable("PessoaFisica");

        builder.HasKey(p =>  p.Id);

        builder.Property(p => p.Id)
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

        builder.Property(p => p.NomeCompleto)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(150);

        builder.Property(p => p.DataNascimento)
            .IsRequired(false)
            .HasColumnType("DATE");

        builder.Property(p => p.Cpf)
            .IsRequired(true)
            .HasColumnType("VARCHAR")
            .HasMaxLength(15);

        builder.Property(p => p.Genero)
            .IsRequired(true)
            .HasColumnType("SMALLINT");

        builder.Property(p => p.Email)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(160);

        builder.Property(p => p.Telefone)
            .IsRequired(false)
            .HasColumnType("VARCHAR")
            .HasMaxLength(20);

        builder.Property(p => p.EnderecoId)
            .IsRequired(true)
            .HasColumnType("INT");
    }
}
