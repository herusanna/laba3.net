namespace laba3.net
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
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkLineBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.startButton.Location = new System.Drawing.Point(289, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(142, 48);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.exitButton.Location = new System.Drawing.Point(289, 362);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 48);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkLineBox
            // 
            this.checkLineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkLineBox.Location = new System.Drawing.Point(120, 64);
            this.checkLineBox.Name = "checkLineBox";
            this.checkLineBox.Size = new System.Drawing.Size(480, 283);
            this.checkLineBox.TabIndex = 2;
            this.checkLineBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 422);
            this.Controls.Add(this.checkLineBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Straight lines";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RichTextBox checkLineBox;
    }
}

