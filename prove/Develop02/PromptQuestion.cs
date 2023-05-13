public class RandomQuestions
{
    public List<RandomQuestions> _promptQuestion = new List<RandomQuestions>();
    public string _promptQuestion1;
    public string _promptQuestion2;
    public string _promptQuestion3;
    public string _promptQuestion4;
    public string _promptQuestion5;

    public void displayRandomQuestions()
    {
        foreach(RandomQuestions question in _promptQuestion)
        Console.WriteLine($"{_promptQuestion}");
    }

}