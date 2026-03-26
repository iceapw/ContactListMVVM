using ContactListMVVM.Models.ViewModels;

namespace ContactListMVVM.Views;

public partial class Homepage : ContentPage
{
	private ContactListViewModel contactsViewModel;
	public Homepage()
	{
		InitializeComponent();
		contactsViewModel = new ContactListViewModel();
		BindingContext = contactsViewModel;

		contactsViewModel.OnContactAdded = async () =>
		{
			var contactList = new ContactList();
			contactList.BindingContext = contactsViewModel;
			await Navigation.PushAsync(contactList);
		};
	}



	private void Button_Clicked(object sender, EventArgs e)
	{

		var contactList = new ContactList();
		contactList.BindingContext = contactsViewModel;
		Navigation.PushAsync(contactList);
	}
}