public class Resume
{
    public string _fullName = "";
    public List<Job> Jobs = new List<Job>();

    public void DisplayMyResume()
    {
        Console.WriteLine(_fullName);
        Console.WriteLine($"{Jobs}:");
    }
}
