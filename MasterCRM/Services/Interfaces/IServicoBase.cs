using System.Linq.Expressions;

namespace MasterCRM.Services.Interfaces;
public interface IServicoBase<T> where T : class
{
    IEnumerable<T> Todos();
    T? Obter(Expression<Func<T, bool>> predicado);
    void InserirOuAtualizar(T entidade);
    void Atualizar(T entidade);
    void Deletar(long id);
}