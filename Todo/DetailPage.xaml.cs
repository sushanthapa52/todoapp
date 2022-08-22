using CommunityToolkit.Mvvm.Input;
using Todo.ViewModel;

namespace Todo;

public partial class DetailPage : ContentPage
{

	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;

      
    }

	[RelayCommand]
	async Task SaveDetails()
	{

        //            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");

    }


}