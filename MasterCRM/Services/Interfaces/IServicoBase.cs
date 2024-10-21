using System.Linq.Expressions;
using MasterCRM.Domain.Base;

namespace MasterCRM.Services.Interfaces;
public interface IServicoBase<T> where T : EntidadeBase
{
    IEnumerable<T> Todos();
    T? Obter(Expression<Func<T, bool>> predicado);
    T? Obter(long id);
    void InserirOuAtualizar(T entidade);
    void Atualizar(T entidade);
    void Deletar(long id);
}