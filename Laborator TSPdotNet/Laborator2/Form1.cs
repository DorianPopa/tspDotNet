using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator2
{
    public partial class Form1 : Form
    {
        private readonly string _calculatorRegex = @"^(\d+\.?\d*)([+\-\*\/])(\d+\.?\d*)$";
        private bool writingFloat = false;
        private bool operationAlreadyExistent = false;
        private bool alreadyComputed = false;

        private float firstNumber = 0f;
        private float secondNumber = 0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            ValidateInput(currentButton.Text);
        }

        private void OpperationButton_Click(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            ValidateInput(currentButton.Text);
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            ComputeOperation();
        }

        private void KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) ||
               (e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '=' || e.KeyChar == '.'))
                ValidateInput(e.KeyChar.ToString());

            //else if (e.KeyChar == 8)    // Backspace
                //resultTextBox.Text = resultTextBox.Text.Remove(resultTextBox.Text.Length - 1, 1);

            else if (e.KeyChar == 13)
                ComputeOperation();     // Enter
        }

        private void ValidateInput(string currentInput)
        {
            List<char> operations = new List<char>() { '*', '/', '+', '-' };


            string currentText = resultTextBox.Text;
            if (currentText == "0" && currentInput[0] >= '1' && currentInput[0] <= '9')
                resultTextBox.Text = currentInput;
            else if(currentInput[0] == '.')
            {
                if (writingFloat)
                    return;
                else if (operations.Contains(resultTextBox.Text[resultTextBox.Text.Length - 1]))
                {
                    writingFloat = true;
                    resultTextBox.Text += "0.";
                }
                else
                {
                    writingFloat = true;
                    resultTextBox.Text += currentInput;
                } 
            }
            else if (operations.Contains(currentInput[0]))
            {
                if (operationAlreadyExistent)
                    return;
                else if (resultTextBox.Text[resultTextBox.Text.Length - 1] == '.')
                    return;
                else
                {
                    writingFloat = false;
                    operationAlreadyExistent = true;
                    resultTextBox.Text += currentInput;
                }
            }
            else if (char.IsDigit(currentInput[0]))
            {
                if(currentInput[0] == '0')
                {
                    if (currentText == "0" || (resultTextBox.Text[resultTextBox.Text.Length - 1] == '0' && !writingFloat))
                        return;
                    else
                        resultTextBox.Text += currentInput;
                }
                else
                {
                    if(resultTextBox.Text[resultTextBox.Text.Length - 1] == '0' && !writingFloat)
                    {
                        writingFloat = true;
                        resultTextBox.Text += "." + currentInput;
                    }
                    else
                    {
                        resultTextBox.Text += currentInput;
                    }
                }
            }
        }

        private void ComputeOperation()
        {
            GroupCollection regexGroups = SplitInput(resultTextBox.Text);
            if (regexGroups == null || regexGroups.Count != 4)
                return;

            firstNumber = Convert.ToSingle(regexGroups[1].Value);
            secondNumber = Convert.ToSingle(regexGroups[3].Value);
            float result = 0f;
            switch (regexGroups[2].Value)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    resultTextBox.Text = result.ToString();
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    resultTextBox.Text = result.ToString();
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    resultTextBox.Text = result.ToString();
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    resultTextBox.Text = result.ToString();
                    break;
            }
        }

        private GroupCollection SplitInput(string input)
        {
            Match m = Regex.Match(resultTextBox.Text, _calculatorRegex);
            if (m.Success)
                return m.Groups;
            else
                return null;
        }
    }
}
