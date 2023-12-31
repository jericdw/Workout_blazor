namespace Workout_blazor;

using Workout_blazor.Models;
using Workout_blazor.ViewModel;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new MainPage(new ExerciseRepository("Exercises.db"), null);
        
        
    }
}