using System.Linq.Expressions;
using MasterCRM.Data;
using MasterCRM.Domain.Base;
using MasterCRM.Exceptions;
using MasterCRM.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MasterCRM.Services;

public class ServicoBase<T> : IServicoBase<T> where T : EntidadeBase
{
    private AppDBContext _context;

    public ServicoBase(AppDBContext context)
    {
        _context = context;
    }

    public void Atualizar(T entidade)
    {
        _context.Set<T>().Update(entidade);
        _context.SaveChanges();
    }

    public void Deletar(long id)
    {
        var entidade = _context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id);
        if (entidade == null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");
        
        _context.Set<T>().Remove(entidade);
        _context.SaveChanges();
    }

    public void InserirOuAtualizar(T entidade)
    {
        if (entidade == null)
            throw new ArgumentNullException("Dados inválidos");
        
        if(entidade.EstaSalva)
        {
            _context.Set<T>().Add(entidade);
            _context.SaveChanges();
        }
        else
        {
            Atualizar(entidade);
        }
    }

    public T? Obter(Expression<Func<T, bool>> predicado)
    {
        var entidade = _context.Set<T>().AsNoTracking().FirstOrDefault(predicado);
        if (entidade == null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");

        return entidade;
    }

    public T? Obter(long id)
    {
        var entidade = _context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id);
        if (entidade == null)
            throw new NotFoundException("Não encontrado nenhum registro com esses dados");

        return entidade;
    }

    public IEnumerable<T> Todos()
    {
        return _context.Set<T>().AsNoTracking();
    }
}