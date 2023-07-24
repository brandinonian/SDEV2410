using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch2SnackStand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void snackLabel_Click(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int snackNumber = int.Parse(snackTextBox.Text);
            int drinkNumber = int.Parse(drinkTextBox.Text);
            double totalCost = (snackNumber * 2.25) + drinkNumber;
            totalLabel.Text = ($"Total Cost: {totalCost:C}");
        }
    }
}
