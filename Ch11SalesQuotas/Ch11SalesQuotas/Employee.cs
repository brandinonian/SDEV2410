using System;
namespace Ch11SalesQuotas
{
	public struct Employee
	{
		private string fname;
		private string lname;
		private double quota;

        public Employee(string fname, string lname, double quota)
		{
			this.fname = fname;
			this.lname = lname;
			this.quota = quota;
		}

        public double GetQuota() => quota;

		public string GetName() => fname;

		public string GetFullName() => fname + " " + lname;
	}
}

