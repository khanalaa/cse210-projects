/*
Aayush Khanal
purpose: This program basically calls all the class and have the menu of Journal.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt promptGenerator = new Prompt(); // Create a prompt generator
        Journal journal = new Journal("Aayush Khanal"); // create a journal with a username

        // Define and add journal prompts
        promptGenerator._ak_prompt.Add("What is your favorite memory?");
        promptGenerator._ak_prompt.Add("Describe a place and what you like about it.");
        promptGenerator._ak_prompt.Add("Who was the most interesting person you interacted with today?");
        promptGenerator._ak_prompt.Add("If you had one thing you could do over today, what would it be?");
        promptGenerator._ak_prompt.Add("What was the best part of the day?");

        // stay in loop until it is false
        while (true){
        
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? (1-5): ");
            string _ak_choice = Console.ReadLine();

            
            switch (_ak_choice)
            {
                case "1":

                    Console.Write("\nEnter the location: ");
                    string ak_location = Console.ReadLine(); // Read the location given by user

                    string ak_generatedPrompt = promptGenerator.GeneratePrompt();

                    Console.WriteLine(ak_generatedPrompt); // Display the random prompt

                    Console.Write("Enter your response: ");
                    string ak_response = Console.ReadLine(); //Read the response

                    journal.AddEntry(DateTime.Now, ak_generatedPrompt, ak_location, ak_response);
                    Console.WriteLine("Journal entry added successfully.");
                    break;

                case "2":
                    Console.WriteLine($"\nJournal entries for {journal.GetUserName()}:");
                    journal.Display();
                    break;
                case "3":
                    journal.SaveToFile(); // Save the journal entries to a file
                    Console.WriteLine("Journal entries saved to file.");
                    break;
                case "4":
                    journal.LoadFromFile(); // Load journal entries from file
                    Console.WriteLine("Journal entries loaded from file.");
                    break;
                case "5":
                    Console.WriteLine("Quitting the journal program. Goodbye and see you agian!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

        }
    }
}