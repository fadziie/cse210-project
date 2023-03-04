class Journal
{
    List<Entry> entries;

    public Journal()
    {
      entries = new List<Entry>();

    }
    public void DisplayJournalEntries()
    {
        foreach(Entry entry in entries)
        {
         Console.WriteLine("date ,entry ,response");
        }
        
    }
    public void CreateJournalEntries()
    {
         Entry entry = new Entry("temp date", "temp prompt", "temp response");

         Entry.AddEntry();
         entries.Add(entry);

    }
    public void SaveToTXT()
    {

      Console.WriteLine("Enter a file name (.txt)");
        string fileName =  Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in entries)
            {
                outputFile.WriteLine("date ,prompt ,answer");
            }
        }
    }
    public void LoadFromTXT()
    {
        entries.Clear();
        Console.WriteLine("What file's name would you like to load");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

    }
}