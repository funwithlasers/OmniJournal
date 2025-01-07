using OmniJournal.Core.Models;

namespace OmniJournal.Core;

public class RankTracker : Tracker
{
    private List<Ranking> _options;

    public List<Ranking> Options
    {
        get => _options;
        set => _options = value;
    }

    public RankTracker(string name, List<Ranking> rankings) : base()
    {
        _options = rankings;
    }

}
