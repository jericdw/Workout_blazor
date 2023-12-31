//Copyright(c) Krueger Systems, Inc.

//All rights reserved.

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

namespace Workout_blazor;
using Workout_blazor.Models;
using Workout_blazor.ViewModel;


public partial class MainPage : ContentPage
{
    private readonly ExerciseRepository _exerciseRepository;
    //private readonly MainViewModel vm;

    public MainPage(ExerciseRepository exerciseRepository, MainViewModel vm)
    { 
        _exerciseRepository = exerciseRepository;
        InitializeComponent();
        BindingContext = vm;
        

    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        GetExercises();
    }

    private void AddExerciseClicked(object sender, EventArgs e)
    {
        var exercise = new Exercise()
        {
            Name = "Bench Press",
            Sets = 2,
            Reps = 12,
            Force = 135,
            Coefficient = 0.654M

        };
        _exerciseRepository.CreateExercise(exercise);
        GetExercises();
    }


    private void UpdateExerciseClicked(object sender, EventArgs e)
    {
        if (collectionView.SelectedItem is null)
            return;

        var exercise = collectionView.SelectedItem as Exercise;
        if (exercise is null)
            return;

        exercise.Name = "Dumbell Bench";
        exercise.Coefficient = 1.436M;
        _exerciseRepository.UpdateExercise(exercise);
        GetExercises();
    }

    private void DeleteExerciseClicked(object sender, EventArgs e)
    {
        if (collectionView.SelectedItem is null)
            return;

        var exercise = collectionView.SelectedItem as Exercise;
        if (exercise is null)
            return;

        _exerciseRepository.DeleteExercise(exercise);
        GetExercises();
    }

    private void Filter2ExerciseClicked(object sender, EventArgs e)
    {
        collectionView.ItemsSource = _exerciseRepository.QueryExerciseByCoefficient();
    }

    private void Filter1ExerciseClicked(object sender, EventArgs e)
    {
        collectionView.ItemsSource = _exerciseRepository.QueryExerciseByName();
    }

    private void GetExercises()
    {
        collectionView.ItemsSource = _exerciseRepository.GetExercises();
    }

}