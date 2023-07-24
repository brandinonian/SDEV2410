internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch11 Console Project: Name Array by Brandon Phillips");

        int size = 4;
        string[] names = new string[size];

        // ask for names
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write("Enter a first and last name: ");
            names[i] = Console.ReadLine();
        }

        // split names
        string[] firstNames = new string[size];
        string[] lastNames = new string[size];

        // split each name and place in separate arrays
        for (int i = 0; i < names.Length; i++)
        {
            string[] splitNames = names[i].Split(' ');
            firstNames[i] = splitNames[0];
            lastNames[i] = splitNames[1];
        }

        // determine the longest names
        string longestFirst = "";
        foreach (string name in firstNames)
        {
            if (name.Length > longestFirst.Length)
            {
                longestFirst = name;
            }
        }

        string longestLast = "";
        foreach (string name in lastNames)
        {
            if (name.Length > longestLast.Length)
            {
                longestLast = name;
            }
        }

        // Output names
        Console.WriteLine("These are the names: ");
        for (int i = 0; i < size; i++)
        {
            Console.Write("\n" + firstNames[i].PadLeft(longestFirst.Length) + " ");
            Console.Write(lastNames[i].PadRight(longestLast.Length));
            Console.Write($"  Lenth = {names[i].Length - 1}");
        }

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}