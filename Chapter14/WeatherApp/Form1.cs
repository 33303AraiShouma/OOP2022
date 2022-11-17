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
using Newtonsoft.Json;

namespace WeatherApp {
    public partial class Form1 : Form {

        List<string> list = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"areacode.csv",Encoding.GetEncoding("shift_jis"));
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    list.Add(line);
                    
                    

                }
            }
        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = list[cbRegion.SelectedIndex];
            string[] values = a.Split(',');
            var value = values[1];
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{value}.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
            tbWeatherInfo.Text = json.text;

        }
    }
 }
