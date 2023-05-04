public class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    
    public void WriteEntries()
    {
         
    }

    public void DisplayEntries()
    {
        foreach(Entry entry in entries)
        {
            entry.displayEntryWithFormat();
        }
    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }
}