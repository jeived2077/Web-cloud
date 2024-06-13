namespace WindowsFormsApp1
{
    partial class Form2
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
            this.yandex = new System.Windows.Forms.Button();
            this.mailru = new System.Windows.Forms.Button();
            this.google = new System.Windows.Forms.Button();
            this.cloudmailru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите облачное хранилище";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yandex
            // 
            this.yandex.Location = new System.Drawing.Point(6, 140);
            this.yandex.Name = "yandex";
            this.yandex.Size = new System.Drawing.Size(153, 298);
            this.yandex.TabIndex = 1;
            this.yandex.Text = "Яндекс";
            this.yandex.UseVisualStyleBackColor = true;
            this.yandex.Click += new System.EventHandler(this.yandex_Click);
            // 
            // mailru
            // 
            this.mailru.Location = new System.Drawing.Point(190, 140);
            this.mailru.Name = "mailru";
            this.mailru.Size = new System.Drawing.Size(139, 298);
            this.mailru.TabIndex = 2;
            this.mailru.Text = "Dropbox";
            this.mailru.UseVisualStyleBackColor = true;
            this.mailru.Click += new System.EventHandler(this.mailru_Click);
            // 
            // google
            // 
            this.google.Location = new System.Drawing.Point(357, 140);
            this.google.Name = "google";
            this.google.Size = new System.Drawing.Size(157, 298);
            this.google.TabIndex = 3;
            this.google.Text = "Onedrive";
            this.google.UseVisualStyleBackColor = true;
            this.google.Click += new System.EventHandler(this.google_Click);
            // 
            // cloudmailru
            // 
            this.cloudmailru.Location = new System.Drawing.Point(532, 140);
            this.cloudmailru.Name = "cloudmailru";
            this.cloudmailru.Size = new System.Drawing.Size(233, 298);
            this.cloudmailru.TabIndex = 4;
            this.cloudmailru.Text = "CloudMailru";
            this.cloudmailru.UseVisualStyleBackColor = true;
            this.cloudmailru.Click += new System.EventHandler(this.cloudmailru_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cloudmailru);
            this.Controls.Add(this.google);
            this.Controls.Add(this.mailru);
            this.Controls.Add(this.yandex);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yandex;
        private System.Windows.Forms.Button mailru;
        private System.Windows.Forms.Button google;
        private System.Windows.Forms.Button cloudmailru;
    }
}