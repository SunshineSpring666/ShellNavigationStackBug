
using CommunityToolkit.Maui.Alerts;

namespace MaApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Login_InsertPageBefore_Clicked(object sender, EventArgs e)
    {
        var toast = Toast.Make("Logged in successfully");
        await toast.Show();

        Navigation.InsertPageBefore(new AnnouncementsPage(), this);
        await Navigation.PopToRootAsync();
    }

    private async void Login_PushAsync_Clicked(object sender, EventArgs e)
    {
        var toast = Toast.Make("Logged in successfully");
        await toast.Show();

        await Navigation.PushAsync(new AnnouncementsPage());
    }
}