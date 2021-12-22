using CRMProject.Contollers;
using System.Windows.Forms;

namespace CRMProject.Forms
{
    /// <summary>
    /// Форма для просмотра отчетов
    /// </summary>
    public partial class ReportForm : Form
    {
        /// <summary>
        /// Инициализация формы для просмотра отчетов
        /// </summary>
        public ReportForm(int id)
        {
            InitializeComponent();
            ControllerReports reports = new ControllerReports();
            Report = reports.GetInfoAboutOrders(Report, id);
        }
    }
}