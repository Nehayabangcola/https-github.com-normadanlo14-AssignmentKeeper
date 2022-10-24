using Firebase.Database;
namespace AssignmentKeeper;

public partial class App : Application
{
	public static FirebaseClient client = new("https://another-aa1b4-default-rtdb.asia-southeast1.firebasedatabase.app/");
	public static string assignment, firstname, lastname, key, email, passowrd;
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
