namespace Calcultor
{
    partial class Calc
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dotButton = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Label();
            this.nine = new System.Windows.Forms.Label();
            this.eight = new System.Windows.Forms.Label();
            this.seven = new System.Windows.Forms.Label();
            this.six = new System.Windows.Forms.Label();
            this.five = new System.Windows.Forms.Label();
            this.four = new System.Windows.Forms.Label();
            this.three = new System.Windows.Forms.Label();
            this.two = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.getAnswerButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dotButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.zero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nine, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.eight, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.seven, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.six, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.five, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.four, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.three, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.two, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.one, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plusButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.minusButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.getAnswerButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.divideButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.multiplyButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.backspaceButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 264);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dotButton
            // 
            this.dotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotButton.Location = new System.Drawing.Point(121, 159);
            this.dotButton.Margin = new System.Windows.Forms.Padding(2);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(54, 47);
            this.dotButton.TabIndex = 7;
            this.dotButton.Text = ",";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.OnDotButtonClick);
            // 
            // zero
            // 
            this.zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.Location = new System.Drawing.Point(62, 157);
            this.zero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(54, 51);
            this.zero.TabIndex = 26;
            this.zero.Text = "0";
            this.zero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.zero.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // nine
            // 
            this.nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(121, 105);
            this.nine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(54, 51);
            this.nine.TabIndex = 25;
            this.nine.Text = "9";
            this.nine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nine.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // eight
            // 
            this.eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(62, 105);
            this.eight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(54, 51);
            this.eight.TabIndex = 24;
            this.eight.Text = "8";
            this.eight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eight.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // seven
            // 
            this.seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(3, 105);
            this.seven.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(54, 51);
            this.seven.TabIndex = 23;
            this.seven.Text = "7";
            this.seven.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.seven.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // six
            // 
            this.six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(121, 53);
            this.six.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(54, 51);
            this.six.TabIndex = 22;
            this.six.Text = "6";
            this.six.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.six.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // five
            // 
            this.five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(62, 53);
            this.five.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(54, 51);
            this.five.TabIndex = 21;
            this.five.Text = "5";
            this.five.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.five.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // four
            // 
            this.four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(3, 53);
            this.four.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(54, 51);
            this.four.TabIndex = 20;
            this.four.Text = "4";
            this.four.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.four.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // three
            // 
            this.three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(121, 1);
            this.three.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(54, 51);
            this.three.TabIndex = 19;
            this.three.Text = "3";
            this.three.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.three.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // two
            // 
            this.two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(62, 1);
            this.two.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(54, 51);
            this.two.TabIndex = 18;
            this.two.Text = "2";
            this.two.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.two.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // one
            // 
            this.one.Dock = System.Windows.Forms.DockStyle.Fill;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(3, 1);
            this.one.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(54, 51);
            this.one.TabIndex = 4;
            this.one.Text = "1";
            this.one.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.one.Click += new System.EventHandler(this.OnNumberLabelClick);
            // 
            // plusButton
            // 
            this.plusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusButton.Location = new System.Drawing.Point(180, 107);
            this.plusButton.Margin = new System.Windows.Forms.Padding(2);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(54, 47);
            this.plusButton.TabIndex = 3;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // minusButton
            // 
            this.minusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusButton.Location = new System.Drawing.Point(180, 159);
            this.minusButton.Margin = new System.Windows.Forms.Padding(2);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(54, 47);
            this.minusButton.TabIndex = 4;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // getAnswerButton
            // 
            this.getAnswerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getAnswerButton.Location = new System.Drawing.Point(180, 211);
            this.getAnswerButton.Margin = new System.Windows.Forms.Padding(2);
            this.getAnswerButton.Name = "getAnswerButton";
            this.getAnswerButton.Size = new System.Drawing.Size(54, 50);
            this.getAnswerButton.TabIndex = 5;
            this.getAnswerButton.TabStop = false;
            this.getAnswerButton.Text = "=";
            this.getAnswerButton.UseVisualStyleBackColor = true;
            this.getAnswerButton.Click += new System.EventHandler(this.OnGetAnswerClick);
            // 
            // divideButton
            // 
            this.divideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideButton.Location = new System.Drawing.Point(180, 55);
            this.divideButton.Margin = new System.Windows.Forms.Padding(2);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(54, 47);
            this.divideButton.TabIndex = 2;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplyButton.Location = new System.Drawing.Point(180, 3);
            this.multiplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(54, 47);
            this.multiplyButton.TabIndex = 1;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearButton.Location = new System.Drawing.Point(3, 159);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(54, 47);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.OnClearButtonClick);
            // 
            // backspaceButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.backspaceButton, 3);
            this.backspaceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backspaceButton.Location = new System.Drawing.Point(3, 211);
            this.backspaceButton.Margin = new System.Windows.Forms.Padding(2);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(172, 50);
            this.backspaceButton.TabIndex = 8;
            this.backspaceButton.Text = "backspace";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.OnBackspaceButtonClick);
            // 
            // answerLabel
            // 
            this.answerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerLabel.Location = new System.Drawing.Point(42, 55);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(184, 59);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "0";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // operatorLabel
            // 
            this.operatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.operatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorLabel.Location = new System.Drawing.Point(3, 55);
            this.operatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.operatorLabel.MaximumSize = new System.Drawing.Size(34, 59);
            this.operatorLabel.MinimumSize = new System.Drawing.Size(34, 59);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(34, 59);
            this.operatorLabel.TabIndex = 3;
            this.operatorLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(237, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operatorLabel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(253, 447);
            this.MinimumSize = new System.Drawing.Size(253, 447);
            this.Name = "Calc";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button getAnswerButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Label one;
        private System.Windows.Forms.Label zero;
        private System.Windows.Forms.Label nine;
        private System.Windows.Forms.Label eight;
        private System.Windows.Forms.Label seven;
        private System.Windows.Forms.Label six;
        private System.Windows.Forms.Label five;
        private System.Windows.Forms.Label four;
        private System.Windows.Forms.Label three;
        private System.Windows.Forms.Label two;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Label label1;
    }
}

