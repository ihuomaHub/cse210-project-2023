using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> words;
    private Reference reference;

    public List<Word> Words { get {return words; }}
    public Reference Reference { get {return reference}}

    public Scripture(Reference reference, string text)
    {
        this.refernce = reference;
        this.words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string WordText in wordArray)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }
    }

    public string GetRendaredText()
    {
        string renderedText = " ";
        foreach (Word word in words)
        {
            renderedText += word.GetRenderedText() + " ";
        }
        return renderedText.TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (word.IsVisible)
            {
                return false;
            }
            return true;
        }
    }
}