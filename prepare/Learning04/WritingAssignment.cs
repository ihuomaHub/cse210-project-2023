using System;
public class WritingAssignment : Assignment
{
    protected _title = "";

    Public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"Title: {_title}";
    }
}