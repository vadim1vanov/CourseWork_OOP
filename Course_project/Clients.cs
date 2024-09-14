using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course_project
{
    /// <summary>
    /// Класс формы работы с клиентами
    /// </summary>
    public partial class Clients : Form
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
        /// поле для хранения количества клиентов
        /// </summary>
        int n_clients = 0;
        /// <summary>
        /// поле для хранения номера строки
        /// </summary>
        int numbers = 0;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Clients()
        {
            Task.Run(() => File.Open(FILE_CLIENTS, FileMode.OpenOrCreate).Close());
            Task.Run(() => File.Open(FILE_BOOKS, FileMode.OpenOrCreate).Close());

            InitializeComponent();
        }





        /// <summary>
        /// Отображение всех клиентов из базы данных
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        async void Clients_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_CLIENTS))
            {
                var table_of_clients = await ReadFromFile<InfoClients>(FILE_CLIENTS);
                DateTime now_time = DateTime.Now;
                
                


                n_clients = table_of_clients.Count;
                count_of_clients.Text = Convert.ToString(n_clients);

                if (table_of_clients != null)
                    foreach (var client in table_of_clients)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[numbers].Cells[0].Value = client.FirstName;
                        dataGridView1.Rows[numbers].Cells[1].Value = client.LastName;
                        dataGridView1.Rows[numbers].Cells[2].Value = client.Date;
                        dataGridView1.Rows[numbers].Cells[3].Value = client.Deadline;  
                        dataGridView1.Rows[numbers].Cells[4].Value = client.Phone;
                        dataGridView1.Rows[numbers].Cells[5].Value = client.IsReturned;                  
                        dataGridView1.Rows[numbers].Cells[6].Value = client.BookID;  
                        DataGridViewCell cell5 = dataGridView1.Rows[numbers].Cells[5];
                        DataGridViewCell cell3 = dataGridView1.Rows[numbers].Cells[3];
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.MistyRose;
                        if (client.IsReturned == "Нет")
                        {
                            if (now_time > DateTime.Parse(client.Deadline)) { 
                                cell5.Style = style; 
                                cell3.Style = style; }                   
                        }
                        numbers++;
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
        /// <summary>
        /// Кнопка открытия формы добавления клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void btn_Add_Click(object sender, EventArgs e)
        {
            Add_Client addClient = new Add_Client();
            addClient.ShowDialog();

            string firstName = Add_Client.firstName;
            string lastName = Add_Client.lastName;
            string date = Add_Client.date;
            string deadline = Add_Client.deadline;
            string phone = Add_Client.phone;
            int BookID = Add_Client.BookID;
            string isReturned = Add_Client.isReturned;

            InfoClients newClient = new InfoClients(firstName, lastName, date, deadline, phone, BookID, isReturned);

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(date) && !string.IsNullOrEmpty(deadline) &&
                !string.IsNullOrEmpty(phone) && (BookID > 0) && !string.IsNullOrEmpty(isReturned))
            {
                var clients = await ReadFromFile<InfoClients>(FILE_CLIENTS);
                var books = await ReadFromFile<InfoBooks>(FILE_BOOKS);

                bool check = false;
                foreach (var book in books)
                    if (book.BookID == BookID)
                        check = true;
                if (!check)
                {
                    MessageBox.Show($"Книги с ID {BookID} не существует."
                            , "Добавление клиента", 0, MessageBoxIcon.Information);
                    return;
                }

                clients.Add(newClient);

                n_clients = clients.Count;
                count_of_clients.Text = Convert.ToString(n_clients);

                await WriteToFile(clients, FILE_CLIENTS);

                dataGridView1.Rows.Add();
                dataGridView1.Rows[numbers].Cells[0].Value = firstName;
                dataGridView1.Rows[numbers].Cells[1].Value = lastName;
                dataGridView1.Rows[numbers].Cells[2].Value = date;
                dataGridView1.Rows[numbers].Cells[3].Value = deadline;
                dataGridView1.Rows[numbers].Cells[4].Value = phone;
                dataGridView1.Rows[numbers].Cells[5].Value = BookID;
                dataGridView1.Rows[numbers].Cells[6].Value = isReturned;
                numbers++;
            }
        }
        /// <summary>
        /// Кнопка удаления клиента
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        async void btn_Remove_Click(object sender, EventArgs e)
        {
            var Items = dataGridView1.SelectedRows;
            int selectCount = Items.Count;

            if (selectCount > 0)
            {
                var clients = await ReadFromFile<InfoClients>(FILE_CLIENTS);

                foreach (var item in Items)
                {
                    var it = (DataGridViewRow)item;
                    string firstName = it.Cells[0].Value.ToString();
                    string lastName = it.Cells[1].Value.ToString();
                    string date = it.Cells[2].Value.ToString();
                    string deadline = it.Cells[3].Value.ToString();
                    string phone = it.Cells[4].Value.ToString();
                    int bookID = Convert.ToInt32(it.Cells[6].Value.ToString());
                    string isReturned = (it.Cells[5].Value).ToString();

                    foreach (var cl in clients)
                    {
                        if (firstName == cl.FirstName && lastName == cl.LastName && date == cl.Date && deadline == cl.Deadline &&
                            phone == cl.Phone && bookID == cl.BookID)
                        {
                            clients.Remove(cl);
                            n_clients = clients.Count;
                            count_of_clients.Text = Convert.ToString(n_clients);
                            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                            numbers--;
                            MessageBox.Show($"Клиент  {cl.FirstName} {cl.LastName}  удалён!", "Удаление клиента",
                                0, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
                await WriteToFile(clients, FILE_CLIENTS);
            }
            else
            {
                MessageBox.Show("Нет клиентов", "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }
        /// <summary>
        /// Кнопка выхода из формы управления клиентами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
