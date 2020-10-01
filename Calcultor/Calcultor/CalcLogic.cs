using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcultor
{
    class CalcLogic
    {

        /// <summary>
        /// Работа калькулятора
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="inputUser"></param>
        /// <param name="lastOperator"></param>
        /// <returns></returns>
        public static Tuple<double, double> CalculateAnswer(double answer, string inputUser, string lastOperator)
        {
            double Value;
            if (inputUser == "")
            {
                Value = 0;
            }
            else if (!Double.TryParse(inputUser, out Value))
            {
            }
            switch (lastOperator)
            {
                case "-":
                    answer -= Value;
                    break;
                case "+":
                    answer += Value;
                    break;
                case "*":
                    answer *= Value;
                    break;
                case "/":
                    if (Value == 0)
                    {
                        throw new DivideByZeroException("MISTAKE");
                    }
                    answer /= Value;
                    break;
                case "=":
                    Value = answer;
                    break;
                case "":
                    answer = Value;
                    break;
                default:
                    break;
            }
            return Tuple.Create(Value, answer);
        }
    }
}