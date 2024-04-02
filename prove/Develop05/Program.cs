using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize variables and objects
        bool ak_is_on = true;
        int ak_total_points = 0;
        List<Goal> goals = new List<Goal>();
        Save save = new Save();
        Load load = new Load();

        while (ak_is_on)
        {
            // Display menu options
            Console.WriteLine($"\nYou have {ak_total_points} points.\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goal");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            // User input for menu choice
            Console.Write("Select a choice from the menu: ");
            int ak_choice = Int32.Parse(Console.ReadLine());

            if (ak_choice == 1)
            {
                // Create a new goal based on user input
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. CheckList Goal");

                Console.Write("Which type of goal would you like to create? ");
                int ak_user_goal = Int32.Parse(Console.ReadLine());

                if (ak_user_goal == 1)
                {
                    // Create a SimpleGoal
                    Console.Write("What is the name of your goal? ");
                    string ak_name = Console.ReadLine();

                    Console.Write("What is the short description of it? ");
                    string ak_description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int ak_point = Int32.Parse(Console.ReadLine());

                    Simple goal = new Simple(ak_name, ak_description, ak_point, false);
                    goals.Add(goal);
                }
                else if (ak_user_goal == 2)
                {
                    // Create an EternalGoal
                    Console.Write("What is the name of your goal? ");
                    string ak_name = Console.ReadLine();

                    Console.Write("What is the short description of it? ");
                    string ak_description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int ak_point = Int32.Parse(Console.ReadLine());

                    Eternal goal = new Eternal(ak_name, ak_description, ak_point);
                    goals.Add(goal);
                }
                else if (ak_user_goal == 3)
                {
                    // Create a CheckListGoal
                    Console.Write("What is the name of your goal? ");
                    string ak_name = Console.ReadLine();

                    Console.Write("What is the short description of it? ");
                    string ak_description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int ak_point = Int32.Parse(Console.ReadLine());

                    Console.Write("How many times the goal need to be accomplished for a bonus? ");
                    int ak_bonus = Int32.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int ak_bonus_point = Int32.Parse(Console.ReadLine());

                    CheckList goal = new CheckList(ak_name, ak_description, ak_point, ak_bonus, ak_bonus_point);
                    goals.Add(goal);
                }
            }
            else if (ak_choice == 2)
            {
                // Display the list of goals
                Console.WriteLine("The goals are: ");
                int count = 1;
                foreach (Goal g in goals)
                {
                    g.List(count);
                    count += 1;
                }
            }
            else if (ak_choice == 3)
            {
                // Save goals to a file
                save.SaveToFile(goals);
            }
            else if (ak_choice == 4)
            {
                // Load goals from a file
                load.LoadFromFile(goals);
            }
            else if (ak_choice == 5)
            {
                // Record an event and update points
                Console.WriteLine("The goals are: ");
                int count = 1;
                foreach (Goal g in goals)
                {
                    g.List(count);
                    count += 1;
                }

                Console.Write("Which goal did you accomplish? ");
                string ak_goal_choice = Console.ReadLine();
                ak_total_points += goals[int.Parse(ak_goal_choice) - 1].Complete();
                Console.WriteLine($"Congratulations. You now have {ak_total_points} points.");
            }
            else if (ak_choice == 6)
            {
                // Ask for confirmation before quitting
                Console.WriteLine("Do you want us to remind you for a task? (Yes/No)");
                string ak_remind = Console.ReadLine().ToLower();
                if (ak_remind == "no")
                {
                    Console.WriteLine("Thank You. See you again!");
                }
                else
                {
                    Console.WriteLine("When do you want us to remind? (DD/MM)");
                    string ak_time = Console.ReadLine();
                    Console.WriteLine($"Thank you. We will remind you on {ak_time}. Have a great time.");
                }
                ak_is_on = false; // Exit the loop and end the program
            }
        }
    }
}