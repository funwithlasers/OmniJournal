using OmniJournal.Core.Models;

namespace OmniJournal.Maui.Templates;

public class TrackerTemplateSelector : DataTemplateSelector
{
    public DataTemplate DefaultTemplate { get; set; }
    public DataTemplate SpecialTemplate { get; set; } // Add more templates as needed

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        if (item is TrackerDesigner tracker)
        {
            return tracker.TrackerType switch
            {
                TrackerType.InputTracker => DefaultTemplate,
                TrackerType.RankTracker => SpecialTemplate,
                _ => DefaultTemplate,
            };
        }
        return DefaultTemplate;
    }
}