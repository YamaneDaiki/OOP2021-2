﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sanpuru0823 {
    public partial class Form1 : Form {
            public Form1() {
                InitializeComponent();
            }

            private void Exec_Click(object sender, EventArgs e) {

            Result.Text = Math.Pow(int.Parse(Value.Text), 
                          int.Parse(Jou.Text)).ToString();
            }
        }
    }