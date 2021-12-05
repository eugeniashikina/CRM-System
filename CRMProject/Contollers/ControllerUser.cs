using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CRMProject.Entity;

namespace CRMProject.Contollers
{
    /// <summary>
    ///     Контролер для обратки запросов авторизации.
    /// </summary>
    public class ContollerUser
    {
        /// <summary>
        ///     Строка подключения.
        /// </summary>
        private readonly string StringConnction = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heart\source\repos\CRM_system\CRMProject\Database.mdf;Integrated Security=True";

        /// <summary>
        ///     Берет данные с БД, по логину и паролю.
        /// </summary>
        /// <param name="log">Логин</param>
        /// <param name="pass">Пароль</param>
        private void GetUserData(string log, string pass)
        {
            string sql = "SELECT * FROM Users WHERE Login='" + log + "' AND Password='" + pass + "'";
            SqlConnection conn = new SqlConnection(StringConnction);
            conn.Open();
            DataSet dt = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            DataRow row = dt.Tables[0].Rows[0];
            User.Id = Convert.ToInt64(row["Id"]);
            User.Login = row["Login"].ToString();
            User.Password = row["Password"].ToString();
            User.Role = row["Role"].ToString();
        }

        /// <summary>
        ///     Проверить на правильность ввода логина и пароля.
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns>True - если все верно. False - если есть ошибки.</returns>
        public bool CheckUserData(string login, string password)
        {
            GetUserData(login, password);
            if (login == User.Login && password == User.Password)
            {
                MessageBox.Show("Добро пожаловать " + login + "!", "Успешно!", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                MessageBox.Show("Данного пользователя не существует. Проверьте введенные данные.", "Ошибка!", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}