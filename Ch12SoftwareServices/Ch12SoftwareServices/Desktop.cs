using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12SoftwareServices
{
    internal class Desktop : Service
    {
        private string platform;
        private string uiType;

        public Desktop(int id, int custid, string projectName, string jobType, string status, string platform, string uiType)
            : base(id, custid, projectName, jobType, status)
        {
            this.platform = platform;
            this.uiType = uiType;
        }

        public override string ToString()
        {
            //
            // platform abbreviations:
            //
            string platformString;
            if (platform == "w") // w for Windows
            {
                platformString = "Windows OS";
            }
            else if (platform == "l") // l for Linux
            {
                platformString = "Linux";
            }
            else if (platform == "m") // m for Mac
            {
                platformString = "Mac/OSX";
            }
            else // defaults to other, should not be used intentionally
            {
                platformString = "Other platform";
            }
            //
            // uiType abbreviations:
            //
            string uiString;
            if (uiType == "c") // c for command line
            {
                uiString = "Command Line Interface";
            }
            else if (uiType == "g") // g for GUI
            {
                uiString = "Graphical Interface";
            }
            else // defaults to other, should not be used intentionally
            {
                uiString = "Other Interface";
            }
            return $"\nDesktop: {base.ToString()}\n" +
                $"{platformString} with {uiString}, status: {base.GetStatusLong()}";
        }
    }
}
