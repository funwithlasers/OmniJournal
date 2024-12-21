namespace OmniJournal.Core;

public abstract class Tracker<T> : ITracker
{
    protected string _name;
    protected object? _value;
    public virtual string Name { get; set; }
    public abstract object? Value { get; set; }

    public Tracker(string name)
    {
        _name = name;
    }
}