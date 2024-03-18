/*
Aayush Khanal
*/

using System;
using System.Diagnostics.CodeAnalysis;

class Program {
    static void Main(string[] args) {
        Console.Clear(); // Clear the console screen to start with a clean display.

        // Create an instance of the Reference class to obtain scripture text and reference.
        Reference reference = new Reference();
        string ak_text = reference.getText(); 
        string ak_reference = reference.getReference(); 

        Scripture scripture = new Scripture(ak_text, ak_reference);

        // Continue displaying and manipulating the scripture until all words are hidden.
        while (!scripture.AreAllWordsHidden()) {
            Console.Clear(); // Clear the console for a clean display on each iteration.
            Console.WriteLine(scripture.ToString()); // Display the current state of the scripture.
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine(); // Read user input.

            if (input == "quit") {
                break; // If the user types 'quit', exit the loop and end the program.
            }

            scripture.HideRandomWord(); // Hide a random word in the scripture.
        }


        // Requirement exceeds from here
        Console.WriteLine("Do you want to set reminders for daily scripture practice? (Yes/No)");
        string ak_remind = Console.ReadLine();
        if (ak_remind.ToLower() == "yes"){
            Console.WriteLine("When do you want me to remind you?");
            string ak_date = Console.ReadLine();
            Console.WriteLine($"I will remind you at {ak_date}.");
        }
        else{
            Console.WriteLine("Thank you see you again!!");
        }
    }
}