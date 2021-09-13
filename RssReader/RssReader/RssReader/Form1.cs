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
        IEnumerable<ItemDate> items = null;

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
                items = xdoc.Root.Descendants("item").Select(x => new ItemDate {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("description")
                });

                foreach (var item in items) {
                    ibTitles.Items.Add(item.Title);
                }



            }
        }

        private void ibTitles_Click(object sender, EventArgs e) {
            var num = ibTitles.SelectedIndex;
            string rink = (items.ToArray())[ibTitles.SelectedIndex].Link;
            string description = (items.ToArray())[ibTitles.SelectedIndex].Description;
            DateTime day = (items.ToArray())[ibTitles.SelectedIndex].PubDate;
            ladesc.Text = description;
            laday.Text = day.ToString("yyyy MM dd  hh時mm分ss秒");
        }

        private void btweb_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.weba(items.ToArray()[ibTitles.SelectedIndex].Link);
            form2.Show();
        }
    }
}
