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
            this.Report = new System.Windows.Forms.DataGridView();
            this.Id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).BeginInit();
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
            this.Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report.Location = new System.Drawing.Point(0, 0);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(559, 229);
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
            // ReportAllClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 229);
            this.Controls.Add(this.Report);
            this.Name = "ReportAllClients";
            this.Text = "ReportAllClients";
            ((System.ComponentModel.ISupportInitialize)(this.Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Report;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellMoney;
    }
}