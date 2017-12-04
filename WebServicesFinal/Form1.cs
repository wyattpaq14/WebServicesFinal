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
        private string state;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetInformation_Click(object sender, EventArgs e)
        {

            //clear fields
            emptyFields();
            string locationAPIURL = "http://api.geonames.org/findNearbyPostalCodes?postalcode=" + txtZipCode.Text + "&country=US&radius=10&username=wyattpaq14&style=full";
            parseLocationAPI(locationAPIURL);

            //retreive zipcode from web service


            //retreive information from weather underground api
            string api_key = "80a756655790476a";
            string api_url = "http://api.wunderground.com/api/" + api_key + "/conditions/q/" + state + "/" + city + ".xml";


            //parse the weather xml into the fields
            parseWeatherAPI(api_url);
        }


        private void parseWeatherAPI(string input_xml)
        {

            var cli = new WebClient();
            string weather = cli.DownloadString(input_xml);

            using (XmlReader reader = XmlReader.Create(new StringReader(weather)))
            {
                // Parse the file and display each of the nodes.
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:

                            if (reader.Name.Equals("weather"))
                            {
                                reader.Read();
                                lblConditions.Text += reader.Value;
                            }
                            else if (reader.Name.Equals("observation_time"))
                            {
                                reader.Read();
                                lblObsTime.Text += reader.Value;
                            }
                            else if (reader.Name.Equals("temperature_string"))
                            {
                                reader.Read();
                                lblTempature.Text += reader.Value;
                            }
                            else if (reader.Name.Equals("relative_humidity"))
                            {
                                reader.Read();
                                lblHumidity.Text += reader.Value;
                            }
                            else if (reader.Name.Equals("pressure_mb"))
                            {
                                reader.Read();
                                lblPressure.Text += reader.Value;
                            }
                            else if (reader.Name.Equals("visibility_km"))
                            {
                                reader.Read();
                                lblVisiability.Text += reader.Value + " KM";
                            }
                            else if (reader.Name.Equals("latitude"))
                            {
                                reader.Read();
                                lblLatitude.Text += reader.Value;
                            }
                            else if (reader.Name.Equals("longitude"))
                            {
                                reader.Read();
                                lblLongitude.Text += reader.Value;
                            }

                            break;

                            
                    }
                }
            }
        }

        private void parseLocationAPI(string input_xml)
        {

            var cli = new WebClient();
            string weather = cli.DownloadString(input_xml);

            using (XmlReader reader = XmlReader.Create(new StringReader(weather)))
            {
                // Parse the file and display each of the nodes.
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:

                            if (reader.Name.Equals("name"))
                            {
                                reader.Read();
                                city= reader.Value;
                            }
                            else if (reader.Name.Equals("adminName1"))
                            {
                                reader.Read();
                                state= reader.Value;
                            }

                            break;
                    }
                }
            }
        }

        private void emptyFields()
        {
            lblConditions.Text = "Conditions: ";
            lblHumidity.Text = "Humidity: ";
            lblLatitude.Text = "Latitude: ";
            lblLocation.Text = "Location: ";
            lblLongitude.Text = "Longitude: ";
            lblObsTime.Text = "Observation Time: ";
            lblPressure.Text = "Pressure: ";
            lblTempature.Text = "Tempature: ";
            lblVisiability.Text = "Visiability: ";
        }
    }
}
