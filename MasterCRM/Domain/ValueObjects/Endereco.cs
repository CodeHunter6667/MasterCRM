using MasterCRM.Domain.Base;

namespace MasterCRM.Domain.ValueObjects;

public class Endereco : EntidadeBase
{
    public string Rua { get; set; } = string.Empty;
    public string Numero { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string UF { get; set; } = string.Empty;
    public string Cep { get; set; } = string.Empty;
}
