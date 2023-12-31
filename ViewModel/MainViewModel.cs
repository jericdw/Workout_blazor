using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace Workout_blazor.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    async Task WebContent()
    {
        await Shell.Current.GoToAsync("WebContentPage");
    }
}
