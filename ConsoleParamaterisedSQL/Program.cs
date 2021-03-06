﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleParamaterisedSQL
{
    class Program
    {
        /// <summary>
        /// Initial Version
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            string stringConnectionString = "Data Source=SQL-ead.dev.london.edu;Initial Catalog=TempWork;User ID=rfrancis;Password=(ex1to1)";
            //string stringConnectionString = "Data Source=PC-Ron\\SQLSERVERRON;Initial Catalog=TempWork;Integrated Security=True";
            SqlConnection conn = new SqlConnection(stringConnectionString);
            SqlCommand cmd;
            SqlDataReader reader;

            //----------------------------------------------------------------------------------------------------//
            // Executing a SQL Command using a SQL parameter------------------------------------------------------//
            // ---------------------------------------------------------------------------------------------------//

            //SqlConnection conn = new SqlConnection(stringConnectionString);

            Console.WriteLine("Executing a SQL Select Command using a SQL parameter in the IN clause - Method 1");

            Console.WriteLine("Enter one or more values of Ron1UID separated by commas");
            string userInput = "";
            userInput = Console.ReadLine();

            List<int> userInputUIDs = userInput.Split(',').Select(s => int.Parse(s)).ToList();

            //The following block of code works
            //
            string stringSQLCommand = "Select Ron1UID, Ron1Text, Ron2Text from Ron1Table " +
             "inner join Ron2Table on Ron2FID = Ron2UID " +
             "where Ron1UID in ({0}) or Ron1Comments in ({1})";

            using (conn = new SqlConnection(stringConnectionString))
            {

                cmd = new SqlCommand(stringSQLCommand, conn);

                conn.Open();

                var uidParameterList = new List<string>();
                var index = 0;
                foreach (var uid in userInputUIDs)
                {
                    var paramName = "@UIDsParam" + index;
                    cmd.Parameters.AddWithValue(paramName, uid);
                    uidParameterList.Add(paramName);
                    index++;
                }

                var commentsList = new List<String> { "aa", "bb", "cc" };
                var commentsParameter = new List<string>();
                index = 0; // Reset the index
                foreach (var comment in commentsList)
                {
                    var paramComments = "@CommentsParam" + index;
                    cmd.Parameters.AddWithValue(paramComments, comment);
                    commentsParameter.Add(paramComments);
                    index++;
                }

                cmd.CommandText = String.Format(stringSQLCommand, string.Join(",", uidParameterList), string.Join(",", commentsParameter));

                // string.join concatenates all the elements of a string array or members of a collection, using the specified separator between each element or member.
                // e.g. For string.Join(",", uidParameterList) the specified separator is "," and the string array is uidParameterList

                //----------------------------------------------------------------------------------------------------//

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}, {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2)); //The 0 stands for "the 0'th column", so the first column of the result.
                }

                reader.Close();
                Console.WriteLine("-------------------------------------------------------------------------");

                conn.Close();

            }



            Console.WriteLine("Executing a SQL Select Command using a SQL parameter in the IN clause - Method 2");

            stringSQLCommand = "Select Ron1UID, Ron1Text, Ron2Text from Ron1Table " +
                         "inner join Ron2Table on Ron2FID = Ron2UID " +
                         "where Ron1UID in (@UIDsParam)";

            Console.WriteLine("Enter one or more values of Ron1UID separated by commas");
            userInput = "";
            userInput = Console.ReadLine();

            userInputUIDs = userInput.Split(',').Select(s => int.Parse(s)).ToList();

            using (conn = new SqlConnection(stringConnectionString))
            {

                cmd = new SqlCommand(stringSQLCommand, conn);

                conn.Open();

                SqlParameter myParam = new SqlParameter("@UIDsParam", SqlDbType.VarChar, 50);
                var uidParameterList = new List<string>();
                var index = 0;
                foreach (var uid in userInputUIDs)
                {
                    var paramName = "@UIDsParam" + index;
                    cmd.Parameters.AddWithValue(paramName, uid);
                    uidParameterList.Add(paramName);
                    index++;
                }
                myParam.Value = uidParameterList;
                cmd.Parameters.Add(myParam);



                //var sql = "SELECT * from Table WHERE ID IN (" + getKeys(values.Count) + ")";

                //And getKeys(count) do something like this:

                //var result = string.Empty;
                //for (int i = 0; i < count; i++)
                //    {
                //        result += ", @ID" + i;
                //    }
                //return string.IsNullOrEmpty(result) ? string.Empty : //result.Substring(1);

                //and Finally, add the parameters:

                //foreach (int i = 0; i < values.Count; i++)
                //            {
                //                cmd.Parameters.Add(new SqlParameter("@ID" + i, SqlDbType.VarChar) { Value = values[i]});
                //            }


                //var commentsList = new List<String> { "aa", "bb", "cc" };
                //var commentsParameter = new List<string>();
                //index = 0; // Reset the index
                //foreach (var comment in commentsList)
                //{
                //    var paramComments = "@CommentsParam" + index;
                //    cmd.Parameters.AddWithValue(paramComments, comment);
                //    commentsParameter.Add(paramComments);
                //    index++;
                //}





                var count = 0;
                Int32 i = 0;
                var result = string.Empty;
                for (i = 0; i < count; i++)
                {
                    result += ", @UIDsParam" + i;
                }
                //return string.IsNullOrEmpty(result) ? string.Empty : result.Substring(1);

                i = 0; i < values.Count; i++)
                {
                    cmd.Parameters.Add(new SqlParameter("@UIDsParam" + i, SqlDbType.VarChar) { Value = values[i] });
                }








                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}, {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2)); //The 0 stands for "the 0'th column", so the first column of the result.
                }

                reader.Close();
                Console.WriteLine("-------------------------------------------------------------------------");

                conn.Close();

            }





            //-------------------------------------------------------------------------------------------------------//

            Console.WriteLine("Executing a SQL Select Command using a SQL parameter - Method 1 ");

            stringSQLCommand = "Select Ron1Text, Ron1ThisOrThat from Ron1Table " +
                                "inner join Ron2Table on Ron2FID = Ron2UID " +
                                "where Ron2Text = @Ron2Text";

            using (conn = new SqlConnection(stringConnectionString))
            {

                cmd = new SqlCommand(stringSQLCommand, conn);

                conn.Open();

                Console.WriteLine("Enter a Ron2Text> ");
                userInput = "";
                userInput = Console.ReadLine();

                SqlParameter myParam = new SqlParameter("@Ron2Text", SqlDbType.VarChar, 50);
                myParam.Value = userInput;
                cmd = new SqlCommand(stringSQLCommand, conn);
                cmd.Parameters.Add(myParam);

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                }

                reader.Close();
                Console.WriteLine("-------------------------------------------------------------------------");



                conn.Close();

            }


            using (conn = new SqlConnection(stringConnectionString))
            {
                conn.Open();
                using (var cmd1 = new SqlCommand(stringSQLCommand, conn))
                {
                    cmd1.Parameters.AddWithValue("@Ron2Text", userInput);


                    reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                    }

                    reader.Close();

                }

            conn.Close();
            }


            Console.WriteLine("-------------------------------------------------------------------------");


            Console.WriteLine("Executing a SQL Select Command using a SQL parameter - Method 2 ");

            Console.WriteLine("Enter a Ron2Text> ");
            userInput = "";
            userInput = Console.ReadLine();

            using (conn = new SqlConnection(stringConnectionString))
            {

                using (SqlCommand cmd1 = conn.CreateCommand())
                {
                    cmd1.CommandText = "Select Ron1Text, Ron1ThisOrThat from Ron1Table " +
                                 "inner join Ron2Table on Ron2FID = Ron2UID " +
                                 "where Ron2Text = @Ron2Text";

                    cmd1.CommandType = CommandType.Text;

                    // This is how you add a parameter to your sql command
                    // This way you are protected against SQL injection attacks
                    SqlParameter Ron2TextParameter = cmd1.CreateParameter();
                    Ron2TextParameter.ParameterName = "@Ron2Text";
                    Ron2TextParameter.Value = userInput;
                    cmd1.Parameters.Add(Ron2TextParameter);

                    conn.Open();

                    reader = cmd1.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                    }

                    reader.Close();


                    conn.Close();
                }

            }

            Console.WriteLine("-------------------------------------------------------------------------");






            //-------------------------------------------------------------------------------------------------------------------------------------//
            // Executing Stored Procedures that Return Rows Using a Command Object                                                                 //
            //-------------------------------------------------------------------------------------------------------------------------------------//


            Console.WriteLine("Executing Stored Procedures that Return Rows Using a Command Object ");

            using (conn = new SqlConnection(stringConnectionString))
            {
                cmd = new SqlCommand("usp_Ron1TableRead", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Console.WriteLine("{0}, {1}", reader2.GetInt32(0), reader2.GetInt32(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetBoolean(3), reader.GetString(4), reader.GetString(5));
                }

                reader.Close();

            }
            Console.WriteLine("-------------------------------------------------------------------------");


            conn.Close();



            // Using SQL Parameter

            Console.WriteLine("Executing Stored Procedures that Return Rows Using a Command Object - using a SQL parameter - Method 1 ");

            using (conn = new SqlConnection(stringConnectionString))
            {
                conn.Open();
                using (var cmd1 = new SqlCommand("usp_Ron1TableRead", conn))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;


                    cmd1.Parameters.Add("@P1", SqlDbType.Int);
                    cmd1.Parameters["@P1"].Value = 2;

                    // Use AddWithValue to assign order by parameter.

                    cmd1.Parameters.AddWithValue("@orderby", "Ron1ThisOrThat");

                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        //Console.WriteLine("{0}, {1}", reader2.GetInt32(0), reader2.GetInt32(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader1.GetInt32(0), reader1.GetInt32(1), reader1.GetString(2), reader1.GetBoolean(3), reader1.GetString(4), reader1.GetString(5));
                    }

                    reader1.Close();
                }
            }

            Console.WriteLine("-------------------------------------------------------------------------");


            conn.Close();

            Console.WriteLine("Executing Stored Procedures that Return Rows Using a Command Object - using SQL parameters for selection and Order By ");

            using (conn = new SqlConnection(stringConnectionString))
            {
                conn.Open();
                using (var cmd1 = new SqlCommand("usp_Ron1TableRead3", conn))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;


                    cmd1.Parameters.Add("@UID", SqlDbType.Int);
                    cmd1.Parameters["@UID"].Value = null;
                    cmd1.Parameters.Add("@YesNo", SqlDbType.Bit);
                    cmd1.Parameters["@YesNo"].Value = null;
                    cmd1.Parameters.Add("@ThisOrThat", SqlDbType.VarChar);
                    cmd1.Parameters["@ThisOrThat"].Value = null;

                    // Use AddWithValue to assign order by parameter.

                    cmd1.Parameters.AddWithValue("@orderby", "Ron1YesNoRon1ThisOrThat");

                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        //Console.WriteLine("{0}, {1}", reader2.GetInt32(0), reader2.GetInt32(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader1.GetInt32(0), reader1.GetInt32(1), reader1.GetString(2), reader1.GetBoolean(3), reader1.GetString(4), reader1.GetString(5));
                    }

                    reader1.Close();
                }

            }

            Console.WriteLine("-------------------------------------------------------------------------");


            conn.Close();


            //-------------------------------------------------------------------------------------------------------------------------------------//
            // Executing Stored Procedures that Inserts Rows Using a Command Object                                                                //
            //-------------------------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("Executing Stored Procedures that Inserts Rows Using a Command Object - using SQL parameters ");

            Console.WriteLine("Enter text for Ron1Text> ");
            string userInputRon1Text = "";
            userInputRon1Text = Console.ReadLine();

            Console.WriteLine("Enter Y or N for Ron1YesNo> ");
            string userInputRon1YesNo = "";
            userInputRon1YesNo = Console.ReadLine();
            Boolean inputRon1YesNo = false;
            if (userInputRon1YesNo.ToUpper() == "Y")
            {
                inputRon1YesNo = true;
            }

            Console.WriteLine("Enter This or That for Ron1ThisOrThat> ");
            string userInputRon1ThisOrThat = "";
            userInputRon1ThisOrThat = Console.ReadLine();

            Console.WriteLine("Enter text for a Ron1Comments> ");
            string userInputRon1Comments = "";
            userInputRon1Comments = Console.ReadLine();


            using (conn = new SqlConnection(stringConnectionString))
            {
                conn.Open();
                using (var cmd1 = new SqlCommand("usp_Ron1TableInsert", conn))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;


                    cmd1.Parameters.Add("@FID", SqlDbType.Int);
                    cmd1.Parameters["@FID"].Value = 1;
                    cmd1.Parameters.Add("@Text", SqlDbType.VarChar);
                    cmd1.Parameters["@Text"].Value = userInputRon1Text;
                    cmd1.Parameters.Add("@YesNo", SqlDbType.Bit);
                    cmd1.Parameters["@YesNo"].Value = inputRon1YesNo;
                    cmd1.Parameters.Add("@ThisOrThat", SqlDbType.VarChar);
                    cmd1.Parameters["@ThisOrThat"].Value = userInputRon1ThisOrThat;
                    cmd1.Parameters.Add("@Comments", SqlDbType.VarChar);
                    cmd1.Parameters["@Comments"].Value = userInputRon1Comments;

                    cmd1.ExecuteNonQuery();


                    // Executing SQL Statements that Return Rows Using a Command Object 
                    string sqlSelectString = "Select * from Ron1Table " +
                                 " where Ron1Text = '" + userInputRon1Text + "'"; ;
                    cmd = new SqlCommand(sqlSelectString, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetBoolean(3), reader.GetString(4), reader.GetString(5));
                    }

                    reader.Close();


                }

            }

            Console.WriteLine("-------------------------------------------------------------------------");


            conn.Close();







            //-------------------------------------------------------------------------------------------------------------------------------------//
            // Executing Stored Procedures that Updates Rows Using a Command Object                                                                //
            //-------------------------------------------------------------------------------------------------------------------------------------//






            //---------------------------------------------------------------------------------------------------------//
            //        The End                                                                                          //
            //---------------------------------------------------------------------------------------------------------//

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to finish");
                Console.ReadLine();
            }


        }

    }
 
}
