using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.ViewModel;

    [QueryProperty("Text","Text")]
    [QueryProperty("DateTime","DateTime")]

[QueryProperty("Value", "Value")]

public partial class MoreDetailsViewModel: ObservableObject
    {
    [ObservableProperty]
    string text;

        [ObservableProperty]
        string dateTime;

        [ObservableProperty]
        string value;
    }

