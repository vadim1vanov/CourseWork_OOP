using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Course_project
{
	/// <summary>
	/// Класс формы добавления книги в книгохранилище
	/// </summary>
	public partial class Add_Book : Form
	{
		/// <summary>
		/// поле названия книги
		/// </summary>
		public static string title = "";

		/// <summary>
		/// поле автора книги
		/// </summary>
		public static string author = "";
		/// <summary>
		/// поле жанра книги
		/// </summary>
		public static string genre = "";
		/// <summary>
		/// поле количества страниц
		/// </summary>
		public static int countPages = 0;
		/// <summary>
		/// поле года издания книги
		/// </summary>
		public static int productionYear = 0;

		
		/// <summary>
		/// Конструктор класса
		/// </summary>
		public Add_Book()
		{
			InitializeComponent();
		}


		/// <summary>
		/// Проверка  ввода названия книги
		/// </summary>
		/// <param name="tb">Поле ввода</param>
		bool CheckOnCorrectTitle(TextBox tb) => tb.Text != "" || 
			(tb.BackColor = Color.MistyRose) != Color.MistyRose;
        /// <summary>
        /// Проверка  ввода автора книги
        /// </summary>
        /// <param name="tb">Поле ввода</param>
        bool CheckOnCorrectAuthor(TextBox tb) => tb.Text != "" ||
            (tb.BackColor = Color.MistyRose) != Color.MistyRose;
        /// <summary>
        /// Проверка  ввода количества страниц книги
        /// </summary>
        /// <param name="tb">Поле ввода</param>
        bool CheckOnCorrectNumber(TextBox tb) => int.TryParse(tb.Text, out _) || 
			(tb.BackColor = Color.MistyRose) != Color.MistyRose;
        /// <summary>
        /// Проверка  ввода года выпуска книги
        /// </summary>
        /// <param name="tb">Поле ввода</param>
        bool CheckOnCorrectYear(TextBox tb) => Regex.IsMatch(tb.Text, @"\d{4}") ||
			(tb.BackColor = Color.MistyRose) != Color.MistyRose;
        /// <summary>
        /// Проверка  ввода жанра книги
        /// </summary>
        /// <param name="tb">Поле ввода</param>
        bool CheckOnCorrectGenre(TextBox tb) => tb.Text != "" ||
            (tb.BackColor = Color.MistyRose) != Color.MistyRose;

		/// <summary>
		/// Свойство для проверки корректности заполнения всех полей ввода
		/// </summary>
        bool FlagCorrect =>
			CheckOnCorrectTitle(tb_Title) &
			CheckOnCorrectAuthor(tb_Author) &
			CheckOnCorrectGenre(tb_Genre) &
			CheckOnCorrectNumber(tb_CountPages) &
			CheckOnCorrectYear(tb_ProductionYear);



        //void Control_Click(object sender, EventArgs e) => (sender as Control).BackColor = Color.WhiteSmoke;        -------------------------------


        /// <summary>
        ///  Кнопка добавления книги в базу
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void btn_Add_Click(object sender, EventArgs e)
		{
			if (FlagCorrect)
			{
				title = tb_Title.Text;
				author = tb_Author.Text;
				genre = tb_Genre.Text;
				countPages = Convert.ToInt32(tb_CountPages.Text);
				productionYear = Convert.ToInt32(tb_ProductionYear.Text);

				Close();
			}
			else
				MessageBox.Show($"Некорректные данные", "Добавление книги", 0, MessageBoxIcon.Information);
		}
        /// <summary>
        /// Кнопка выхода из формы добавления книги
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void btn_Back_Click(object sender, EventArgs e)
		{
			title = "";
			author = "";
			genre = "";
			countPages = 0;
			productionYear = 0;
			Close();
		}
	}
}
