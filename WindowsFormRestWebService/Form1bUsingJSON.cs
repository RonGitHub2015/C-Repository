using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormRestWebService
{
    public partial class Form1bUsingJSON : Form
    {
        public Form1bUsingJSON()
        {
            InitializeComponent();
        }

        private async void btnGetForecast_Click(object sender, EventArgs e)
        {
            //Task T = new Task(RequestWeatherForecast.GetForecast("UK/London"));
            //T.Start();

            var results1 = await RequestWeatherForecast.GetConditions("UK/London");
            var results2 = await RequestWeatherForecast.GetForecast("UK/London");


        }
    }
}
