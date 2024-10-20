using System.Linq.Expressions;
using MasterCRM.Data;
using MasterCRM.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MasterCRM.Services;

public class ServicoBase<T> : IServicoBase<T> where T : class
{
    private AppDBContext _context;

    public ServicoBase(AppDBContext context)
    {
        _context = context;
    }

    public void Atualizar(T entidade)
    {
        throw new NotImplementedException();
    }

    public void Deletar(long id)
    {
        throw new NotImplementedException();
    }

    public void InserirOuAtualizar(T entidade)
    {
        throw new NotImplementedException();
    }

    public T? Obter(Expression<Func<T, bool>> predicado)
    {
        return _context.Set<T>().AsNoTracking().FirstOrDefault(predicado);
    }


    public IEnumerable<T> Todos()
    {
        return _context.Set<T>().AsNoTracking();
    }
}