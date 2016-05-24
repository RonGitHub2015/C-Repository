﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using WindowsFormRestWebService.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace WindowsFormRestWebService
{
    public partial class Form1UsingJSON : Form
    {
        // Holds all of the weather data.
        //XDocument GetData;

        // Contains just the forecast.
        static IEnumerable<Forecast> Forecast;

        // Specifies which forecast to use.
        static Int32 ForecastNumber;

        // Defines the maximum number of forecasts.
        static Int32 MaxForecasts;

        // Contains a list of icons associated with the forecast.
        IEnumerable<string> Icons;

        // Specifies which icon to use.
        static Int32 IconNumber;



        public Form1UsingJSON()
        {
            InitializeComponent();

            //// Obtain the forecast.
            //Task T2 = new Task(ApiCallGetForecast);
            //T2.Start();

            GetForecast();

            // sample usage:

            string wuUri = @"http://api.wunderground.com/api/02e5dd8c34e3e657/geolookup/conditions/forecast/q/Dhaka,Bangladesh.json";

            Rootobject WU_Result = GetForecast2(wuUri);

            if (WU_Result != null)
            {
               IEnumerable Forecast = WU_Result.forecast.txt_forecast.forecastday;


                ICollection<Forecast> collectionOfT = Forecast as ICollection<Forecast>;
                if (collectionOfT != null)
                    MaxForecasts = collectionOfT.Count;

                ICollection collection = Forecast as ICollection;
                if (collection != null)
                    MaxForecasts = collection.Count -1;


                // Define the maximum number of forecasts.
                //MaxForecasts = Forecast.Count() - 1;

                // Specify which forecast to use.
                ForecastNumber = 0;

                // Specify which icon to use.
                IconNumber = 0;
                // do something with the data in WU_Result
            }
            else
            {
                // there was a problem getting the data
            }


                        // Display the forecast data.
                        DisplayData(ForecastNumber);
        }


       




        static async void ApiCallGetConditions()
        {

            using (var client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync("http://api.wunderground.com/api/4d7d78f1c8917220/conditions/q/UK/London.json");

                response.EnsureSuccessStatusCode();

                using (HttpContent content = response.Content)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var rootResult = JsonConvert.DeserializeObject<Rootobject>(responseBody);        //parsed_json['location']['city'];
                    string strWeather = rootResult.current_observation.weather;

                }
            }

        }

        //static async void ApiCallGetForecast()
        //{

        //    using (var client = new HttpClient())
        //    {
        //        HttpResponseMessage response = await client.GetAsync("http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/UK/London.json");

        //        response.EnsureSuccessStatusCode();

        //        using (HttpContent contenet = response.Content)
        //        {
        //            string responseBody = await response.Content.ReadAsStringAsync();
        //            var rootResult = JsonConvert.DeserializeObject<Rootobject>(responseBody);
        //            var Forecast = rootResult.forecast.txt_forecast.forecastday;

        //            // Obtain all the forecasts.
        //            //Forecast = GetData.Element("forecast").Element("txt_forecast").Elements("forecastday");

        //            // Define the maximum number of forecasts.
        //            MaxForecasts = Forecast.Count() - 1;

        //            // Specify which forecast to use.
        //            ForecastNumber = 0;

        //            // Specify which icon to use.
        //            IconNumber = 0;


        //        }


        //    }

        //}

        static void GetForecast()
        {

            string strRequestURL = "http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/UK/London.json";

            // Contains the result of a retry request.
            DialogResult TryAgain = DialogResult.Yes;

            // Keep trying to get the weather data until the user
            // gives up or the call is successful.
            while (TryAgain == DialogResult.Yes)
            {
                try
                {
                    // Get the weather data.
                    
                    HttpWebRequest request = WebRequest.Create(strRequestURL) as HttpWebRequest;


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
                            object objResponse = JsonConvert.DeserializeObject<Rootobject>(strJSON);



                        }


                        //RequestWeatherForecast jsonSerializer = new RequestWeatherForecast(typeof(Response));
                        //object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                        //Response jsonResponse
                        //= objResponse as Response;
                        //return jsonResponse;
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





            //using (var client = new HttpClient())
            //{
            //    HttpResponseMessage response = client.GetAsync("http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/UK/London.json");

            //    response.EnsureSuccessStatusCode();

            //    using (HttpContent contenet = response.Content)
            //    {
            //        string responseBody = await response.Content.ReadAsStringAsync();
            //        var rootResult = JsonConvert.DeserializeObject<Rootobject>(responseBody);
            //        var Forecast = rootResult.forecast.txt_forecast.forecastday;

            //        // Obtain all the forecasts.
            //        //Forecast = GetData.Element("forecast").Element("txt_forecast").Elements("forecastday");

            //        // Define the maximum number of forecasts.
            //        MaxForecasts = Forecast.Count() - 1;

            //        // Specify which forecast to use.
            //        ForecastNumber = 0;

            //        // Specify which icon to use.
            //        IconNumber = 0;


            //    }


            //}

        }


        public void DisplayData(Int32 FNumber)
        {
            // Display the title of the current forecast.
            //txtTitle.Text = Forecast.ElementAt(FNumber).Element("title").Value;

            // Display detailed forecast information.
            //txtForecast.Text = Forecast.ElementAt(FNumber).Element("fcttext").Value;

            // Obtain a list of icons associated with the forecast.
            //Icons = Forecast.ElementAt(FNumber).Element("icons").Elements("icon_set");

            // Define the maximum number of available icons.
            //IconSelect.Maximum = Icons.Count() - 1;

            // Display the icon on screen.
            //wbIcon.Url = new Uri(Icons.ElementAt(IconNumber).Element("icon_url").Value);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            //            // Get the weather data.

            //Task T1 = new Task(ApiCallGetConditions);
            //T1.Start();


            //"http://api.wunderground.com/api/4d7d78f1c8917220/conditions/q/CA/San_Francisco.json  "
            //"http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/UK/London.json  "

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

        private void IconSelect_ValueChanged(object sender, EventArgs e)
        {
            // Set the icon value to the value of the up/down control.
            IconNumber = (Int32)IconSelect.Value;

            // Display the information.
            DisplayData(ForecastNumber);
        }

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

                    wUData = JsonConvert.DeserializeObject<Rootobject>(responseData);
                }
            }
            catch (Exception e)
            {
                // error occurred ... ???
            }

            return wUData;
        }







    }
}