namespace ButtonRunning
{
    partial class RunningButtonForm
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
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.Crimson;
            this.Button.Location = new System.Drawing.Point(210, 114);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(119, 52);
            this.Button.TabIndex = 0;
            this.Button.Text = "button";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            this.Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_MouseMove);
            // 
            // RunningButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button);
            this.Name = "RunningButtonForm";
            this.Text = "Button is running!)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button;
    }
}

