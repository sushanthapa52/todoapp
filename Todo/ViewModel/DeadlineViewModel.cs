using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.ViewModel;

[QueryProperty("DateTime", "DateTime")]
public partial class DeadlineViewModel: ObservableObject
    {

    [ObservableProperty]
     DateTime dateTime;

    }

