using GainTrack.Core.Repositories;

namespace GainTrack.Data.Repositories.Investment;

public class InvestmentRepository(GainTrackContext context) : IRepository<Domain.Modules.Investment.Entities.Investment>
{
    private readonly GainTrackContext _context = context;

    public async Task AddAsync(Domain.Modules.Investment.Entities.Investment entity)
    {
        await _context.Investments.AddAsync(entity);
    }

    public Task<Domain.Modules.Investment.Entities.Investment> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Domain.Modules.Investment.Entities.Investment>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Domain.Modules.Investment.Entities.Investment entity)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Domain.Modules.Investment.Entities.Investment entity)
    {
        throw new NotImplementedException();
    }
}