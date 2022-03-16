namespace ConsoleApp;
using System.Linq;

// this class basically handles manipulation of article
public static class Article
{
    static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

    /// <summary>
    /// this is a method that returns an appropriate article for the word given
    /// </summary
    public static string GetArticle(string word)
    {
        char firstLetter = word[0];
        if (vowels.Contains(firstLetter))
            return "an";
        else
            return "a";
    }
}