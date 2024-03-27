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
    public partial class EditGroupForm : Form
    {
        public EditGroupForm()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm();
            addGroupForm.ShowDialog();
        }
        // Заполнение комбобокса номерами групп 
        public void FillComboBox()
        {
            DataBase dB = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `GroupNumber` FROM `group` ", dB.GetConnection());
            dB.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                List<int> list = new List<int>();
                while (reader.Read())
                {
                    list.Add(reader.GetInt32(0));
                }
                list.Distinct().ToArray(); // Удаляем повторяющиеся элементы
                GroupList.DataSource = list.Distinct().ToArray();


            }

        }
        // Метод для выбора студентов и добавления их в группу
        private void GroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentList.Items.Clear();
            DataBase dB = new DataBase();
            GroupList.Click += GroupList_SelectedIndexChanged;
            MySqlCommand command = new MySqlCommand("SELECT `UserSurname` FROM  `user` INNER JOIN `group` ON  user.idUser = group.Group_idUser WHERE `GroupNumber` = @G_N ", dB.GetConnection());
            command.Parameters.Add("@G_N", MySqlDbType.Int32).Value = GroupList.SelectedItem;
            dB.OpenConnection();
            using (MySqlDataReader myReader = command.ExecuteReader())
            {
                while (myReader.Read())
                {
                    StudentList.Items.Add(myReader.IsDBNull(myReader.GetOrdinal("UserSurname")) ? string.Empty : myReader["UserSurname"].ToString());
                }
                dB.CloseConnection();
            }
        }

    }
}
