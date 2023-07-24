using Ch12SoftwareServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ch 12 Console Project: Software Services by Brandon Phillips");

        // array of service jobs
        int size = 6;
        Service[] jobs = new Service[size];

        // hardcoded jobs
        //
        // status abbreviations: ip = in progress, ns = not started, c = complete
        // desktop abbreviations: w = windows, l = linux, m = mac, g = gui, c = cli
        // mobile abbreviations: a = android, i = iOS
        //
        // Web(int id, int custid, string projectName, string jobType, string status, string url, int numPages)
        //
        jobs[0] = new Web(4567, 8012, "company site", "new", "ns", "fixPC.com", 7);
        jobs[1] = new Web(1122, 4431, "Inventory pages", "maintenance", "ip", "pcsupport.com/inv", 2);

        //
        // Mobile(int id, int custid, string projectName, string jobType, string status, string deviceType)
        //
        jobs[2] = new Mobile(8709, 5168, "company app", "maintenance", "ns", "a");
        jobs[3] = new Mobile(8091, 7510, "ordering page", "new", "ip", "i");

        //
        // Desktop(int id, int custid, string projectName, string jobType, string status, string platform, string uiType)
        //
        jobs[4] = new Desktop(8090, 6167, "purchase orders", "maintenance", "ip", "w", "g");
        jobs[5] = new Desktop(3456, 3018, "comission pay", "new", "c", "l", "c");

        // display each job --thanks Brent
        foreach (Service job in jobs)
        {
            Console.WriteLine(job);
        }

        Console.WriteLine("\n----- Find specific jobs -----");
        Console.WriteLine("\nStatus types: ip (in progress), ns (not started), c (complete)");

        // user input
        Console.Write("Which do you want to see? (ip, ns, c): ");
        string input = Console.ReadLine();

        // foreach loop to find jobs matching user input
        foreach (Service job in jobs)
        {
            if (job.GetStatus() == input)
            {
                // display matches
                Console.WriteLine(job);
            }
        }

        // exit program
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}