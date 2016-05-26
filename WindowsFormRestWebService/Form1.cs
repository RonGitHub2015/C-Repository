using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;

namespace RESTService
{
    public partial class Form1 : Form
    {
        // Holds all of the weather data.
        XDocument GetData;

        // Contains just the forecast.
        IEnumerable<XElement> Forecast;

        // Specifies which forecast to use.
        Int32 ForecastNumber;

        // Defines the maximum number of forecasts.
        Int32 MaxForecasts;

        // Contains a list of icons associated with the forecast.
        IEnumerable<XElement> Icons;

        // Specifies which icon to use.
        Int32 IconNumber;

        public Form1()
        {
            InitializeComponent();

            // Obtain the forecast.
            GetForecast();

            // Display the forecast data.
            DisplayData(ForecastNumber);
        }

        public void GetForecast()
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
                    GetData =
                        XDocument.Load(
                            "http://api.wunderground.com/auto/wui/geo/ForecastXML/index.xml?query="
                            + txtLocation.Text);

                    //http://api.wunderground.com/auto/wui/geo/ForecastXML/index.xml?query=CA/San_Francisco

                    // End the loop.
                    TryAgain = DialogResult.No;
                }
                catch (WebException WE)
                {
                    TryAgain = MessageBox.Show(
                        "Couldn't obtain the weather data!\r\nTry Again?",
                        "Data Download Error",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Error);
                }
            }

            // Obtain all the forecasts.
            Forecast = 
                GetData.Element("forecast").Element("txt_forecast").Elements("forecastday");

            // Define the maximum number of forecasts.
            MaxForecasts = Forecast.Count() - 1;

            // Specify which forecast to use.
            ForecastNumber = 0;

            // Specify which icon to use.
            IconNumber = 0;

            // Reset the buttons.
            btnNext.Enabled = true;
            btnPrevious.Enabled = false;
        }

        public void DisplayData(Int32 FNumber)
        {
            // Display the title of the current forecast.
            txtTitle.Text = Forecast.ElementAt(FNumber).Element("title").Value;

            // Display detailed forecast information.
            txtForecast.Text = Forecast.ElementAt(FNumber).Element("fcttext").Value;

            // Obtain a list of icons associated with the forecast.
            Icons = Forecast.ElementAt(FNumber).Element("icons").Elements("icon_set");

            // Define the maximum number of available icons.
            IconSelect.Maximum = Icons.Count() - 1;

            // Display the icon on screen.
            wbIcon.Url = new Uri(Icons.ElementAt(IconNumber).Element("icon_url").Value);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            // End the program.
            Close();
        }

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

        private void IconSelect_ValueChanged(object sender, EventArgs e)
        {
            // Set the icon value to the value of the up/down control.
            IconNumber = (Int32)IconSelect.Value;

            // Display the information.
            DisplayData(ForecastNumber);
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            // Obtain the forecast.
            GetForecast();

            // Verify that there are forecasts to process.
            if (Forecast.Count() == 0)

                // If not, display an error message.
                MessageBox.Show(
                    "No weather data available for location!",
                    "Data Download Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);


            // Otherwise, display the forecast data.
            else
                DisplayData(ForecastNumber);
        }

        private void txtLocation_KeyDown(object sender, KeyEventArgs e)
        {
            // Detect pressing of the Enter key.
            if (e.KeyCode == Keys.Enter)
            {
                // Obtain the forecast.
                GetForecast();

                // Verify that there are forecasts to process.
                if (Forecast.Count() == 0)

                    // If not, display an error message.
                    MessageBox.Show(
                        "No weather data available for location!",
                        "Data Download Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);


                // Otherwise, display the forecast data.
                else
                    DisplayData(ForecastNumber);
            }
        }
    }
}
