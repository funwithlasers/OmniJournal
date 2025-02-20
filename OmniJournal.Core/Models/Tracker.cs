using OmniJournal.Core.Shared.Attributes;

namespace OmniJournal.Core.Models;

public abstract class Tracker : ITracker
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TrackerType TrackerType { get; set; }
    public Type TargetDataType { get; set; }

    protected Tracker(string name, Type? targetDataType = null)
    {
        Name = name;
        TargetDataType = targetDataType ?? typeof(string);

        TrackerType = GetClassType() switch
        {
            Type t when t == typeof(RankTracker) => TrackerType.RankTracker,
            Type t when t == typeof(InputTracker) => TrackerType.InputTracker,
            _ => TrackerType.InputTracker
        };

        //SEND TO DB

        //GET ID FROM DB

        //Id = id;

        //Type = type;
    }

    public virtual Type GetClassType()
    {
        return this.GetType();
    }

    //public static TrackerType FromString(string trackerType) =>
    //Enum.TryParse(trackerType, out TrackerType parsedTrackerType) ? parsedTrackerType : default;
}

public enum TrackerType
{
    [DisplayStringAttribute("Input Tracker")]
    InputTracker,
    [DisplayStringAttribute("Rank Tracker")]
    RankTracker
}
