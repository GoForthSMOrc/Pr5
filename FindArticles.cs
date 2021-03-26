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
    public partial class FindArticles : Form
    {
        public FindArticles()
        {
            InitializeComponent();
        }

        private void FindArticles_Load(object sender, EventArgs e)
        {

        }

        private void FindArticle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "SELECT Articles.TextArticles AS 'Статья', Articles.NameDate AS 'Дата' FROM Articles WHERE Articles.TextArticles = '"+ FindArticlesBox.Text + "';";
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
