using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WebServicesFinal
{
    public partial class Form1 : Form
    {
        private string city;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInformation_Click(object sender, EventArgs e)
        {

            //clear fields
            emptyFields();
            string gApiKey = "AIzaSyDE9AfikwP8gXADdMP6xx5-ymF5YyheqWg";
            string locationAPIURL = "https://maps.googleapis.com/maps/api/geocode/xml?address=" + txtZipCode.Text + "&key=" + gApiKey;
            googleApiRequest(locationAPIURL);

            //retreive zipcode from web service


            //retreive information from weather openweathermap api
            string api_key = "34f231179584a91c051c06c2aa6698df";

            string openWeatherMapAPIURL = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&appid=" + api_key + "&mode=xml&units=imperial";


            //parse the weather xml into the fields
            //parseWeatherAPI(openWeatherMapAPIURL);
            owmApiRequest(openWeatherMapAPIURL);
        }

        private void googleApiRequest(string input_url)
        {
            WebClient client = new WebClient();
            string xml = client.DownloadString(input_url);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            lblLocation.Text += doc.DocumentElement.SelectSingleNode("result/formatted_address").InnerXml;
            city = doc.DocumentElement.SelectSingleNode("result/address_component[2]/long_name").InnerXml;

        }


        private void owmApiRequest(string input_url)
        {
            WebClient client = new WebClient();
            string xml = client.DownloadString(input_url);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            lblTempature.Text += doc.DocumentElement.SelectSingleNode("temperature").Attributes["value"].Value + " Fahrenheit";
            lblPressure.Text += doc.DocumentElement.SelectSingleNode("pressure").Attributes["value"].Value + " hPa";
            lblHumidity.Text += doc.DocumentElement.SelectSingleNode("humidity").Attributes["value"].Value + "%";
            lblWind.Text += doc.DocumentElement.SelectSingleNode("wind/speed").Attributes["name"].Value;
            lblConditions.Text += doc.DocumentElement.SelectSingleNode("weather").Attributes["value"].Value;
            lblSunRise.Text += doc.DocumentElement.SelectSingleNode("city/sun").Attributes["rise"].Value;
            lblSunSet.Text += doc.DocumentElement.SelectSingleNode("city/sun").Attributes["set"].Value;
            lblLongitude.Text += doc.DocumentElement.SelectSingleNode("city/coord").Attributes["lon"].Value;
            lblLatitude.Text += doc.DocumentElement.SelectSingleNode("city/coord").Attributes["lat"].Value;

        }




        private void emptyFields()
        {
            lblWind.Text = "Wind Speed: ";
            lblHumidity.Text = "Humidity: ";
            lblLatitude.Text = "Latitude: ";
            lblLocation.Text = "Location: ";
            lblLongitude.Text = "Longitude: ";
            lblSunSet.Text = "Sun Set: ";
            lblPressure.Text = "Pressure: ";
            lblTempature.Text = "Tempature: ";
            lblConditions.Text = "Conditions: ";
            lblSunRise.Text = "Sun Rise: ";
        }
    }
}
