using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// Initial comit  
/// aaaaaa
/// </summary>

namespace ArrayUsage
{
    public partial class Form1 : Form
    {
        // Create an array.
        String[] TestArray;

        public Form1()
        {
            InitializeComponent();

            // Initialize the array.
            TestArray = new String[] {"One", "Two", "Three", "Four", "Five"};
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // End the application.
            Close();
        }

        private void btnLINQ_Click(object sender, EventArgs e)
        {
            // Create the query.
            var Output = from String TheEntry
                         in TestArray
                         select TheEntry.Substring(0, 3);

            // Display one of the results.
            MessageBox.Show(Output.ToArray<String>()[2]);
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            // Create a variable to hold the result.
            String Output = "";

            // Perform the array processing.
            for (Int32 Counter = 0; Counter < TestArray.Length; Counter++)
            {
                Output = Output + TestArray[Counter] + "\r\n";
            }

            // Display the result on screen.
            MessageBox.Show(Output);
        }

        private void btnConditional_Click(object sender, EventArgs e)
        {
            // Create a variable to hold the result.
            String Output = "";

            // Perform the array processing.
            for (Int32 Counter = 0; Counter < TestArray.Length; Counter++)
            {
                // Place a condition on the task. Perform the task only for the
                // third array element.
                if (Counter == 2)
                {
                    Output = Output + TestArray[Counter].Substring(0, 3) + "\r\n";
                }
            }

            // Display the result on screen.
            MessageBox.Show(Output);
        }
    }
}
