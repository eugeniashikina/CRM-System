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
            this.button1 = new System.Windows.Forms.Button();
            this.Id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrdersClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
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
            this.ListOrdersClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_order,
            this.Data_order,
            this.Id_product,
            this.Count,
            this.Id_client,
            this.Command});
            this.ListOrdersClient.Location = new System.Drawing.Point(10, 29);
            this.ListOrdersClient.Name = "ListOrdersClient";
            this.ListOrdersClient.RowHeadersWidth = 51;
            this.ListOrdersClient.Size = new System.Drawing.Size(608, 237);
            this.ListOrdersClient.TabIndex = 3;
            this.ListOrdersClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOrdersClient_CellContentClick);
            this.ListOrdersClient.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListOrdersClient_UserAddedRow);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Id_order
            // 
            this.Id_order.HeaderText = "ID заказа";
            this.Id_order.Name = "Id_order";
            this.Id_order.ReadOnly = true;
            // 
            // Data_order
            // 
            this.Data_order.HeaderText = "Дата заказа";
            this.Data_order.Name = "Data_order";
            // 
            // Id_product
            // 
            this.Id_product.HeaderText = "Наименование продукта";
            this.Id_product.Name = "Id_product";
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // Id_client
            // 
            this.Id_client.HeaderText = "Имя клиента";
            this.Id_client.Name = "Id_client";
            // 
            // Command
            // 
            this.Command.HeaderText = "Команда";
            this.Command.Name = "Command";
            // 
            // OrdersOfOneClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListOrdersClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrdersOfOneClient";
            this.Text = "OrdersOfOneClient";
            ((System.ComponentModel.ISupportInitialize)(this.ListOrdersClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ListOrdersClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
    }
}