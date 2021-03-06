using CRMProject.Handler;
using System.Windows.Forms;

namespace CRMProject.Contollers
{
    public class ControllerOrdersOfOneClient
    {
        /// <summary>
        ///     Флажок для отличия добавления строки и удаления строки.
        /// </summary>
        private bool NewRowAdding { get; set; }

        HandlerDBOrdersOfOneClient db;

        /// <summary>
        /// Получение информации о заказах одного клиента.
        /// </summary>
        /// <returns> Возвращает информацию о клиентах </returns>
        public DataGridView GetInfoAboutOrders(DataGridView data, int id)
        {
            if (id != 0)
            {
                string sql = "SELECT Id_order, Data_order, Product.Name, Orders.Count, Client.Name" +
                    " FROM Orders" +
                    " LEFT JOIN Product ON Orders.Id_product = Product.Id_product" +
                    " LEFT JOIN Client ON Orders.Id_client = Client.Id" +
                    " WHERE Id_client='" + id + "'" +
                    " ORDER BY Orders.Data_order";
                db = new HandlerDBOrdersOfOneClient("Orders", sql, data);
                data = db.GetInfoAboutTable();
            }
            else MessageBox.Show("Выбирите id клиента для просмотра его заказов", "Ошибка!", MessageBoxButtons.OK);

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
                dataGrid[5, lastRow] = link;
                row.Cells["Command"].Value = "Insert";
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
                dataGrid[5, rowIndex] = link;
                EditingRow.Cells["Command"].Value = "Update";
            }
            return dataGrid;
        }
    }
}