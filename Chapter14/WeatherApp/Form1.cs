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
        public Form1()
        {
            InitializeComponent();
        }

        private void btWeatherGet_Click(object sender, EventArgs e) {
            var wc = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            var dString = wc.DownloadString("https://www.jma.go.jp/bosai/common/const/area.json");

            var json = JsonConvert.DeserializeObject<Rootobject>(dString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"areacode.csv",System.Text.Encoding.GetEncoding("shift_jis"));
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] values = line.Split(',');
                    List<string> lists = new List<string>();
                    lists.AddRange(values);
                    
                    foreach (var item in lists)
                    {
                        
                        cbRegion.Items.Add(item);
                    }

                }
            }
        }
    }
 }
