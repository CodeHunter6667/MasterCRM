using MasterCRM.Domain.Base;
using MasterCRM.Domain.ValueObjects;

namespace MasterCRM.Domain.Contato;

public abstract class Pessoa : EntidadeBase
{
    public string? Telefone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Endereco Endereco { get; set; } = new();
    public long EnderecoId { get; set; }

}
