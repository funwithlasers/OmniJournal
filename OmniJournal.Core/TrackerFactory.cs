using Microsoft.Extensions.DependencyInjection;
using OmniJournal.Core.Models;

namespace OmniJournal.Core;

public class TrackerFactory
{
    public TrackerFactory()
    {
    }

    public static ITracker Create(TrackerType type, string name, ICollection<object> args)
    {
        switch (type)
        {
            case TrackerType.InputTracker:
                return new InputTracker(name);
            case TrackerType.RankTracker:
                return new RankTracker(name, (List<Ranking>)args);
            default:
                throw new ArgumentException("Invalid tracker type");
        }
    }


}
