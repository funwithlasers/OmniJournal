namespace OmniJournal.Core.Models;

public class Tracker
{
    public int Id { get; set; }
    public TrackerType Type { get; set; }
    public required string Name { get; set; }
    public string? Value { get; set; }

    public object? GetTypedValue()
    {
        return Type switch
        {
            TrackerType.StringTracker => Value,
            TrackerType.IntTracker => int.TryParse(Value, out var intValue) ? intValue : null,
            TrackerType.DecimalTracker => decimal.TryParse(Value, out var decimalValue) ? decimalValue : null,
            TrackerType.TimeTracker => TimeSpan.TryParse(Value, out var timeValue) ? timeValue : null,
            _ => null
        };
    }
}

public enum TrackerType
{
    StringTracker,
    IntTracker,
    DecimalTracker,
    TimeTracker,
}
