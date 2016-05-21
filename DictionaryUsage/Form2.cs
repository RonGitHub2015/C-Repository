using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DictionaryUsage
{
    public partial class Form2 : Form
    {
        /// <summary>
        /// Initial comit
        /// </summary>
        // Create a global storage location.
        // The <String, String> part part of the variable declaration defines the datatypes used by the 
        // key and value.
        //Dictionary<String, String> Herbs;
        Dictionary<Int32, String> Herbs;

        public Form2()
        {
            InitializeComponent();

            // First we need to define the dictionary (i.e. Instntiate it) before it can be used
            // The following code defines Herbs as a new Dictionary that has a String datatype as 
            // a key and a string datatype as a value
            //Herbs = new Dictionary<string, string>();
            Herbs = new Dictionary<Int32, string>();

            //---------------------------------------------------------------------------------------//

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

                    while (reader.Read())

                    {
                        //If field Ron1Text contains nulls then GetString(0) will fail with a system error
                        if (reader[1] != null && reader[1] != DBNull.Value)
                        {
                            //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.

                            // Add entries to the dictionary using the Dictionary Add() method.
                            Herbs.Add(reader.GetInt32(0),
                                reader.GetString(1).ToString());

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


            //--------------------------------------------------------------------------------------//


            // Show the keys in lstHerbs.
            // Herbs.Keys is the Keys property of Dictionary Herbs.
            // It returns all the key values.
            // ToArray<String> Turns these values into an array of strings.
            // lstHerbs.Items is the Items property of lstHerbs.
            // It is a collection in which lstHerbs stores the array of key value strings returned by Herbs.Keys.ToArray<String>().
            // AddRange() method is how the key value strings are transferred to lstHerbs. 


            lstHerbs.Items.AddRange(Herbs.Keys.ToArray<String>());
        }

        private void lstHerbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the current selection in the description.
            // First lstHerbs.SelectedItem property supplies the ListItem object for the currently selected list item.
            // The code then calls ToString().
            // This returns a textual representation of whatever the ListItem object contains.
            // This textual representation (in this case a string) gets passed to the Herbs dictionary  
            // which in turn returns the value associated with the key 
            // (the name of the herb is the key, the herb description is the associated 'value').
            // The herb description is then assigned to the Text property of the text box.
            txtDescription.Text = Herbs[lstHerbs.SelectedItem.ToString()];
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // End the program.
            Close();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Tell the ListBox to display the information
            // in sorted order.
            lstHerbs.Sorted = true;
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            // Obtain a list of keys that begin with C.
            var Count = from String TheEntry
                        in Herbs.Keys.ToArray<String>()
                        where TheEntry.Substring(0,1) == "C"
                        select TheEntry;

            // Count the number of entries and display a message box
            // showing the count.
            MessageBox.Show("The number of entries that begin with C: " +
                Count.Count<String>().ToString());
        }
    }
}
