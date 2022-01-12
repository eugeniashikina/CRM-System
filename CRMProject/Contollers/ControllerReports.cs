using CRMProject.Handler;
using System.Windows.Forms;

namespace CRMProject.Contollers
{
    public class ControllerReports
    {
        HandlerDBReports db;

        /// <summary>
        /// Получение информации о заказах одного клиента.
        /// </summary>
        /// <returns> Возвращает информацию о клиентах </returns>
        public DataGridView GetInfoAboutOrders(DataGridView data, int id)
        {
            if (id != 0)
            {
                string sql = "SELECT Client.Name," +
                " COUNT(DISTINCT Orders.Id_order) AS Count," +
                " SUM(Orders.Count * Product.Cost) AS Cost" +
                " FROM Orders" +
                " LEFT JOIN Product ON Orders.Id_product = Product.Id_product" +
                " LEFT JOIN Client ON Orders.Id_client = Client.Id" +
                " WHERE Id_client = '" + id + "'" +
                " Group By Client.Name";
                db = new HandlerDBReports("Orders", sql, data);
                data = db.GetInfoAboutTable();
            }
            else MessageBox.Show("Выбирите id клиента для просмотра отчета", "Ошибка!", MessageBoxButtons.OK);

            return data;
        }

        /// <summary>
        /// Получение информации о заказах всех клиентов.
        /// </summary>
        /// <returns> Возвращает информацию о клиентах </returns>
        public DataGridView GetInfoAboutOrdersAllClints(DataGridView data)
        {
            string sql = "SELECT Client.Name," +
            " COUNT(DISTINCT Orders.Id_order) AS Count," +
            " SUM(Orders.Count * Product.Cost) AS Cost" +
            " FROM Orders" +
            " LEFT JOIN Product ON Orders.Id_product = Product.Id_product" +
            " LEFT JOIN Client ON Orders.Id_client = Client.Id" +
            " Group By Client.Name" +
            " ORDER BY Cost DESC";
            db = new HandlerDBReports("Orders", sql, data);
            data = db.GetInfoAboutTable();

            return data;
        }
    }
}
