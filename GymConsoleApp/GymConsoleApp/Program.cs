
class Exercise 
{
    static readonly int idPool = 0;
    // TODO: update item counter

    public string exerciseName { get; set; }
    int repetitions { get; set; }
    int weight { get; set; }

    public Exercise(string exerciseName, int repetitions, int weight)
    {
        this.weight = weight;
        this.repetitions = repetitions;
        this.exerciseName = exerciseName;
    }
    
    ~Exercise() { }

    public override string ToString()
    {
        return ("Exercise name:\t" + exerciseName + " Repetitions:\t" + repetitions + "Weight:\t" + weight);
    }
}

class Regiment
{
    static readonly int idRegimen = 0;

    string regimentName { get; set; }
    private List<Exercise> exercisesList;

    public Regiment(string regimentName, List<Exercise>? exercisesList = default)
    {
        this.exercisesList = exercisesList ?? new List<Exercise>();
        this.regimentName = regimentName;
    }

    public Exercise this[int iter] => exercisesList[iter];

    public override string ToString()
    {
        string returnString = "Regiment " + regimentName + "\n";
        foreach (Exercise ex in exercisesList)
        {
            returnString += ex.ToString() + "\n";
        }
        return returnString;
    }

    public void addExercise(Exercise ex)
    {
        exercisesList.Add(ex);
    }

    public void removeExercise(Exercise ex)
    {
        // Try to delete exercise based on exercise name; TODO - END
        try
        {
            Exercise? toDelete = exercisesList.Find(x => x.exerciseName == ex.exerciseName);

        }
        finally
        {

        }
    }
}

class App
{ 
    public static void Main()
    {
        Console.WriteLine("this is main");
        Exercise ex1 = new Exercise("dumbell row", 10, 20);
        Exercise ex2 = new Exercise("bench press", 20, 10);

        Regiment re = new Regiment("Monday");
        re.addExercise(ex1);
        re.addExercise(ex2);

        Console.WriteLine(re);
    }
}
