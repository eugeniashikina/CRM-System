using System;
using System.Windows.Forms;

namespace CRMProject.Forms
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализация главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для авторизации
        /// </summary>
        public void AuthorizationClick(object sender, EventArgs e)
        {
            AuthorizationForm auth = new AuthorizationForm();
            Hide();
            auth.ShowDialog();
            Show();
            ListClient.Enabled = true;
            Authorization.Enabled = false;
        }

        /// <summary>
        /// Метод для просмотра списка клиентов
        /// </summary>
        public void ListClientClick(object sender, EventArgs e)
        {
            Hide();
            ListClientForm client = new ListClientForm();
            client.ShowDialog();
            client.Close();
        }
    }
}