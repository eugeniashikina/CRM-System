namespace CRMProject.Entity
{
    /// <summary>
    ///  Сущность пользователя
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public static long Id { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public static string Login { get; set; }

        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public static string Password { get; set; }

        /// <summary>
        /// Роль пользователя
        /// </summary>
        public static string Role { get; set; }
    }
}