using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace ConsoleSQLServerCS
{
    class Program
    {

        //Declare the following variables at the class level so that they can be used by the various methods within the class
        private static string userInput;
        private static string userInputRon1Text;
        private static Boolean inputRon1YesNo;
        private static string userInputRon1ThisOrThat;
        private static string userInputRon1Comments;
        private static Int32 Ron1TableRecUID;
        private static string stringConnectionString;
        private static string sqlSelectString;
        

        static void Main(string[] args)
        {

            //string stringConnectionString = "Data Source=SQL-ead.dev.london.edu;Initial Catalog=TempWork;User ID=rfrancis;Password=(ex1to1)";
            stringConnectionString = "Data Source=PC-Ron\\SQLSERVERRON;Initial Catalog=TempWork;Integrated Security=True";





            //-------------------------------------------------------------------------------------------------------//
            // Executing a SQL Command without a SQL parameter-------------------------------------------------------//
            // ------------------------------------------------------------------------------------------------------//

            //Executing a SQL Select Command without a parameter
            example1();
            //Executing a SQL Insert Command without a parameter
            example2();
            //Executing a SQL Update Command without a parameter
            example3();
            //Executing a SQL Delete Command without a parameter
            example4();




            //Console.WriteLine("1 - Executing a SQL Select Command without a parameter");

            //Console.WriteLine("Enter a Ron2Text> ");
            //string userInput = "";
            //userInput = Console.ReadLine();
            //string sqlSelectString = "Select Ron1UID, Ron2Text, Ron1Text, Ron1ThisOrThat, Ron1YesNo, Ron1Comments from Ron1Table " +
            //                         "inner join Ron2Table on Ron2FID = Ron2UID " +
            //                         "where Ron2Text = '" + userInput + "'";

            //SqlConnection conn = new SqlConnection(stringConnectionString);

            //conn.Open();

            //// Executing SQL Statements that Return Rows Using a Command Object 

            //SqlCommand cmd = new SqlCommand(sqlSelectString, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())

            //{
            //    //If field Ron1Text contains nulls then GetString(0) will fail with a system error
            //    if (reader[0] != null && reader[0] != DBNull.Value)
            //    {
            //        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5)); //The 0 stands for "the 0'th column", so the first column of the result.

            //    }

            //}

            //reader.Close();
            //conn.Close();

            //Console.WriteLine("-------------------------------------------------------------------------");



            //Console.WriteLine("2 - Executing a SQL Insert Command without a parameter");

            //entertextonscreen();

            //sqlSelectString = "Insert into Ron1Table (Ron2FID, Ron1Text, Ron1YesNo, Ron1ThisOrThat, Ron1Comments) " +
            //                         "values (2, '" + userInputRon1Text + "', '" + inputRon1YesNo + "', '" + userInputRon1ThisOrThat + "', '" + userInputRon1Comments + "')";
            ////the sqlSelectString will contain the following if userInputRon1Text = 'ttttt' and userinputRon1YesNo = 'Y' and userInputRon1ThisOrThat = 'this' and userInputRon1Comments = 'yyyyy'
            ////Insert into Ron1Table (Ron2FID, Ron1Text, Ron1YesNo, Ron1ThisOrThat, Ron1Comments) values (2, 'ttttt', 'True', 'this', 'yyyyy')

            ////sqlSelectString = "Insert into Ron1 Table " +
            ////                         "values (value1, value2, value3)";

            //SqlConnection conn = new SqlConnection(stringConnectionString);
            //SqlCommand cmd = new SqlCommand(sqlSelectString, conn);

            //conn.Open();
            //cmd = new SqlCommand(sqlSelectString, conn);
            //cmd.ExecuteNonQuery();


            //// Executing SQL Statements that Return Rows Using a Command Object 
            //sqlSelectString = "Select Ron1UID, Ron2Text, Ron1Text, Ron1ThisOrThat, Ron1YesNo, Ron1Comments from Ron1Table " +
            //             "inner join Ron2Table on Ron2FID = Ron2UID " +
            //             "where Ron2FID = 2";
            //cmd = new SqlCommand(sqlSelectString, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
            //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5)); //The 0 stands for "the 0'th column", so the first column of the result.

            //}


            //reader.Close();
            //conn.Close();

            //Console.WriteLine("-------------------------------------------------------------------------");


            //Console.WriteLine("3 -Executing a SQL Update Command without a parameter");

            //entertextonscreen();

            //sqlSelectString = "Update Ron1Table set Ron1YesNo = '" + inputRon1YesNo + "', Ron1ThisOrThat = '" + userInputRon1ThisOrThat + "', Ron1Comments = '" + userInputRon1Comments + "'" +
            //                  " where Ron1Text = '" + userInputRon1Text + "'";


            //conn.Open();
            //cmd = new SqlCommand(sqlSelectString, conn);
            //cmd.ExecuteNonQuery();

            //sqlSelectString = "Select Ron1UID, Ron2Text, Ron1Text, Ron1ThisOrThat, Ron1YesNo, Ron1Comments from Ron1Table " +
            //                  "inner join Ron2Table on Ron2FID = Ron2UID " +
            //                  "where Ron1Text = '" + userInputRon1Text + "'";

            //cmd = new SqlCommand(sqlSelectString, conn);
            //reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
            //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5)); //The 0 stands for "the 0'th column", so the first column of the result.
            //}

            //reader.Close();
            //conn.Close();

            //Console.WriteLine("-------------------------------------------------------------------------");

            //Console.WriteLine("4 - Executing a SQL Delete Command without a parameter");

            //Console.WriteLine("Press enter to delete a record");
            //userInput = "";
            //userInput = Console.ReadLine();


            //sqlSelectString = "Delete from Ron1Table where Ron1Text = '" + userInputRon1Text + "'";


            //conn.Open();
            //cmd = new SqlCommand(sqlSelectString, conn);
            //cmd.ExecuteNonQuery();

            //sqlSelectString = "Select Ron1UID, Ron2Text, Ron1Text, Ron1ThisOrThat, Ron1YesNo, Ron1Comments from Ron1Table " +
            //                  "inner join Ron2Table on Ron2FID = Ron2UID " +
            //                  "where Ron1Text = '" + userInputRon1Text + "'";

            //cmd = new SqlCommand(sqlSelectString, conn);
            //reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
            //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5)); //The 0 stands for "the 0'th column", so the first column of the result.
            //}

            //reader.Close();
            //conn.Close();

            //Console.WriteLine("-------------------------------------------------------------------------");




            //----------------------------------------------------------------------------------------------------//
            // Executing a SQL Command using a SQL parameter------------------------------------------------------//
            // ---------------------------------------------------------------------------------------------------//

            //Executing a SQL Select Command using a SQL parameter in the IN clause
            example5();
            //Executing a SQL Select Command using a SQL parameter - Method 1 
            example6();
            //Executing a SQL Select Command using a SQL parameter - Method 2
            example7();



            //Console.WriteLine("5 - Executing a SQL Select Command using a SQL parameter in the IN clause");


            ////string stringSQLCommand = "Select Ron1UID, Ron1Text, Ron2Text from Ron1Table " +
            ////             "inner join Ron2Table on Ron2FID = Ron2UID " +
            ////             "where Ron1UID in (@UIDsParam) or Ron1Comments in (@CommentsParam)";




            //Console.WriteLine("Enter one or more values of Ron1UID separated by commas");
            //userInput = "";
            //userInput = Console.ReadLine();

            //List<int> userInputUIDs = userInput.Split(',').Select(s => int.Parse(s)).ToList();

            //////var uidList = new List<int> { 2, 3, 4, 5, 6 };
            //////var uidParameterList = new List<string>();
            //////var index = 0;
            //////foreach (var uid in uidList)
            //////{
            //////    var paramName = "@UIDsParam" + index;
            //////    cmd.Parameters.AddWithValue(paramName, uid);
            //////    uidParameterList.Add(paramName);
            //////    index++;
            //////}

            ////The following block of code works
            ////
            ////string stringSQLCommand = "Select Ron1UID, Ron1Text, Ron2Text from Ron1Table " +
            //// "inner join Ron2Table on Ron2FID = Ron2UID " +
            //// "where Ron1UID in ({0}) or Ron1Comments in ({1})";

            ////var uidParameterList = new List<string>();
            ////var index = 0;
            ////foreach (var uid in userInputUIDs)
            ////{
            ////    var paramName = "@UIDsParam" + index;
            ////    cmd.Parameters.AddWithValue(paramName, uid);
            ////    uidParameterList.Add(paramName);
            ////    index++;
            ////}

            ////var commentsList = new List<String> { "aa", "bb", "cc" };
            ////var commentsParameter = new List<string>();
            ////index = 0; // Reset the index
            ////foreach (var comment in commentsList)
            ////{
            ////    var paramComments = "@CommentsParam" + index;
            ////    cmd.Parameters.AddWithValue(paramComments, comment);
            ////    commentsParameter.Add(paramComments);
            ////    index++;
            ////}

            ////cmd.CommandText = String.Format(stringSQLCommand, string.Join(",", uidParameterList), string.Join(",", commentsParameter));

            ////----------------------------------------------------------------------------------------------------//

            ////var sql = "SELECT * FROM TBL_USER_MASTER WHERE USER_ID IN ({0}) OR USER_NAME IN ({1})";

            ////var idList = new List<int> { 100, 50, 40, 20, 10 };
            ////var idParameterList = new List<string>();
            ////var index = 0;
            ////foreach (var id in idList)
            ////{
            ////    var paramName = "@idParam" + index;
            ////    sqlCommand.Parameters.AddWithValue(paramName, id);
            ////    idParameterList.Add(paramName);
            ////    index++;
            ////}

            ////var nameList = new List<String> { "sebastian", "kuuro", "svenbit" };
            ////var nameParameter = new List<string>();
            ////index = 0; // Reset the index
            ////foreach (var name in nameList)
            ////{
            ////    var paramName = "@nameParam" + index;
            ////    sqlCommand.Parameters.AddWithValue(paramName, name);
            ////    nameParameter.Add(paramName);
            ////    index++;
            ////}

            ////sqlCommand.CommandText = String.Format(sql, string.Join(",", idParameterList), string.Join(",", nameParameter));

            ////The block of code above works --------------------------------------------------------------------------------------//

            ////---------------------------------------------------------------------------------------------------//

            //conn.Open();

            //reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    //Console.WriteLine("{0}, {1}, {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2)); //The 0 stands for "the 0'th column", so the first column of the result.
            //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
            //}

            //reader.Close();
            //Console.WriteLine("-------------------------------------------------------------------------");


            //string stringSQLCommand = "Select * from Ron1Table " +
            //                 "inner join Ron2Table on Ron2FID = Ron2UID " +
            //                 "where Ron2Text = @Ron2Text";

            //Console.WriteLine("6 - Executing a SQL Select Command using a SQL parameter - Method 1 ");

            //Console.WriteLine("Enter a Ron2Text> ");
            //userInput = "";
            //userInput = Console.ReadLine();

            //SqlParameter myParam = new SqlParameter("@Ron2Text", SqlDbType.VarChar, 50);
            //myParam.Value = userInput;
            //cmd = new SqlCommand(stringSQLCommand, conn);
            //cmd.Parameters.Add(myParam);

            ////conn.Open();

            //reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
            //    Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
            //}

            //reader.Close();
            //Console.WriteLine("-------------------------------------------------------------------------");

            //conn.Close();


            //using (conn = new SqlConnection(stringConnectionString))
            //{
            //    conn.Open();
            //    using (var cmd1 = new SqlCommand(stringSQLCommand, conn))
            //    {
            //        cmd1.Parameters.AddWithValue("@Ron2Text", userInput);


            //        reader = cmd1.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
            //            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));

            //        }

            //        reader.Close();

            //    }

            //    conn.Close();
            //}


            //Console.WriteLine("-------------------------------------------------------------------------");


            //Console.WriteLine("7 - Executing a SQL Select Command using a SQL parameter - Method 2 ");

            //Console.WriteLine("Enter a Ron2Text> ");
            //userInput = "";
            //userInput = Console.ReadLine();

            //using (conn = new SqlConnection(stringConnectionString))
            //{

            //    using (SqlCommand cmd1 = conn.CreateCommand())
            //    {
            //        cmd1.CommandText = "Select * from Ron1Table " +
            //                     "inner join Ron2Table on Ron2FID = Ron2UID " +
            //                     "where Ron2Text = @Ron2Text";

            //        cmd1.CommandType = CommandType.Text;

            //        // This is how you add a parameter to your sql command
            //        // This way you are protected against SQL injection attacks
            //        SqlParameter Ron2TextParameter = cmd1.CreateParameter();
            //        Ron2TextParameter.ParameterName = "@Ron2Text";
            //        Ron2TextParameter.Value = userInput;
            //        cmd1.Parameters.Add(Ron2TextParameter);

            //        conn.Open();

            //        reader = cmd1.ExecuteReader();
            //        while (reader.Read())
            //        {
            //            //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
            //            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
            //        }

            //        reader.Close();


            //        conn.Close();
            //    }

            //}

            //Console.WriteLine("-------------------------------------------------------------------------");






            //-------------------------------------------------------------------------------------------------------------------------------------//
            // Executing Stored Procedures that Return Rows Using a Command Object                                                                 //
            //-------------------------------------------------------------------------------------------------------------------------------------//
             
            // 


            // Using SQL Parameter

            Console.WriteLine("9 - Executing Stored Procedures that Return Rows Using a Command Object - using a SQL parameter - Method 1 - Do not pass a parameter so that all rows are returned ");

            SqlConnection conn = new SqlConnection(stringConnectionString);

            using (conn = new SqlConnection(stringConnectionString))
            {
                conn.Open();
                using (var cmd1 = new SqlCommand("usp_Ron1Ron2TableRead", conn))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;


                    //cmd1.Parameters.Add("@UID", SqlDbType.Int);
                    //cmd1.Parameters["@UID"].Value = 2;

                    //// Use AddWithValue to assign order by parameter.

                    //cmd1.Parameters.AddWithValue("@orderby", "Ron1ThisOrThat");

                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    while (reader1.Read())
                    {
                        //Console.WriteLine("{0}, {1}", reader1.GetInt32(0), reader1.GetInt32(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader1.GetInt32(0), reader1.GetInt32(1), reader1.GetString(2), reader1.GetString(3), reader1.GetBoolean(4), reader1.GetString(5), reader1.GetInt32(6), reader1.GetString(7));

                    }

                    reader1.Close();
                }
            }

            Console.WriteLine("-------------------------------------------------------------------------");


            conn.Close();

            Console.WriteLine("10 - Executing Stored Procedures that Return Rows Using a Command Object - using SQL parameters for selection and Order By ");

            using (conn = new SqlConnection(stringConnectionString))
            {
                conn.Open();
                using (var cmd1 = new SqlCommand("usp_Ron1Ron2TableRead", conn))
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
                        //Console.WriteLine("{0}, {1}", reader1.GetInt32(0), reader1.GetInt32(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader1.GetInt32(0), reader1.GetInt32(1), reader1.GetString(2), reader1.GetString(3), reader1.GetBoolean(4), reader1.GetString(5), reader1.GetInt32(6), reader1.GetString(7));

                    }

                    reader1.Close();
                }

            }

            Console.WriteLine("-------------------------------------------------------------------------");


            conn.Close();


            //-------------------------------------------------------------------------------------------------------------------------------------//
            // Executing Stored Procedures that Inserts Rows Using a Command Object                                                                //
            //-------------------------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("11 - Executing Stored Procedures that Inserts Rows Using a Command Object - using SQL parameters ");

            entertextonscreen();

            Ron1TableRecUID = 0;

            try
            {

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

                        //This parameter is the returned parameter and will contains the identity of the record added to the table
                        var returnParameter = cmd1.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        cmd1.ExecuteNonQuery();

                        Ron1TableRecUID = Convert.ToInt32(returnParameter.Value);

                        // Executing SQL Statements that Return Rows Using a Command Object 
                        sqlSelectString = "Select * from Ron1Table " +
                                     " where Ron1Text = '" + userInputRon1Text + "'"; ;

                        SqlCommand cmd = new SqlCommand(sqlSelectString, conn);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5));
                            //Ron1TableRecUID = reader.GetInt32(0);
                        }

                        reader.Close();
                        conn.Close();

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");




            //-------------------------------------------------------------------------------------------------------------------------------------//
            // Executing Stored Procedures that Updates Rows Using a Command Object                                                                //
            //-------------------------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("12 - Executing Stored Procedure that Updates A Row Using a Command Object - using SQL parameters ");

            entertextonscreen();

            using (conn = new SqlConnection(stringConnectionString))
            {
                conn.Open();
                using (var cmd1 = new SqlCommand("usp_Ron1TableUpdate", conn))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.Add("@UID", SqlDbType.Int);
                    cmd1.Parameters["@UID"].Value = Ron1TableRecUID;
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
                    sqlSelectString = "Select * from Ron1Table " +
                                 " where Ron1UID = " + Ron1TableRecUID;
                    SqlCommand cmd = new SqlCommand(sqlSelectString, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5));
                    }

                    reader.Close();


                }

            }

            Console.WriteLine("-------------------------------------------------------------------------");


            conn.Close();




            //---------------------------------------------------------------------------------------------------------//
            //        The End                                                                                          //
            //---------------------------------------------------------------------------------------------------------//

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to finish");
                Console.ReadLine();
            }


        }

        //-------------------------------------------------------------------------------------------------------------//
        //---End of Static Void Main ----------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------------------------------//

        static void example1()
        {

            Console.WriteLine("1 - Executing a SQL Select Command without a parameter");

            try
            {

                Console.WriteLine("Enter a Ron2Text> ");
                string userInput = "";
                userInput = Console.ReadLine();
                string sqlSelectString = "Select Ron1UID, Ron2Text, Ron1Text, Ron1ThisOrThat, Ron1YesNo, Ron1Comments from Ron1Table " +
                                         "inner join Ron2Table on Ron2FID = Ron2UID " +
                                         "where Ron2Text = '" + userInput + "'";

                SqlConnection conn = new SqlConnection(stringConnectionString);

                conn.Open();

                // Executing SQL Statements that Return Rows Using a Command Object 

                SqlCommand cmd = new SqlCommand(sqlSelectString, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())

                {
                    //If field Ron1Text contains nulls then GetString(0) will fail with a system error
                    if (reader[0] != null && reader[0] != DBNull.Value)
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5)); //The 0 stands for "the 0'th column", so the first column of the result.

                    }

                }

                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example2()
        {

            Console.WriteLine("2 - Executing a SQL Insert Command without a parameter");

            try
            {

                entertextonscreen();

                sqlSelectString = "Insert into Ron1Table (Ron2FID, Ron1Text, Ron1YesNo, Ron1ThisOrThat, Ron1Comments) " +
                                         "values (2, '" + userInputRon1Text + "', '" + inputRon1YesNo + "', '" + userInputRon1ThisOrThat + "', '" + userInputRon1Comments + "')";
                //the sqlSelectString will contain the following if userInputRon1Text = 'ttttt' and userinputRon1YesNo = 'Y' and userInputRon1ThisOrThat = 'this' and userInputRon1Comments = 'yyyyy'
                //Insert into Ron1Table (Ron2FID, Ron1Text, Ron1YesNo, Ron1ThisOrThat, Ron1Comments) values (2, 'ttttt', 'True', 'this', 'yyyyy')

                //sqlSelectString = "Insert into Ron1 Table " +
                //                         "values (value1, value2, value3)";

                using (SqlConnection conn = new SqlConnection(stringConnectionString))
                {

                    SqlCommand cmd = new SqlCommand(sqlSelectString, conn);


                    cmd = new SqlCommand(sqlSelectString, conn);

                    conn.Open();

                    cmd.ExecuteNonQuery();


                    // Executing SQL Statements that Return Rows Using a Command Object 
                    sqlSelectString = "Select Ron1UID, Ron2Text, Ron1Text, Ron1ThisOrThat, Ron1YesNo, Ron1Comments from Ron1Table " +
                                 "inner join Ron2Table on Ron2FID = Ron2UID " +
                                 "where Ron2FID = 2";
                    cmd = new SqlCommand(sqlSelectString, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5)); //The 0 stands for "the 0'th column", so the first column of the result.
                    }

                    reader.Close();
                    conn.Close();

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }


        static void example3()
        {

            Console.WriteLine("3 -Executing a SQL Update Command without a parameter");

            try
            {

                entertextonscreen();

                sqlSelectString = "Update Ron1Table set Ron1YesNo = '" + inputRon1YesNo + "', Ron1ThisOrThat = '" + userInputRon1ThisOrThat + "', Ron1Comments = '" + userInputRon1Comments + "'" +
                                  " where Ron1Text = '" + userInputRon1Text + "'";

                using (SqlConnection conn = new SqlConnection(stringConnectionString))
                {

                    SqlCommand cmd = new SqlCommand(sqlSelectString, conn);

                    cmd = new SqlCommand(sqlSelectString, conn);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                    sqlSelectString = "Select Ron1UID, Ron2Text, Ron1Text, Ron1ThisOrThat, Ron1YesNo, Ron1Comments from Ron1Table " +
                                      "inner join Ron2Table on Ron2FID = Ron2UID " +
                                      "where Ron1Text = '" + userInputRon1Text + "'";

                    cmd = new SqlCommand(sqlSelectString, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5)); //The 0 stands for "the 0'th column", so the first column of the result.
                    }

                    reader.Close();
                    conn.Close();

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example4()
        {

            Console.WriteLine("4 - Executing a SQL Delete Command without a parameter");

            try
            {

                Console.WriteLine("Press enter to delete a record");
                userInput = "";
                userInput = Console.ReadLine();


                sqlSelectString = "Delete from Ron1Table where Ron1Text = '" + userInputRon1Text + "'";

                using (SqlConnection conn = new SqlConnection(stringConnectionString))
                {
                    
                    SqlCommand cmd = new SqlCommand(sqlSelectString, conn);

                    cmd = new SqlCommand(sqlSelectString, conn);
                    
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    sqlSelectString = "Select Ron1UID, Ron2Text, Ron1Text, Ron1ThisOrThat, Ron1YesNo, Ron1Comments from Ron1Table " +
                                      "inner join Ron2Table on Ron2FID = Ron2UID " +
                                      "where Ron1Text = '" + userInputRon1Text + "'";

                    cmd = new SqlCommand(sqlSelectString, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                        Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5)); //The 0 stands for "the 0'th column", so the first column of the result.
                    }

                    reader.Close();
                    conn.Close();

                }




            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example5()
        {

            Console.WriteLine("5 - Executing a SQL Select Command using a SQL parameter in the IN clause");

            try
            {

                //string stringSQLCommand = "Select Ron1UID, Ron1Text, Ron2Text from Ron1Table " +
                //             "inner join Ron2Table on Ron2FID = Ron2UID " +
                //             "where Ron1UID in (@UIDsParam) or Ron1Comments in (@CommentsParam)";

                Console.WriteLine("Enter one or more values of Ron1UID separated by commas");
                userInput = "";
                userInput = Console.ReadLine();

                List<int> userInputUIDs = userInput.Split(',').Select(s => int.Parse(s)).ToList();

                ////var uidList = new List<int> { 2, 3, 4, 5, 6 };
                ////var uidParameterList = new List<string>();
                ////var index = 0;
                ////foreach (var uid in uidList)
                ////{
                ////    var paramName = "@UIDsParam" + index;
                ////    cmd.Parameters.AddWithValue(paramName, uid);
                ////    uidParameterList.Add(paramName);
                ////    index++;
                ////}

                //The following block of code works
                //
                //string stringSQLCommand = "Select Ron1UID, Ron1Text, Ron2Text from Ron1Table " +
                // "inner join Ron2Table on Ron2FID = Ron2UID " +
                // "where Ron1UID in ({0}) or Ron1Comments in ({1})";

                //var uidParameterList = new List<string>();
                //var index = 0;
                //foreach (var uid in userInputUIDs)
                //{
                //    var paramName = "@UIDsParam" + index;
                //    cmd.Parameters.AddWithValue(paramName, uid);
                //    uidParameterList.Add(paramName);
                //    index++;
                //}

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

                //cmd.CommandText = String.Format(stringSQLCommand, string.Join(",", uidParameterList), string.Join(",", commentsParameter));

                //----------------------------------------------------------------------------------------------------//

                //var sql = "SELECT * FROM TBL_USER_MASTER WHERE USER_ID IN ({0}) OR USER_NAME IN ({1})";

                //var idList = new List<int> { 100, 50, 40, 20, 10 };
                //var idParameterList = new List<string>();
                //var index = 0;
                //foreach (var id in idList)
                //{
                //    var paramName = "@idParam" + index;
                //    sqlCommand.Parameters.AddWithValue(paramName, id);
                //    idParameterList.Add(paramName);
                //    index++;
                //}

                //var nameList = new List<String> { "sebastian", "kuuro", "svenbit" };
                //var nameParameter = new List<string>();
                //index = 0; // Reset the index
                //foreach (var name in nameList)
                //{
                //    var paramName = "@nameParam" + index;
                //    sqlCommand.Parameters.AddWithValue(paramName, name);
                //    nameParameter.Add(paramName);
                //    index++;
                //}

                //sqlCommand.CommandText = String.Format(sql, string.Join(",", idParameterList), string.Join(",", nameParameter));

                //The block of code above works --------------------------------------------------------------------------------------//

                //---------------------------------------------------------------------------------------------------//

                //SqlConnection conn = new SqlConnection(stringConnectionString);

                using (SqlConnection conn = new SqlConnection(stringConnectionString))

                {

                    using (SqlCommand cmd = new SqlCommand(sqlSelectString, conn))
                    {

                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0}, {1}, {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2)); //The 0 stands for "the 0'th column", so the first column of the result.
                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
                        }

                        reader.Close();
                        conn.Close();
                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example6()
        {

            Console.WriteLine("6 - Executing a SQL Select Command using a SQL parameter - Method 1a ");

            try
            {

                Console.WriteLine("Enter a Ron2Text> ");
                userInput = "";
                userInput = Console.ReadLine();
                string strRon2Text = userInput;

                string stringSQLCommand = "Select * from Ron1Table " +
                                 "inner join Ron2Table on Ron2FID = Ron2UID " +
                                 "where Ron2Text = @Ron2Text";

                SqlParameter myParam = new SqlParameter("@Ron2Text", SqlDbType.VarChar, 50);
                //myParam.Value = userInput;

                using (SqlConnection conn = new SqlConnection(stringConnectionString))
                {

                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(stringSQLCommand, conn))
                    {

                        //One method of adding a parameter value to the SQL
                        myParam.Value = strRon2Text;
                        cmd.Parameters.Add(myParam);

                        //conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
                        }

                        reader.Close();
                        //conn.Close();

                    }

                //}

                Console.WriteLine("6 - Executing a SQL Select Command using a SQL parameter - Method 1b ");

                    Console.WriteLine("Press enter to continue");
                    string userInput = "";
                    userInput = Console.ReadLine();


                    //using (SqlConnection conn = new SqlConnection(stringConnectionString))
                    //{
                    using (SqlCommand cmd = new SqlCommand(stringSQLCommand, conn))
                    {

                        //Alternative method of adding a parameter value to the SQL
                        cmd.Parameters.AddWithValue("@Ron2Text", strRon2Text);

                        //conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
                        }

                        reader.Close();
                        //conn.Close();

                    }

                    conn.Close();

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example7()
        {

            Console.WriteLine("7 - Executing a SQL Select Command using a SQL parameter - Method 2 ");


            try
            {

                Console.WriteLine("Enter a Ron2Text> ");
                userInput = "";
                userInput = Console.ReadLine();

                using (SqlConnection conn = new SqlConnection(stringConnectionString))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "Select * from Ron1Table " +
                                     "inner join Ron2Table on Ron2FID = Ron2UID " +
                                     "where Ron2Text = @Ron2Text";

                        cmd.CommandType = CommandType.Text;

                        // This is how you add a parameter to your sql command
                        // This way you are protected against SQL injection attacks
                        SqlParameter Ron2TextParameter = cmd.CreateParameter();
                        Ron2TextParameter.ParameterName = "@Ron2Text";
                        Ron2TextParameter.Value = userInput;
                        cmd.Parameters.Add(Ron2TextParameter);

                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
                        }

                        reader.Close();
                        conn.Close();

                    }

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example8()
        {

            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example9()
        {

            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example10()
        {

            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example11()
        {

            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }

        static void example12()
        {

            try
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

        }


        static void entertextonscreen()

        {

            Console.WriteLine("Enter text for Ron1Text> ");
            userInputRon1Text = "";
            userInputRon1Text = Console.ReadLine();

            Console.WriteLine("Enter Y or N for Ron1YesNo> ");
            string userInputRon1YesNo = "";
            userInputRon1YesNo = Console.ReadLine();
            inputRon1YesNo = false;
            if (userInputRon1YesNo.ToUpper() == "Y")
            {
                inputRon1YesNo = true;
            }

            Console.WriteLine("Enter This or That for Ron1ThisOrThat> ");
            userInputRon1ThisOrThat = "";
            userInputRon1ThisOrThat = Console.ReadLine();

            Console.WriteLine("Enter text for a Ron1Comments> ");
            userInputRon1Comments = "";
            userInputRon1Comments = Console.ReadLine();

        }

    }

    //-------------------------------------------------------------------------------------------------------------//
    //---End of class Program--- ----------------------------------------------------------------------------------//
    //-------------------------------------------------------------------------------------------------------------//


}
