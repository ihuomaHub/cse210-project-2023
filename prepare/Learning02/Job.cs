public class Job
{
    public string _companyName = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = -1;
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}