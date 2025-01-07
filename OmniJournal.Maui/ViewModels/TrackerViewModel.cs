using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using OmniJournal.Core.Models;

namespace OmniJournal.Maui.ViewModels;

public class TrackerViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Tracker> Trackers { get; set; } = new ObservableCollection<Tracker>();


    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
