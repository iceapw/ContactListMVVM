namespace ContactListMVVM.Views;

public partial class ContactDetail : ContentPage
{
	public ContactDetail()
	{
		InitializeComponent();
	}

	private async void OnBackClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}