using CRMProject.Entity;
using CRMProject.Handler;
using System.Windows.Forms;

namespace CRMProject.Contollers
{
    public class ControllerClients
    {
        /// <summary>
        ///     Флажок для отличия добавления и удаления строки.
        /// </summary>
        private bool NewRowAdding { get; set; }

        HandlerDBClients db;

        /// <summary>
        /// Получение информации о клиентах
        /// </summary>
        /// <returns> Возвращает информацию о клиентах </returns>
        public DataGridView GetInfoAboutClient(DataGridView data)
        {
            string sql = "SELECT *, 'Delete' AS [Delete] FROM Client WHERE Id_user='" + User.Id + "'";
            db = new HandlerDBClients("Client", sql, data);
            data = db.GetInfoAboutTable();
            return data;
        }

        /// <summary>
        ///     Контроллер для обработки запросов редактирования информации.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public DataGridView Contorller(DataGridView data, DataGridViewCellEventArgs e)
        {
            string task = data.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (task == "Insert" || task == "Update" || task == "Delete")
            {
                data = db.Handler(e, data, task);
                NewRowAdding = false;
            }
            return data;
        }

        /// <summary>
        /// Добавление нового клиента в БД
        /// </summary>
        public DataGridView AddNewRow(DataGridView dataGrid)
        {
            if (NewRowAdding == false)
            {
                NewRowAdding = true;
                int lastRow = dataGrid.Rows.Count - 2;
                DataGridViewRow row = dataGrid.Rows[lastRow];
                DataGridViewLinkCell link = new DataGridViewLinkCell();
                dataGrid[6, lastRow] = link;
                row.Cells["Delete"].Value = "Insert";
            }
            return dataGrid;
        }

        /// <summary>
        /// Обновление данных о клиенте
        /// </summary>
        public DataGridView UpdateValue(DataGridView dataGrid)
        {
            if (NewRowAdding == false)
            {
                int rowIndex = dataGrid.SelectedCells[0].RowIndex;
                DataGridViewRow EditingRow = dataGrid.Rows[rowIndex];
                DataGridViewLinkCell link = new DataGridViewLinkCell();
                dataGrid[6, rowIndex] = link;
                EditingRow.Cells["Delete"].Value = "Update";
            }
            return dataGrid;
        }
    }
}
