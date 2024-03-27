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
    public partial class RegistrationWindow : Form
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            StudentProfile profile = new StudentProfile();
            profile.CreateControl();
        }

        private int CheckRadioButton()
        {
            int valueRb;
            if (IAdminButton.Checked == true)
            {
                valueRb = 1;
            }
            else
            {
                valueRb = 0;
            }

            return valueRb;
        }
        // Проверка, существует ли пользователь с таким же логином
        protected Boolean CheckUser()
        {

            DataBase dB = new DataBase();
            DataTable dTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `user` WHERE `UserEmail` = @lU", dB.GetConnection());
            mySqlCommand.Parameters.Add("@lU", MySqlDbType.VarChar).Value = EmailText.Text;

            adapter.SelectCommand = mySqlCommand;
            adapter.Fill(dTable);

            if (dTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }
      
        // Метод для начала регистрации пользователя и внесения данных в БД
        private void RegistrationStart_Click_1(object sender, EventArgs e)
        {

            if (NameText.Text == String.Empty && SurnameText.Text == String.Empty && PatronymicText.Text == String.Empty && PhoneNumberText.Text == String.Empty && PasswordText.Text == String.Empty)
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }
            if (CheckUser())
            {
                return;
            }

            int count = 8;
            if (PasswordText.Text.Length < count && CheckPasswordText.Text.Length < count)
            {
                MessageBox.Show("Пароль должен содержать не менее 8 символов");
            }
            if (PasswordText.Text != CheckPasswordText.Text)
            {
                MessageBox.Show("Пароли должны совпадать");
            }

            DataBase dB = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`UserName`, `UserSurname`, `UserPatronymic`, `UserRole`, `UserEmail`, `UserTelephone`, `UserPassword`) VALUES (@nU, @sU, @pU, @r, @eU, @tU, @passU)", dB.GetConnection());
            command.Parameters.Add("@nU", MySqlDbType.VarChar).Value = NameText.Text;
            command.Parameters.Add("@sU", MySqlDbType.VarChar).Value = SurnameText.Text;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = PatronymicText.Text;
            command.Parameters.Add("@r", MySqlDbType.Int32).Value = CheckRadioButton();
            command.Parameters.Add("@eU", MySqlDbType.VarChar).Value = EmailText.Text;
            command.Parameters.Add("@tU", MySqlDbType.VarChar).Value = PhoneNumberText.Text;
            command.Parameters.Add("@passU", MySqlDbType.VarChar).Value = PasswordText.Text;


            dB.OpenConnection();
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            RegistrationWindow regWin = new RegistrationWindow();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Такой аккаунт уже существует");
                authorizationWindow.Show();
                regWin.Close();
            }
            else
            {
                MessageBox.Show("Возникла ошибка при создании аккаунта. Пожалуйста, попробуйте ещё раз.");
            }
            dB.CloseConnection();
        }
    }
}
