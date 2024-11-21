using GainTrack.Core.DomainObjects;
using GainTrack.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GainTrack.Data.Repositories.Abstractions;

public class RepositoryBase<T> : IRepository<T> where T : class, IAggregateRoot
{
    private readonly GainTrackContext _context;
    private readonly DbSet<T> _entity;

    public RepositoryBase(GainTrackContext context)
    {
        _context = context;
        _entity = context.Set<T>();
    }

    public virtual async Task AddAsync(T entity)
    {
        await _entity.AddAsync(entity);
    }

    public virtual async Task<T> GetByIdAsync(Guid id)
    {
        return await _entity.FindAsync(id);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _entity.ToListAsync();
    }

    public virtual void Update(T entity)
    {
        _entity.Update(entity);
    }

    public virtual void Remove(T entity)
    {
        _entity.Remove(entity);
    }
}