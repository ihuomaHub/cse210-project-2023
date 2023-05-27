using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> words;
    private Reference reference;

    
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            if (!string.IsNullOrWhiteSpace(wordText))
            {
                string sanitizedWordText = wordText.Trim(',', ';', '.');
                Word word = new Word(sanitizedWordText);
                words.Add(word);

                if (wordText.EndsWith(",") || wordText.EndsWith(";") || wordText.EndsWith("."))
                {
                    //Adding word with only punctuation mark
                    string punctuationMark = wordText.Substring(wordText.Length - 1);
                    Word punctuationWord = new Word(punctuationMark);
                    words.Add(punctuationWord);
                }
            }
        }
    }
    public void HideRandomWord()
    {
        List<Word> visibleWords = GetVisibleWords();
        if (visibleWords.Count > 0)
        {
            List<Word> wordsToHide = RandomWordSelector.SelectRandomWords(visibleWords, 1);
            foreach (Word word in wordsToHide)
            {
                word.Hide();
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (word.IsVisible)
            {
                return false;
            }
            
        }
        return true;
    }

    public string GetFormattedText()
    {
        string formattedText = $"{reference.GetFormattedReference()} {Environment.NewLine}";
        bool addSpace = true;

        foreach (Word word in words)
        {
            if (word.GetRenderedText() == "," || word.GetRenderedText() == ";" || word.GetRenderedText() == ".")
            {
                formattedText += word.GetRenderedText();
            }
            else
            {
                if(addSpace)
                {
                    formattedText += " ";
                }
                formattedText += word.GetRenderedText();
                addSpace = true;
            }
            if (word.GetRenderedText() == "," || word.GetRenderedText() == ";" || word.GetRenderedText() == ".")
            {
                addSpace = false;
            }
        }
        return formattedText;
        
    }
    private List<Word> GetVisibleWords()
    {
         List<Word> visibleWords = new List<Word>();
            foreach (Word word in words)
            {
                if(word.IsVisible)
                
                {
                    visibleWords.Add(word);
                }
            }
            return visibleWords;
    }
}