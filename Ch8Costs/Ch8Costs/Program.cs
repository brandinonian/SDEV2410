﻿using Ch8Costs;  internal class Program {     private static void Main(string[] args)     {         Console.WriteLine("Ch 8 Console Project: Costs by Brandon Phillips\n");          // create objects         Hardware firstHardware = new Hardware(1234, "optical mouse", 49.95);         Hardware secondHardware = new Hardware(9876, "wireless keyboard", 59.95);         Repair firstRepair = new Repair("j241", "Jones hard drive", 100);         Repair secondRepair = new Repair("m572", "Murphy blue screen", 200);          // variables         string reply = "";         object tempObj = "";          // display objects         Console.WriteLine($"{firstHardware.Display()}");         Console.WriteLine($"{secondHardware.Display()}");         Console.WriteLine($"{firstRepair.Display()}");         Console.WriteLine($"{secondRepair.Display()}");          // update objects         do         {             Console.Write("\nWhich one is being processed? ");             string userInput = Console.ReadLine();             Console.WriteLine(userInput);              // test user input             if (userInput == "1234")             {                 tempObj = firstHardware;             }             else if (userInput == "9876")             {                 tempObj = secondHardware;             }             else if (userInput == "j241")             {                 tempObj = firstRepair;             }             else if (userInput == "m572")             {                 tempObj = secondRepair;             }             // test tempObj type             if (tempObj is Hardware)             {                 double subtotal = 0;                 Hardware newHardware = (Hardware)tempObj;                 double addCost = newHardware.Calculate(ref subtotal);                 double grandTotal = subtotal + addCost;                 Console.WriteLine($"Subtotal: {subtotal:C}");                 Console.WriteLine($"Taxes: {addCost:C}");                 Console.WriteLine($"Total: {grandTotal:C}");             }             else if (tempObj is Repair)             {                 double subtotal = 0;                 Repair newRepair = (Repair)tempObj;                 double addCost = newRepair.Calculate(ref subtotal);                 double grandTotal = subtotal + addCost;                 Console.WriteLine($"Subtotal: {subtotal:C}");                 Console.WriteLine($"Taxes and fees: {addCost:C}");                 Console.WriteLine($"Total: {grandTotal:C}");             }             do             {                 Console.Write("\nProcess another? (y/n) ");                 reply = Console.ReadLine();             } while (reply != "y" && reply != "n");         } while (reply == "y");          //exit program         Console.WriteLine("\nPress any key to exit...");         Console.ReadKey();     } }