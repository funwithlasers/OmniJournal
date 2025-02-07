namespace OmniJournal.Core.Models;

public class RankTracker : Tracker
{
    private List<Ranking> _options;

    public List<Ranking> Options
    {
        get => _options;
        set => _options = value;
    }

    public RankTracker(string name, List<Ranking> rankings) : base(name)
    {
        _options = rankings;
    }
}
