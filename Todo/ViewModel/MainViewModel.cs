using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Todo.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;
        public MainViewModel(IConnectivity connectivity)
        {
            Items = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }

        [ObservableProperty]
        ObservableCollection<string> items;   

        [ObservableProperty]
        string text;

    

        [RelayCommand]
        async void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;
            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("uh oh!", "No Internet", "OK");
            }

            Items.Add(Text);    
            //add our item
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if(items.Contains(s))
            {
                Items.Remove(s);
            }
        }
        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");

        }
    }
}
