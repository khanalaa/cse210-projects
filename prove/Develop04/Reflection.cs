using System;
class Reflection:Activities{
    private List<string> _ak_reflect;

    public Reflection(): base(){
        _ak_reflect = new List<string>();
    }
    public Reflection(string ak_name, string ak_description) : base(ak_name, ak_description){
        _ak_reflect = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    public void reflectStartActivities(){

        base.startActivities();
        string ak_prompt = base.getPrompt();
        Console.WriteLine("Consider the following prompt:\n");

        Console.WriteLine("  ---"+ak_prompt+"---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        ConsoleKeyInfo keyInfo;
        do{
            keyInfo = Console.ReadKey(true);
            if(keyInfo.Key == ConsoleKey.Enter){
                break;
            }
        } while (true);

        Console.WriteLine("\nNow ponder on each of the following questions as they related to the experience.");
        Console.Write("You may beign in few seconds.");
        base.ShowLoadingAnimation();
        


    }

    public void displayQuestion(){
        Console.Clear();


        int ak_time = base.getDuration();

        while(ak_time > 0 ){

            int ak_questionTime = Math.Min(10, ak_time);

            Random random = new Random();
            int index = random.Next(_ak_reflect.Count-1);
            string ak_randomPrompt = _ak_reflect[index];

            Console.Write(ak_randomPrompt);
           
            // Adding a "Loading" animation using periods (dots)
            for (int i = 0; i < ak_questionTime; i++)  // Displaying 5 dots
            {
                Console.Write(".");
                Thread.Sleep(1000);  // Pauses for 1000 milliseconds
            }
            Console.Write("\n");  // Move to the next line
    
            ak_time -= ak_questionTime;
        }

        
    }

    public void reflectEndActivities(){
        base.EndActivities();
    }
}