using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayUsage
{
    public partial class Form2 : Form
    {
        // Declare TestArray as a string array of any size
        string[] TestArray;

        public Form2()
        {
            InitializeComponent();

            // Create the array - the declaration above does not actually create the array
            // N.B. The number of items in an array has to be defined and is fixed
            // Below creates an array of up to 100 elements.
            TestArray = new string[100];
            //Below creates an array of up to 5 elements
            //TestArray = new string[] { "", "", "", "", "" };


            //string strConnection = "Data Source=SQL-ead.dev.london.edu;Initial Catalog=TempWork;User ID=rfrancis;Password=(ex1to1)";
            string strConnection = "Data Source=PC-Ron\\SQLSERVERRON;Initial Catalog=TempWork;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(strConnection))
                {
                    conn.Open();

                    string sqlSelectString = "Select Ron1UID, Ron1Text, Ron1ThisOrThat, Ron1ThisOrThat, " +
                                     "Ron1YesNo, Ron1Comments, Ron2FID, Ron2Text " +
                                     "from Ron1Table " +
                                     "inner join Ron2Table on Ron2FID = Ron2UID ";

                    SqlCommand cmd = new SqlCommand(sqlSelectString, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    Int32 counter = 0;


                    while (reader.Read())

                    {
                        //If field Ron1Text contains nulls then GetString(0) will fail with a system error
                        if (reader[1] != null && reader[1] != DBNull.Value)
                        {
                            //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.


                            TestArray[counter] = reader.GetString(1).ToString();
                            counter++;
                        }
                    }

                    reader.Close();
                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnForm2LINQ_Click(object sender, EventArgs e)
        {
            // Create the query.
            var Output = from String TheEntry
                         in TestArray
                         select TheEntry.Substring(0, 3);

            // Display one of the results.
            MessageBox.Show(Output.ToArray<String>()[2]);
        }

        private void btnForm2Loop_Click(object sender, EventArgs e)
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

        private void btnForm2Conditional_Click(object sender, EventArgs e)
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

        private void btnForm2Quit_Click(object sender, EventArgs e)
        {
            // End the application.
            Close();
        }
    }
}
