public class SaveJournal
{
    public static void SaveJournalEntries(List<JournalEntry> entries, string fileName)
    {
        List<string> lines = new List<string>();
        foreach (JournalEntry entry in entries)
        {
            string line = $"{entry._entryDate}|{entry._randomPrompt}|{entry._response}";
            lines.Add(line);
        }
        File.WriteAllLines(fileName, lines);
    }
}
