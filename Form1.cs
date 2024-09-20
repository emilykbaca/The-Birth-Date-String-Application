using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Birth_Date_String_Application
{
    public partial class birthDateString : Form
    {
        public birthDateString()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            // declare a string variable
            string output;
            
            // concatenate the input and build the output string
            output = dayOfWeekTextBox.Text + ", " + 
                     nameOfMonthTextBox.Text + " " + 
                     dayOfMonthTextBox.Text + ", " + 
                     yearTextBox.Text;

            // display the output string in the Label control
            outputLabel.Text = output;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear the textboxes
            dayOfWeekTextBox.Text = "";
            nameOfMonthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";

            // clear the outputLabel
            outputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
