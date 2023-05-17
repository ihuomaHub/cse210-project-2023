public class RandomPromptGenerator
{
    private Random random;
    private string[] prompts;

    public RandomPromptGenerator()
    {
        random = new Random();
        prompts = new string[]
        {
            "What was the best part of my day?",
            "What good have I done in the world today?",
            "If I had one thing I could do over today, what would it be?",
            "What blessings are my grateful for?"
        };
    }

    public string GenerateRandomPrompt()
    {
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}