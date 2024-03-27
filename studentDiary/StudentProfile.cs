using MySql.Data.MySqlClient;
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
    public partial class StudentProfile : Form
    {
        string OldEmail { get; set; }
        public StudentProfile()
        {
            InitializeComponent();
        }
        public StudentProfile(string login, string password)
        {
            InitializeComponent();
            InputInfoStudent(login, password);
        }

        private void InputInfoStudent(string login, string password)
        {
            DataBase dB = new DataBase();
            DataTable dTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `user` WHERE `UserEmail` = @lU AND `UserPassword` = @pU", dB.GetConnection());
            mySqlCommand.Parameters.Add("@lU", MySqlDbType.VarChar).Value = login;
            mySqlCommand.Parameters.Add("@pU", MySqlDbType.VarChar).Value = password;
            dB.OpenConnection();
            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    NameStudentProfileText.Text = reader.GetString("UserName");
                    SurnameStudentProfileText.Text = reader.GetString("UserSurname");
                    PatronymicStudentProfileText.Text = reader.GetString("UserPatronymic");
                    EmailStudentProfileText.Text = reader.GetString("UserEmail");
                    PhoneNumberStudentProfileText.Text = reader.GetString("UserTelephone");
                    RoleStudentText.Text = "Студент";
                }

                dB.CloseConnection();
            }
        }

        private void StudentProfileButton_Click(object sender, EventArgs e)
        {
            StudentProfile studentProfile = new StudentProfile();
            studentProfile.Show();
        }
        private void MainWindowButton_Click(object sender, EventArgs e)
        {
            MainWindowStudent mainWindowStudent = new MainWindowStudent();
            mainWindowStudent.Show();
        }

        private void EditButtonStudentProfile_Click(object sender, EventArgs e)
        {
            NameStudentProfileText.ReadOnly = false;
            SurnameStudentProfileText.ReadOnly = false;
            PatronymicStudentProfileText.ReadOnly = false;
            PhoneNumberStudentProfileText.ReadOnly = false;
            SaveInfoButton.Visible = true;
        }

        private void SaveInfoButton_Click(object sender, EventArgs e)
        {
            if (NameStudentProfileText.Text == String.Empty && SurnameStudentProfileText.Text == String.Empty && PatronymicStudentProfileText.Text == String.Empty && EmailStudentProfileText.Text == String.Empty && PhoneNumberStudentProfileText.Text == String.Empty)
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }
            DataBase dB = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET UserName = @nU, UserSurname = @sU, UserPatronymic = @pU, UserTelephone = @tU WHERE UserEmail = @eU", dB.GetConnection());
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = EmailStudentProfileText.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = NameStudentProfileText.Text;
            command.Parameters.Add("@sU", MySqlDbType.VarChar).Value = SurnameStudentProfileText.Text;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = PatronymicStudentProfileText.Text;
            command.Parameters.Add("@tU", MySqlDbType.VarChar).Value = PhoneNumberStudentProfileText.Text;

            dB.OpenConnection();
            command.ExecuteNonQuery();
            dB.CloseConnection();

            NameStudentProfileText.ReadOnly = true;
            SurnameStudentProfileText.ReadOnly = true;
            PatronymicStudentProfileText.ReadOnly = true;
            EmailStudentProfileText.ReadOnly = true;
            PhoneNumberStudentProfileText.ReadOnly = true;
            SaveInfoButton.Visible = false;
        }

        private void ScheduleStudentProfile_Click(object sender, EventArgs e)
        {
            StudentScheduleWindow studentSchedule = new StudentScheduleWindow();
            studentSchedule.Show();
        }

        private void GradeStudentProfile_Click(object sender, EventArgs e)
        {
            MarksTableStudent marksTableStudent = new MarksTableStudent();
            marksTableStudent.Show();
        }
    }
}
