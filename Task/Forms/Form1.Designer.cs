namespace Task
{
    partial class Form1
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
            this.BttnControlStudents = new System.Windows.Forms.Button();
            this.BttnControlWorkers = new System.Windows.Forms.Button();
            this.BttnControlDirector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BttnControlStudents
            // 
            this.BttnControlStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnControlStudents.Location = new System.Drawing.Point(13, 68);
            this.BttnControlStudents.Name = "BttnControlStudents";
            this.BttnControlStudents.Size = new System.Drawing.Size(459, 50);
            this.BttnControlStudents.TabIndex = 0;
            this.BttnControlStudents.Text = "Панель управления студентами";
            this.BttnControlStudents.UseVisualStyleBackColor = true;
            this.BttnControlStudents.Click += new System.EventHandler(this.BttnControlStudents_Click);
            // 
            // BttnControlWorkers
            // 
            this.BttnControlWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnControlWorkers.Location = new System.Drawing.Point(12, 124);
            this.BttnControlWorkers.Name = "BttnControlWorkers";
            this.BttnControlWorkers.Size = new System.Drawing.Size(459, 50);
            this.BttnControlWorkers.TabIndex = 1;
            this.BttnControlWorkers.Text = "Панель управления работниками";
            this.BttnControlWorkers.UseVisualStyleBackColor = true;
            this.BttnControlWorkers.Click += new System.EventHandler(this.BttnControlWorkers_Click);
            // 
            // BttnControlDirector
            // 
            this.BttnControlDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BttnControlDirector.Location = new System.Drawing.Point(13, 12);
            this.BttnControlDirector.Name = "BttnControlDirector";
            this.BttnControlDirector.Size = new System.Drawing.Size(459, 50);
            this.BttnControlDirector.TabIndex = 2;
            this.BttnControlDirector.Text = "Панель управления директора";
            this.BttnControlDirector.UseVisualStyleBackColor = true;
            this.BttnControlDirector.Click += new System.EventHandler(this.BttnControlDirector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 186);
            this.Controls.Add(this.BttnControlDirector);
            this.Controls.Add(this.BttnControlWorkers);
            this.Controls.Add(this.BttnControlStudents);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Задание";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BttnControlStudents;
        private System.Windows.Forms.Button BttnControlWorkers;
        private System.Windows.Forms.Button BttnControlDirector;
    }
}

