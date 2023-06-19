class BreathingActivity : Mindfullness
{
    public BreathingActivity()
    {
        activityName = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void RunActivity()
    {
        base.RunActivity();

        Console.WriteLine("Breathe in...");
        PauseWithSpinner(duration);

        Console.WriteLine("Breathe out...");
        PauseWithSpinner(duration);
    }
}