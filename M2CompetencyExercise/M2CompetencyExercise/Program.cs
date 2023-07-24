using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace M2CompetencyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Module 2 Competency Exercise: Average Scores by Brandon Phillips\n");

            double reply = 0;
            double scoresTotal = 0;
            double scoresNum = 0;
            WriteLine("Enter any number of scores (-1 to quit)");
            do
            {
                try
                {
                    Write("Enter a score from 0 to 100: ");
                    reply = double.Parse(ReadLine());
                    if (reply != -1)
                    {
                        if (reply < 0)
                        {
                            throw new Exception("Value too small");
                        }
                        else if (reply > 100)
                        {
                            throw new Exception("Value too large");
                        }
                        else
                        {
                            scoresTotal += reply;
                            scoresNum++;
                        }
                    }
                }
                catch (FormatException e)
                {
                    WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    WriteLine(e.Message);
                }
            } while (reply != -1);
            if (scoresNum != 0)
            {
                WriteLine($"The average for {scoresNum} scores is {scoresTotal / scoresNum}");
            }
            // exit program
            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
    }
}
