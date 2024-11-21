using GainTrack.Data.Repositories.Abstractions;
using GainTrack.Domain.Modules.Investment.Interfaces;

namespace GainTrack.Data.Repositories.Investment;

public class InvestmentRepository(GainTrackContext context)
    : RepositoryBase<Domain.Modules.Investment.Entities.Investment>(context), IInvestmentRepository
{
}