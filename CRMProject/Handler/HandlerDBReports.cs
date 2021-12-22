using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRMProject.Handler
{
    public class HandlerDBReports : HandlerDataBase
    {
        /// <summary>
        ///     Формирует начало общения DataGridView c DataBase.
        /// </summary>
        /// <param name="nameTable">Имя таблицы</param>
        public HandlerDBReports(string nameTable, string sql, DataGridView data)
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
            }
            DataReader.Close();

            foreach (var s in data)
                Data.Rows.Add(s);

            return Data;
        }
    }
}