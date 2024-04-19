namespace Task
{
    partial class ControlDirector
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BttnPromote = new System.Windows.Forms.Button();
            this.BttnPenalize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Повысить выплаты на";
            // 
            // BttnPromote
            // 
            this.BttnPromote.Location = new System.Drawing.Point(12, 55);
            this.BttnPromote.Name = "BttnPromote";
            this.BttnPromote.Size = new System.Drawing.Size(360, 29);
            this.BttnPromote.TabIndex = 2;
            this.BttnPromote.Text = "Повысить";
            this.BttnPromote.UseVisualStyleBackColor = true;
            this.BttnPromote.Click += new System.EventHandler(this.BttnPromote_Click);
            // 
            // BttnPenalize
            // 
            this.BttnPenalize.Location = new System.Drawing.Point(12, 137);
            this.BttnPenalize.Name = "BttnPenalize";
            this.BttnPenalize.Size = new System.Drawing.Size(360, 29);
            this.BttnPenalize.TabIndex = 5;
            this.BttnPenalize.Text = "Оштрафовать";
            this.BttnPenalize.UseVisualStyleBackColor = true;
            this.BttnPenalize.Click += new System.EventHandler(this.BttnPenalize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выписать штраф на";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(360, 20);
            this.textBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(360, 108);
            this.listBox1.TabIndex = 6;
            // 
            // ControlDirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BttnPenalize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BttnPromote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlDirector";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель управления директора";
            this.Load += new System.EventHandler(this.ControlDirector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BttnPromote;
        private System.Windows.Forms.Button BttnPenalize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}