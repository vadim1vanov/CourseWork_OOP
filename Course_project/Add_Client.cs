using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Course_project
{
    /// <summary>
    /// Класс формы добавления клиента
    /// </summary>
    public partial class Add_Client : Form
    {
        /// <summary>
        /// поле фамилии клиента
        /// </summary>
        public static string firstName = "";
        /// <summary>
        /// поле имени клиента
        /// </summary>
        public static string lastName = "";
        /// <summary>
        /// поле даты выдачи книги клиенту
        /// </summary>
        public static string date = "";
        /// <summary>
        /// поле крайнего срока сдачи книги
        /// </summary>
        public static string deadline = "";
        /// <summary>
        /// поле телефона клиента
        /// </summary>
        public static string phone = "";
        /// <summary>
        /// поле id книги
        /// </summary>
        public static int BookID = 0;
        /// <summary>
        /// поле состояния сдачи книги
        /// </summary>
        public static string isReturned = "";
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Add_Client()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка  ввода имени и фамилии клиента
        /// </summary>
        /// <param name="tb">Поле ввода</param>
        bool CheckOnCorrectName(TextBox tb) => Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]") || 
            (tb.BackColor = Color.MistyRose) != Color.MistyRose;
        /// <summary>
        /// Проверка  ввода даты выдачи книги
        /// </summary>
        /// <param name="tb">Поле ввода</param>
        bool CheckOnCorrectDate(TextBox tb) => DateTime.TryParse(tb.Text, out _) || 
            (tb.BackColor = Color.MistyRose) != Color.MistyRose;
        /// <summary>
        /// Проверка  ввода крайнего срока сдачи книги
        /// </summary>
        /// <param name="tb">Поле ввода</param>
        bool CheckOnCorrectDeadline(TextBox tb) => DateTime.TryParse(tb.Text, out _) ||
            (tb.BackColor = Color.MistyRose) != Color.MistyRose;
        /// <summary>
        /// Проверка  ввода телефона клиента
        /// </summary>
        /// <param name="tb">Поле ввода</param>
        bool CheckOnCorrectPhone(TextBox tb) => Regex.IsMatch(tb.Text, @"\d{9}") || 
            (tb.BackColor = Color.MistyRose) != Color.MistyRose;
        /// <summary>
        /// Проверка  ввода id книги
        /// </summary>
        /// <param name="tb">Поле ввода</param>
        bool CheckOnCorrectID(TextBox tb) => (int.TryParse(tb.Text, out _) || 
            (tb.BackColor = Color.MistyRose) != Color.MistyRose);
        /// <summary>
        /// Свойство для проверки корректности заполнения всех полей ввода
        /// </summary>
        bool FlagCorrect =>
            CheckOnCorrectName(tb_Name) &
            CheckOnCorrectName(tb_Surname) &
            CheckOnCorrectDate(tb_Date) &
            CheckOnCorrectDeadline(tb_Deadline) &
            CheckOnCorrectPhone(tb_Phone) &
            CheckOnCorrectID(tb_ID);

        // void Control_Click(object sender, EventArgs e){ (sender as Control).BackColor = Color.WhiteSmoke;}

        /// <summary>
        /// Кнопка добавления клиента в базу
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (FlagCorrect)
            {
                firstName = tb_Name.Text;
                lastName = tb_Surname.Text;
                date = tb_Date.Text;
                deadline = tb_Deadline.Text;
                phone = tb_Phone.Text;
                BookID = Convert.ToInt32(tb_ID.Text);
                isReturned = "Нет";
                if ((cb_IsReturned.CheckState).ToString() == "Checked") isReturned = "Да";

                Close();
            }
            else
                MessageBox.Show($"Некорректные данные", "Добавление клиента", 0, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Кнопка выхода из формы добавления клиента
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            firstName = "";
            lastName = "";
            date = "";
            deadline = "";
            phone = "";
            BookID = 0;
            isReturned = "";
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Add_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
