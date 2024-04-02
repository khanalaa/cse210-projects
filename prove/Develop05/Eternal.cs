class Eternal : Goal
{
    // Constructor
    public Eternal(string ak_name, string ak_description, int ak_points) : base(ak_name, ak_description, ak_points)
    {
        // The constructor of the base class (Goal) is called with specified parameters
    }

    // Override List method
    public override void List(int i)
    {
        Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()})");
        // This displays the eternal goal information in a specific format
    }

    // Override Complete method
    public override int Complete()
    {
        return base.getPoints();
        // Completing an eternal goal returns its base points without any additional logic
    }

    // Override SaveFile method
    public override string SaveFile()
    {
        return $"EternalGoal,{base.getName()},{base.getDescription()},{base.getPoints()},{_ak_isCompleted}";
        // This returns a string representation of the eternal goal for saving to a file
    }
}