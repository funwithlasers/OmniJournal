using OmniJournal.Core.Models;

namespace OmniJournal.Maui.Templates
{
    public class TrackerTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate RankedTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object trackerType, BindableObject container)
        {
            return trackerType switch
            {
                TrackerType.StringTracker => DefaultTemplate,
                TrackerType.IntTracker => DefaultTemplate,
                TrackerType.DecimalTracker => DefaultTemplate,
                TrackerType.TimeTracker => RankedTemplate,
                _ => DefaultTemplate,
            };
        }
    }
}
