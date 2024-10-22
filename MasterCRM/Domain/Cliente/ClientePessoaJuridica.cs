using MasterCRM.Domain.Contato;

namespace MasterCRM.Domain.Cliente;

public class ClientePessoaJuridica : ClienteBase
{
    public PessoaJuridica Cliente { get; set; } = new();
    public string TipoMercado { get; set; } = string.Empty;
    public int NumeroFuncionarios { get; set; }
}
