﻿using GainTrack.Core.DomainObjects;

namespace GainTrack.Core.Repositories;

public interface IRepository<T> where T : IAggregateRoot
{
    Task AddAsync(T entity);
    Task<T> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    void Update(T entity);
    void Remove(T entity);
}