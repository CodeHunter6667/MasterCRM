namespace MasterCRM.Domain.Base;

public class EntidadeBaseLog
{
    public long Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public string UsarioCriacao { get; set; } = string.Empty;
}
