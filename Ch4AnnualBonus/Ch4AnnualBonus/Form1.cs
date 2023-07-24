using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4AnnualBonus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int serviceYears = int.Parse(numYearsTextBox.Text);
            int yearlySales = int.Parse(yearlySalesTextBox.Text);

            if (serviceYears > 10 || yearlySales > 250000)
            {
                calcLabel.Text = "5%";
            }
            else if (serviceYears > 5 || yearlySales > 125000)
            {
                calcLabel.Text = "2.5%";
            }
            else
            {
                calcLabel.Text = "$100";
            }
        }
    }
}
