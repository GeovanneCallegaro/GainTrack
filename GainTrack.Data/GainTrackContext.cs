using GainTrack.Domain.Modules.Investment.Entities;
using Microsoft.EntityFrameworkCore;

namespace GainTrack.Data;

public class GainTrackContext : DbContext
{
    public GainTrackContext(DbContextOptions<GainTrackContext> options)
        : base(options)
    {
    }

    public DbSet<Investment> Investments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}