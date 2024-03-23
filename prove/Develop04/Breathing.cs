using System;
using System.Threading;

class Breathing : Activities {

    public Breathing(string ak_name, string ak_description) : base(ak_name, ak_description)
    {

    }
    public void breathStartActivities(){
        base.startActivities();

        Random rnd = new Random();
        int ak_totalTime = getDuration() * 1000;
        while(ak_totalTime > 0){
            int ak_breathIn = 4000;
            int ak_breathOut = 6000;

            if (ak_totalTime >= (ak_breathIn + ak_breathOut))
            {
                // Breathe in
                ak_totalTime -= ak_breathIn;
                Console.Write("\n\nBreathe in...");
                base.CountDown(ak_breathIn);

                // Breathe out
                ak_totalTime -= ak_breathOut;
                Console.Write("\nBreathe out...");
                base.CountDown(ak_breathOut);
                Console.WriteLine();
            }
            else{
                int mb_new_time = ak_totalTime / 2;
                Console.Write("\n\nBreathe in...");
                base.CountDown(ak_breathIn);

                Console.Write("\n\nBreathe out...");
                base.CountDown(ak_breathOut);
                Console.WriteLine();
                ak_totalTime = 0;
               }
        }
        
    }

    public void breathEndActivities(){
        base.EndActivities();
    }

}