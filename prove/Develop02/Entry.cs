public class Entry
{   public string prompt, answer;
    public DateTime date;
    public Entry(DateTime _date, string _prompt, string _answer)
    {
        _date = date;
        _prompt = prompt;
        _answer = answer;
    }

    public void displayEntryWithFormat()
    {
        string dateToString = date.ToShortDateString();
        Console.WriteLine($"Date: {dateToString} - Prompt: {prompt}\n{answer}");
    }   

    public string SaveAsCsvEntry()
    {
        return string.Format("{0}|{1}|{2}", date, prompt, answer);
    }
}