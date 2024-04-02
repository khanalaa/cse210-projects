class Goal
{
    // Fields
    public bool _ak_isCompleted = false;
    private string _ak_name;
    private string _ak_description;
    private int _ak_point;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _ak_name = name;
        _ak_point = points;
        _ak_description = description;
    }

    // Getter methods
    public string getName()
    {
        return _ak_name;
    }

    public string getDescription()
    {
        return _ak_description;
    }

    public int getPoints()
    {
        return _ak_point;
    }

    public bool getComplete()
    {
        return _ak_isCompleted;
    }

    // Virtual methods
    public virtual void List(int i)
    {
        // This method is intended to be overridden by derived classes
    }

    public virtual string SaveFile()
    {
        // This method is intended to be overridden by derived classes
        return "";
    }

    public virtual int Complete()
    {
        if (_ak_isCompleted == false)
        {
            _ak_isCompleted = true;
            return _ak_point;
        }
        else
        {
            return 0;
        }
    }
}