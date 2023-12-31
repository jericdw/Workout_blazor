using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_blazor.Models;

using SQLite;

public class ExerciseRepository : IDisposable
{
    private readonly SQLiteConnection db;

    public ExerciseRepository(string dbName)
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
        db = new SQLiteConnection(dbPath);
        db.CreateTable<Exercise>();

    }

    public List<Exercise> GetExercises()
    {
        return db.Table<Exercise>().ToList();
    }

    public int CreateExercise(Exercise exercise)
    {
        return db.Insert(exercise);
    }

    public int UpdateExercise(Exercise exercise)
    {
        return db.Update(exercise);
    }

    public int DeleteExercise(Exercise exercise)
    {
        return db.Delete(exercise);
    }

    public List<Exercise> QueryExerciseByName()
    {
        //return db.Query<Exercise>("SELECT * FROM Exercise WHERE Id = 1");
        return db.Query<Exercise>("SELECT * FROM Exercise WHERE Name = 'Bench Press'");
    }
    public List<Exercise> QueryExerciseByCoefficient()
    {
        return db.Query<Exercise>("SELECT * FROM Exercise WHERE Coefficient > 1");
    }

    public void Dispose()
    {
        db.Dispose();
    }
}
