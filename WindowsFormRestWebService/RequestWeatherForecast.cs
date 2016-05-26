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

        public static async Task<Rootobject> GetWeather(string strLocation)

        {
            //"http://api.wunderground.com/api/4d7d78f1c8917220/geolookup/conditions/forecast/q/CA/San_Francisco.json"
            //"http://api.wunderground.com/api/4d7d78f1c8917220/geolookup/conditions/forecast/q/UK/London.json"
            //string strAPIUrl = "http://api.wunderground.com/api/4d7d78f1c8917220/conditions/q/";
            //string strAPIUrl = "http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/";
            string strAPIUrl = "http://api.wunderground.com/api/4d7d78f1c8917220/geolookup/conditions/forecast/q/";
            string strAPILocation = strLocation;             //UK / London.json

            Rootobject wUData = null;

            //try
            //{
                using (var client = new HttpClient())
                {
                    string repUrl = strAPIUrl + strAPILocation + ".json";
                    HttpResponseMessage response = await client.GetAsync(repUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        wUData = JsonConvert.DeserializeObject<Rootobject>(result);
                        return wUData;
                    }
                    else
                    {
                        return wUData;
                    }
                }
            //}
            //catch (Exception e)
            //{
            //    return null;
            //}
                       

        }

        //----------------------------------------------------------------------------------------------//

        //public static async Task<Rootobject> GetForecast(string strLocation)
        //{
        //    string strAPIUrl = "http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/";
        //    string strAPILocation = strLocation;             //UK / London.json

        //    Rootobject wUData = null;

        //    using (var client = new HttpClient())
        //    {
        //        string repUrl = strAPIUrl + strAPILocation + ".json";
        //        HttpResponseMessage response = await client.GetAsync(repUrl);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string result = await response.Content.ReadAsStringAsync();
        //            wUData = JsonConvert.DeserializeObject<Rootobject>(result);
        //            return wUData;
        //        }
        //        else
        //        {
        //            return wUData;
        //        }
        //    }

        //}
        //    public static async Task<IEnumerable<Forecast>> GetForecast1(string strLocation)

        //{
        //        string strAPIUrl = "http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/";
        //        string strAPILocation = strLocation;             //UK / London.json

        //        using (var client = new HttpClient())
        //        {
        //            string repUrl = strAPIUrl + strAPILocation + ".json";
        //            HttpResponseMessage response = await client.GetAsync(repUrl);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            string result = await response.Content.ReadAsStringAsync();
        //            var rootResult = JsonConvert.DeserializeObject<Rootobject>(result);
        //            var Forecast = rootResult.forecast.txt_forecast.forecastday;
                    

        //            //// Obtain all the forecasts.
        //            ////Forecast = GetData.Element("forecast").Element("txt_forecast").Elements("forecastday");

        //            //// Define the maximum number of forecasts.
        //            //Int32 MaxForecasts = Forecast.Count() - 1;

        //            //// Specify which forecast to use.
        //            //Int32 ForecastNumber = 0;

        //            //// Specify which icon to use.
        //            ////IconNumber = 0;

        //            return null;


        //        }
        //            else
        //            {
        //                return null;
        //            }
        //        }


        //    }


        //---------------------------------------------------------------------------------------------//

    }
}
