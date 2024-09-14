using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Course_project
{

    /// <summary>
    /// Класс формы работы с книгохранилищем
    /// </summary>
    public partial class Books : Form
    {
        /// <summary>
        /// Константа, содержащая имя json-файла с информацией по книгам
        /// </summary>
        const string FILE_BOOKS = "Books.json";
        /// <summary>
        /// Константа, содержащая имя json-файла с информацией по клиентам
        /// </summary>
        const string FILE_CLIENTS = "Clients.json";
        /// <summary>
        /// поле для хранения номера строки
        /// </summary>
        int number = 0;
        /// <summary>
        /// поле для хранения количества книг
        /// </summary>
        int n_books = 0;
        /// <summary>
        /// поле id книги 
        /// </summary>
        int ID = 1;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Books()
        {
            Task.Run(() => File.Open(FILE_BOOKS, FileMode.OpenOrCreate).Close());
            Task.Run(() => File.Open(FILE_CLIENTS, FileMode.OpenOrCreate).Close());

            InitializeComponent();
        }

        /// <summary>
        /// Отображение всех книг из книгохранилища
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        async void Books_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_BOOKS))
            {
                var table_of_books = await ReadFromFile<InfoBooks>(FILE_BOOKS);

                n_books = table_of_books.Count;
                count_of_books.Text = Convert.ToString(n_books);

                if (table_of_books.Count != 0)
                {
                    foreach (var book in table_of_books)
                    {
                        Print(book);
                        if (ID == book.BookID) ID++;
                    }
                }
            }
        }

        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <typeparam name="T">Тип</typeparam>
        /// <param name="data">Имя списка</param>
        /// <param name="FILE_NAME">Имя файла, в который записывается</param>
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false)) 
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }
        /// <summary>
        /// Чтение из файла
        /// </summary>
        /// <typeparam name="T">Тип</typeparam>
        /// <param name="FILE_NAME">Имя файла, в который записывается</param>
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () => JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

       //void Control_Click(object sender, EventArgs e) => (sender as Control).BackColor = Color.White;

        /// <summary>
        /// Кнопка открытия формы добавления книги
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void btn_Add_Click(object sender, EventArgs e)
        { 
            btn_Reset_Click(sender, e);
            Add_Book FormAdd = new Add_Book();
            FormAdd.ShowDialog();

            string title = Add_Book.title;
            string author = Add_Book.author;
            string genre = Add_Book.genre;
            int countPages = Add_Book.countPages;
            int productionYear = Add_Book.productionYear;

            int BookID = ID;
             
            InfoBooks newBook = new InfoBooks(title, author, genre, countPages, productionYear, BookID);

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(genre) && (countPages > 0)
            && (productionYear > 0) && (BookID > 0))
            {
                var books = await ReadFromFile<InfoBooks>(FILE_BOOKS);

                if (!books.Contains(newBook))
                {
                    books.Add(newBook);

                    n_books = books.Count;
                    count_of_books.Text = Convert.ToString(n_books);
                    ID++;

                    books.Sort();

                    await WriteToFile(books, FILE_BOOKS);

                    Print(newBook);
                }
                else
                {
                    MessageBox.Show($"Данная книга уже есть в базе данных", 
                        "Добавление книги", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        /// <summary>
        /// Кнопка удаления книги
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        async void btn_Remove_Click(object sender, EventArgs e)
        {
            var Items = dataGridView1.SelectedRows;
            int selectCount = Items.Count;

            if (selectCount > 0)
            {
                var books = await ReadFromFile<InfoBooks>(FILE_BOOKS);
                var clients = await ReadFromFile<InfoClients>(FILE_CLIENTS);

                foreach (var item in Items)
                {
                    int ID = Convert.ToInt32(((DataGridViewRow)item).Cells[0].Value);

                    foreach (var book in books)
                    {
                        if (ID == book.BookID)
                        {
                            bool check = true;

                            foreach (var cl in clients)
                            {
                                if (ID == cl.BookID)
                                {
                                    MessageBox.Show($"Удаление невозможно, данная книга сдана клиенту",
                                        "Удаление книги", 0, MessageBoxIcon.Information);
                                    check = false;
                                    break;
                                }
                            }
                            if (check)
                            {
                                books.Remove(book);
                                n_books = books.Count;
                                count_of_books.Text = Convert.ToString(n_books);
                                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                                number--;
                                MessageBox.Show($"Книга <{book.Title}> удалена",
                                    "Удаление книги", 0, MessageBoxIcon.Information);
                                break;
                            }
                        }
                    }
                }
                
                await WriteToFile(books, FILE_BOOKS);
            }
            else
            {
                MessageBox.Show("Выберите книгу для удаления", "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        /// <summary>
        /// Вывод всех строчек с информацией о каждой книге
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        bool Print(InfoBooks book)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[number].Cells[0].Value = book.BookID;
            dataGridView1.Rows[number].Cells[1].Value = book.Title;
            dataGridView1.Rows[number].Cells[2].Value = book.Author;
            dataGridView1.Rows[number].Cells[3].Value = book.Genre;
            dataGridView1.Rows[number].Cells[4].Value = book.CountPages;
            dataGridView1.Rows[number].Cells[5].Value = book.ProductionYear;
            number++;
            return true;
        }

        /// <summary>
        /// Фильтрация книг по заданному критерию
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        async void btn_filter_Click(object sender, EventArgs e)
        {
              if (comboBox1.SelectedItem is null)
            {
                MessageBox.Show("Выберите фильтр", "Фильтрация", 0, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Заполните поле", "Фильтрация", 0, MessageBoxIcon.Information);
                textBox1.BackColor = Color.MistyRose;
            }
            else
            {
                textBox1.BackColor = Color.White;
                string filter = textBox1.Text;
                int fil;

                textBox2.Text = "";
                dataGridView1.Rows.Clear();
                number = 0;

                bool flag = false;
                var books = await ReadFromFile<InfoBooks>(FILE_BOOKS);

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        foreach (var book in books)
                            if (book.Title == Convert.ToString(filter))
                                flag = Print(book);

                        if (flag == false)
                            MessageBox.Show($"Книги с названием '{filter}' не найдены, проверьте правильность ввода",
                                "Фильтрация", 0, MessageBoxIcon.Information);
                        break;
                    case 1:
                        foreach (var book in books)
                            if (book.Author == Convert.ToString(filter))
                                flag = Print(book);

                        if (flag == false)
                            MessageBox.Show($"Книги с автором '{filter}' не найдены, проверьте правильность ввода",
                                "Фильтрация", 0, MessageBoxIcon.Information);
                        break;
                    case 2:
                            foreach (var book in books)
                                if (book.Genre == Convert.ToString(filter))
                                    flag = Print(book);
                            if (flag == false)
                                MessageBox.Show($"Книги жанра '{filter}' не найдены, " +
                                    $"проверьте правильность ввода",
                                    "Фильтрация", 0, MessageBoxIcon.Information);
                        
                        break;
                    
                    case 3:
                        if (int.TryParse(filter, out fil) && fil > 0)
                        {
                            foreach (var book in books)
                                if (book.CountPages < fil)
                                    flag = Print(book);

                            if (flag == false)
                                MessageBox.Show($"Книги с количеством страниц до {filter} не найдены, " +
                                    $"проверьте правильность ввода",
                                    "Фильтрация", 0, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show($"Некорректные данные",
                                    "Фильтрация", 0, MessageBoxIcon.Information);
                        break;
                    case 4:
                        if (int.TryParse(filter, out fil) && fil > 0)
                        {
                            foreach (var book in books)
                                if (book.CountPages >= fil)
                                    flag = Print(book);

                            if (flag == false)
                                MessageBox.Show($"Книги с количеством страниц от {filter} не найдены, " +
                                    $"проверьте правильность ввода",
                                    "Фильтрация", 0, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show($"Некорректные данные",
                                    "Фильтрация", 0, MessageBoxIcon.Information);
                        break;
                    case 5:
                        if (int.TryParse(filter, out fil) && fil > 0)
                        {
                            foreach (var book in books)
                                if (book.ProductionYear < fil)
                                    flag = Print(book);

                            if (flag == false)
                                MessageBox.Show($"Книги изданные до {filter} года не найдены, " +
                                    $"проверьте правильность ввода",
                                    "Фильтрация", 0, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show($"Некорректные данные",
                                    "Фильтрация", 0, MessageBoxIcon.Information);
                        break;
                    case 6:
                        if (int.TryParse(filter, out fil) && fil > 0)
                        {
                            foreach (var book in books)
                                if (book.ProductionYear >= fil)
                                    flag = Print(book);

                            if (flag == false)
                                MessageBox.Show($"Книги изданные с {filter} года не найдены, " +
                                    $"проверьте правильность ввода",
                                    "Фильтрация", 0, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show($"Некорректные данные",
                                    "Фильтрация", 0, MessageBoxIcon.Information);
                        break;

                }
                count_of_books.Text = Convert.ToString(dataGridView1.RowCount);
                label_Filter.Visible = true;
            }
        }
        /// <summary>
        /// Поиск книги по заданному id
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            dataGridView1.ClearSelection();

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Заполните поле", "Поиск", 0, MessageBoxIcon.Information);
                textBox2.BackColor = Color.MistyRose;
            }
            else
            {
                textBox2.BackColor = Color.White;
                if (int.TryParse(textBox2.Text, out int fil))
                {
                    bool flag = false;
                    var Items = dataGridView1.Rows;

                    foreach (var item in Items)
                        if (Convert.ToInt32(((DataGridViewRow)item).Cells[0].Value) == fil)
                        {
                            ((DataGridViewRow)item).Selected = true;
                            flag = true;
                        }

                    if (flag == false)
                        MessageBox.Show($"Книги с ID {fil} не найдены, " +
                            $"проверьте правильность ввода",
                            "Поиск", 0, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show($"Некорректные данные",
                            "Поиск", 0, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Сброс всех фильтров
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        async void btn_Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label_Filter.Visible = false;
            dataGridView1.Rows.Clear();
            comboBox1.SelectedIndex = -1;
            number = 0;

            var books = await ReadFromFile<InfoBooks>(FILE_BOOKS);

            foreach (var book in books)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[number].Cells[0].Value = book.BookID;
                dataGridView1.Rows[number].Cells[1].Value = book.Title;
                dataGridView1.Rows[number].Cells[2].Value = book.Author;
                dataGridView1.Rows[number].Cells[3].Value = book.Genre;
                dataGridView1.Rows[number].Cells[4].Value = book.CountPages;
                dataGridView1.Rows[number].Cells[5].Value = book.ProductionYear;
                number++;
            }
            count_of_books.Text = Convert.ToString(dataGridView1.RowCount);
        }
        /// <summary>
        /// Редактирование книги
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        async void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int BookID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            string title = dataGridView1.SelectedCells[1].Value.ToString();
            string author = dataGridView1.SelectedCells[2].Value.ToString();
            string genre = dataGridView1.SelectedCells[3].Value.ToString();
            int countPages = Convert.ToInt32(dataGridView1.SelectedCells[4].Value.ToString());
            int productionYear = Convert.ToInt32(dataGridView1.SelectedCells[5].Value.ToString());


            Edit_Book FormEdit = new Edit_Book(title, author, genre, countPages, productionYear, BookID);
            FormEdit.ShowDialog();

            title = Edit_Book.Title;
            author = Edit_Book.Author;
            genre = Edit_Book.Genre;
            countPages = Edit_Book.CountPages;
            productionYear = Edit_Book.ProductionYear;

            textBox2.Text = "";
            dataGridView1.Rows.Clear();
            number = 0;

            var books = await ReadFromFile<InfoBooks>(FILE_BOOKS);

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(genre) && (countPages > 0)
            && (productionYear > 0) &&  (BookID > 0))
            {
                foreach (var book in books)
                {
                    if (book.BookID == BookID)
                    {
                        book.Title = title;
                        book.Author = author;
                        book.Genre = genre;
                        book.CountPages = countPages;
                        book.ProductionYear = productionYear;

                        await WriteToFile(books, FILE_BOOKS);
                    }
                    Print(book);
                }
            }
        }
        /// <summary>
        /// Кнопка выхода из формы управления книгохранилищем
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
