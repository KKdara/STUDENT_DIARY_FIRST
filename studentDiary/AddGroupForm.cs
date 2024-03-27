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
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
            StudentsWhoAreNotInTheGroup();
        }
        // Метод для получения списка студентов, которые не входят в группу
        public void StudentsWhoAreNotInTheGroup()
        {
            DataBase dB = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `UserSurname`, `idUser` FROM `user` WHERE `InTheGroupOrNot` = @n AND `UserRole` = @r", dB.GetConnection());
            command.Parameters.Add("@n", MySqlDbType.Int32).Value = 0;
            command.Parameters.Add("@r", MySqlDbType.Int32).Value = 0;
            dB.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    StudentsListText.Rows.Add(reader.GetInt32("idUser"), reader.GetString("UserSurname"));
                }
                dB.CloseConnection();
            }
        }
        private void AddGroupButton_Click(object sender, System.EventArgs e)
        {
            int v;
            if (int.TryParse(GroupNumberText.Text, out v))
            {
                DataBase dB = new DataBase();
                dB.OpenConnection();
                MySqlCommand command = new MySqlCommand("INSERT INTO `group` (`Group_idUser`,`GroupNumber`) VALUES (@Gid, @Gn)", dB.GetConnection());
                MySqlCommand command2 = new MySqlCommand("UPDATE `user` SET InTheGroupOrNot = @InTG WHERE `idUser` = @Gid2", dB.GetConnection());

                command.Parameters.Add("@Gn", MySqlDbType.VarChar);
                command.Parameters.Add("@Gid", MySqlDbType.VarChar);
                command2.Parameters.Add("@InTG", MySqlDbType.Int32);
                command2.Parameters.Add("@Gid2", MySqlDbType.VarChar);
                for (int i = 0; i < AddedStudentsText.RowCount - 1; i++)
                {
                    command.Parameters["@Gn"].Value = GroupNumberText.Text;
                    command.Parameters["@Gid"].Value = AddedStudentsText.Rows[i].Cells[0].Value.ToString();
                    command.ExecuteNonQuery();

                    command2.Parameters["@Gid2"].Value = AddedStudentsText.Rows[i].Cells[0].Value.ToString();
                    command2.Parameters["@InTG"].Value = 1;
                    command2.ExecuteNonQuery();

                }
                if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Группа создана");
                }
                else
                {
                    MessageBox.Show("Произошла ошибка. Не удалось создать группу");
                }
                dB.CloseConnection();

            }
            else
            {
                MessageBox.Show("Некорректный ввод группы");
                return;
            }

        }
    }
}
