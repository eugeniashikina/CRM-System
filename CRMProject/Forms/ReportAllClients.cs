using CRMProject.Contollers;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace CRMProject.Forms
{
    public partial class ReportAllClients : Form
    {
        public ReportAllClients()
        {
            InitializeComponent();
            ControllerReports reports = new ControllerReports();
            Report = reports.GetInfoAboutOrdersAllClints(Report);
            SetDataChart();
        }

        /// <summary>
        ///     Вставляет данные в граффик.
        /// </summary>
        private void SetDataChart()
        {
            List<string> nameClients = new List<string>();
            List<string> sellMoney = new List<string>();

            for (int i = 0; i < Report.Rows.Count; i++)
            {
                nameClients.Add(Report.Rows[i].Cells["Id_client"].Value.ToString());
                sellMoney.Add(Report.Rows[i].Cells["SellMoney"].Value.ToString());
            }

            for (int i = 0; i < nameClients.Count && i < sellMoney.Count; i++)
            {
                Chart.Series["Клиенты"].Points.AddXY(nameClients[i], Convert.ToDouble(sellMoney[i]));
            }
        }
    }
}