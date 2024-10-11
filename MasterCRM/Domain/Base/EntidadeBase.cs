namespace MasterCRM.Domain.Base;

public class EntidadeBase
{
    public long Id { get; set; }
    public bool EstaSalva { get; set; }
    public string UsuarioCriacao { get; set; } = string.Empty;
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
}
