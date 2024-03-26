using System;

class Breathing : Activities
{
    public Breathing(string ak_name, string ak_description) : base(ak_name, ak_description)
    {
    }

    public void BreathStartActivities()
    {
        base.StartActivities();

        Random rnd = new Random();
        int ak_totalTime = GetDuration() * 1000;
        while (ak_totalTime > 0)
        {
            int ak_breathIn = 4000;
            int ak_breathOut = 6000;

            if (ak_totalTime >= (ak_breathIn + ak_breathOut))
            {
                // Breathe in
                ak_totalTime -= ak_breathIn;
                Console.Write("\n\nBreathe in...");
                CountDown(ak_breathIn);

                // Breathe out
                ak_totalTime -= ak_breathOut;
                Console.Write("\nBreathe out...");
                CountDown(ak_breathOut);
                Console.WriteLine();
            }
            else
            {
                int ak_new_time = ak_totalTime / 2;
                Console.Write("\n\nBreathe in...");
                CountDown(ak_breathIn);

                Console.Write("\n\nBreathe out...");
                CountDown(ak_breathOut);
                Console.WriteLine();
                ak_totalTime = 0;
            }
        }
    }

    public void BreathEndActivities()
    {
        base.EndActivities();
    }
}
