namespace CRMProject.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Authorization = new System.Windows.Forms.Button();
            this.ListClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Authorization
            // 
            this.Authorization.Location = new System.Drawing.Point(93, 21);
            this.Authorization.Name = "Authorization";
            this.Authorization.Size = new System.Drawing.Size(98, 25);
            this.Authorization.TabIndex = 0;
            this.Authorization.Text = "Авторизация";
            this.Authorization.UseVisualStyleBackColor = true;
            this.Authorization.Click += new System.EventHandler(this.AuthorizationClick);
            // 
            // ListClient
            // 
            this.ListClient.Enabled = false;
            this.ListClient.Location = new System.Drawing.Point(12, 135);
            this.ListClient.Name = "ListClient";
            this.ListClient.Size = new System.Drawing.Size(108, 24);
            this.ListClient.TabIndex = 1;
            this.ListClient.Text = "Список клиентов";
            this.ListClient.UseVisualStyleBackColor = true;
            this.ListClient.Click += new System.EventHandler(this.ListClientClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 182);
            this.Controls.Add(this.ListClient);
            this.Controls.Add(this.Authorization);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Authorization;
        private System.Windows.Forms.Button ListClient;
    }
}

