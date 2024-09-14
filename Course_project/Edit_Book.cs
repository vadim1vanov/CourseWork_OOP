using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Course_project
{
	/// <summary>
	/// Класс формы редактирования книги
	/// </summary>
	public partial class Edit_Book : Form
	{
		/// <summary>
		/// поле названия книги
		/// </summary>
		public static string Title = "";
		/// <summary>
		/// поле автора книги
		/// </summary>
		public static string Author = "";
		/// <summary>
		/// поле жанра книги
		/// </summary>
		public static string Genre = "";
		/// <summary>
		/// поле количества страниц в книге
		/// </summary>
		public static int CountPages = 0;
		/// <summary>
		/// поле года издания книги
		/// </summary>
		public static int ProductionYear = 0;

		/// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		/// <param name="title">название</param>
		/// <param name="author">автор</param>
		/// <param name="genre">жанр</param>
		/// <param name="countPages">количество страниц</param>
		/// <param name="productionYear">год издания</param>
		/// <param name="bookID">id книги</param>
		public Edit_Book(string title, string author, string genre, int countPages, int productionYear,  int bookID)
		{
			InitializeComponent();
			Title = title;
			Author = author;
			Genre = genre;
			CountPages = countPages;
			ProductionYear = productionYear;


			label1.Text = $"Текущая книга (ID: {bookID})";
			tb_Title.Text = title;
			tb_Author.Text = author;
			tb_Genre.Text = genre.ToString();
			tb_CountPages.Text = countPages.ToString();
			tb_ProductionYear.Text = productionYear.ToString();
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


        //void Control_Click(object sender, EventArgs e) => (sender as Control).BackColor = Color.WhiteSmoke;

        /// <summary>
        ///  Кнопка добавления книги в базу
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void btn_Add_Click(object sender, EventArgs e)
		{

			if (FlagCorrect)
			{
				Title = tb_Title.Text;
				Author = tb_Author.Text;
				Genre = tb_Genre.Text;
				CountPages = Convert.ToInt32(tb_CountPages.Text);
				ProductionYear = Convert.ToInt32(tb_ProductionYear.Text);

				Close();
			}
			else
				MessageBox.Show($"Некорректные данные", "Редактирование книги", 0, MessageBoxIcon.Information);
		}
        /// <summary>
        /// Кнопка выхода из формы добавления книги
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void btn_Back_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
