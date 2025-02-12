using System.ComponentModel;
using System.Runtime.CompilerServices;
using OmniJournal.Core.Models;
using OmniJournal.Maui.Templates;

namespace OmniJournal.Maui.ViewModels;


public partial class TrackerDesignerViewModel : INotifyPropertyChanged
{
    private string? _selectedTemplate;
    public string? SelectedTemplate
    {
        get => _selectedTemplate;
        set
        {
            if (_selectedTemplate != value)
            {
                _selectedTemplate = value;
                OnPropertyChanged();
            }
        }
    }

    private TrackerDesigner _trackerDesigner;
    private Picker templatePicker;
    private Picker _templatePicker;

    public TrackerDesigner ActiveTrackerDesigner
    {
        get => _trackerDesigner;
        set
        {
            _trackerDesigner = value;
            OnPropertyChanged(nameof(ActiveTrackerDesigner));
            OnPropertyChanged(nameof(TrackerName));
            OnPropertyChanged(nameof(TrackerTypeString));
        }   
    }

    public List<string> TrackerTypes { get; set; } = [.. Enum.GetNames<TrackerType>()];

    public string TrackerName => ActiveTrackerDesigner?.Name ?? string.Empty;
    public string TrackerTypeString => ActiveTrackerDesigner?.TrackerType.ToString() ?? string.Empty;

    public Command ShowMessageCommand { get; }
    public Command ChangeDesignerTemplate { get; }

    public TrackerDesignerViewModel(Picker templatePicker)
    {
        _templatePicker = templatePicker;


        ActiveTrackerDesigner = new TrackerDesigner();
        ShowMessageCommand = new Command(OnShowMessage);
        ChangeDesignerTemplate = new Command(OnTrackerTypeChanged);
    }


    private void OnShowMessage()
    {
        ActiveTrackerDesigner!.Name = ActiveTrackerDesigner.Name == "Default Tracker" ? "Alt Tracker" : "Default Tracker";
    }

    private void OnTrackerTypeChanged()
    {
       
    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedType = (TrackerType)templatePicker.SelectedIndex;
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
