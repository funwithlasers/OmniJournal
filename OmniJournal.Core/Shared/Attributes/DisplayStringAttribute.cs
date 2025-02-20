namespace OmniJournal.Core.Shared.Attributes;
public class DisplayStringAttribute : Attribute
{
    public string Name { get; }

    public DisplayStringAttribute(string name)
    {
        Name = name;
    }
}
