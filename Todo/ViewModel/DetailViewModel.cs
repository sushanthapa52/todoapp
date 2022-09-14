using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;

namespace Todo.ViewModel;


[QueryProperty("Text", "Text")]

public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;



    [ObservableProperty]
    DateTime dateTime;



    [ObservableProperty]
    string value;




    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async Task SaveDetails()
    {
        var DateTime = new Dictionary<string, object>
        {

            { "DateTime", dateTime.ToString() },
            { "Value", value.ToString() },

        };
   
        await Shell.Current.GoToAsync($"{nameof(MoreDetailsPage)}?Text={Text}", DateTime);
    }



}

