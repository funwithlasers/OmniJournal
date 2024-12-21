namespace OmniJournal;

public interface ITracker
{
    string Name { get; set; }
    object? Value { get; set; }
}
