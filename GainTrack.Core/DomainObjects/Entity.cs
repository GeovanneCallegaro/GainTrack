using Flunt.Notifications;

namespace GainTrack.Core.DomainObjects;

public abstract class Entity : Notifiable<Notification>
{
    public Guid Id { get; protected set; }
    public DateTime CreatedDate { get; protected set; }
    public bool IsDeleted { get; protected set; }
    public DateTime DeletedDate { get; protected set; }

    public virtual void Delete()
    {
        IsDeleted = true;
        DeletedDate = DateTime.Now;
    }
}