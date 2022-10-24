using Assignment1.Model;
using static AssignmentKeeper.App;
namespace AssignmentKeeper.Pages;

public partial class EditPage : ContentPage
{
	private Users users = new();
	public EditPage()
	{
		InitializeComponent();

	}
    protected override void OnAppearing()
    {

        base.OnAppearing();
        entryfname.Text = firstname;
        entrylname.Text = lastname;
        entryass.Text = assignment;

    }

    private async void btnmodify_Clicked(object sender, EventArgs e)
	{
        if (!string.IsNullOrEmpty(entryfname.Text) || string.IsNullOrEmpty(entrylname.Text) || string.IsNullOrEmpty(entryass.Text))
        {
            var a = await users.editdata(entrylname.Text, entryfname.Text, entryass.Text);
            if (!a)
                await DisplayAlert("Modify", "Data Successfully Updated", "OK");
            await Navigation.PopAsync();
            return;
        }
        await DisplayAlert("Modify", "Data Not Successfully Updated", "OK");
    }
}