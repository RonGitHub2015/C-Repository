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

            //----------------------------------------------------------------------------------------------------//
            // Executing a SQL Command using a SQL parameter------------------------------------------------------//
            // ---------------------------------------------------------------------------------------------------//

            //Executing a SQL Select Command using a SQL parameter in the IN clause
            example5();
            //Executing a SQL Select Command using a SQL parameter - Method 1 
            example6();
            //Executing a SQL Select Command using a SQL parameter - Method 2
            example7();
            
            //-------------------------------------------------------------------------------------------------------------------------------------//
            // Executing Stored Procedures                                                                //
            //-------------------------------------------------------------------------------------------------------------------------------------//

            //Executing a Stored Procedure that Returns Rows Using a Command Object - not using a SQL parameter so that all rows are returned 
            example9();
            //Executing a Stored Procedure that Returns Rows Using a Command Object - using SQL parameters for record selection and Order By
            example10();
            //Executing a Stored Procedure that Inserts a Row Using a Command Object
            Ron1TableRecUID = Example11();
            //Executing Stored Procedure that Updates A Row Using a Command Object
            example12(Ron1TableRecUID);
            
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

            Console.WriteLine("9 - Executing Stored Procedures that Return Rows Using a Command Object - not using a SQL parameter so that all rows are returned ");


            try
            {

                using (SqlConnection conn = new SqlConnection(stringConnectionString))

                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Ron1Ron2TableRead", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0}, {1}", reader1.GetInt32(0), reader1.GetInt32(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));
                        }

                        reader.Close();
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

        static void example10()
        {

            Console.WriteLine("10 - Executing Stored Procedures that Return Rows Using a Command Object - using SQL parameters for record selection and Order By ");

            try
            {

                using (SqlConnection conn = new SqlConnection(stringConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Ron1Ron2TableRead", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //cmd.Parameters.Add("@UID", SqlDbType.Int);
                        //cmd.Parameters["@UID"].Value = null;
                        //cmd.Parameters.Add("@YesNo", SqlDbType.Bit);
                        //cmd.Parameters["@YesNo"].Value = null;
                        cmd.Parameters.Add("@ThisOrThat", SqlDbType.VarChar);
                        cmd.Parameters["@ThisOrThat"].Value = "That";

                        // Example of using the AddWithValue method to assign order by parameter.
                        cmd.Parameters.AddWithValue("@orderby", "Ron1YesNoRon1ThisOrThat");

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0}, {1}", reader1.GetInt32(0), reader1.GetInt32(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5), reader.GetInt32(6), reader.GetString(7));

                        }

                        reader.Close();
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

        private static Int32 Example11()
        {

            Console.WriteLine("11 - Executing Stored Procedures that Inserts Rows Using a Command Object - using SQL parameters ");

            entertextonscreen();

            Ron1TableRecUID = 0;

            try
            {

                using (SqlConnection conn = new SqlConnection(stringConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Ron1TableInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.Add("@FID", SqlDbType.Int);
                        cmd.Parameters["@FID"].Value = 1;
                        cmd.Parameters.Add("@Text", SqlDbType.VarChar);
                        cmd.Parameters["@Text"].Value = userInputRon1Text;
                        cmd.Parameters.Add("@YesNo", SqlDbType.Bit);
                        cmd.Parameters["@YesNo"].Value = inputRon1YesNo;
                        cmd.Parameters.Add("@ThisOrThat", SqlDbType.VarChar);
                        cmd.Parameters["@ThisOrThat"].Value = userInputRon1ThisOrThat;
                        cmd.Parameters.Add("@Comments", SqlDbType.VarChar);
                        cmd.Parameters["@Comments"].Value = userInputRon1Comments;

                        //This parameter is the returned parameter and will contains the identity of the record added to the table
                        var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        cmd.ExecuteNonQuery();

                        Ron1TableRecUID = Convert.ToInt32(returnParameter.Value);

                        // Executing SQL Statements that Return Rows Using a Command Object 
                        sqlSelectString = "Select * from Ron1Table " +
                                     " where Ron1UID = " + Ron1TableRecUID ;

                        SqlCommand cmd1 = new SqlCommand(sqlSelectString, conn);

                        SqlDataReader reader = cmd1.ExecuteReader();

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

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("-------------------------------------------------------------------------");

            return Ron1TableRecUID;
            
        }

        static void example12(Int32 Ron1TableRecUID)
        {

            Console.WriteLine("12 - Executing Stored Procedure that Updates A Row Using a Command Object - using SQL parameters ");

            entertextonscreen();

            try
            {


                using (SqlConnection conn = new SqlConnection(stringConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("usp_Ron1TableUpdate", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@UID", SqlDbType.Int);
                        cmd.Parameters["@UID"].Value = Ron1TableRecUID;
                        cmd.Parameters.Add("@FID", SqlDbType.Int);
                        cmd.Parameters["@FID"].Value = 1;
                        cmd.Parameters.Add("@Text", SqlDbType.VarChar);
                        cmd.Parameters["@Text"].Value = userInputRon1Text;
                        cmd.Parameters.Add("@YesNo", SqlDbType.Bit);
                        cmd.Parameters["@YesNo"].Value = inputRon1YesNo;
                        cmd.Parameters.Add("@ThisOrThat", SqlDbType.VarChar);
                        cmd.Parameters["@ThisOrThat"].Value = userInputRon1ThisOrThat;
                        cmd.Parameters.Add("@Comments", SqlDbType.VarChar);
                        cmd.Parameters["@Comments"].Value = userInputRon1Comments;

                        cmd.ExecuteNonQuery();

                        // Executing SQL Statements that Return Rows Using a Command Object 
                        sqlSelectString = "Select * from Ron1Table " +
                                     " where Ron1UID = " + Ron1TableRecUID;
                        SqlCommand cmd1 = new SqlCommand(sqlSelectString, conn);
                        SqlDataReader reader = cmd1.ExecuteReader();
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0}, {1}", reader.GetString(0), reader.GetString(1)); //The 0 stands for "the 0'th column", so the first column of the result.
                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetBoolean(4), reader.GetString(5));
                        }

                        reader.Close();

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
