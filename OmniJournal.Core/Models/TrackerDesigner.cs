namespace OmniJournal.Core.Models;

public class TrackerDesigner 
{
    private const int MAX_PRECISION = 2;    //this 100% does not belong here

    public static List<Ranking> _starRankings = new List<Ranking>
    {
        new Ranking { Rank = 1, Name = "One Star" },
        new Ranking { Rank = 2, Name = "Two Star" },
        new Ranking { Rank = 3, Name = "Three Star" },
        new Ranking { Rank = 4, Name = "Four Star" },
        new Ranking { Rank = 5, Name = "Five Star" }
    };

    private TrackerType _trackerType = TrackerType.InputTracker;
    private string _name = string.Empty;
    private Type _dataType = typeof(int);
    private List<Ranking>? _rankings;
    private int _precision = 0;

    public TrackerType TrackerType
    {
        get { return _trackerType; }
        set { _trackerType = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Type DataType
    {
        get { return _dataType; }
        set { _dataType = value; }
    }

    public int Precision
    {
        get { return _precision; }
        set { _precision = value; }
    }

    public List<Ranking>? Rankings
    {
        get { return _rankings; }
        set { _rankings = value; }
    }

    void ValidateInputTrackerFields()   //this should probably be a class
    {
        if (TrackerType is not TrackerType.InputTracker)
        {
            throw new ArgumentException("TrackerType must be InputTracker");
        }
        if (Name is not null)
        {
            throw new ArgumentException("Name cannot be null or empty");
        }
        //TODO: Validate Type
    }

    void ValidateRankingTrackerFields()   //this should probably be a class
    {
        if (TrackerType is not TrackerType.RankTracker)
        {
            throw new ArgumentException("TrackerType must be InputTracker");
        }
        if (Name is null)
        {
            throw new ArgumentException("Name cannot be null or empty");
        }
        if (Rankings is null || Rankings.Count < 3)
        {
            throw new ArgumentException("Rankings cannot be null or have fewer than 3 choices");
        }
    }

    public Type GetNumericType(int precision)
    {
        if (precision < 0)
        {
            throw new ArgumentException("Precision cannot be negative");
        }

        if (precision > MAX_PRECISION)
        {
            throw new ArgumentException($"Precision cannot be greater than {MAX_PRECISION}");
        }

        return precision == 0 ? typeof(int) : typeof(float);
    }

}