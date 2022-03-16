namespace ConsoleApp;

// entry class
public static class Program
{
    // entry point of the application
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(ProcessProgramInput(args[0], args[1]));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    // this method process user input to the system
    public static string ProcessProgramInput(string word, string location)
    {
        //First the value provided are not null and containing white spaces
        if (string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(location))
            throw new Exception("Please provide valid input to the program: whitespaces, null values are not allowed");
        if (word.Length == 1)
            throw new Exception("Please input a valid object name for the captain to react appropriately");

        return $"Ahoy, Captain, {Article.GetArticle(word)} {word} of to {location}!";
    }
}