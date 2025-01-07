namespace OmniJournal.Maui;

public partial class TrackerBuilderPage : ContentPage
{

	public TrackerBuilderPage()
	{
		InitializeComponent();
	}

	private void OnCreateTrackerClicked(object sender, EventArgs e)
	{

		SemanticScreenReader.Announce("SubmitButton.Hint");
	}
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

