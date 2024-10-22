using MasterCRM.Domain.Enums;

namespace MasterCRM.Domain.Contato;

public class PessoaFisica : Pessoa
{
    public string NomeCompleto { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public int? Idade { get
        {
            if (DataNascimento.HasValue)
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - DataNascimento.Value.Year;
                if (DataNascimento.Value.Date > hoje.AddYears(-idade)) idade--;
                return idade;
            }
            return null;
        } }
    public DateTime? DataNascimento { get; set; }
    public EGenero Genero { get; set; }
    public long PessoaId { get; set; }
}
