using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// basic caculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region 
        /// <summary>
        ///  basic constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        /// <summary>
        /// clear the user input text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInput.Text = string.Empty;
            this.UserInput.Focus();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text.Length >= this.UserInput.SelectionStart + 1)
                removeValue();
            focusInput();
        }

        private void DivBouton_Click(object sender, EventArgs e)
        {
            addValue("%");
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            addValue("7");
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            addValue("8");
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            addValue("9");
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            addValue("X");
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            addValue("4");
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            addValue("5");
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            addValue("6");
        }

        private void BtnMoins_Click(object sender, EventArgs e)
        {
            addValue("-");
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            addValue("1");
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            addValue("2");
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            addValue("3");
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            addValue("+");
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            addValue("0");
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            addValue(".");
        }

        private void BtnEgale_Click(object sender, EventArgs e)
        {
            this.UserInput.Focus();
            Calculate();
        }


        #region Private Helpers

        private void focusInput()
        {
            this.UserInput.Focus();
        }
        private void addValue(string n)
        {
            var selectionStart = this.UserInput.SelectionStart;
            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.SelectionStart, n);
            UserInput.SelectionStart = selectionStart + n.Length;
            UserInput.SelectionLength = 0;
            focusInput();
        }
        private void removeValue()
        {
            var selectionStart = this.UserInput.SelectionStart;
            this.UserInput.Text = this.UserInput.Text.Remove(this.UserInput.SelectionStart, 1);
            UserInput.SelectionStart = selectionStart ;
            UserInput.SelectionLength = 0;
        }

        private void Calculate()
        {
            var userInput = UserInput.Text;
            Results.Text = ParseOperation();
        }
        /// <summary>
        /// Parses the users equation and calculates the results
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                var userInput = UserInput.Text;
                userInput = userInput.Replace(" ", "");
                var operation = new Operation();
                var leftSide = true;

                for(int i=0; i < userInput.Length; i++)
                {

                    if ("0123456789.".Contains(userInput[i]))
                    {
                        
                        if (leftSide)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, userInput[i]);
                        }
                        else
                        {
                            operation.RightSide = AddNumberPart(operation.RightSide, userInput[i]);
                        }
                    }else if ("+-*/xX".Contains(userInput[i]))
                    {
                        if (!leftSide)
                        {
                            var operatorType = GetOperationType(userInput[i]);
                        }
                        else
                        {
                            var operatorType = GetOperationType(userInput[i]);
                            if (operation.LeftSide.Length == 0)
                            {
                                if (operatorType != OperationsType.Minus)
                                    throw new InvalidOperationException($"Operator + * / or more than one -) specified without an left side number");
                                operation.LeftSide += userInput[i];

                            }
                            else
                            {
                                operation.OperationsType = operatorType;
                                leftSide = false;
                            }
                        }
                    }
                }

                return CalculateOperation(operation);
                
            }
            catch (Exception e)
            {
                return $"invalid equation. {e.Message}";
            }
        }

        private string CalculateOperation(Operation operation)
        {
            double leftside = 0;
            double rightside = 0;

            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out leftside))
                throw new InvalidOperationException($"Left Side of the operation was not a number. {operation}");

            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out rightside))
                throw new InvalidOperationException($"Right Side of the operation was not a number. {operation}");

            try
            {
                switch (operation.OperationsType)
                {
                    case OperationsType.Add:
                        return (leftside + rightside).ToString();
                    case OperationsType.Minus:
                        return (leftside - rightside).ToString();
                    case OperationsType.Divide:
                        return ((int)leftside / (int)rightside).ToString();
                    case OperationsType.Multiply:
                        return (leftside * rightside).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. {operation.OperationsType}");
                }
            }catch(Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationsType} {operation.RightSide}. {ex.Message}");
            }
        }

        /// <summary>
        /// accepts a character and return the known <see cref="OperationsType"/>
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>

        private OperationsType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationsType.Add;
                case '-':
                    return OperationsType.Minus;
                case '/':
                    return OperationsType.Divide;
                case '*':
                    return OperationsType.Multiply;
                case 'x':
                    return OperationsType.Multiply;
                case 'X':
                    return OperationsType.Multiply;
                default:
                    throw new InvalidOperationException($"unknown operator type {character}");
            }
        }
        private string AddNumberPart(string currNumber, char newChar)
        {
            if(newChar == '.' && currNumber.Contains('.'))
            {
                throw new InvalidOperationException($"Number {currNumber} already contains a . and another cannot be added");
            }

            return currNumber+newChar;
        }
        #endregion
    }
}
