using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;

            tbDaytDisp.Text = string.Format("{0:yyyy/M/d HH:mm}", today) + "\r\n";
            tbDaytDisp.Text += today.ToString("yyyy年MM月dd日 HH時mm分ss秒") + "\r\n";

            var calture = new CultureInfo("ja-JP");
            calture.DateTimeFormat.Calendar = new JapaneseCalendar();
            //tbDaytDisp.Text = today.ToString("d");
            tbDaytDisp.Text += today.ToString("ggyy年　M月d日(dddd)",calture);
        }

        private void Form1_Load(object sender, EventArgs e) {
            Timer tm = new Timer();
            tm.Tick += Tm_Tick;
            tm.Interval = 1000;
            tm.Start();
            
        }

        private void Tm_Tick(object sender, EventArgs e) {
            tssTimeLabel.Text = DateTime.Now.ToString();
        }
    }
}
