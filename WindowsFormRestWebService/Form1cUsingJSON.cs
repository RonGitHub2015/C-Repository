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
using System.Net.Http;
using WindowsFormRestWebService.Models;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace WindowsFormRestWebService
{
    public partial class Form1cUsingJSON : Form
    {
        // Holds all of the weather data.
        //XDocument GetData;

        // Contains just the forecast.
        IEnumerable<Forecastday> aForecastday;

        // Specifies which forecast to use.
        static Int32 ForecastNumber;

        // Defines the maximum number of forecasts.
        static Int32 MaxForecasts;

        // Contains a list of icons associated with the forecast.
        IEnumerable<string> Icons;

        // Specifies which icon to use.
        static Int32 IconNumber;



        public Form1cUsingJSON()
        {
            InitializeComponent();

        }



        private async void btnGetForecast_Click(object sender, EventArgs e)
        {
            string strLocation = txtLocation.Text;
            Rootobject WU_Result = await RequestWeatherForecast.GetWeather(strLocation);

            if (WU_Result != null)
            {
                aForecastday = WU_Result.forecast.txt_forecast.forecastday; 

                ICollection<Forecastday> collectionOfT = aForecastday as ICollection<Forecastday>;
                if (collectionOfT != null)
                    MaxForecasts = collectionOfT.Count;

                ICollection collection = aForecastday as ICollection;
                if (collection != null)
                    MaxForecasts = collection.Count - 1;

                // Specify which forecast to use.
                ForecastNumber = 0;

                // Specify which icon to use.
                IconNumber = 0;

                // do something with the data in WU_Result
                // Display the forecast data.
                DisplayData(ForecastNumber);
            }
            else
            {
                // there was a problem getting the data
                MessageBox.Show("There was a problem getting the data");
            }

        }


        //---------------------------------------------------------------------------------------------------//
 

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

//----------------------------------------------------------------------------------------------------------------------------------//

        }
        private void btnNext_Click(object sender, EventArgs e)
        {


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




    }
}
