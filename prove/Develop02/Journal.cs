public class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    
    public void WriteEntries()
    {
         List<string> Prompts = new List<string>()
         
            {
                "What was an spiritual impresion you felt today?",
                "Were you able to feel something while praying?",
                "How was your mood on your work?",
                "Did you experience a challenge today? How did you overcome it?",
                "What can you do to build a stronger family?"
            };
            int RandomPrompt = new Random().Next(0, Prompts.Count());
            string promptSelected = Prompts[RandomPrompt];
            Console.WriteLine(promptSelected);
            string answer = Console.ReadLine();
            Entry  entry = new Entry(DateTime.Now, promptSelected, answer);
            entry.SaveAsCsvEntry();
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