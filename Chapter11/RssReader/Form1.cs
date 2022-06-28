using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {

        IEnumerable<XElement> xNews;

        public Form1()
        {
            InitializeComponent();
        }

        private void btRssGet_Click(object sender, EventArgs e){
            using (var wc = new WebClient())
            {
                var stream = wc.OpenRead(cbRssUrl.Text);
                var xdoc = XDocument.Load(stream);
                xNews = xdoc.Root.Descendants("item");
                
                foreach (var titles in xNews)
                {
                    lbRssTitle.Items.Add((string)titles.Element("title"));
                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e){
            var index = lbRssTitle.SelectedIndex;//選択した箇所のインデックスを取得（０～
            wbBrowser.Navigate((string)xNews.ElementAt(index).Element("link"));
        }
    }
}
