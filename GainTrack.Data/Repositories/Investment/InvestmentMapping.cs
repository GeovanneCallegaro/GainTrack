using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GainTrack.Data.Repositories.Investment;

public class InvestmentMapping : IEntityTypeConfiguration<InvestmentMapping>
{
    public void Configure(EntityTypeBuilder<InvestmentMapping> builder)
    {
        throw new NotImplementedException();
    }
}