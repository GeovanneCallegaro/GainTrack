using GainTrack.Domain.Modules.Investment.Entities;
using Microsoft.EntityFrameworkCore;

namespace GainTrack.Data;

public class GainTrackContext : DbContext
{
    public DbSet<Investment> Investments { get; set; }
}