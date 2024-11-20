namespace GainTrack.Core.Expections;

public class DomainException : Exception 
{
    public DomainException(string message) : base(message)
    {
    }

    public DomainException(IEnumerable<string> messages) 
        : base(string.Join(", ", messages))
    {
    }
    
}