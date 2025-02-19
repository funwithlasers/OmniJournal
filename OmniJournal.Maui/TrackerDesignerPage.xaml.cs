using OmniJournal.Maui.ViewModels;
using OmniJournal.Maui.Views;

namespace OmniJournal.Maui;
public partial class TrackerDesignerPage : ContentPage
{
    public TrackerDesignerPage()
    {
        InitializeComponent();
        BindingContext = new TrackerDesignerViewModel();
    }

    private void OnTrackerTypeSelectedIndexChanged(object sender, EventArgs e)
    {

        int selectedIndex = trackerTypePicker.SelectedIndex;

        // Update the ContentView based on the selected index
        switch (selectedIndex)
        {
            case 0:
                contentPresenter.Content = new RankTrackerDesignerView();
                break;
            case 1:
                contentPresenter.Content = new InputTrackerDesignerView();
                break;
            default:
                contentPresenter.Content = null; // Clear the content
                break;
        }
    }
}