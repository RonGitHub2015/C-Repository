using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormRestWebService.Models;
using System.Net;
using System.IO;
using System.Collections;

namespace WindowsFormRestWebService
{
    public partial class Form1aUsingJSON : Form
    {
        // Holds all of the weather data.
        //XDocument GetData;

        // Contains just the forecast.
        IEnumerable<Forecastday> aForecastday;

        // Specifies which forecast to use.
        Int32 ForecastNumber;

        // Defines the maximum number of forecasts.
        Int32 MaxForecasts;

        public Form1aUsingJSON()
        {
            InitializeComponent();

            string wuUri = @"http://api.wunderground.com/api/4d7d78f1c8917220/geolookup/conditions/forecast/q/Dhaka,Bangladesh.json";

            //string wuUri = "http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/UK/London.json";
            //string wuUri = "http://api.wunderground.com/api/4d7d78f1c8917220/conditions/q/UK/London.json";


            GetForecast(wuUri);

            Rootobject WU_Result = GetForecast2(wuUri);

            if (WU_Result != null)
            {
                //string strWeather = WU_Result.current_observation.weather;
                //string stringForecastTitle = WU_Result.forecast.txt_forecast.forecastday[0].title; 

                aForecastday = WU_Result.forecast.txt_forecast.forecastday;

                //foreach (var fday in aForecastday)
                //{
                //    string strTitle = fday.title;
                //    string strIcon = fday.icon;

                //}
               

                //Both the following methods of counting the number of Forecast days work
                ICollection<Forecastday> collectionOfT = aForecastday as ICollection<Forecastday>;
                if (collectionOfT != null)
                    MaxForecasts = collectionOfT.Count - 1;

                ICollection collection = aForecastday as ICollection;
                if (collection != null)
                    MaxForecasts = collection.Count - 1;

                // Specify which forecast to use.
                ForecastNumber = 0;

                // Display the forecast data.
                DisplayData(ForecastNumber);

            }
            else
            {
                // there was a problem getting the data
                MessageBox.Show("There was a problem getting the data");
            }


        }

        //---------------------------------------------------------------------------------------------------

        static void GetForecast(string targetURI)
        {

            // Contains the result of a retry request.
            DialogResult TryAgain = DialogResult.Yes;

            // Keep trying to get the weather data until the user
            // gives up or the call is successful.
            while (TryAgain == DialogResult.Yes)
            {
                try
                {
                    // Get the weather data.
                    HttpWebRequest request = WebRequest.Create(targetURI) as HttpWebRequest;

                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {

                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            throw new Exception(String.Format(
                              "Server error (HTTP {0}: {1}).",
                              response.StatusCode,
                              response.StatusDescription));
                        }

                        using (Stream stream = response.GetResponseStream())
                        {
                            StreamReader reader = new StreamReader(stream);

                            //JObject json = JObject.Parse(reader.ReadToEnd());
                            //string strJSON = json.ToString();
                            //or
                            string strJSON = reader.ReadToEnd();
                            //object objResponse = JsonConvert.DeserializeObject<Rootobject>(strJSON);
                            //or
                            var rootResult = JsonConvert.DeserializeObject<Rootobject>(strJSON); 
                            string strWeather = rootResult.current_observation.weather;
                            string strForecastTitle = rootResult.forecast.txt_forecast.forecastday[0].title;

                        }

                    }

                    // End the loop.
                    TryAgain = DialogResult.No;
                }
                catch (Exception e)     
                {
                    TryAgain = MessageBox.Show(
                        "Couldn't obtain the weather data!\r\nTry Again?",
                        "Data Download Error",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error);
                }
            }
        }

        //---------------------------------------------------------------------------------------------------


        private Rootobject GetForecast2(string targetURI)
        {
            Uri uri = new Uri(targetURI);

            var webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();

            Rootobject wUData = null;

            try
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var responseData = streamReader.ReadToEnd();

                    // if you want all the "raw data" as a string
                    // just use: responseData.ToString()
                    // or
                    wUData = JsonConvert.DeserializeObject<Rootobject>(responseData);
                    // or
                    //var rootResult = JsonConvert.DeserializeObject<Rootobject>(responseData);
                    //string strWeather = rootResult.current_observation.weather;
                    //string strForecastTitle = rootResult.forecast.txt_forecast.forecastday[0].title;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }

            return wUData;
        }

        //------------------------------------------------------------------------------------------------------------------//

        public void DisplayData(Int32 FNumber)
        {

            //foreach (var fday in aForecastday)
            //{
            //    string strTitle = fday.title;
            //    string strIcon = fday.icon;
            //}

            // Display the title of the current forecast.

            txtTitle.Text = (from aforecastday in aForecastday.AsEnumerable()
                             where aforecastday.period == FNumber
                             select aforecastday.title).First();

            //txtTitle.Text = aForecastday.AsEnumerable().Select(x => new { title = x.Field<int>("title") }); - the syntax is not correct

            //var varTitle = aForecastday.AsEnumerable()
            //    .Where(x => (x.period == FNumber))
            //    .Select(x => new { title = x.title});

            //txtTitle.Text = varTitle.title; 

           //aForecastday
           //TIMETABLEs
           //   .Where(t => (t.SlotId == (Int32?)1))
           //   .Select(t => new {SlotEntry = t.SlotEntry})


           //txtTitle.Text = Forecast.ElementAt(FNumber).txt_forecast.forecastday[FNumber].title;

           var qFields = aForecastday.AsEnumerable()
                .Where(x => (x.period == FNumber))
                .Select(x => new
                            { title = x.title,
                              fcttext = x.fcttext,
                              icon = x.icon,
                              icon_url = x.icon_url
                            }
                       );

            foreach (var qf in qFields)
            {
                txtTitle.Text = qf.title;
                txtForecast.Text = qf.fcttext;
                wbIcon.Url = new System.Uri(qf.icon_url); //webbrowser1.Url = new System.Uri(my.settings.website);
            }

        }

        //------------------------------------------------------------------------------------------------------------//

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Enable the Previous button.
            btnPrevious.Enabled = true;

            // Determine whether there is a next forecast.
            if (ForecastNumber < MaxForecasts)

                // Increase the forecast number.
                ForecastNumber++;

            // Otherwise, disable the Next button.
            else
                btnNext.Enabled = false;

            // Display the information.
            DisplayData(ForecastNumber);




        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Enable the Next button.
            btnNext.Enabled = true;

            // Determine whether there is a previous forecast.
            if (ForecastNumber > 0)

                // Decrease the forecast number.
                ForecastNumber--;

            // Otherwise, disable the Previous button.
            else
                btnPrevious.Enabled = false;

            // Display the information.
            DisplayData(ForecastNumber);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // End the program.
            Close();
        }

    }
}
