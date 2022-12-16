namespace MaApp;

public partial class SharedTasksPage : ContentPage
{
	public SharedTasksPage()
	{
		InitializeComponent();
	}

    // Why NavigationStack[0] is always null?
    protected override bool OnBackButtonPressed() 
		=> Navigation.NavigationStack.Count == 2 && Navigation.NavigationStack[0].GetType() == typeof(LoginPage);

}