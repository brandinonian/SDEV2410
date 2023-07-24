using System;
namespace M4Competency
{
	public class Customer
	{
		private int id;
		private string firstName;
		private string lastName;

		public Customer( int id, string firstName, string lastName )
		{
			this.id = id;
			this.firstName = firstName;
			this.lastName = lastName;
		}

		public Customer()
		{
			id = 0;
			firstName = "";
			lastName = "";
		}

		public int GetId() => id;
		public string GetFirstName() => firstName;
		public string GetLastName() => lastName;

		public void SetId(int num) => id = num;
		public void SetFirstName(string name) => firstName = name;
		public void SetLastName(string name) => lastName = name;

        public override string ToString() => id + " " + firstName + " " + lastName;
	}
}
