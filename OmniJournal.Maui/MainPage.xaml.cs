using Kotlin;

namespace OmniJournal.Maui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
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

