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
            listView1.Items.Clear();
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

        private void FindArticles_Click(object sender, EventArgs e)
        {
            FindArticles Win = new FindArticles();
            Win.Show();
            listView1.Items.Clear();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            /*
             using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace TestPrintProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // текст для печати
        private string result = "";

        // обработчик события нажатия на кнопку Печать
        private void printButton_Click(object sender, EventArgs e)
        {
            // задаем текст для печати
            result = "Строка 1\n\n";

            result += "Строка 2\nСтрока 3";

            // объект для печати
            PrintDocument printDocument = new PrintDocument();

            // обработчик события печати
            printDocument.PrintPage += PrintPageHandler;

            // диалог настройки печати
            PrintDialog printDialog = new PrintDialog();

            // установка объекта печати для его настройки
            printDialog.Document = printDocument;

            // если в диалоге было нажато ОК
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print(); // печатаем
        }

        // обработчик события печати
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // печать строки result
            e.Graphics.DrawString(result, new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}
            */
        }
    }
}
