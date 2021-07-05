using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            var today = new DateTime((int)nudYear.Value, (int)nudMonth.Value, (int)nudDay.Value);
            DayOfWeek dayOfWeek = picka.Value.DayOfWeek;

            string dow = "";
            //曜日
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
            }
            tbOutput.Text = dow + "です";

            //閏年判定
            var isLeapYear = DateTime.IsLeapYear((int)nudYear.Value);
            if (isLeapYear) {
                tbLeapYear.Text = "閏年です";
            } else {
                tbLeapYear.Text = "閏年ではありません";
            }

            var date1 = new DateTime(2009, 10, 22, 1, 30, 20);
            var date2 = DateTime.Today;

            //tbOutput.Text = DateTime.Today.DayOfYear.ToString();
            var birthday = today;
            var targetDay = date2;
            //tbAge.Text = GetAge(birthday, targetDay).ToString();

            var age = date2.Year - picka.Value.Year;
            tbAge.Text = age.ToString();
        }
        //年齢を求めるメソッド
        public static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}

