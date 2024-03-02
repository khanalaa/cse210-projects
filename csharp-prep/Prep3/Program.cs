using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        while (playAgain != "no"){
       Random random = new Random();
       int magicNum = random.Next(1,101);

       int guess = -1;
       int count = 0;

        while(guess != magicNum){

            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());
            count += 1;

            if (guess > magicNum){
                Console.WriteLine("Lower");
            }
            else if (guess < magicNum){
                Console.WriteLine("Higher");
            }
            else if (guess == magicNum){
                Console.WriteLine("You guessed it!");
            }
        }
        Console.WriteLine($"It took {count} guess to find the number.\n");
        Console.Write("Do you want to play again? (yes/no)");
        playAgain = Console.ReadLine().ToLower();
    }
    }
}