using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Todo.ViewModel;


[QueryProperty("Text", "Text")]

public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [ObservableProperty]
    string value;



    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async Task SaveDetails(string s)
    {
        await Shell.Current.GoToAsync($"{nameof(MoreDetailsPage)}?Text={s}");
    }
}
 

    


