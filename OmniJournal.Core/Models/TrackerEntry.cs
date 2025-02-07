using System.Diagnostics.CodeAnalysis;

namespace OmniJournal.Core.Models;

public class TrackerEntry
{
    private ITracker Tracker { get; set; }
    public Object Value { get; set; }
    public TrackerEntry()
    {
    }
}
