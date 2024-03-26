using System;
class Activities
{
    private string _ak_name;
    private string _ak_description;
    private int _ak_duration;
    private List<string> _prompts;

    public Activities()
    {
        _ak_name = "";
        _ak_description = "";
        _ak_duration = 0;
        _prompts = new List<string>();
    }

    public Activities(string ak_name, string ak_description)
    {
        _ak_name = ak_name;
        _ak_description = ak_description;
        _ak_duration = 0;
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }

    public void Animation()
    {
        char[] spinner = { '|', '/', '-', '\\' };

        for (int i = 0; i < 20; i++)  // 20 iterations of spinning
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(300);  // Pause for 300 milliseconds
            Console.Write('\b');  // Move cursor back
        }
    }

    public void StartActivities()
    {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_ak_name} activity.\n");
        Console.WriteLine(_ak_description);
        Console.Write("\nHow long, in seconds, would you like for your sessions? ");
        _ak_duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready!!");
        Animation();
    }

    public int GetDuration()
    {
        return _ak_duration;
    }

    public string GetPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        string ak_randomPrompt = _prompts[index];
        return ak_randomPrompt;
    }

    public void EndActivities()
    {
        Console.WriteLine($"\nWell done!!!");
        Animation();
        Console.WriteLine($"You have completed another {_ak_duration} seconds of the {_ak_name} Activity.\n");
        Animation();
    }

    public void CountDown(int time)
    {
        for (int i = time; i > 0; i -= 1000)
        {
            Console.Write($"{i / 1000}  ");
            Thread.Sleep(1000);
        }
    }
}
