public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity.\n\n", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n\n") { }

    public void Run()
    {
        DisplayStartingMessage();

        int timeSpent = 0;
        while (timeSpent < _duration)
        {
            Console.Clear();
            BreatheIn();
            Console.Clear();
            BreatheOut(); 

            timeSpent += 5;  // Each cycle of in/out takes 5 seconds
        }

        DisplayEndingMessage();
    }
     private void BreatheIn()
    {
        Console.WriteLine("Breathe in...");
        AnimateBreath("inhale");
    }

    //Exceeding Requirements.
    private void BreatheOut()
    {
        Console.WriteLine("Breathe out...");
        AnimateBreath("exhale");
    }
    private void AnimateBreath(string action)
    {
        string breathText = action == "inhale" ? "Breathe in..." : "Breathe out...";
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }
    }
}
