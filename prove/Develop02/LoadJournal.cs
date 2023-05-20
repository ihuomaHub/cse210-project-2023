public class LoadJournal
{
    public static List<JournalEntry> LoadJournalEntries(string fileName)
    {
        List<JournalEntry> entries = new List<JournalEntry>();
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach(string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    DateTime entryDate;
                    if (DateTime.TryParse(parts[0], out entryDate))
                    {
                        string randomPrompt = parts[1];
                        string response = parts[2];
                        JournalEntry entry = new JournalEntry();
                        entry._entryDate = entryDate;
                        entry._randomPrompt = randomPrompt;
                        entry._response = response;
                        entries.Add(entry);

                    }
                }
            }
        }

        return entries;
    }
}