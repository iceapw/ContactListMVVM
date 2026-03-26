using CommunityToolkit.Mvvm.ComponentModel;

namespace ContactListMVVM.Models.ViewModels;

partial class ContactDetailViewModel : ObservableObject
{
	[ObservableProperty]
	private Contacts contact;
}
