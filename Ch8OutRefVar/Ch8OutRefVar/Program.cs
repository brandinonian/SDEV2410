internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 8 Console Project: Out and Ref Variables by Brandon Phillips\n");

        double thisTemp = 88;
        double outTemp;
        Console.WriteLine($"Original value of thisTemp: {thisTemp}");
        Console.WriteLine("Original value of outTemp is unassigned");
        //valTemps
        Console.WriteLine($"\nCalling valTemps with value variable, thisTemp = {thisTemp}");
        valTemps(thisTemp);
        Console.WriteLine($"Leaving valTemps, value variable thisTemp = {thisTemp}");
        // refTemps
        Console.WriteLine($"\nCalling refTemps with value variable, thisTemp = {thisTemp}");
        refTemps(ref thisTemp);
        Console.WriteLine($"Leaving refTemps, value variable thisTemp = {thisTemp}");
        // outTemps
        Console.WriteLine("\nCalling outTemps with unassigned variable");
        outTemps(out outTemp);
        Console.WriteLine($"Leaving valTemps, value variable outTemp = {outTemp}");

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();


        // functions
        static void valTemps(double tempConvert)
        {
            Console.WriteLine($"entering valTemps, value variable = {tempConvert}");
            tempConvert = (tempConvert - 32) * 5.0 / 9.0;
            Console.WriteLine($"leaving valTemps, value variable = {tempConvert}");
        }
        // using ref
        static void refTemps(ref double tempConvert)
        {
            Console.WriteLine($"entering refTemps, value variable = {tempConvert}");
            tempConvert = (tempConvert - 32) * 5.0 / 9.0;
            Console.WriteLine($"leaving refTemps, value variable = {tempConvert}");
        }
        // using out
        static void outTemps(out double tempConvert)
        {
            Console.WriteLine("entering outTemps, variable unassigned");
            tempConvert = 88;
            tempConvert = (tempConvert - 32) * 5.0 / 9.0;
            Console.WriteLine($"leaving outTemps, value variable = {tempConvert}");
        }
    }
}