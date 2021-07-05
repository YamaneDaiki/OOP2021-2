using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        //時間計測のストップウォッチオブジェクト
        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            TimerLabel.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\,ff");
        }

        private void StartButton_Click(object sender, EventArgs e) {
            Timer tm = new Timer();
            tm.Tick += Tm_Tick;
            tm.Interval = 1000;
            tm.Start();
        }

        private void Tm_Tick(object sender, EventArgs e) {
            //TimerLabel.Text = 
        }
    }
}
