using System;
public class Word
{
    private string text;
    private bool isVisible;

    public string Text { get {return text; }}
    public bool IsVisible { get {return isVisible; }}

    public Word(string text)
    {
        this.text = text;
        this.isVisible = true;   
    }
    public void Hide()
    {
        isVisible = false;
    }
    
    public void Show()
    {
        isVisible = true;
    }

    public bool IsHidden()
    {
        return !isVisible;
    }

    public string GetRenderedText()
    {
        if (isVisible)
        {
            return text;
        }
        else
        {
            return new string ('_', text.Length);
        }
    }
}