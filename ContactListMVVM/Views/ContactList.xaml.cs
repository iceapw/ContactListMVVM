using ContactListMVVM.Models.ViewModels;
using ContactListMVVM.Models;

namespace ContactListMVVM.Views;

public partial class ContactList : ContentPage
{
	public ContactList()
	{
		InitializeComponent();
	}

	private void Lv_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var contact = e.Item as ContactListMVVM.Models.Contacts;
		var contactViewModel = new ContactDetailViewModel { Contact = contact };
		var contactDetail = new ContactDetail();
		contactDetail.BindingContext = contactViewModel;
		Navigation.PushAsync(contactDetail);

	}
}