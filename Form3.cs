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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Новый пользователь Кнопка Добавить//
        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO UsersDB(Login,Password) values('" + NewLogin.Text + "','" + Password.Text + "');";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Новый пользователь Функция создания случайного пароля//
        static string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        static Random r = new Random();

        static string GetRandom(string type)
        {
            string Result = "";
            if (type == "Password")
            {
                for (int i = 0; i < 5; i++)
                {
                    var index = r.Next(symbols.Length);
                    Result += symbols[index];
                }

            }
            return Result;
        }
        //Новый пользователь Кнопка обновить//
        private void button1_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.Text = GetRandom(Password.Name.ToString());
        }

        private void NewLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
