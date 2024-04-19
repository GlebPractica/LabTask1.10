namespace Task
{
    partial class ControlWorkers
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
            this.BttnDelAllSt = new System.Windows.Forms.Button();
            this.BttnShowAllSt = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BttnDescAllSt = new System.Windows.Forms.Button();
            this.BttnSubAllSt = new System.Windows.Forms.Button();
            this.BttnAcceptVal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BttnDelAllSt
            // 
            this.BttnDelAllSt.Location = new System.Drawing.Point(202, 211);
            this.BttnDelAllSt.Name = "BttnDelAllSt";
            this.BttnDelAllSt.Size = new System.Drawing.Size(170, 40);
            this.BttnDelAllSt.TabIndex = 19;
            this.BttnDelAllSt.Text = "Удалить сотрудников";
            this.BttnDelAllSt.UseVisualStyleBackColor = true;
            this.BttnDelAllSt.Click += new System.EventHandler(this.BttnDelAllSt_Click);
            // 
            // BttnShowAllSt
            // 
            this.BttnShowAllSt.Location = new System.Drawing.Point(12, 211);
            this.BttnShowAllSt.Name = "BttnShowAllSt";
            this.BttnShowAllSt.Size = new System.Drawing.Size(170, 40);
            this.BttnShowAllSt.TabIndex = 18;
            this.BttnShowAllSt.Text = "Просмотреть сотрудников";
            this.BttnShowAllSt.UseVisualStyleBackColor = true;
            this.BttnShowAllSt.Click += new System.EventHandler(this.BttnShowAllSt_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 264);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 186);
            this.listBox1.TabIndex = 17;
            // 
            // BttnDescAllSt
            // 
            this.BttnDescAllSt.Location = new System.Drawing.Point(202, 165);
            this.BttnDescAllSt.Name = "BttnDescAllSt";
            this.BttnDescAllSt.Size = new System.Drawing.Size(170, 40);
            this.BttnDescAllSt.TabIndex = 16;
            this.BttnDescAllSt.Text = "Отписать сотрудников";
            this.BttnDescAllSt.UseVisualStyleBackColor = true;
            this.BttnDescAllSt.Click += new System.EventHandler(this.BttnDescAllSt_Click);
            // 
            // BttnSubAllSt
            // 
            this.BttnSubAllSt.Location = new System.Drawing.Point(12, 165);
            this.BttnSubAllSt.Name = "BttnSubAllSt";
            this.BttnSubAllSt.Size = new System.Drawing.Size(170, 40);
            this.BttnSubAllSt.TabIndex = 15;
            this.BttnSubAllSt.Text = "Подписать сотрудников";
            this.BttnSubAllSt.UseVisualStyleBackColor = true;
            this.BttnSubAllSt.Click += new System.EventHandler(this.BttnSubAllSt_Click);
            // 
            // BttnAcceptVal
            // 
            this.BttnAcceptVal.Location = new System.Drawing.Point(12, 99);
            this.BttnAcceptVal.Name = "BttnAcceptVal";
            this.BttnAcceptVal.Size = new System.Drawing.Size(359, 30);
            this.BttnAcceptVal.TabIndex = 14;
            this.BttnAcceptVal.Text = "Принять";
            this.BttnAcceptVal.UseVisualStyleBackColor = true;
            this.BttnAcceptVal.Click += new System.EventHandler(this.BttnAcceptVal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Зарплата работника";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(359, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ФИО работника";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(359, 20);
            this.textBox1.TabIndex = 10;
            // 
            // ControlWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.BttnDelAllSt);
            this.Controls.Add(this.BttnShowAllSt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BttnDescAllSt);
            this.Controls.Add(this.BttnSubAllSt);
            this.Controls.Add(this.BttnAcceptVal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlWorkers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления работниками";
            this.Load += new System.EventHandler(this.ControlWorkers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttnDelAllSt;
        private System.Windows.Forms.Button BttnShowAllSt;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BttnDescAllSt;
        private System.Windows.Forms.Button BttnSubAllSt;
        private System.Windows.Forms.Button BttnAcceptVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}