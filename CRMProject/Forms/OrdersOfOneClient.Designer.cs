namespace CRMProject.Forms
{
    partial class OrdersOfOneClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListOrdersClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrdersClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список заказов одного клиента";
            // 
            // ListOrdersClient
            // 
            this.ListOrdersClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListOrdersClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListOrdersClient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListOrdersClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListOrdersClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOrdersClient.Location = new System.Drawing.Point(13, 36);
            this.ListOrdersClient.Margin = new System.Windows.Forms.Padding(4);
            this.ListOrdersClient.Name = "ListOrdersClient";
            this.ListOrdersClient.RowHeadersWidth = 51;
            this.ListOrdersClient.Size = new System.Drawing.Size(811, 292);
            this.ListOrdersClient.TabIndex = 3;
            this.ListOrdersClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOrdersClient_CellContentClick);
            this.ListOrdersClient.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOrdersClient_CellValueChanged);
            this.ListOrdersClient.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListOrdersClient_UserAddedRow);
            // 
            // OrdersOfOneClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListOrdersClient);
            this.Name = "OrdersOfOneClient";
            this.Text = "OrdersOfOneClient";
            ((System.ComponentModel.ISupportInitialize)(this.ListOrdersClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ListOrdersClient;
    }
}