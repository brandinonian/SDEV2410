using Ch11CompanyPotluck;
using System.Collections;

namespace Ch11CompanyPotluck
{
    internal static class ProgramHelpers
    {
        // helper method to find specific attendee
        public static Attendee FindAttendee(ArrayList attendees, string fname, string lname)
        {
            Attendee? person = null;
            foreach (Attendee attendee in attendees)
            {
                // check if the first name matches
                if (attendee.GetFirstName() == fname)
                {
                    //check if the last name matches
                    if (attendee.GetLastName() == lname)
                    {
                        person = attendee;
                    }
                }
            }
            return person;
        }

        // helper methods for name and item input, will not allow blank entries
        public static string InputFirstName()
        {
            string firstName;
            do
            {
                Console.Write("First name: ");
                firstName = Console.ReadLine();
            } while (firstName == "");
            return firstName;
        }

        public static string InputItem()
        {
            string item;
            do
            {
                Console.Write("Item: ");
                item = Console.ReadLine();
            } while (item == "");
            return item;
        }

        public static string InputLastName()
        {
            string lastName;
            do
            {
                Console.Write("Last name: ");
                lastName = Console.ReadLine();
            } while (lastName == "");
            return lastName;
        }
    } 
}