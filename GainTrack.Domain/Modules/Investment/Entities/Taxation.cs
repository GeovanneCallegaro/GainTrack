using Flunt.Validations;
using GainTrack.Core.DomainObjects;

namespace GainTrack.Domain.Modules.Investment.Entities;

public class Taxation : Entity, IAggregateRoot
{
    public int PeriodYear { get; private set; }
    public decimal TaxRate { get; private set; }

    protected Taxation()
    {
    }

    public decimal CalculateTax(decimal gain) => gain * TaxRate / 100;
}