using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DictionaryUsage
{
    public partial class Form1 : Form
    {

        // Create a global storage location.
        // The <String, String> part part of the variable declaration defines the datatypes used by the 
        // key and value.
        Dictionary<String, String> Herbs;

        public Form1()
        {
            InitializeComponent();

            // First we need to define the dictionary (i.e. Instntiate it) before it can be used
            // The following code defines Herbs as a new Dictionary that has a String datatype as 
            // a key and a string datatype as a value
            Herbs = new Dictionary<string, string>();

            // Add entries to the dictionary using the Dictionary Add() method.
            Herbs.Add("Basil", 
                "A somewhat minty herb used mainly with meat dishes.");
            Herbs.Add("Caraway", 
                "A licorice tasting herb commonly used in German cooking.");
            Herbs.Add("Chives",
                "An onion-tasting herb used in soups and salads.");
            Herbs.Add("Bay",
                "A minty tasting herb used in leaf form in soups and sauces.");
            Herbs.Add("Garlic",
                "A pungeant herb that comes in many varieties from mild to spicy.");
            Herbs.Add("Anise",
                "An herb with a strong licorice taste and smell.");
            Herbs.Add("Mint",
                "An invasive leafy herb that comes in a vast array of flavors.");
            Herbs.Add("Savory",
                "A piney/peppery herb used mainly to season meat dishes.");

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
