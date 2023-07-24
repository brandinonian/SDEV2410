using System;
namespace Ch11CleanUserResponses
{
	public struct Customer
	{
		private int id;
		private string firstName;
		private string lastName;

		public Customer(int id, string firstName, string lastName)
		{
			this.id = id;
			this.firstName = firstName;
			this.lastName = lastName;
		}

		public string Display() => id + " " + firstName  + " " + lastName;
	}
}

