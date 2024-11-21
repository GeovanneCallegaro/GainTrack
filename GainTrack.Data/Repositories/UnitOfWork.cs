using GainTrack.Core.Repositories;
using GainTrack.Domain.Modules.Investment.Interfaces;

namespace GainTrack.Data.Repositories;

public class UnitOfWork(GainTrackContext context) : IUnitOfWork
{
    private readonly GainTrackContext context;

    public IInvestmentRepository Investments { get; }

    public async Task CommitAsync()
    {
        await context.SaveChangesAsync();
    }

    public void Dispose()
    {
        context.Dispose();
    }
}