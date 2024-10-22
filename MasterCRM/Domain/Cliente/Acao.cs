using MasterCRM.Domain.Base;
using MasterCRM.Domain.Enums;

namespace MasterCRM.Domain.Cliente;

public class Acao : EntidadeBaseLog
{
    public const int DescricaoTamanhoMax = 1500;

    public long ClienteId { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public ETipoContato Contato { get; set; }
}
