using System;

class Program
{
    static void Main(string[] args)
    {   
        List<string> ak_user_activity = new List<string> {"Breathing", "Reflecting", "Listing", "Quit"};
        List<string> ak_user_description = new List<string> {"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                                            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                                            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                                            "Quit"};

        List<int> ak_log = new List<int>{0,0,0};

        bool ak_program_on = true;

        while(ak_program_on){
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit\n");

            Console.Write("Select a choice from the menu: ");
            int ak_choice = Int32.Parse(Console.ReadLine());

            string ak_chosen_activity = ak_user_activity[ak_choice-1];
            string ak_chosen_description = ak_user_description[ak_choice -1];
            // Activities activity = new Activities(ak_chosen_activity, ak_chosen_description);
            if (ak_choice == 1){
                Breathing breath = new Breathing(ak_chosen_activity, ak_chosen_description);
                breath.breathStartActivities();
                breath.breathEndActivities();
                ak_log[ak_choice-1] += 1;
            }
            else if (ak_choice == 2){
                Reflection reflect = new Reflection(ak_chosen_activity, ak_chosen_description);
                reflect.reflectStartActivities();
                reflect.displayQuestion();
                reflect.reflectEndActivities();
                ak_log[ak_choice-1] += 1;
            }
            else if (ak_choice == 3){
                Listing reflect = new Listing(ak_chosen_activity, ak_chosen_description);
                reflect.listStartActivities();
                reflect.listEndActivities();
                ak_log[ak_choice-1] += 1;
            }

            else if (ak_choice == 4){
                Console.WriteLine("\nActivity Log:");
                for(int i =0; i < 3; i++){
                    Console.WriteLine($"{ak_user_activity[i]}: Performed {ak_log[i]} time(s)");
                }
                ak_program_on = false;
            }
            else {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
            
    }
}