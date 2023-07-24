using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12SoftwareServices
{
    internal class Service
    {
        private int id;
        private int custid;
        private string projectName;
        private string jobType;
        private string status;

        public Service(int id, int custid, string projectName, string jobType, string status)
        {
            this.id = id;
            this.custid = custid;
            this.projectName = projectName;
            this.jobType = jobType;
            this.status = status;
        }

        public override string ToString()
        {
            
            return $"{jobType} {id} {projectName} for cust #{custid},";
        }

        public int GetID() => id;

        public string GetName() => projectName;

        public string GetStatus() => status;

        public string GetStatusLong()
        {
            //
            // status abbreviations:
            //
            if (status == "ns") // ns for not started
            {
                return "not started";
            }
            else if (status == "ip") // ip for in progress
            {
                return "in progress";
            }
            else if (status == "c") // c for complete
            {
                return "complete";
            }
            else
            {
                return status;
            }
        }
    }
}
