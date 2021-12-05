using System.Data;
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
            SqlRequest = sql;
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
            SqlDataAdapter = new SqlDataAdapter(SqlRequest, Connection);
            SqlBuilder = new SqlCommandBuilder(SqlDataAdapter);
            SqlBuilder.GetInsertCommand();
            SqlBuilder.GetDeleteCommand();
            SqlBuilder.GetUpdateCommand();
            DataSet = new DataSet();
            SqlDataAdapter.Fill(DataSet, NameTableDataBase);
            Data.DataSource = DataSet.Tables[NameTableDataBase];
            SetLinkCells();
            return Data;
        }

        /// <summary>
        ///     Вставляет ссылки взависимости от названия таблицы.
        /// </summary>
        private void SetLinkCells()
        {
            for (int i = 0; i < Data.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                Data[5, i] = linkCell;
            };
        }

        /// <summary>
        /// Обновление таблицы клиентов в БД
        /// </summary>
        private void ReloadData()
        {
            DataSet.Tables[NameTableDataBase].Clear();
            SqlDataAdapter.Fill(DataSet, NameTableDataBase);
            Data.DataSource = DataSet.Tables[NameTableDataBase];
            SetLinkCells();
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
                InsertData(e);
            }
            else if (task == "Update")
            {
                UpdateData(e);
            }
            ReloadData();
            return Data;
        }

        /// <summary>
        ///     Добавляет данные в таблицу.
        /// </summary>
        private void InsertData(DataGridViewCellEventArgs e)
        {
            int rowIndex = Data.Rows.Count - 2;
            DataRow row = DataSet.Tables[NameTableDataBase].NewRow();
            row["Data_order"] = Data.Rows[rowIndex].Cells["Data_Order"].Value;
            row["Id_product"] = Data.Rows[rowIndex].Cells["Id_product"].Value;
            row["Count"] = Data.Rows[rowIndex].Cells["Count"].Value;
            Data.Rows[e.RowIndex].Cells[5].Value = "Delete";
            DataSet.Tables[NameTableDataBase].Rows.Add(row);
            DataSet.Tables[NameTableDataBase].Rows.RemoveAt(DataSet.Tables[NameTableDataBase].Rows.Count - 1);
            Data.Rows.RemoveAt(Data.Rows.Count - 2);
            SqlDataAdapter.Update(DataSet, NameTableDataBase);
        }

        /// <summary>
        ///     Удаляет выбранные данные из таблицы.
        /// </summary>
        private void DeleteData(DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Удалить данный заказ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.Rows.RemoveAt(e.RowIndex);
                DataSet.Tables[NameTableDataBase].Rows[e.RowIndex].Delete();
                SqlDataAdapter.Update(DataSet, NameTableDataBase);
            }
        }

        /// <summary>
        ///     Обновляет таблицу
        /// </summary>
        private void UpdateData(DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataSet.Tables[NameTableDataBase].Rows[r]["Data_order"] = Data.Rows[r].Cells["Data_order"].Value;
            DataSet.Tables[NameTableDataBase].Rows[r]["Id_product"] = Data.Rows[r].Cells["Id_product"].Value;
            DataSet.Tables[NameTableDataBase].Rows[r]["Count"] = Data.Rows[r].Cells["Count"].Value;
            Data.Rows[r].Cells[5].Value = "Delete";
            SqlDataAdapter.Update(DataSet, NameTableDataBase);
        }
    }
}
