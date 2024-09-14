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
    /// Класс формы отчета по должникам
    /// </summary>
    public partial class Report : Form
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
        /// Конструктор класса
        /// </summary>
        public Report()
        {
            Task.Run(() => File.Open(FILE_BOOKS, FileMode.OpenOrCreate).Close());
            Task.Run(() => File.Open(FILE_CLIENTS, FileMode.OpenOrCreate).Close());

            InitializeComponent();
        }
        /// <summary>
        /// Отображение всех должников
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        async void Report_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_CLIENTS))
            {
                var table_of_books = await ReadFromFile<InfoBooks>(FILE_BOOKS);
                var table_of_clients = await ReadFromFile<InfoClients>(FILE_CLIENTS);

                

                if (table_of_clients.Count != 0)
                    foreach (var client in table_of_clients)
                    {
                        if ((DateTime.Now > DateTime.Parse(client.Deadline)) && (client.IsReturned == "Нет")) { 
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[number].Cells[0].Value = client.BookID;
                        dataGridView1.Rows[number].Cells[1].Value = client.FirstName;
                        dataGridView1.Rows[number].Cells[2].Value = client.LastName;
                        dataGridView1.Rows[number].Cells[3].Value = client.Date;
                        dataGridView1.Rows[number].Cells[4].Value = client.Deadline;
                        dataGridView1.Rows[number].Cells[5].Value = client.Phone;
                        foreach (var book in table_of_books)
                        {
                            if (book.BookID == client.BookID)
                            {
                                dataGridView1.Rows[number].Cells[6].Value = book.Title;
                                dataGridView1.Rows[number].Cells[7].Value = book.Author;
                                dataGridView1.Rows[number].Cells[8].Value = book.Genre;
                                dataGridView1.Rows[number].Cells[9].Value = book.CountPages;
                                dataGridView1.Rows[number].Cells[10].Value = book.ProductionYear;
                            }
                        }

                        number++;}
                    }
                count_debtors.Text = number.ToString();
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
        /// <summary>
        /// Кнопка выхода из формы отчета по должникам
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
