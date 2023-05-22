using System;
using System.Collections.Generic;
public class RandomWordSelector
{
    private static Random random = new Random();
    public static List<Word> SelectRandomWords(List<Word> words, int count)
    {
        List<Word> SelectWords = new List<Word>();

        int totalWords = words.Count;
        for (int i = 0; i < count; i++)
        {
            int randomIndex = random.Next(, totalWords);
            selectedWords.Add(words[randomIndex]);
        }
        return selectedWords;
    }
}