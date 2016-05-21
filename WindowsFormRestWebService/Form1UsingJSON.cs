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

namespace WindowsFormRestWebService
{
    public partial class Form1UsingJSON : Form
    {
        public Form1UsingJSON()
        {
            InitializeComponent();
        }

        ////static void Main(string[] args)
        ////{
        ////    Task T = new Task(ApiCall);
        ////    T.Start();
        ////    Console.WriteLine("Json data........");
        ////    Console.ReadLine();
        ////}

        ////static async void ApiCall()
        ////{

        ////    using (var client = new HttpClient())
        ////    {

        ////        HttpResponseMessage response = await client.GetAsync("http://localhost:57135/api/Employees/");

        ////        response.EnsureSuccessStatusCode();

        ////        using (HttpContent content = response.Content)
        ////        {
        ////            string responseBody = await response.Content.ReadAsStringAsync();

        ////            Console.WriteLine(responseBody.Substring(0, 50) + "........");

        ////            //var articles = JsonConvert.DeserializeObject<List<Employee>>(responseBody);



        ////            //foreach (var Emp in articles)
        ////            //{
        ////            //    Console.WriteLine("{0}\t{1}\t{2}\t{3}", Emp.EmployeeId, Emp.FirstName, Emp.LastName, Emp.Age);
        ////            //}

        ////        }

        ////    }





        private void btnNext_Click(object sender, EventArgs e)
        {
            //            // Get the weather data.

            Task T = new Task(ApiCall);
            T.Start();


            //"http://api.wunderground.com/api/4d7d78f1c8917220/conditions/q/CA/San_Francisco.json  "
            //"http://api.wunderground.com/api/4d7d78f1c8917220/forecast/q/UK/London.json  "

            //Deserialise JSON received
            //string JSONString = the jason file recived
            //Something s1 = JsonConvert.DeserializeObject<Something>(JSONString);
            // textBoxForecast.Text = s1;


        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }

        static async void ApiCall()
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



    }
}
