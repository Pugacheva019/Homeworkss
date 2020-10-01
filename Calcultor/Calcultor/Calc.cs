using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcultor
{
    public partial class Calc : Form
    {
        /// <summary>
        /// Инициализирует форму
        /// </summary>
        public Calc()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        /// <summary>
        /// Ввод пользователя
        /// </summary>
        private string inputUser = "";

        /// <summary>
        /// Ответ 
        /// </summary>
        private double answer;

        /// <summary>
        /// Предыдущий оператор
        /// </summary>
        private string lastOperator = "";

        /// <summary>
        /// нажатие "равно"
        /// </summary>
        private bool getAnswer = false;

        /// <summary>
        /// класс нажатия на какую-либо цифру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNumberLabelClick(object sender, EventArgs e)
        {
            if (getAnswer)
            {
                Cleaner();
            }
            var label = sender as Label;
            int value = Int32.Parse(label.Text);
            UpdateInput(value);
            UpdateScreen();
        }

        /// <summary>
        /// Вывод значения на экран
        /// </summary>
        private void UpdateScreen()
        {
            operatorLabel.Text = lastOperator;
            answerLabel.Text = inputUser != "" ? inputUser : "0";
        }

        /// <summary>
        /// класс нажатия на какую-либоа клавишу-операторции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButtonClick(object sender, EventArgs e)
        {
            if (getAnswer)
            {
                getAnswer = false;
                lastOperator = "=";
            }
            var button = sender as Button;
            string currentOperator = button.Text;
            try
            {
                var updatedValues = CalcLogic.CalculateAnswer(answer, inputUser, lastOperator);
                answer = updatedValues.Item2;
                inputUser = "";
                lastOperator = currentOperator;
                UpdateScreen();
            }
            catch (DivideByZeroException)
            {
                answerLabel.Text = "MISTAKE!";
                inputUser = "";
            }
            catch (SyntaxErrorException)
            {
                answerLabel.Text = "MISTAKE";
                inputUser = "";
            }
        }

        /// <summary>
        /// класс нажатия на запятую
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDotButtonClick(object sender, EventArgs e)
        {
            UpdateInput(",");
            UpdateScreen();
        }

        /// <summary>
        /// класс  нажатия на "равно"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnGetAnswerClick(object sender, EventArgs e)
        {
            getAnswer = true;
            operatorLabel.Text = "=";
            try
            {
                var updatedValues = CalcLogic.CalculateAnswer(answer, inputUser, lastOperator);
                answer = updatedValues.Item2;
            }
            catch (DivideByZeroException)
            {
                answerLabel.Text = "Mistake";
                inputUser = "";
                return;
            }
            catch (SyntaxErrorException)
            {
                answerLabel.Text = "Mistake";
                inputUser = "";
                return;
            }
            string toPrint = answer.ToString();
            int index = toPrint.IndexOf(',');
            if (index > 0 && ((index + 2) < toPrint.Length))
            {
                toPrint = toPrint.Substring(0, index + 3);
            }
            if (toPrint.Length <= 8)
            {
                answerLabel.Text = toPrint;
            }
            else
            {
                answerLabel.Text = "Mistake";
            }
        }

        /// <summary>
        ///  класс нажатия на "С"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClearButtonClick(object sender, EventArgs e)
        {
            Cleaner();
        }

        /// <summary>
        /// класс нажатия "backspace"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBackspaceButtonClick(object sender, EventArgs e)
        {
            if (getAnswer)
            {
                Cleaner();
            }
            if (inputUser.Length > 0)
            {
                inputUser = inputUser.Substring(0, inputUser.Length - 1);
            }
            UpdateScreen();
        }

        /// <summary>
        /// Запись ввода пользователя
        /// </summary>
        /// <param name="value"></param>
        private void UpdateInput(string value)
        {
            if (getAnswer)
            {
                Cleaner();
            }
            if (inputUser.ToString().Length >= 8)
            {
                return;
            }
            inputUser = inputUser + value;
            UpdateScreen();
        }

        /// <summary>
        /// очистка
        /// </summary>
        private void Cleaner()
        {
            getAnswer = false;
            answer = 0;
            inputUser = "";
            lastOperator = "";
            UpdateScreen();
        }

        /// <summary>
        /// Запись ввода пользователя
        /// </summary>
        /// <param name="value"></param>
        private void UpdateInput(int value)
        {
            string convertedValue = value.ToString();
            UpdateInput(convertedValue);
        }
    }
}
