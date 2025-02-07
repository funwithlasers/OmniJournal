using OmniJournal.Core.Models;

namespace OmniJournal.Maui.Templates; 
public class TrackerDesignerTemplateSelector : DataTemplateSelector
{
    public DataTemplate InputTrackerDesignerTemplate { get; set; }
    public DataTemplate RankTrackerDesignerTemplate { get; set; }
    public DataTemplate SelectionTrackerDesignerTemplate { get; set; }

    public TrackerDesignerTemplateSelector()
    {
        SelectionTrackerDesignerTemplate = new DataTemplate(() =>
        {
            var label = new Label();
            label.SetBinding(Label.TextProperty, "I am .NET only, no XAML!");
            return label;
        }); 
    }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        var displayItem = item as TrackerDesigner;
        if (displayItem == null)
            return null;

        return displayItem.TrackerType switch
        {
            TrackerType.InputTracker => InputTrackerDesignerTemplate,
            TrackerType.RankTracker => RankTrackerDesignerTemplate,
            //TrackerType.Se => RankTemplate
            _ => null
        };
    }

    //public void OnSelectTemplateChanged(object sender, SelectedItemChangedEventArgs e)
    //{
    //    OnSelectTemplate(sender, e);
    //}
}
