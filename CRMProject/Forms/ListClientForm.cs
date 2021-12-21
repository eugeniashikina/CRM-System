using CRMProject.Contollers;
using System;
using System.Windows.Forms;

namespace CRMProject.Forms
{
    /// <summary>
    /// Форма для просмотра списка клиентов
    /// </summary>
    public partial class ListClientForm : Form
    {
        private ControllerClients clients;

        /// <summary>
        ///     Значение, выбранное пользователем в DataGridView.
        /// </summary>
        private int Id;

        /// <summary>
        /// Инициализация формы для просмотра клиентов
        /// </summary>
        /// 
        public ListClientForm()
        {
            InitializeComponent();
            clients = new ControllerClients();
            GetInfo();
        }

        private void GetInfo()
        {
            ListClient = clients.GetInfoAboutClient(ListClient);
        }

        private void ListClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ListClient = clients.Contorller(ListClient, e);
        }

        private void ListClient_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            ListClient = clients.AddNewRow(ListClient);
        }

        private void ListClient_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            ListClient = clients.UpdateValue(ListClient);
        }

        private void OpenOrders_Click(object sender, EventArgs e)
        {
            OrdersOfOneClient orders = new OrdersOfOneClient(Id);
            if(Id != 0)
            {
                Hide();
                orders.ShowDialog();
                Show();
            }
        }

        private void ListClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListClient.Columns[e.ColumnIndex].HeaderText == "Id")
                Id = int.Parse(ListClient.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            else
                Id = 0;

        }
    }
}
