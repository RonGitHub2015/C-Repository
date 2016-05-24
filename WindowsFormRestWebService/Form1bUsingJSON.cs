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

namespace WindowsFormRestWebService
{



    public partial class Form1bUsingJSON : Form
    {


        // Holds all of the weather data.
        //XDocument GetData;

        // Contains just the forecast.
        IEnumerable<Forecast> Forecast;

        // Specifies which forecast to use.
        Int32 ForecastNumber;

        // Defines the maximum number of forecasts.
        Int32 MaxForecasts;

        // Contains a list of icons associated with the forecast.
        IEnumerable<Icon> Icons;

        // Specifies which icon to use.
        Int32 IconNumber;

        public Form1bUsingJSON()
        {
            InitializeComponent();
        }

        private async void btnGetForecast_Click(object sender, EventArgs e)
        {
            //Task T = new Task(RequestWeatherForecast.GetForecast("UK/London"));
            //T.Start();

            var results1 = await RequestWeatherForecast.GetConditions("UK/London");
            var rootResult = JsonConvert.DeserializeObject<Rootobject>(results1);
            string strWeather = rootResult.current_observation.weather;


            var results2 = await RequestWeatherForecast.GetForecast("UK/London");
            rootResult = JsonConvert.DeserializeObject<Rootobject>(results2);
            string strForecastDate = rootResult.forecast.txt_forecast.date;
            string strForecastDay = rootResult.forecast.txt_forecast.forecastday[1].title.ToString();


        }
    }
}
