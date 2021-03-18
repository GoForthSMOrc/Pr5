using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Practic5
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //Главное меню Кнопка Список статей//
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Articles.TextArticles as 'Статья', Conditions.NameConditions as 'Условия' FROM Articles JOIN Conditions ON Articles.id_Conditions = Conditions.Id_Conditions;";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                conn.Close();
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                MessageBox.Show("Подключение к БД прошло успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к БД");
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Главное меню Кнопка Добавить новую статью//
        private void EnterNewArticle_Click(object sender, EventArgs e)
        {
            Form2 Win = new Form2();
            Win.Show();
        }
        //Главное меню Кнопка Добавить нового пользователя//
        private void NewUser_Click(object sender, EventArgs e)
        {
            Form3 Win = new Form3();
            Win.Show();
        }
    }
}
