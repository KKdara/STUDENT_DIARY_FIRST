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
    public partial class AdministratorProfile : Form
    {
        public AdministratorProfile()
        {
            InitializeComponent();
        }
        public AdministratorProfile(string login, string password)
        {
            InitializeComponent();
            InputInfoAdmin(login, password);
        }
        // Метод, который выполняется при вводе электронной почты(логина) и пароля
        private void InputInfoAdmin(string login, string password)
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
                    NameAdminProfileText.Text = reader.GetString("UserName");
                    SurnameAdminProfileText.Text = reader.GetString("UserSurname");
                    PatronymicAdminProfileText.Text = reader.GetString("UserPatronymic");
                    EmailAdminProfileText.Text = reader.GetString("UserEmail");
                    PhoneNumberAdminProfileText.Text = reader.GetString("UserTelephone");
                    RoleAdminText.Text = "Администратор";
                }

                dB.CloseConnection();
            }
        }
        // Метод для сохрения изменений в профиле

        private void SaveButtonAdminProfile_Click(object sender, EventArgs e)
        {
            if (NameAdminProfileText.Text == String.Empty && SurnameAdminProfileText.Text == String.Empty && PatronymicAdminProfileText.Text == String.Empty && EmailAdminProfileText.Text == String.Empty && PhoneNumberAdminProfileText.Text == String.Empty)
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }
            DataBase dB = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE `user` SET UserName = @nU, UserSurname = @sU, UserPatronymic = @pU, UserTelephone = @tU WHERE UserEmail = @eU", dB.GetConnection());
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = EmailAdminProfileText.Text;
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = NameAdminProfileText.Text;
            command.Parameters.Add("@sU", MySqlDbType.VarChar).Value = SurnameAdminProfileText.Text;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = PatronymicAdminProfileText.Text;
            command.Parameters.Add("@tU", MySqlDbType.VarChar).Value = PhoneNumberAdminProfileText.Text;

            dB.OpenConnection();
            command.ExecuteNonQuery();
            dB.CloseConnection();

            NameAdminProfileText.ReadOnly = true;
            SurnameAdminProfileText.ReadOnly = true;
            PatronymicAdminProfileText.ReadOnly = true;
            EmailAdminProfileText.ReadOnly = true;
            PhoneNumberAdminProfileText.ReadOnly = true;
            SaveInfoButton.Visible = false;
        }

        private void EditButtonAdminProfile_Click(object sender, EventArgs e)
        {
            NameAdminProfileText.ReadOnly = false;
            SurnameAdminProfileText.ReadOnly = false;
            PatronymicAdminProfileText.ReadOnly = false;
            PhoneNumberAdminProfileText.ReadOnly = false;
            SaveInfoButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditGroupForm editGroupForm = new EditGroupForm();
            editGroupForm.Show();
        }
    }
}
