using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormRestWebService.Models;
using System.Net.Http;
using System.Collections;

namespace WindowsFormRestWebService
{



    public partial class Form1bUsingJSON : Form
    {

        // Holds all of the weather data.
        //XDocument GetData;

        // Contains just the forecast.
        IEnumerable<Forecastday> aForecastday;

        // Specifies which forecast to use.
        Int32 ForecastNumber;

        // Defines the maximum number of forecasts.
        Int32 MaxForecasts;



        public Form1bUsingJSON()
        {
            InitializeComponent();
        }

        private async void btnGetForecast_Click(object sender, EventArgs e)
        {


            //using (var client = new HttpClient())
            //{

            //    HttpResponseMessage response = await client.GetAsync("http://api.wunderground.com/api/4d7d78f1c8917220/conditions/q/UK/London.json");

            //    response.EnsureSuccessStatusCode();

            //    using (HttpContent content = response.Content)
            //    {
            //        string responseBody = await response.Content.ReadAsStringAsync();
            //        var rootResult = JsonConvert.DeserializeObject<Rootobject>(responseBody);        //parsed_json['location']['city'];
            //        string strWeather = rootResult.current_observation.weather;

            //    }
            //}

            string strAPIUrl = "http://api.wunderground.com/api/4d7d78f1c8917220/geolookup/conditions/forecast/q/";
            string strAPILocation = txtBoxCountry.Text + '/' + txtBoxCity.Text;             //UK / London.json

            try
            {

                using (var client = new HttpClient())
                {
                    string repUrl = strAPIUrl + strAPILocation + ".json";
                    HttpResponseMessage response = await client.GetAsync(repUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        var rootResult = JsonConvert.DeserializeObject<Rootobject>(result);


                        aForecastday = rootResult.forecast.txt_forecast.forecastday;

                        //Both the following methods of counting the number of Forecast days work
                        ICollection<Forecastday> collectionOfT = aForecastday as ICollection<Forecastday>;
                        if (collectionOfT != null)
                            MaxForecasts = collectionOfT.Count - 1;

                        ICollection collection = aForecastday as ICollection;
                        if (collection != null)
                            MaxForecasts = collection.Count - 1;

                        // Specify which forecast to use.
                        ForecastNumber = 0;



                    }
                    else
                    {
                        //return null;
                    }
                }
            }
            catch (Exception a)
            {

                MessageBox.Show("Error" + a);
            }

            // Display the information.
            DisplayData(ForecastNumber);

            //var results1 = await RequestWeatherForecast.GetConditions("UK/London");
            //var rootResult = JsonConvert.DeserializeObject<Rootobject>(results1);
            //string strWeather = rootResult.current_observation.weather;


            //var results2 = await RequestWeatherForecast.GetForecast("UK/London");
            //rootResult = JsonConvert.DeserializeObject<Rootobject>(results2);
            //string strForecastDate = rootResult.forecast.txt_forecast.date;
            //string strForecastDay = rootResult.forecast.txt_forecast.forecastday[1].title.ToString();

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
                 {
                     title = x.title,
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

