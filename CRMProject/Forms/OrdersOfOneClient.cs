using CRMProject.Contollers;
using System.Windows.Forms;

namespace CRMProject.Forms
{
    public partial class OrdersOfOneClient : Form
    {
        private ControllerOrdersOfOneClient orders;
        public OrdersOfOneClient(int id)
        {
            InitializeComponent();
            orders = new ControllerOrdersOfOneClient();
            ListOrdersClient = orders.GetInfoAboutOrders(ListOrdersClient, id);
        }

        private void ListOrdersClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListOrdersClient = orders.Contorller(ListOrdersClient, e);
        }

        private void ListOrdersClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ListOrdersClient = orders.UpdateValue(ListOrdersClient);
        }

        private void ListOrdersClient_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            ListOrdersClient = orders.AddNewRow(ListOrdersClient);
        }
    }
}
