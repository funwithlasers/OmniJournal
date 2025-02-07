using OmniJournal.Core.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OmniJournal.Maui.Views;

public partial class TrackerBuilderPage : ContentPage, INotifyPropertyChanged
{
    //public ObservableCollection<TrackerBuilder> ActiveTrackerBuilder { get; set; }
    //private readonly TrackerFactory _trackerFactory = new TrackerFactory();
    private TrackerType _selectedTrackerType;

    public TrackerType SelectedTrackerType
    {
        get => _selectedTrackerType;
        set     // Copoliot gave me this nonsense that can be improved with an attribute
        {
            if (_selectedTrackerType != value)
            {
                _selectedTrackerType = value;
                OnPropertyChanged(nameof(SelectedTrackerType));
            }
        }
    }

    public List<string> TrackerTypes { get; set; } = [.. Enum.GetNames<TrackerType>()];

    public TrackerBuilderPage()
    {
        InitializeComponent();
        SelectedTrackerType = (TrackerType)(-1); // Set a default value that is not a valid TrackerType
        BindingContext = this;
    }

    //public event PropertyChangedEventHandler PropertyChanged;

    //protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}

}

//MySolution
//│
//├── MyApp.Core(Class Library)
//│   ├── Models
//│   ├── Services
//│   └── Interfaces
//│
//├── MyApp.Data(Class Library)
//│   ├── Repositories
//│   └── DataContext
//│
//├── MyApp.Tests(Unit Test Project)
//│   ├── CoreTests
//│   └── DataTests
//│
//├── MyApp.Mobile(MAUI Project)
//│   ├── Views
//│   ├── ViewModels
//│   └── Resources
//│
//└── MyApp.Desktop(MAUI Project)
//    ├── Views
//    ├── ViewModels
//    └── Resources

