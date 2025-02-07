namespace OmniJournal.Core.Models;

public interface ITracker
{
    int Id { get; set; }
    Type TargetDataType { get; set; }
    TrackerType TrackerType { get; set; }
    string Name { get; set; }
}
