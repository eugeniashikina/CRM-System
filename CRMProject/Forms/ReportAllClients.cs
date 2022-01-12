using CRMProject.Contollers;
using System.Windows.Forms;

namespace CRMProject.Forms
{
    public partial class ReportAllClients : Form
    {
        public ReportAllClients()
        {
            InitializeComponent();
            ControllerReports reports = new ControllerReports();
            Report = reports.GetInfoAboutOrdersAllClints(Report);
        }
    }
}