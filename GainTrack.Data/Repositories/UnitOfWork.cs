using GainTrack.Core.Repositories;

namespace GainTrack.Data.Repositories;

public class UnitOfWork(GainTrackContext context) : IUnitOfWork
{
    private readonly GainTrackContext context;
    
    public IRepository<Domain.Modules.Investment.Entities.Investment> Investments { get; }
    
    public async Task CommitAsync()
    {
        await context.SaveChangesAsync();
    }
    
    public void Dispose()
    {
        context.Dispose();
    }
}