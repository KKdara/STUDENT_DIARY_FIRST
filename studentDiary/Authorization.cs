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
    public partial class AuthorizationWindow : Form
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void AuthorizationStart_Click(object sender, EventArgs e)
        {
            string emailUser = EmailText.Text;
            string passwordUser = PasswordText.Text;
            DataBase db = new DataBase();
            DataTable dTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM 'user' WHERE 'UserEmail' = @lU AND 'UserPassword' = @pU", db.GetConnection());
            mySqlCommand.Parameters.Add("@lU", MySqlDbType.VarChar).Value = emailUser;
            mySqlCommand.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = mySqlCommand;
            adapter.Fill(dTable);

            db.OpenConnection();
            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                if(dTable.Rows.Count > 0)
                {
                    MessageBox.Show("Профиль успешно создан!");
                    while (reader.Read())
                    {
                        StudentProfile studentProfile = new StudentProfile(emailUser, passwordUser);
                        AdministratorProfile administratorProfile = new AdministratorProfile(emailUser, passwordUser);
                        if (reader.GetUInt32("UserRole") == 0)
                        {
                            studentProfile.Show();
                        }
                        else
                        {
                            administratorProfile.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Произошла ошибка. Пожалуйста, повторите позже");
                }
            }

            db.CloseConnection();
        }
    }
}
