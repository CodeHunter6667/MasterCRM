namespace MasterCRM.Domain.Contato;

public class PessoaJuridica : Pessoa
{
    public string RazaoSocial { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    public string Cnpj { get; set; } = string.Empty;
    public string? IncricaoEstadual { get; set; } = string.Empty;
    public bool EhSimplesNacional { get; set; }

}
