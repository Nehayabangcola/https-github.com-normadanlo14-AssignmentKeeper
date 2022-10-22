using Assignment1.Model;

namespace AssignmentKeeper.Pages;

public partial class CreateAccount : ContentPage
{
	Users users = new Users();
	public CreateAccount()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		var result = await users.AddUser(Assignment.Text, fname.Text, lname.Text, emailCA.Text, passwordCA.Text);
		if (result)
		{
			await DisplayAlert("Alert", "Created", "OK");
			await Navigation.PopAsync();
		}
		else
		{
            await DisplayAlert("Alert", "Not Created", "OK");

        }
    }
}