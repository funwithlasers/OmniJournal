using System.ComponentModel;
using System.Runtime.CompilerServices;
using OmniJournal.Core.Models;
using OmniJournal.Maui.Views;
using OmniJournal.Core.Shared.Extensions;

namespace OmniJournal.Maui.ViewModels;

public partial class TrackerDesignerViewModel : INotifyPropertyChanged
{
    private string? _selectedTrackerType;
    public string SelectedTrackerType
    {
        get => _selectedTrackerType;
        set
        {
            _selectedTrackerType = value;
            OnPropertyChanged(nameof(SelectedTrackerType));
            OnPropertyChanged(nameof(SelectedTrackerView));
        }
    }

    public ContentView SelectedTrackerView
    {
        get
        {
            return SelectedTrackerType switch
            {
                "RankTracker" => new RankTrackerDesignerView(),
                "InputTracker" => new RankTrackerDesignerView()
            };
        }
    }

    private TrackerDesigner _trackerDesigner;

    public TrackerDesigner ActiveTrackerDesigner
    {
        get => _trackerDesigner;
        set
        {
            _trackerDesigner = value;
            OnPropertyChanged(nameof(ActiveTrackerDesigner));
            OnPropertyChanged(nameof(SelectedTrackerType));
        }
    }

    //public List<string> TrackerTypes { get; set; } = [.. Enum.GetNames<TrackerType>()];
    public List<string> TrackerTypes { get; set; } = EnumExtensions.GetDisplayStrings<TrackerType>();

    public TrackerDesignerViewModel()
    {
        ActiveTrackerDesigner = new TrackerDesigner();
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
