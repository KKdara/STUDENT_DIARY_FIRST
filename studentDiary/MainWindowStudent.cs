using System;
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
    public partial class MainWindowStudent : Form
    {
        public MainWindowStudent()
        {
            InitializeComponent();
            Date.Text = DateTime.Now.ToString("dd.MM");
        }

        private void MainWindowButton_Click(object sender, EventArgs e)
        {
            MainWindowStudent mainWindowStudent = new MainWindowStudent();
            mainWindowStudent.Show();
        }

        private void StudentProfileButton_Click(object sender, EventArgs e)
        {
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();
        }
    }
}
