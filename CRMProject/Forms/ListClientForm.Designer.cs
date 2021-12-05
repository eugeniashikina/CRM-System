namespace CRMProject.Forms
{
    partial class ListClientForm
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
            this.ListClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListClient)).BeginInit();
            this.SuspendLayout();
            // 
            // ListClient
            // 
            this.ListClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListClient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ListClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListClient.Location = new System.Drawing.Point(53, 32);
            this.ListClient.Margin = new System.Windows.Forms.Padding(4);
            this.ListClient.Name = "ListClient";
            this.ListClient.RowHeadersWidth = 51;
            this.ListClient.Size = new System.Drawing.Size(811, 292);
            this.ListClient.TabIndex = 0;
            this.ListClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListClient_CellClick);
            this.ListClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListClient_CellContentClick);
            this.ListClient.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListClient_CellValueChanged);
            this.ListClient.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.ListClient_UserAddedRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список клиентов";
            // 
            // OpenOrders
            // 
            this.OpenOrders.Location = new System.Drawing.Point(39, 341);
            this.OpenOrders.Name = "OpenOrders";
            this.OpenOrders.Size = new System.Drawing.Size(98, 34);
            this.OpenOrders.TabIndex = 3;
            this.OpenOrders.Text = "Заказы";
            this.OpenOrders.UseVisualStyleBackColor = true;
            this.OpenOrders.Click += new System.EventHandler(this.OpenOrders_Click);
            // 
            // ListClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 398);
            this.Controls.Add(this.OpenOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListClient);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListClientForm";
            this.Text = "ListClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenOrders;
    }
}