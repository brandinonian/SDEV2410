using System.Collections;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Ch11CompanyPotluck
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Ch. 11 Console Project: Company Potluck by Brandon Phillips");

            // create array list of attendess
            ArrayList attendees = new ArrayList();

            // loop options with user input
            string reply = "";
            do
            {
                Console.Write("\nWhat do you want to do, (a)Add entry, (p)Print list, (r)Remove entry, (c)Change entry, or (x)Exit? ");
                reply = Console.ReadLine();
                switch (reply)
                {
                    case "a":
                        // add entry
                        {
                            Console.WriteLine("Add new name and item for the potluck");

                            // input first name
                            string firstName = ProgramHelpers.InputFirstName();

                            // input last name
                            string lastName = ProgramHelpers.InputLastName();

                            // input item
                            string item = ProgramHelpers.InputItem();

                            // add entry to attendees list
                            attendees.Add(new Attendee(firstName, lastName, item));
                        }
                        break;
                    case "p":
                        // print list
                        {
                            Console.WriteLine($"List of {attendees.Count} attendees");
                            foreach (Attendee attendee in attendees)
                            {
                                Console.WriteLine(attendee.ToString());
                            }
                        }
                        break;
                    case "r":
                        // remove entry
                        {
                            Console.WriteLine("Remove entry");

                            // input first name
                            string firstName = ProgramHelpers.InputFirstName();

                            // input last name
                            string lastName = ProgramHelpers.InputLastName();

                            // search attendees, return the result or null
                            Attendee? result = ProgramHelpers.FindAttendee(attendees, firstName, lastName);

                            // if result is not null delete it from the list
                            if (result != null)
                            {
                                attendees.Remove(result);
                                Console.WriteLine("Entry removed...");
                            }
                            else { Console.WriteLine("No attendees found..."); }

                        }
                        break;
                    case "c":
                        // change entry
                        {
                            Console.WriteLine("Change with entry?");

                            // input first name
                            string firstName = ProgramHelpers.InputFirstName();

                            // input last name
                            string lastName = ProgramHelpers.InputLastName();

                            // search attendees, return the result or null
                            Attendee? result = ProgramHelpers.FindAttendee(attendees, firstName, lastName);

                            // input new item, error message if null
                            if (result != null)
                            {
                                string newItem = ProgramHelpers.InputItem();
                                result.SetItem(newItem);
                                Console.WriteLine("Item updated");
                            }
                            else { Console.WriteLine("Could not find attendee"); }
                        }
                        break;
                    case "x":
                        // exit
                        break;
                    default:
                        Console.WriteLine("Invalid entry...");
                        break;
                }
            } while (reply != "x");

            // exit program
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}