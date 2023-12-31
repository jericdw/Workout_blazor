using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace Workout_blazor.Models;

public class Exercise
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    [Indexed]
    public int AccountId { get; set; }
    public DateTime Time { get; set; }
    public string Type { get; set; }
    public String Name { get; set; }
    public int Sets { get; set; }
    public int Reps { get; set; }
    public int Force { get; set; }
    public decimal Coefficient { get; set; }
    public decimal Points { get; set; }


}
