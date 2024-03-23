using System;
using System.Diagnostics;

class Listing : Activities{
    private List<string> _ak_questions;
    private List<string> _ak_userResponse;
    public Listing() : base(){
        _ak_questions = new List<string>();
        _ak_userResponse = new List<string>();
    }

    public Listing(string ak_name, string ak_description): base(ak_name, ak_description){
        _ak_questions = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
         _ak_userResponse = new List<string>();
    }

    public void listStartActivities(){
        base.startActivities();

        Console.WriteLine("List as many responses you can to the following prompt:\n");

        displayPrompt();
        

    }

    public void listEndActivities(){
        base.EndActivities();
    }


    public void displayPrompt(){

        Random random = new Random();
        int ak_random_question_index = random.Next(_ak_questions.Count-1);
        string ak_random_question = _ak_questions[ak_random_question_index];

        Console.WriteLine(" ---"+ak_random_question+"---\n");

        Console.Write("You may beign in 5 seconds.\n");
        base.ShowLoadingAnimation();

        int time = base.getDuration();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine($"Begin:");

        while (stopwatch.Elapsed.Seconds < time) {
            if (Console.KeyAvailable) {
                string ak_userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ak_userInput)){
                    _ak_userResponse.Add(ak_userInput);
                }
            }
            // Give a small delay to prevent the loop from consuming too much CPU
            Thread.Sleep(100); // 100ms delay
        }
        Console.Write($"\nYou listed {_ak_userResponse.Count} items!\n");

        
    }
}