using System.Numerics;

namespace OmniJournal.Core;

public class InputTracker<T> : Tracker<T> where T : INumber<T>
{
    public InputTracker(string name) : base(name)
    {
    }

    public override object? Value
    {
        get => (T?)_value;
        set
        {
            if (value == null)
            {
                _value = value;
            }
            else
            {
                throw new ArgumentException($"Value must be of type {typeof(T)} or null.");
            }
        }
    }
}
