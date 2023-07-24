internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 9 Console Project: Adding Colors with Enum by Brandon Phillips");

        // pick colors
        Console.WriteLine("\nWhich colors do you want to add together?");
        Console.WriteLine("red(r) green(g) blue(b)");
        Console.Write("First color: ");
        string firstReply = Console.ReadLine();

        // assign answer to enum
        Colors firstColor = Colors.red;
        switch (firstReply)
        {
            case "r":
                firstColor = Colors.red;
                break;
            case "g":
                firstColor = Colors.green;
                break;
            case "b":
                firstColor = Colors.blue;
                break;
        }
        Console.Write("Second color: ");
        string secondReply = Console.ReadLine();

        // assign the second answer to enum
        Colors secondColor = Colors.green;
        switch (secondReply)
        {
            case "r":
                secondColor = Colors.red;
                break;
            case "g":
                secondColor = Colors.green;
                break;
            case "b":
                secondColor = Colors.blue;
                break;
        }

        // result variable
        Colors resultColor = Colors.none;

        // add using loop
        resultColor = firstColor;
        for (int i = 1; i <= (int)secondColor; i++)
        {
            resultColor++;
        }
        Console.WriteLine($"Looping: Result of mixing {firstColor} and {secondColor} is {resultColor}");

        // add using casting
        int firstInt = (int)firstColor;
        int secondInt = (int)secondColor;
        int thirdInt = firstInt + secondInt;
        resultColor = (Colors)thirdInt;
        Console.WriteLine($"Casting: Combining {firstColor} and {secondColor} gives {resultColor}");

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
    // colors enum
    enum Colors
    {
        none,
        red,
        green,
        yellow,
        blue,
        pink,
        cyan
    }
}