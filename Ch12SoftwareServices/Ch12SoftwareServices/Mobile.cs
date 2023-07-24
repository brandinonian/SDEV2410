using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12SoftwareServices
{
    internal class Mobile : Service
    {
        private string deviceType;

        public Mobile(int id, int custid, string projectName, string jobType, string status, string deviceType)
            : base(id, custid, projectName, jobType, status)
        {
            this.deviceType = deviceType;
        }

        public override string ToString()
        {
            //
            // deviceType abbreviations
            //
            string deviceString;
            if (deviceType == "i") // i for iOS
            {
                deviceString = "iOS";
            }
            else if (deviceType == "a") // a for Android
            {
                deviceString = "Android";
            }
            else // defaults to other, should not be used intentionally
            {
                deviceString = "Other";
            }
            return $"\nMobile: {base.ToString()}\n" +
                $"{deviceString}, status: {base.GetStatusLong()}";
        }
    }
}
