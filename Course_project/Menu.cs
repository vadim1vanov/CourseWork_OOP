using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace Course_project
{
    public partial class Menu : Form
    {
        const string FILE_BOOKS = "Books.json";
        const string FILE_CLIENTS = "Clients.json";

        public Menu()
        {
            InitializeComponent();
            Task.Run(() => File.Open(FILE_BOOKS, FileMode.OpenOrCreate).Close());
            Task.Run(() => File.Open(FILE_CLIENTS, FileMode.OpenOrCreate).Close());
        }

        private void btn_books_Click(object sender, EventArgs e)
        {
            Books Book = new Books();
            Book.ShowDialog();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            Clients Client = new Clients();
            Client.ShowDialog();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            Report Report = new Report();
            Report.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_deleteDatabase_Click(object sender, EventArgs e)
        {
            if (File.Exists(FILE_CLIENTS)) {
                File.WriteAllText(FILE_CLIENTS, string.Empty);
                MessageBox.Show("База клиентов была очищена", "Удаление базы данных", 0, MessageBoxIcon.Information);
            }

            if (File.Exists(FILE_BOOKS))
            {
                File.WriteAllText(FILE_BOOKS, string.Empty);
                MessageBox.Show("База книгохранилища была очищена", "Удаление базы данных", 0, MessageBoxIcon.Information);
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://github.com/vadim1vanov/CourseWork_OOP", UseShellExecute = true });
        }
    }
}
