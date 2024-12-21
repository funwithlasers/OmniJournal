namespace OmniJournal.Core;

public interface ITracker
{
    string Name { get; set; }
    object? Value { get; set; }
}
