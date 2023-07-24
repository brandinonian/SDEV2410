using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12SoftwareServices
{
    internal class Web : Service
    {
        private string url;
        private int numPages;

        public Web(int id, int custid, string projectName, string jobType, string status, string url, int numPages)
            : base(id, custid, projectName, jobType, status)
        {
            this.url = url;
            this.numPages = numPages;
        }

        public override string ToString()
        {
            return $"\nWeb: {base.ToString()}\n" +
                $"URL: {url}, {numPages} pages, status: {base.GetStatusLong()}";
        }
    }
}
