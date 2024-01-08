namespace CollectionViewIsEnabledTest;

public partial class MainPage : ContentPage
{
	public List<string> Items { get; } = new List<string>()
	{
		"Item 1",
		"Item 2",
		"Item 3",
		"Item 4",
		"Item 5",
	};

	public MainPage()
	{
		InitializeComponent();

		BindingContext = this;
	}

}


