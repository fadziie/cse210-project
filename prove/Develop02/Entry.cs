class Entry
{
    string date;
    string prompt;
    string response;

    public Entry(string _date, string _prompt, string _response)

    {

    }
    public void DisplayEntry()
    {

    }
    public string getEntryAsTXT()
    {
        return string.Format("{0}|{1}|{2}", date, prompt , response);

    }
     public string Date()
    {
        return DateTime.Now.ToShortDateString();
    }
    public void AddEntry()
    {
        date = Date ();
        PromptGenerator Prompt = new PromptGenerator();
        prompt = Prompt.GetRandomPrompt();
        response = Console.ReadLine();
    }

}