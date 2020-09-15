namespace Calculator
{
    partial class Window
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
            this.Deleting = new System.Windows.Forms.Button();
            this.Equally = new System.Windows.Forms.Button();
            this.Percent = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.Null = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Deleting
            // 
            this.Deleting.BackColor = System.Drawing.Color.RosyBrown;
            this.Deleting.Location = new System.Drawing.Point(162, 21);
            this.Deleting.Name = "Deleting";
            this.Deleting.Size = new System.Drawing.Size(36, 49);
            this.Deleting.TabIndex = 0;
            this.Deleting.Text = "<-";
            this.Deleting.UseVisualStyleBackColor = false;
            this.Deleting.Click += new System.EventHandler(this.Deleting_Click);
            // 
            // Equally
            // 
            this.Equally.BackColor = System.Drawing.Color.RosyBrown;
            this.Equally.Location = new System.Drawing.Point(131, 105);
            this.Equally.Name = "Equally";
            this.Equally.Size = new System.Drawing.Size(67, 52);
            this.Equally.TabIndex = 1;
            this.Equally.Text = "=";
            this.Equally.UseVisualStyleBackColor = false;
            this.Equally.Click += new System.EventHandler(this.Equally_Click);
            // 
            // Percent
            // 
            this.Percent.BackColor = System.Drawing.Color.RosyBrown;
            this.Percent.Location = new System.Drawing.Point(131, 47);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(25, 23);
            this.Percent.TabIndex = 2;
            this.Percent.Text = "%";
            this.Percent.UseVisualStyleBackColor = false;
            this.Percent.Click += new System.EventHandler(this.Operation_click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.RosyBrown;
            this.Delete.Location = new System.Drawing.Point(131, 76);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(67, 23);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "CE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.RosyBrown;
            this.Four.Location = new System.Drawing.Point(2, 76);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(26, 23);
            this.Four.TabIndex = 4;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.One_Click);
            // 
            // Three
            // 
            this.Three.BackColor = System.Drawing.Color.RosyBrown;
            this.Three.Location = new System.Drawing.Point(65, 47);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(27, 23);
            this.Three.TabIndex = 5;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = false;
            this.Three.Click += new System.EventHandler(this.One_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.RosyBrown;
            this.Eight.Location = new System.Drawing.Point(32, 105);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(27, 23);
            this.Eight.TabIndex = 6;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.One_Click);
            // 
            // Nine
            // 
            this.Nine.BackColor = System.Drawing.Color.RosyBrown;
            this.Nine.Location = new System.Drawing.Point(65, 105);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(27, 23);
            this.Nine.TabIndex = 7;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = false;
            this.Nine.Click += new System.EventHandler(this.One_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.RosyBrown;
            this.Seven.Location = new System.Drawing.Point(2, 105);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(26, 23);
            this.Seven.TabIndex = 8;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.One_Click);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.RosyBrown;
            this.Plus.Location = new System.Drawing.Point(97, 134);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(28, 23);
            this.Plus.TabIndex = 9;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Operation_click);
            // 
            // One
            // 
            this.One.BackColor = System.Drawing.Color.RosyBrown;
            this.One.Location = new System.Drawing.Point(2, 47);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(26, 23);
            this.One.TabIndex = 10;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = false;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.Color.RosyBrown;
            this.Point.Location = new System.Drawing.Point(65, 134);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(26, 23);
            this.Point.TabIndex = 11;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = false;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Two
            // 
            this.Two.BackColor = System.Drawing.Color.RosyBrown;
            this.Two.Location = new System.Drawing.Point(32, 47);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(27, 23);
            this.Two.TabIndex = 12;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = false;
            this.Two.Click += new System.EventHandler(this.One_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.RosyBrown;
            this.button14.Location = new System.Drawing.Point(97, 47);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(28, 23);
            this.button14.TabIndex = 13;
            this.button14.Text = "/";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Operation_click);
            // 
            // Null
            // 
            this.Null.BackColor = System.Drawing.Color.RosyBrown;
            this.Null.Location = new System.Drawing.Point(2, 134);
            this.Null.Name = "Null";
            this.Null.Size = new System.Drawing.Size(57, 23);
            this.Null.TabIndex = 14;
            this.Null.Text = "0";
            this.Null.UseVisualStyleBackColor = false;
            this.Null.Click += new System.EventHandler(this.One_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.RosyBrown;
            this.Five.Location = new System.Drawing.Point(32, 76);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(27, 23);
            this.Five.TabIndex = 15;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.One_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.RosyBrown;
            this.Six.Location = new System.Drawing.Point(65, 76);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(27, 23);
            this.Six.TabIndex = 16;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.One_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.RosyBrown;
            this.button18.Location = new System.Drawing.Point(97, 76);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(28, 23);
            this.button18.TabIndex = 17;
            this.button18.Text = "x";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Operation_click);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.RosyBrown;
            this.Minus.Location = new System.Drawing.Point(97, 105);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(28, 23);
            this.Minus.TabIndex = 18;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Operation_click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox_Result.Location = new System.Drawing.Point(2, 21);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(154, 20);
            this.textBox_Result.TabIndex = 19;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            this.label1.Click += new System.EventHandler(this.Label);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(209, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Null);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.Equally);
            this.Controls.Add(this.Deleting);
            this.Name = "Window";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Deleting;
        private System.Windows.Forms.Button Equally;
        private System.Windows.Forms.Button Percent;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button Null;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label1;
    }
}

