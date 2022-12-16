namespace MaApp;

public partial class InventoriesPage : ContentPage
{
	public InventoriesPage()
	{
		InitializeComponent();
	}

    // Why NavigationStack[0] is always null?
    protected override bool OnBackButtonPressed()
        => Navigation.NavigationStack.Count == 2 && Navigation.NavigationStack[0].GetType() == typeof(LoginPage);

}