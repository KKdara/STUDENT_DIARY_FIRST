﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentDiary
{
    public partial class StudentScheduleWindow : Form
    {
        public StudentScheduleWindow()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MainWindowStudent mainWindowStudent = new MainWindowStudent();
            mainWindowStudent.Show();
        }
    }
}
