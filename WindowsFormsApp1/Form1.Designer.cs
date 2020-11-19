namespace WindowsFormsApp1
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
            this.selectButton1 = new System.Windows.Forms.Button();
            this.selectButton2 = new System.Windows.Forms.Button();
            this.insertButton3 = new System.Windows.Forms.Button();
            this.updateButton4 = new System.Windows.Forms.Button();
            this.deleteButton5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectButton1
            // 
            this.selectButton1.Location = new System.Drawing.Point(627, 89);
            this.selectButton1.Name = "selectButton1";
            this.selectButton1.Size = new System.Drawing.Size(83, 23);
            this.selectButton1.TabIndex = 0;
            this.selectButton1.Text = "SELECT1";
            this.selectButton1.UseVisualStyleBackColor = true;
            this.selectButton1.Click += new System.EventHandler(this.selectButton1_Click);
            // 
            // selectButton2
            // 
            this.selectButton2.Location = new System.Drawing.Point(627, 156);
            this.selectButton2.Name = "selectButton2";
            this.selectButton2.Size = new System.Drawing.Size(83, 23);
            this.selectButton2.TabIndex = 1;
            this.selectButton2.Text = "SELECT2";
            this.selectButton2.UseVisualStyleBackColor = true;
            this.selectButton2.Click += new System.EventHandler(this.selectButton2_Click);
            // 
            // insertButton3
            // 
            this.insertButton3.Location = new System.Drawing.Point(627, 231);
            this.insertButton3.Name = "insertButton3";
            this.insertButton3.Size = new System.Drawing.Size(83, 23);
            this.insertButton3.TabIndex = 2;
            this.insertButton3.Text = "INSERT";
            this.insertButton3.UseVisualStyleBackColor = true;
            this.insertButton3.Click += new System.EventHandler(this.insertButton3_Click);
            // 
            // updateButton4
            // 
            this.updateButton4.Location = new System.Drawing.Point(627, 308);
            this.updateButton4.Name = "updateButton4";
            this.updateButton4.Size = new System.Drawing.Size(83, 23);
            this.updateButton4.TabIndex = 3;
            this.updateButton4.Text = "UPDATE";
            this.updateButton4.UseVisualStyleBackColor = true;
            this.updateButton4.Click += new System.EventHandler(this.updateButton4_Click);
            // 
            // deleteButton5
            // 
            this.deleteButton5.Location = new System.Drawing.Point(627, 406);
            this.deleteButton5.Name = "deleteButton5";
            this.deleteButton5.Size = new System.Drawing.Size(83, 23);
            this.deleteButton5.TabIndex = 4;
            this.deleteButton5.Text = "DELETE";
            this.deleteButton5.UseVisualStyleBackColor = true;
            this.deleteButton5.Click += new System.EventHandler(this.deleteButton5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(593, 340);
            this.listBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(593, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deleteButton5);
            this.Controls.Add(this.updateButton4);
            this.Controls.Add(this.insertButton3);
            this.Controls.Add(this.selectButton2);
            this.Controls.Add(this.selectButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectButton1;
        private System.Windows.Forms.Button selectButton2;
        private System.Windows.Forms.Button insertButton3;
        private System.Windows.Forms.Button updateButton4;
        private System.Windows.Forms.Button deleteButton5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

