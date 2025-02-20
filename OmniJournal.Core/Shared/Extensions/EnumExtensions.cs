using OmniJournal.Core.Shared.Attributes;
using System.Reflection;

namespace OmniJournal.Core.Shared.Extensions;
public static class EnumExtensions
{
    public static List<string> GetDisplayStrings<T>() where T : Enum
    {
        // Get all values of the enum
        var enumValues = Enum.GetValues(typeof(T)).Cast<T>();

        // Call ToDisplayString on each value and return the result as a list
        return enumValues.Select(value => value.ToDisplayString()).ToList();
    }

    public static string ToDisplayString(this Enum value)
    {
        {
            return value.GetType()
                            .GetMember(value.ToString())
                            .First()
                            .GetCustomAttribute<DisplayStringAttribute>()
                            .Name;
        }
    }
}