namespace CRMProject.Forms
{
    partial class ReportForm
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.Report.Location = new System.Drawing.Point(24, 23);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(421, 78);
            this.Report.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчеты";
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
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Report);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellMoney;
    }
}