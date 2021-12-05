using System;
using System.Windows.Forms;
using CRMProject.Contollers;

namespace CRMProject.Forms
{
    /// <summary>
    /// Форма для авторизации пользователя
    /// </summary>
    public partial class AuthorizationForm : Form
    {
        /// <summary>
        /// Инициализация формы авторизации
        /// </summary>
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для входа в аккаунт пользователя
        /// </summary>
        /// <param name="sender"> Нажатие </param>
        /// <param name="e"> EventArgs </param>
        public void SignInClick(object sender, EventArgs e)
        {
            ContollerUser user = new ContollerUser();
            if (user.CheckUserData(textBox1.Text, textBox2.Text) == true)
                Close();
        }
    }
}
