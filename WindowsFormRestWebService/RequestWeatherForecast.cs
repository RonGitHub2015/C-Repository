using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormRestWebService.Models;
using System.Net.Http;
using Newtonsoft.Json;


namespace WindowsFormRestWebService
{

    class RequestWeatherForecast
    {
        //public static async Task<List<Current_Observation>> GetConditions(string strLocation)
        public static async Task<string> GetConditions(string strLocation)

        {
            string strAPIUrl = "http://api.wunderground.com/api/4d7d78f1c8917220/conditions/q/";
            string strAPILocation = strLocation;             //UK / London.json

            using (var client = new HttpClient() )
            {
                string repUrl = strAPIUrl + strAPILocation + ".json";
                HttpResponseMessage response = await client.GetAsync(repUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    //var rootResult = JsonConvert.DeserializeObject<Rootobject>(result);
                    //return rootResult.current_observation;
                    //string strWeather = rootResult.current_observation.weather;
                    //return null;
                    return result;
                }
                else
                {
                    return null;
                }
            }

        }

        //----------------------------------------------------------------------------------------------//

        public static async Task<string> GetForecast(string strLocation)
        //public static async Task<IEnumerable<Forecast>> GetForecast(string strLocation)

        {
            string strAPIUrl = "http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/";
            string strAPILocation = strLocation;             //UK / London.json

            using (var client = new HttpClient())
            {
                string repUrl = strAPIUrl + strAPILocation + ".json";
                HttpResponseMessage response = await client.GetAsync(repUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    //var rootResult = JsonConvert.DeserializeObject<Rootobject>(result);
                    //string strForecastDate = rootResult.forecast.txt_forecast.forecastday.ToString();
                    //return null;
                    return result;
                }
                else
                {
                    return null;
                }
            }

        }
            public static async Task<IEnumerable<Forecast>> GetForecast1(string strLocation)

        {
                string strAPIUrl = "http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/";
                string strAPILocation = strLocation;             //UK / London.json

                using (var client = new HttpClient())
                {
                    string repUrl = strAPIUrl + strAPILocation + ".json";
                    HttpResponseMessage response = await client.GetAsync(repUrl);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    var rootResult = JsonConvert.DeserializeObject<Rootobject>(result);
                    var Forecast = rootResult.forecast.txt_forecast.forecastday;
                    

                    // Obtain all the forecasts.
                    //Forecast = GetData.Element("forecast").Element("txt_forecast").Elements("forecastday");

                    // Define the maximum number of forecasts.
                    Int32 MaxForecasts = Forecast.Count() - 1;

                    // Specify which forecast to use.
                    Int32 ForecastNumber = 0;

                    // Specify which icon to use.
                    //IconNumber = 0;

                    return null;


                }
                    else
                    {
                        return null;
                    }
                }


            }


        //---------------------------------------------------------------------------------------------//

    }
}
