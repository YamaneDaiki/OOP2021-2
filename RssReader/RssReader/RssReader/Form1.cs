using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        List<string> rink = new List<string>();
        List<string> desc = new List<string>();

        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            setRssTitle(tbUrl.Text);
        }

        //指定したURL先からXMLデータを取得し、リストボックスへセットする。
        private void setRssTitle(string Uri) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type" , "charset=UTF-8");

                var Url = new Uri(Uri);
                var stream = wc.OpenRead(Url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("item");
                foreach (var node in nodes) {
                    ibTitles.Items.Add(node.Element("title").Value);
                    rink.Add(node.Element("link").Value);
                    desc.Add(node.Element("description").Value);


                }


            }
        }

        private void ibTitles_Click(object sender, EventArgs e) {
            var num = ibTitles.SelectedIndex;
            ladesc.Text = desc[ num ];
            wbBrowser.Url = new Uri(rink[num]);
        }

 
    }
}
