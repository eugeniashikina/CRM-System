using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMProject.Handler
{
    public abstract class HandlerDataBase
    {
        /// <summary>
        ///     SqlDataAdapter
        /// </summary>
        public SqlDataAdapter SqlDataAdapter { get; set; }

        /// <summary>
        ///     DataSet
        /// </summary>
        public DataSet DataSet { get; set; }

        /// <summary>
        ///     SqlBuider
        /// </summary>
        public SqlCommandBuilder SqlBuilder { get; set; }

        /// <summary>
        ///     SqlConnection
        /// </summary>
        public SqlConnection Connection { get; set; }

        /// <summary>
        ///     DataGridView
        /// </summary>
        public DataGridViewRow Row { get; set; }

        /// <summary>
        ///     Строка подключения.
        /// </summary>
        public readonly string StringConnction = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\heart\source\repos\CRM_system\CRMProject\Database.mdf;Integrated Security=True";

        /// <summary>
        ///     Имя таблицы к которой нужно обратиться для работы с ней.
        /// </summary>
        public string NameTableDataBase { get; set; }

        /// <summary>
        ///     Sql запрос к базе данных.
        /// </summary>
        public string SqlRequest { get; set; }

        /// <summary>
        ///     Локальная DataGridView для заполнения ее данными.
        /// </summary>
        public DataGridView Data { get; set; }
    }
}
