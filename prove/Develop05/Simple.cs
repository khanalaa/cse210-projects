class Simple : Goal
{
    // Constructor for SimpleGoal
    public Simple(string ak_name, string ak_description, int ak_points, bool ak_isCompleted)
        : base(ak_name, ak_description, ak_points)
    {
        // Set the isCompleted field for SimpleGoal
        this._ak_isCompleted = ak_isCompleted;
    }

    // Override the List method to customize how SimpleGoal is displayed
    public override void List(int i)
    {
        if (_ak_isCompleted)
        {
            Console.WriteLine($"{i}. [X] {base.getName()} ({base.getDescription()})");
        }
        else
        {
            Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()})");
        }
    }

    // Override the SaveFile method to provide a custom string representation for saving
    public override string SaveFile()
    {
        // Return a formatted string containing information about the SimpleGoal
        return $"SimpleGoal,{base.getName()},{base.getDescription()},{base.getPoints()},{_ak_isCompleted}";
    }
}