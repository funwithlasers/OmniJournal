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

    // I want to move this to viewmodel as an ICommand but need to look into MVVM
    private void OnTrackerTypeSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        switch (picker.SelectedItem.ToString())
        {
            case "Rank Tracker":
                contentPresenter.Content = new RankTrackerDesignerView();
                break;
            case "Input Tracker":
                contentPresenter.Content = new InputTrackerDesignerView();
                break;
            default:
                contentPresenter.Content = null; // Clear the content
                break;
        }
    }
}