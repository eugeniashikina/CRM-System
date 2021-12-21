using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMProject.Handler
{
    public class HandlerDBOrdersOfOneClient : HandlerDataBase
    {
        /// <summary>
        ///     Формирует начало общения DataGridView c DataBase.
        /// </summary>
        /// <param name="nameTable">Имя таблицы</param>
        public HandlerDBOrdersOfOneClient(string nameTable, string sql, DataGridView data)
        {
            Data = data;
            SqlDataRequest = sql;
            NameTableDataBase = nameTable;
            Connection = new SqlConnection(StringConnction);
            Connection.Open();
        }

        /// <summary>
        /// Получение информации Table from DataBase.
        /// </summary>
        /// <returns> Возвращает информацию данной Table </returns>
        public DataGridView GetInfoAboutTable()
        {
            Data.Rows.Clear();
            Command = new SqlCommand(SqlDataRequest, Connection);
            DataReader = Command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (DataReader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = DataReader[0].ToString();
                data[data.Count - 1][1] = DataReader[1].ToString();
                data[data.Count - 1][2] = DataReader[2].ToString();
                data[data.Count - 1][3] = DataReader[3].ToString();
                data[data.Count - 1][4] = DataReader[4].ToString();
            }
            DataReader.Close();

            foreach (var s in data)
                Data.Rows.Add(s);

            SetLinkCells();

            return Data;
        }

        /// <summary>
        ///     Вставляет ссылки взависимости от названия таблицы.
        /// </summary>
        private void SetLinkCells()
        {
            for (int i = 0; i < Data.Rows.Count - 1; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                Data[5, i] = linkCell;
                Data[5, i].Value = "Delete";
            }
        }

        /// <summary>
        /// Обработчик событий(Update, Delete, Insert) во всех таблицах бд.
        /// </summary>
        public DataGridView Handler(DataGridViewCellEventArgs e, DataGridView dataGrid, string task)
        {
            Data = dataGrid;

            if (task == "Delete")
            {
                DeleteData(e);
            }
            else if (task == "Insert")
            {
                InsertData();
            }
            else if (task == "Update")
            {
                UpdateData(e);
            }
            GetInfoAboutTable();
            return Data;
        }

        /// <summary>
        ///     Добавляет данные в таблицу.
        /// </summary>
        private void InsertData()
        {
            int rowIndex = Data.Rows.Count - 2;
            string date = Data.Rows[rowIndex].Cells["Data_order"].Value.ToString();
            string nameProduct = Data.Rows[rowIndex].Cells["Id_product"].Value.ToString();
            string count = Data.Rows[rowIndex].Cells["Count"].Value.ToString();
            string nameClient = Data.Rows[rowIndex].Cells["Id_client"].Value.ToString();

            SqlRequest = "SELECT Id FROM Client WHERE Name=N'" + nameClient + "'";
            string idClient = RequestSql();

            SqlRequest = "SELECT Id_product FROM Product WHERE Name=N'" + nameProduct + "'";
            string idProduct = RequestSql();


            SqlRequest = "INSERT INTO Orders (Data_order, Id_product, Count, Id_client) " +
                "VALUES (N'" + date + "', " + idProduct + ", " + count + ", " + idClient + ")";
            Command = new SqlCommand(SqlRequest, Connection);
            Command.ExecuteNonQuery();
        }

        /// <summary>
        ///     Выполняет запрос.
        /// </summary>
        /// <returns>Переменную по запросу</returns>
        private string RequestSql()
        {
            string value = string.Empty;
            Command = new SqlCommand(SqlRequest, Connection);
            DataReader = Command.ExecuteReader();
            if (DataReader.Read())
                value = DataReader[0].ToString();
            DataReader.Close();
            return value;
        }

        /// <summary>
        ///     Удаляет выбранные данные из таблицы.
        /// </summary>
        private void DeleteData(DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Удалить данный заказ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlRequest = "DELETE FROM Orders WHERE Id_order=" + Data.Rows[e.RowIndex].Cells["Id_order"].Value;
                Command = new SqlCommand(SqlRequest, Connection);
                Command.ExecuteNonQuery();
                Data.Rows.RemoveAt(e.RowIndex);
                DataReader.Close();
            }
        }

        /// <summary>
        ///     Обновляет таблицу
        /// </summary>
        private void UpdateData(DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string id = Data.Rows[rowIndex].Cells["Id_order"].Value.ToString();
            string date = Data.Rows[rowIndex].Cells["Data_order"].Value.ToString();
            string nameProduct = Data.Rows[rowIndex].Cells["Id_product"].Value.ToString();
            string count = Data.Rows[rowIndex].Cells["Count"].Value.ToString();
            string nameClient = Data.Rows[rowIndex].Cells["Id_client"].Value.ToString();

            SqlRequest = "SELECT Id FROM Client WHERE Name=N'" + nameClient + "'";
            string idClient = RequestSql();

            SqlRequest = "SELECT Id_product FROM Product WHERE Name=N'" + nameProduct + "'";
            string idProduct = RequestSql();

            SqlRequest = "UPDATE Orders SET " +
                "Data_order=N'" + date + "', " +
                "Id_product=" + idProduct + ", " +
                "Count =" + count + ", " +
                "Id_client=" + idClient +
                " WHERE Id_order=" + id;
            Command = new SqlCommand(SqlRequest, Connection);
            Command.ExecuteNonQuery();
        }
    }
}