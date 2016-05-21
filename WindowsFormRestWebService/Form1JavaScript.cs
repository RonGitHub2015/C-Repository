using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace WindowsFormRestWebService
{
    public partial class Form1JavaScript : Form
    {
        public Form1JavaScript()
        {
            InitializeComponent();
        }

        private void btnGetWeatherForecast_Click(object sender, EventArgs e)
        {



            //-------------------------------------------------//

            //< script src = "http://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js" ></ script >
            // < script >
            // jQuery(document).ready(function($) {
            //  $.ajax({
            //                url: "http://api.wunderground.com/api/Your_Key/geolookup/conditions/q/IA/Cedar_Rapids.json",
            //  dataType: "jsonp",
            //  success: function(parsed_json) {
            //                        var location = parsed_json['location']['city'];
            //                        var temp_f = parsed_json['current_observation']['temp_f'];
            //                        alert("Current temperature in " + location + " is: " + temp_f);
            //                    }
            //                });
            //            });
            //</ script >

            //----------------------------------------//

            //Deserialise JSON received
            //string JSONString = 
            //JavaScriptSerializer ser = new JavaScriptSerializer();
            //Something s1 = ser.Deserialize<Something>(JSONString);
            //textBoxForecast.Text = s1;



        }
    }
}
