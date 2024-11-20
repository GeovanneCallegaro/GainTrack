namespace GainTrack.Core.Repositories;

public interface IUnitOfWork : IDisposable
{
    Task CommitAsync();
}