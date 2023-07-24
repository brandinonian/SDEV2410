internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 10 Console Project: Dice Rolls Array by Brandon Phillips\n");

        // array to track rolls
        int[] rolls = new int[13];

        int rollCount = 0;
        Random rng = new Random();

        // roll dice loop
        for (int i = 0; i < 100;  i++)
        {
            // generate random rolls
            int d1, d2, total;
            d1 = rng.Next(1,7);
            d2 = rng.Next(1,7);
            total = d1 + d2;

            // update count in rolls array
            for (int rollTotal = 0; rollTotal < rolls.Length; rollTotal++)
            {
                try
                {
                    if (rollTotal == total)
                    {
                        rolls[rollTotal]++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }

            //track the number of rolls
            rollCount++;
        }
        
        // display results
        for (int i = 2; i < rolls.Length; i++)
        {
            try
            {
                Console.WriteLine($"Number of rolls = {i}: {rolls[i]}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} Index = {i}");
            }
        }

        // display total number of rolls (hardcoded at ln 13)
        Console.WriteLine($"\nTotal number of rolls: {rollCount}");

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}