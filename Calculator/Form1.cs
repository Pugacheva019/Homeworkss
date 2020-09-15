using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }
        
        private void One_Click(object sender, EventArgs e)
        {
           if (textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }
           if (label1.Text == "MISTAKE")
            {
                Delete.PerformClick();
                textBox_Result.Clear();
            }
            textBox_Result.Text += (sender as Button).Text;
            label1.Text +=  (sender as Button).Text;
        }
        
        Double Value = 0;
        
        String Operation = "";
        
        int ScoreOperation = 0;
        
        private void Operation_click(object sender, EventArgs e)
        {
            if (label1.Text == "MISTAKE")
            {
                Delete.PerformClick();
            }
            
            Button button = (Button)sender;
            
            if (ScoreOperation == 0)
            {
                Operation = button.Text;
                
                if (Operation !="/")
                {
                    Value = Double.Parse(textBox_Result.Text);
                    label1.Text += " " + Operation;
                    textBox_Result.Clear();
                    ScoreOperation += 1;
                }
                else
                {
                    Value = Double.Parse(textBox_Result.Text);
                    label1.Text += " " + Operation;
                    textBox_Result.Clear();
                    ScoreOperation += 1;
                    DivisionsOperation += 1;
                }
            }
            else if ((ScoreOperation != 0))
            {
                label1.Text = textBox_Result.Text;
                Equally.PerformClick();
                Operation = button.Text;
                
                if (Operation != "/")
                {
                    Value = Double.Parse(textBox_Result.Text);
                    label1.Text += " " + Operation;
                    textBox_Result.Clear();
                    ScoreOperation += 1;
                }
                else
                {
                    Value = Double.Parse(textBox_Result.Text);
                    label1.Text += " " + Operation;
                    textBox_Result.Clear();
                    ScoreOperation += 1;
                    DivisionsOperation += 1;
                }
            }
        }
        
        private void Delete_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            Value = 0;
            label1.Text = "";
            ScoreOperation = 0;
        }
        
        private void Equally_Click(object sender, EventArgs e)
        {
          if ((ScoreOperation != 0) && (DivisionsOperation == 0))
          {
                switch (Operation)
                {
                    case "+":
                        textBox_Result.Text = (Value + Double.Parse(textBox_Result.Text)).ToString(); 
                        break;
                    case "-":
                        textBox_Result.Text = (Value - Double.Parse(textBox_Result.Text)).ToString(); 
                        break;
                    case "x":
                        textBox_Result.Text = (Value * Double.Parse(textBox_Result.Text)).ToString(); 
                        break;
                    case "%":
                        textBox_Result.Text = (Value * 100 / Double.Parse(textBox_Result.Text)).ToString(); 
                        break;
                }
                label1.Text = textBox_Result.Text;
                ScoreOperation = 0;
          }
          else if (DivisionsOperation != 0)
            {
                if (Double.Parse(textBox_Result.Text) != 0)
                {
                    textBox_Result.Text = (Value / Double.Parse(textBox_Result.Text)).ToString();
                    DivisionsOperation = 0;
                    label1.Text = textBox_Result.Text;
                    ScoreOperation = 0;
                }
                else
                {
                    label1.Text = "MISTAKE";
                    DivisionsOperation = 0;
                    ScoreOperation = 0;
                }
            }
        }
        
        private void Label(object sender, EventArgs e)
        {

        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (!textBox_Result.Text.Contains(","))
            {
                textBox_Result.Text += ",";
                label1.Text += ",";
            }
        }

        private void Deleting_Click(object sender, EventArgs e)
        {
            if((textBox_Result.Text.Length != 0)&&(textBox_Result.Text != "0"))
            {
                textBox_Result.Text = textBox_Result.Text.Remove(textBox_Result.Text.Length - 1, 1);
                if (textBox_Result.Text == "")
                {
                    textBox_Result.Text = "0";
                }
                label1.Text = label1.Text.Remove(label1.Text.Length -1, 1);
            }
        }
        
        int DivisionsOperation = 0;
    }
}
