internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch11 Console Project: Count Words");


        // ask for user input
        Console.Write("Enter a sentence or phrase: ");
        string userInput = Console.ReadLine();

        // split at whitespace
        string[] words = userInput.Split(' ');

        // display word count
        Console.WriteLine($"There are {words.Count()} words in that sentence.");

        // find the longest word
        string longest = "";
        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        // display the number of words
        Console.WriteLine($"The longest word is {longest} which is {longest.Length} characters.");


        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}