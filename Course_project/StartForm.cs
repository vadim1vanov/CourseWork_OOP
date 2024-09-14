using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_project
{
    /// <summary>
    /// Класс загрузочной формы
    /// </summary>
    public partial class StartForm : Form
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Отображение формы с задержкой
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        async void StartForm_Load(object sender, EventArgs e)
        {
            await Task.Delay(3000);
            this.Close();
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender">Объект, который вызвал срабатывание</param>
        /// <param name="e">Объект, с дополнительной информацией</param>
        private void StartForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
