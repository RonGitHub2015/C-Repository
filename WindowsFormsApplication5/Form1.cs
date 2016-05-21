using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {

        //static string strConnection = "Data Source=PC-Ron\\SQLSERVERRON;Initial Catalog=TempWork;Integrated Security=True";
        //static string strConnection = "Data Source=SQL-Test3.london.edu;Initial Catalog=TempWork;User ID=rfrancis;Password=rfrancis123";
        static string strConnection = "Data Source=sql-ead.dev.london.edu;Initial Catalog=TempWork;User ID=rfrancis;Password=(ex1to1)";
        
        static string struspTable1AddRecord = "usp_Ron1TableInsert";
        static string struspTable1UpdateRecord = "usp_Ron1TableUpdate";
        static string struspTable1Table2Read = "usp_Ron1Ron2TableRead";

        //static Int32 int1UID;
        Int32 int1UID;
        string str1TextFilter;
        //static Int32 int2FID;
        Int32 int2FID;
        //static string strYesNo;
        string strYesNo;
        //static Int32 intYesNo;
        Int32 intYesNo;
        //static string strThisOrThat;
        string strThisOrThat;
        string strCommentsFilter;
        //static Boolean blnLoadCombo;
        Boolean blnLoadCombo;
        //string str1UID;
        //string str2FID;
        //string stringRon1Text;
        string strSQLAddOrUpdate;
        Boolean blnUpdate;

        Boolean blnYesNo;
        //string strRon1ThisOrThat;
        //string stringRon1Comments;

        SqlConnection con = new SqlConnection(strConnection);
        SqlCommand com;
       
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

        initFormControls();

    }

        private void LoadGrid()
        {

            dataGridViewRon1Table.Rows.Clear();
            
            //Connect to the SQL database and get the data to populate the datagridview


            SqlConnection con = new SqlConnection(strConnection);

            try 
	        {	        
               
                //-------------------------------------------------------------------

                using (con)
                {

                    con.Open();
                    //using (var cmd = new SqlCommand("usp_Ron1Ron2TableRead", con))
                    using (var cmd = new SqlCommand(struspTable1Table2Read, con))                  
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.Add("@UID", SqlDbType.Int);
                        if (int1UID != 0)
                        {
                            cmd.Parameters["@UID"].Value = int1UID;                            
                        }
                        else
	                    {
                             cmd.Parameters["@UID"].Value = null;
	                    }

                        cmd.Parameters.Add("@Text", SqlDbType.VarChar);
                        if (str1TextFilter != null && str1TextFilter != "")
                        {
                            cmd.Parameters["@Text"].Value = str1TextFilter;
                        }
                        else
                        {
                            cmd.Parameters["@Text"].Value = null;
                        }

                        cmd.Parameters.Add("@FID", SqlDbType.Int);
                        if (int2FID != 0)
                        {
                            cmd.Parameters["@FID"].Value = int2FID;
                        }
                        else
                        {
                            cmd.Parameters["@FID"].Value = null;
                        }


                        cmd.Parameters.Add("@ThisOrThat", SqlDbType.VarChar);
                        if (strThisOrThat != null && strThisOrThat != "")
                        {
                            cmd.Parameters["@ThisOrThat"].Value = strThisOrThat;
                        }
                        else
                        {
                            cmd.Parameters["@ThisOrThat"].Value = null;
                        }

                        cmd.Parameters.Add("@YesNo", SqlDbType.Bit);
                        if (strYesNo != null && strYesNo != "")
                        {
                            cmd.Parameters["@YesNo"].Value = intYesNo;
                        }
                        else
                        {
                            cmd.Parameters["@YesNo"].Value = null;
                        }


                        cmd.Parameters.Add("@Comments", SqlDbType.VarChar);
                        if (strCommentsFilter != null && strCommentsFilter != "")
                        {
                            cmd.Parameters["@Comments"].Value = strCommentsFilter;
                        }
                        else
                        {
                            cmd.Parameters["@Comments"].Value = null;
                        }

                        //// Use AddWithValue to assign order by parameter.
                        //cmd.Parameters.AddWithValue("@orderby", "Ron1YesNoRon1ThisOrThat");


                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {


                            //SqlDataReader reader = com.ExecuteReader();

                            ////The following method loads the datagridview with all the data returned by the SQL statement
                            ////N.B. This method displays more columns in the datagrid than should be
                            ////N.B. Comment out the following block of code if the alternative method below of populating the grid is to be used
                            //if (reader.HasRows)
                            //{
                            //    DataTable dt = new DataTable();
                            //    dt.Load(reader);
                            //    dataGridViewRon1Table.DataSource = dt;

                            //};


                            //The following method loads the datagridview with selected columns from all the data returned by the SQL statement
                            //Use this method to restrict the number of columns displayed in the datagrid
                            //N.B. Comment out the following block of code if the alternative method above of populating the grid is to be used
                            int rowNumber = 0;
                            while (reader.Read())
                            {
                                dataGridViewRon1Table.Rows.Add();
                                //dataGridViewBeers.Rows[rowNumber].Cells[0].Value = reader[0].ToString();
                                dataGridViewRon1Table.Rows[rowNumber].Cells["Ron1UID"].Value = reader[0].ToString();
                                dataGridViewRon1Table.Rows[rowNumber].Cells["Ron2FID"].Value = reader[1].ToString();
                                dataGridViewRon1Table.Rows[rowNumber].Cells["Ron2Text"].Value = reader[7].ToString();
                                dataGridViewRon1Table.Rows[rowNumber].Cells["Ron1Text"].Value = reader[2].ToString();
                                dataGridViewRon1Table.Rows[rowNumber].Cells["Ron1ThisOrThat"].Value = reader[3].ToString();



                                blnYesNo = reader.GetBoolean(4);
                                dataGridViewRon1Table.Rows[rowNumber].Cells["Ron1YesNo"].Value = blnYesNo;

                                if (reader.GetBoolean(4) == false) 

                                {
                                    dataGridViewRon1Table.Rows[rowNumber].Cells["gridYesNo"].Value = "No";
                                    //dataGridViewRon1Table.Rows[rowNumber].Cells["Ron1YesNo"].Value = "No";
                                }
                                else
                                {
                                    dataGridViewRon1Table.Rows[rowNumber].Cells["gridYesNo"].Value = "Yes";                                    
                                    //dataGridViewRon1Table.Rows[rowNumber].Cells["Ron1YesNo"].Value = "Yes";
                                }
                                
                                

                                dataGridViewRon1Table.Rows[rowNumber].Cells["Ron1Comments"].Value = reader[5].ToString();


                                rowNumber = rowNumber + 1;
                            }
                        }

                        reader.Close();
                    }
                    con.Close();

                }
                //-------------------------------------------------------------------

	        }

	       catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //---------------------------------------------------------------------------------------------//
        private void loadComboRon2Text()
        {
            //Connect to the SQL database and get the data to populate the dropdown
            SqlConnection con = new SqlConnection(strConnection);


            //Method 1 - Not using SQL parameter
            try
            {
                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "select Ron2UID, Ron2Text from Ron2Table order by Ron2Text";
                con.Open();
                SqlDataReader reader = com.ExecuteReader();


                //The following method first of all loads the data returned by the SQL into a table.
                //Then it adds a header row to the table.
                //Then it binds the table to the combobox.

                blnLoadCombo = true;

                DataTable dt = new DataTable("Ron2Data");

                //Add DataTable column dynamically/run time/on the fly.
                dt.Columns.Add(new DataColumn("Ron2UID", typeof(System.Int32)));
                dt.Columns.Add(new DataColumn("Ron2Text", typeof(System.String)));

                //Add DataTable rows dynamically/run time/on the fly
                while (reader.Read())
                {
                    dt.Rows.Add(Convert.ToInt32(reader[0].ToString()), reader[1].ToString());
                };

                reader.Close();
                con.Close();

                DataTable dt1;
                dt1 = dt.Copy();


                // Use insertAt method to force to enter data
                DataRow oRow = dt.NewRow();
                oRow["Ron2Text"] = "--Select All--";
                dt.Rows.InsertAt(oRow, 0);

                //blnLoadCombo = true;

                comboRon2TextFilter.DataSource = dt;
                comboRon2TextFilter.DisplayMember = "Ron2Text";
                comboRon2TextFilter.ValueMember = "Ron2UID";
                
               
                comboRon2Fid.DataSource = dt1;
                comboRon2Fid.DisplayMember = "Ron2Text";
                comboRon2Fid.ValueMember = "Ron2UID";

                comboRon2Fid.Text = null;


                blnLoadCombo = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //---------------------------------------------------------------------------------------------//

        //---------------------------------------------------------------------------------------------//
        private void loadComboRon1TextFilter()
        {
            //Connect to the SQL database and get the data to populate the dropdown
            SqlConnection con = new SqlConnection(strConnection);

            //Method 1 - Not using SQL parameter
            try
            {
                com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "select distinct Ron1Text from Ron1Table order by Ron1Text";
                con.Open();
                SqlDataReader reader = com.ExecuteReader();


                //The following method first of all loads the data returned by the SQL into a table.
                //Then it adds a header row to the table.
                //Then it binds the table to the combobox.

                blnLoadCombo = true;

                //DataTable dt = new DataTable("Ron1Data");
                DataTable dt = new DataTable("");


                //Add DataTable column dynamically/run time/on the fly.
                dt.Columns.Add(new DataColumn("Ron1Text", typeof(System.String)));

                //Add DataTable rows dynamically/run time/on the fly
                while (reader.Read())
                {
                    dt.Rows.Add(reader[0].ToString());
                };

                reader.Close();
                con.Close();

               // Use insertAt method to force to enter data
                DataRow oRow = dt.NewRow();
                oRow["Ron1Text"] = "--Select All--";
                dt.Rows.InsertAt(oRow, 0);

                //blnLoadCombo = true;

                comboRon1TextFilter.DataSource = dt;
                comboRon1TextFilter.DisplayMember = "Ron1Text";
                //comboRon1TextFilter.ValueMember = "Ron1UID";

                blnLoadCombo = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        //---------------------------------------------------------------------------------------------//



        private void comboRon2TextFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!blnLoadCombo)
            {

                int2FID = 0;

                if (comboRon2TextFilter.SelectedValue != null && comboRon2TextFilter.SelectedIndex != 0) //Ron2Text
                {
                    int2FID = Convert.ToInt32(comboRon2TextFilter.SelectedValue.ToString());
                }

            }

        }

//---------------------------------------------------------------------------------------------------------------//

        private void comboRon1TextFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!blnLoadCombo)
            {

                str1TextFilter = null;

                if (comboRon1TextFilter.SelectedItem != null && comboRon1TextFilter.SelectedIndex != 0) //
                {

                    str1TextFilter = comboRon1TextFilter.Text;
                }

            }

        }

//---------------------------------------------------------------------------------------------------------------//

        private void comboYesNoFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            strYesNo = null;

            if (comboYesNoFilter.SelectedItem != null)
            {

                strYesNo = comboYesNoFilter.SelectedItem.ToString();

                switch (comboYesNoFilter.SelectedItem.ToString())
                {
                    case "No":
                        intYesNo = 0;
                        break;
                    case "Yes":
                        intYesNo = 1;
                        break;
                    default:
                        break;
                }

            }

        }

//---------------------------------------------------------------------------------------------------------------//

        private void comboThisOrThatFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            strThisOrThat = null;

            if (comboThisOrThatFilter.SelectedItem != null && comboThisOrThatFilter.SelectedIndex != 0)
            {
                strThisOrThat = comboThisOrThatFilter.SelectedItem.ToString();
            }

        }

      

//--------------------------------------------------------------------------------------------------------------//
        private void initFormControls()
        {

            //Reload the Gridview
            int1UID = 0;
            int2FID = 0;
            str1TextFilter = null;
            strThisOrThat = null;
            strYesNo = null;
            strCommentsFilter = null;
            LoadGrid();

            //Initialise the filter fields
            loadComboRon2Text();
            loadComboRon1TextFilter();
            comboThisOrThatFilter.SelectedIndex = 0;
            comboYesNoFilter.SelectedIndex = 0;
            txtFilterComments.Text = null;

            //Disable the Update and Delete buttons
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            //Enable the Filter button
            this.btnFilter.Enabled = true;
            
            //Blank out the input fields used by the Add,Update and Delete buttons
            comboRon2Fid.SelectedIndex = 0;
            comboRon2Fid.Text = null;
            comboThisOrThat.SelectedIndex = 0;
            comboYesNo.SelectedIndex = 0;
            txtRon1Text.Text = null;
            txtComments.Text = null;

        }
        //----------------------------------------------------------------------------------------//

        //----------------------------------------------------------------------------------------//
        private void btnFilter_Click(object sender, EventArgs e)
        {

            strCommentsFilter = txtFilterComments.Text;
            LoadGrid();
 
        }
        //----------------------------------------------------------------------------------------//

        //----------------------------------------------------------------------------------------//
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Blank out the input fields
            comboRon2Fid.SelectedIndex = 0;
            comboRon2Fid.Text = null;
            comboYesNo.SelectedIndex = 0;
            comboThisOrThat.SelectedIndex = 0;
            txtRon1Text.Text = null;
            txtComments.Text = null;
            txtFilterComments.Text = null;

            //Disable the Update and Delete buttons
            this.btnUpdate.Enabled = false;
            this.btnDelete.Enabled = false;

            //Enable the Filter button
            this.btnFilter.Enabled = true;


        }
        //----------------------------------------------------------------------------------------//

        //----------------------------------------------------------------------------------------//
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //if (ValidateInputs() == false)
            //    return;

            blnUpdate = false;
            strSQLAddOrUpdate = struspTable1AddRecord;
            addOrUpdateRecord();

        }
        //----------------------------------------------------------------------------------------//


        //----------------------------------------------------------------------------------------//
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            //if (ValidateInputs() == false)
            //    return;
            
            blnUpdate = true;
            strSQLAddOrUpdate = struspTable1UpdateRecord;
            addOrUpdateRecord();

        }
        //----------------------------------------------------------------------------------------//

        //----------------------------------------------------------------------------------------//
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (ValidateInputs() == false)
                return;

            //int1UID = Convert.ToInt32(row.Cells["Ron1UID"].Value);

            //------------------------------------------------------------------------------------//
            //Execute stored procedure to delete the record from the SQL database table

            try
            {

                using (con = new SqlConnection(strConnection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("usp_Ron1TableDelete", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@UID", SqlDbType.Int);
                        cmd.Parameters["@UID"].Value = int1UID;

                        cmd.ExecuteNonQuery();

                    }

                }

                con.Close();

                //------------------------------------------------------------------------------------//

            }
            catch (Exception ex)
            {
                   
                MessageBox.Show(ex.Message);
            }


            //------------------------------------------------------------------------------------//


            initFormControls();

        }
        //----------------------------------------------------------------------------------------//


        //----------------------------------------------------------------------------------------//
        private void dataGridViewRon1Table_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Enable the Amend and Delete buttons
                this.btnUpdate.Enabled = true;
                this.btnDelete.Enabled = true;

                //Disable the Filter button
                this.btnFilter.Enabled = false;

                // Get selected row values and populate form fields
                var cell = this.dataGridViewRon1Table.SelectedCells[0];
                var row = this.dataGridViewRon1Table.Rows[cell.RowIndex];

                // Get selected row cell values and populate the form input fields used when adding, updating or deleting a Ron1Table record
                int1UID = Convert.ToInt32(row.Cells["Ron1UID"].Value);

                comboRon2Fid.SelectedIndex = comboRon2Fid.FindStringExact(row.Cells["Ron2Text"].Value.ToString());

                txtRon1Text.Text = row.Cells["Ron1Text"].Value.ToString();

                comboThisOrThat.SelectedIndex = comboThisOrThat.FindStringExact(row.Cells["Ron1ThisOrThat"].Value.ToString());

                comboYesNo.SelectedIndex = comboYesNo.FindStringExact(row.Cells["GridYesNo"].Value.ToString());

                txtComments.Text = row.Cells["Ron1Comments"].Value.ToString();

            }
            catch { } // Error trap

        }
        //----------------------------------------------------------------------------------------//



        //----------------------------------------------------------------------------------------//
        private bool ValidateInputs()
        {

            if (
                
                 comboRon2Fid.Text == null || comboRon2Fid.Text == ""
                 ||
                 txtRon1Text.Text == null || txtRon1Text.Text == ""
                 ||
                 comboThisOrThat.SelectedIndex <= 0
                 ||
                 comboYesNo.SelectedIndex <= 0
                 ||
                 txtComments.Text == null || txtComments.Text == ""
                )
            {
                MessageBox.Show("All fields must be populated", "ErroR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        //----------------------------------------------------------------------------------------//




        ///<summary
        ///This method either adds a record to the database table or updates the selected record in the database table
        ///</summary>

        //----------------------------------------------------------------------------------------//
        private void addOrUpdateRecord()
        {

            try
            {

                if (ValidateInputs() == false)
                    return;

                //If the user has manually entered a text string into the Table2 Text dropdown box (comboRon2FID)
                if (comboRon2Fid.SelectedValue == null && comboRon2Fid.Text != null)
                {
                    //First of all check if the text already exists in the dropdown list
                    int intIndex = comboRon2Fid.FindStringExact(comboRon2Fid.Text);
                    if (intIndex >= 0)
                    {
                        MessageBox.Show("intIndex = " + intIndex);
                        int2FID = intIndex;
                    }

                    else //The text string is not in the dropdown list so add a record to Table 2
                    {
                        int2FID = addTable2Record(comboRon2Fid.Text);
                    }


                }

                else // the user has selected an item from the list in the Table2 Text dropdown box (comboRon2FID)
                {
                    int2FID = Convert.ToInt32(comboRon2Fid.SelectedValue.ToString());
                }



                switch (comboYesNo.SelectedItem.ToString().ToUpper())
                {
                    case "NO":
                        intYesNo = 0;
                        break;
                    case "YES":
                        intYesNo = 1;
                        break;
                    default:
                        break;
                }


                //------------------------------------------------------------------------------------//

                using (con = new SqlConnection(strConnection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand(strSQLAddOrUpdate, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        if (blnUpdate)
                        {
                            cmd.Parameters.Add("@UID", SqlDbType.Int);
                            cmd.Parameters["@UID"].Value = int1UID;
                        }


                        cmd.Parameters.Add("@FID", SqlDbType.Int);
                        cmd.Parameters["@FID"].Value = int2FID;
                        cmd.Parameters.Add("@Text", SqlDbType.VarChar);
                        cmd.Parameters["@Text"].Value = txtRon1Text.Text;
                        cmd.Parameters.Add("@YesNo", SqlDbType.Bit);
                        cmd.Parameters["@YesNo"].Value = intYesNo;
                        cmd.Parameters.Add("@ThisOrThat", SqlDbType.VarChar);
                        cmd.Parameters["@ThisOrThat"].Value = comboThisOrThat.SelectedItem.ToString();
                        cmd.Parameters.Add("@Comments", SqlDbType.VarChar);
                        cmd.Parameters["@Comments"].Value = txtComments.Text;

                        cmd.ExecuteNonQuery();

                    }

                }

                con.Close();

                //------------------------------------------------------------------------------------//

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            initFormControls();

        }
        //----------------------------------------------------------------------------------------//


        //----------------------------------------------------------------------------------------//
        private int addTable2Record(string Table2Text)
        {


            //------------------------------------------------------------------------------------//
            //Execute stored procedure to add a record to Table 2

            int insertedId = 0;

            try
            {
                SqlConnection con = new SqlConnection(strConnection);
                using (con = new SqlConnection(strConnection))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("usp_Ron2TableInsert", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@Text", SqlDbType.VarChar);
                        cmd.Parameters["@Text"].Value = Table2Text;
                        //cmd.Parameters.Add("@NewId", SqlDbType.Int);
                        //cmd.Parameters["@FID"].Value = int2FID;

                        insertedId = Convert.ToInt32(cmd.ExecuteScalar());

                        MessageBox.Show("InsertedId = " + insertedId);
                    }

                }



                con.Close();

                //------------------------------------------------------------------------------------//

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return insertedId;

        }
        //----------------------------------------------------------------------------------------//


     }

}
