namespace OmniJournal.Core;

public class RankTracker : Tracker<int>
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

    public override object? Value
    {
        get => (int?)_value;
        set
        {
            if (value == null || _options.Any(option => option.Rank == (int?)value))
            {
                _value = value;
            }
            else
            {
                throw new ArgumentException("Value must belong to one of the options.");
            }
        }
    }
}
