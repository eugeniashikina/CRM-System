namespace CRMProject.Forms
{
    partial class ReportAllClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Report = new System.Windows.Forms.DataGridView();
            this.Id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.AllowUserToAddRows = false;
            this.Report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Report.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Report.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_client,
            this.CountOrders,
            this.SellMoney});
            this.Report.Location = new System.Drawing.Point(0, 0);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(559, 300);
            this.Report.TabIndex = 1;
            // 
            // Id_client
            // 
            this.Id_client.HeaderText = "Имя клиента";
            this.Id_client.Name = "Id_client";
            // 
            // CountOrders
            // 
            this.CountOrders.HeaderText = "Кол-во заказов";
            this.CountOrders.Name = "CountOrders";
            // 
            // SellMoney
            // 
            this.SellMoney.HeaderText = "Всего потрачено денег";
            this.SellMoney.Name = "SellMoney";
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(565, 0);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Клиенты";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(300, 300);
            this.Chart.TabIndex = 2;
            this.Chart.Text = " Диаграмма";
            // 
            // ReportAllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 300);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.Report);
            this.Name = "ReportAllClients";
            this.Text = "ReportAllClients";
            ((System.ComponentModel.ISupportInitialize)(this.Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellMoney;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}