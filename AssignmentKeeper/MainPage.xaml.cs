using Assignment1.Model;
using AssignmentKeeper.Pages;
namespace AssignmentKeeper;

public partial class MainPage : ContentPage
{
	Users users = new Users();
	public MainPage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		var a = await users.UserLogin(email.Text, password.Text);
		if (a)
		{
			await DisplayAlert("Alerrt!", "Acces Granted", "Got it");
			await Navigation.PushAsync(new HomePage());
		}
		else
		{
            await DisplayAlert("Alerrt!", "Acces Denied", "Got it");

        }
    }

	private async void Button_Clicked_1(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new CreateAccount());

    }
}

