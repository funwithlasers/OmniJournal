namespace OmniJournal.Core.Models;

public interface ITracker
{
    int Id { get; set; }
    TrackerType Type { get; set; }
    string Name { get; set; }
    string? Value { get; set; }

    object? GetTypedValue();
}
