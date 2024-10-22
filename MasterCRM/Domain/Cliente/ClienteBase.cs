using MasterCRM.Domain.Base;
using MasterCRM.Domain.Enums;

namespace MasterCRM.Domain.Cliente;

public class ClienteBase : EntidadeBase
{
    public ClienteBase()
    {
        Acoes = new List<Acao>();
    }

    public ETipoCadastro Tipo { get; set; }
    public List<Acao> Acoes { get; set; }
}
