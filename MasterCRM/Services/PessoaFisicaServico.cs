using MasterCRM.Data;
using MasterCRM.Domain.Contato;
using MasterCRM.Services.Interfaces;

namespace MasterCRM.Services;
public class PessoaFisicaServico : ServicoBase<PessoaFisica>, IPessoaFisicaServico
{
    public PessoaFisicaServico(AppDBContext context) : base(context)
    {
    }
}
