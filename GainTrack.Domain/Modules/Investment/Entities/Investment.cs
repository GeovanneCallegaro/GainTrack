using System.Transactions;
using Flunt.Validations;
using GainTrack.Core.DomainObjects;

namespace GainTrack.Domain.Modules.Investment.Entities;

public class Investment : Entity, IAggregateRoot
{
    public decimal InitialValue { get; private set; }
    public decimal CurrentValue { get; private set; }
    public Guid OwnerId { get; private set; }

    public Investment(decimal initialValue, Guid ownerId, DateTime? date = null)
    {
        Validate();
        
        Id = Guid.NewGuid();
        InitialValue = initialValue;
        CurrentValue = initialValue;
        OwnerId = ownerId;
        CreatedDate = date ?? DateTime.Now;
    }
    
    private void Validate()
    {
        AddNotifications(
            new Contract<Investment>()
                .Requires()
                .IsGreaterThan(InitialValue, 0, "Investment.InitialValue")
                .IsGreaterThan(CurrentValue, 0, "Investment.CurrentValue")
                .IsNotEmpty(OwnerId, "OwnerId")
            );
    }
    
    public void SetCurrentValue(decimal value) => CurrentValue = value;
}