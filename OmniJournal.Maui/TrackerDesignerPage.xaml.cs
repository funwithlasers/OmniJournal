using OmniJournal.Maui.ViewModels;
using OmniJournal.Maui.Templates;
using OmniJournal.Core.Models;

namespace OmniJournal.Maui;
public partial class TrackerDesignerPage : ContentPage
{
    public TrackerDesignerPage()
    {
        InitializeComponent();
        BindingContext = new TrackerDesignerViewModel(templatePicker);
    }
    private void OnPickerSelectionChanged(object sender, EventArgs e)
    {
        if (templatePicker.SelectedItem is TrackerDesigner selectedTracker)
        {
            var selectedTemplate = (TrackerType)templatePicker.SelectedIndex;
            // Use the selectedTemplate as needed
            // For example, you can set it to a ContentView or other UI element
        }
    }
}