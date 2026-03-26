
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ContactListMVVM.Models.ViewModels;

partial class ContactListViewModel : ObservableObject


{

	public Action OnContactAdded;
	[ObservableProperty]
	private ObservableCollection<Contacts> contacts = new();

	[ObservableProperty]
	private Contacts contact = new();

	[RelayCommand]
	private void Add()
	{
		Contacts.Add(Contact);
		Contact = new();
		OnContactAdded?.Invoke();
	}

}
