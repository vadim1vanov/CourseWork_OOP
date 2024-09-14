namespace Course_project
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_books = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_deleteDatabase = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_books
            // 
            this.btn_books.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_books.Location = new System.Drawing.Point(232, 107);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(170, 45);
            this.btn_books.TabIndex = 0;
            this.btn_books.Text = "Книги";
            this.btn_books.UseVisualStyleBackColor = true;
            this.btn_books.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // btn_clients
            // 
            this.btn_clients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clients.Location = new System.Drawing.Point(232, 168);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(170, 45);
            this.btn_clients.TabIndex = 1;
            this.btn_clients.Text = "Клиенты";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(227, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Главное меню";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Report.Location = new System.Drawing.Point(232, 229);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(170, 45);
            this.btn_Report.TabIndex = 1;
            this.btn_Report.Text = "Должники";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // btn_deleteDatabase
            // 
            this.btn_deleteDatabase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_deleteDatabase.BackColor = System.Drawing.SystemColors.Control;
            this.btn_deleteDatabase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_deleteDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_deleteDatabase.ForeColor = System.Drawing.Color.Black;
            this.btn_deleteDatabase.Location = new System.Drawing.Point(12, 296);
            this.btn_deleteDatabase.Name = "btn_deleteDatabase";
            this.btn_deleteDatabase.Size = new System.Drawing.Size(127, 33);
            this.btn_deleteDatabase.TabIndex = 3;
            this.btn_deleteDatabase.Text = "Очистить базу";
            this.btn_deleteDatabase.UseVisualStyleBackColor = false;
            this.btn_deleteDatabase.Click += new System.EventHandler(this.btn_deleteDatabase_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_close.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.Location = new System.Drawing.Point(543, 296);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(95, 33);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Выйти";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GitHub: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(229, 306);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(257, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/vadim1vanov/CourseWork_OOP";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "21ВП1 Иванов Вадим";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_deleteDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.btn_clients);
            this.Controls.Add(this.btn_books);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_deleteDatabase;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}

