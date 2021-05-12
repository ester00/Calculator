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
    public partial class Calculator : Form
    {
        private string memory;

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Calculator()
        {
            InitializeComponent();
            this.memory = string.Empty;
        }

        #endregion

        #region Clearing Methods
        private void DelButton_Click(object sender, EventArgs e)
        {
            DeleteTextValue();

           // FocusInputText();
        }

        /// <summary>
        /// Clears the user input text
        /// </summary>
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = String.Empty;

            FocusInputText();
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            this.CalculationResultsText.Text = "";
            this.UserInputText.Text = String.Empty;

            FocusInputText();
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            this.memory = string.Empty;
        }

        private void MRButton_Click(object sender, EventArgs e)
        {
            UserInputText.Text = UserInputText.Text + this.memory;
        }

        private void M1Button_Click(object sender, EventArgs e)
        {
            this.memory =(double.Parse(this.memory) + double.Parse(UserInputText.Text)).ToString(); 
        }

        private void M2Button_Click(object sender, EventArgs e)
        {
            this.memory = (double.Parse(this.memory) - double.Parse(UserInputText.Text)).ToString();
        }
        #endregion

        #region Operator Functions
        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("√");

            FocusInputText();
        }

        private void DevisionButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("÷");

            FocusInputText();
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("x");

            FocusInputText();
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            FocusInputText();
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            //var value = int.Parse(this.UserInputText.Text);
            //this.TotalValue += value;

            FocusInputText();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();

            FocusInputText();
        }

        #endregion

        private void CalculateEquation()
        {

            this.CalculationResultsText.Text = ParseOperation().ToString();

            FocusInputText();
        }

        private object ParseOperation()
        {
            try
            {
                var Input = this.UserInputText.Text;

                Input = Input.Replace(" ", "");

                var Operation = new Operation();
                var LeftSide = true;

                for (int i = 0; i < Input.Length; i++)
                {
                    if ("1234567890.".Any(c => Input[i] == c))
                    {
                        if (LeftSide)
                            Operation.LeftSide = AddNumberPart(Operation.LeftSide, Input[i]);
                        else
                            Operation.RightSide = AddNumberPart(Operation.RightSide, Input[i]);
                    }
                    else if ("+-x÷√".Any(c => Input[i] == c))
                    {
                        if (Input[i] == '√')
                        {
                            int counter = 0;
                            bool isMultipleDigit = false;
                            for (int v = i+1; v < Input.Length; v++)
                            {
                                if ("+-x÷√".Any(c => Input[v] == c) )
                                {
                                    break;
                                    isMultipleDigit = true;
                                }
                                counter++;
                            }
                            var curNumber = Math.Sqrt(double.Parse(Input.Substring(i + 1, counter))).ToString();

                            if (isMultipleDigit == false && Input.Length-counter-1 == 0)
                            {
                                return curNumber;
                            }

                            for (int c = 0; c < curNumber.Length; c++)
                            {
                                if (LeftSide)
                                    Operation.LeftSide = AddNumberPart(Operation.LeftSide, curNumber[c]);
                                else
                                    Operation.RightSide = AddNumberPart(Operation.RightSide, curNumber[c]);
                            }
                            for (int y = 0; y < counter; y++)
                            {
                                i++;
                            }
                        }
                       else if (!LeftSide)
                        {
                            var operatorType = GetOperationType(Input[i]);

                            if (Operation.RightSide.Length == 0)
                            {
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ x ÷ √ or more than one -) specified whithout a right side number.");
                                Operation.RightSide += Input[i];


                            }
                            else
                            {
                                Operation.LeftSide = CalculateOperation(Operation);

                                Operation.OperationType = operatorType;

                                Operation.RightSide = String.Empty;
                            }
                        }
                        else
                        {
                            var operatorType = GetOperationType(Input[i]);

                            if (Operation.LeftSide.Length == 0)
                            {
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ x ÷ √ or more than one -) specified whithout a left side number.");
                                Operation.LeftSide += Input[i];


                            }
                            else
                            {
                                Operation.OperationType = operatorType;
                                LeftSide = false;

                            }
                        }
                    }
                }
                    
                return CalculateOperation(Operation);
            }
            catch (Exception ex)
            {
                return $"Invalid equation. { ex.Message}";
            }
        }

        private string CalculateOperation(Operation operation)
        {
            decimal left = 0;
            decimal right = 0;

            if (string.IsNullOrEmpty(operation.LeftSide) || !decimal.TryParse(operation.LeftSide, out left))
                throw new InvalidOperationException($"Left side of the operation is not a number. {operation.LeftSide}");

            if (string.IsNullOrEmpty(operation.RightSide) || !decimal.TryParse(operation.RightSide, out right))
                throw new InvalidOperationException($"Right side of the operation is not a number. {operation.RightSide}");

            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return ((int)left / (int)right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unkown operator type when calculating operation. {operation.OperationType}");

                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");

            }


            return String.Empty;
        }

        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case 'x':
                    return OperationType.Multiply;
                case '÷':
                    return OperationType.Divide;
                case '√':
                    return OperationType.SquareRoot;
                default:
                    throw new InvalidOperationException($"Unknown operator type {character}");

            }
        }

        private string AddNumberPart(string currentNumber, char newCarachter)
        {
            if (newCarachter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number already contains a dot and another can not be added.");
            return currentNumber + newCarachter;
        }


        #region Number Functions
        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            FocusInputText();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            FocusInputText();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            FocusInputText();
        }

        private void NIneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            FocusInputText();
        }
        #endregion

        #region
        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        private void InsertTextValue(string value)
        {
            var selectionStart = this.UserInputText.SelectionStart;

            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            this.UserInputText.SelectionStart = selectionStart + value.Length;

            this.UserInputText.SelectionLength = 0;
        }

        private void DeleteTextValue()
        {
            if (UserInputText.Text.Length == 0)
                return;

            UserInputText.Text = UserInputText.Text.Substring(0, UserInputText.Text.Length - 1);

        }

        #endregion

        private void MSButton_Click(object sender, EventArgs e)
        {
            this.memory = UserInputText.Text;
            this.MCButton.Enabled = true;
            this.MRButton.Enabled = true;
        }
    }


}
