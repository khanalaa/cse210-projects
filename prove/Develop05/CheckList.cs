class CheckList : Goal
{
    // Fields specific to CheckListGoal
    private int _ak_currentGoal;
    private int _ak_bonus;
    private int _ak_bonusPoint;

    // Constructor
    public CheckList(string ak_name, string ak_description, int ak_points, int ak_bonus, int ak_bonus_point) : base(ak_name, ak_description, ak_points)
    {
        // Initialize fields specific to CheckListGoal
        _ak_bonus = ak_bonus;
        _ak_bonusPoint = ak_bonus_point; 
    }

    // Override List method
    public override void List(int i)
    {
        if (_ak_isCompleted)
        {
            Console.WriteLine($"{i}. [X] {base.getName()} ({base.getDescription()}) -- Currently Completed: {_ak_currentGoal}/{_ak_bonus}");
        }
        else
        {
            Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()}) -- Currently Completed: {_ak_currentGoal}/{_ak_bonus}");
        }
    }

    // Override Complete method
    public override int Complete()
    {
        if (_ak_isCompleted == false)
        {
            _ak_currentGoal += 1;
            if (_ak_currentGoal == _ak_bonus)
            {
                _ak_isCompleted = true;
                return base.getPoints() + _ak_bonusPoint;
            }
            else
            {
                return base.getPoints();
            }
        }
        else
        {
            return 0;
        }
    }

    // Override SaveFile method
    public override string SaveFile()
    {
        return $"CheckListGoal,{base.getName()},{base.getDescription()},{base.getPoints()},{_ak_isCompleted}, {_ak_currentGoal}, {_ak_bonusPoint}, {_ak_bonus}";
    }
}