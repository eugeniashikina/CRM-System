using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMProject.Handler
{
    public class HandlerDBClients : HandlerDataBase
    {
        /// <summary>
        ///     Формирует начало общения DataGridView c DataBase.
        /// </summary>
        /// <param name="nameTable">Имя таблицы</param>
        public HandlerDBClients(string nameTable, string sql, DataGridView data)
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
                Data[6, i] = linkCell;
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
            row["Name"] = Data.Rows[rowIndex].Cells["Name"].Value;
            row["Surname"] = Data.Rows[rowIndex].Cells["Surname"].Value;
            row["Patronymic"] = Data.Rows[rowIndex].Cells["Patronymic"].Value;
            row["Number_phone"] = Data.Rows[rowIndex].Cells["Number_phone"].Value;
            row["Id_user"] = Data.Rows[rowIndex].Cells["Id_user"].Value;
            Data.Rows[e.RowIndex].Cells[6].Value = "Delete";
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
            if (MessageBox.Show("Удалить данного клиента?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            DataSet.Tables[NameTableDataBase].Rows[r]["Name"] = Data.Rows[r].Cells["Name"].Value;
            DataSet.Tables[NameTableDataBase].Rows[r]["Surname"] = Data.Rows[r].Cells["Surname"].Value;
            DataSet.Tables[NameTableDataBase].Rows[r]["Patronymic"] = Data.Rows[r].Cells["Patronymic"].Value;
            DataSet.Tables[NameTableDataBase].Rows[r]["Number_phone"] = Data.Rows[r].Cells["Number_phone"].Value;
            DataSet.Tables[NameTableDataBase].Rows[r]["Id_user"] = Data.Rows[r].Cells["Id_user"].Value;
            Data.Rows[r].Cells[6].Value = "Delete";
            SqlDataAdapter.Update(DataSet, NameTableDataBase);
        }
    }
}
