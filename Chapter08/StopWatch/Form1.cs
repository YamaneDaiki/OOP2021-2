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
        Timer tm = new Timer();
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            TimerLabel.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\,ff");
        }

        private void StartButton_Click(object sender, EventArgs e) {
            tm.Start();
            tm.Tick += Tm_Tick;
        }

        private void Tm_Tick(object sender, EventArgs e) {
            sw.Start();
            TimerLabel.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\,ff");
        }

        private void StopButton_Click(object sender, EventArgs e) {
            tm.Stop();
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            sw.Reset();
            tm.Stop();
            TimerLabel.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\,ff");
            listBox1.Items.Clear(); 
        }

        private void RapButton_Click(object sender, EventArgs e) {
            listBox1.Items.Insert(0, TimerLabel.Text);
        }

     
    }
}
