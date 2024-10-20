using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MasterCRM.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rua = table.Column<string>(type: "VARCHAR", maxLength: 255, nullable: false),
                    Numero = table.Column<string>(type: "VARCHAR", maxLength: 10, nullable: false),
                    Cidade = table.Column<string>(type: "VARCHAR", maxLength: 100, nullable: false),
                    UF = table.Column<string>(type: "VARCHAR", maxLength: 2, nullable: false),
                    Cep = table.Column<string>(type: "text", nullable: false),
                    EstaSalva = table.Column<bool>(type: "boolean", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP WITHOUT TIME ZONE", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP WITHOUT TIME ZONE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeCompleto = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: true),
                    Cpf = table.Column<string>(type: "VARCHAR", maxLength: 15, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "DATE", nullable: true),
                    Genero = table.Column<short>(type: "SMALLINT", nullable: false),
                    EstaSalva = table.Column<bool>(type: "boolean", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP WITHOUT TIME ZONE", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP WITHOUT TIME ZONE", nullable: true),
                    Telefone = table.Column<string>(type: "VARCHAR", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "VARCHAR", maxLength: 160, nullable: true),
                    EnderecoId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaFisica_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PessoaJuridica",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RazaoSocial = table.Column<string>(type: "VARCHAR", maxLength: 255, nullable: false),
                    NomeFantasia = table.Column<string>(type: "VARCHAR", maxLength: 300, nullable: false),
                    Cnpj = table.Column<string>(type: "VARCHAR", maxLength: 15, nullable: false),
                    IncricaoEstadual = table.Column<string>(type: "VARCHAR", maxLength: 30, nullable: true),
                    EhSimplesNacional = table.Column<bool>(type: "BOOLEAN", nullable: false),
                    EstaSalva = table.Column<bool>(type: "boolean", nullable: false),
                    UsuarioCriacao = table.Column<string>(type: "VARCHAR", maxLength: 150, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TIMESTAMP WITHOUT TIME ZONE", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "TIMESTAMP WITHOUT TIME ZONE", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    EnderecoId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaJuridica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaJuridica_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFisica_EnderecoId",
                table: "PessoaFisica",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaJuridica_EnderecoId",
                table: "PessoaJuridica",
                column: "EnderecoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaFisica");

            migrationBuilder.DropTable(
                name: "PessoaJuridica");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
