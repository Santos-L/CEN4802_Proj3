﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEN4802_Proj3
{
    public partial class formMain : Form
    {
        // create logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region variables
        // On/Off state
        private bool power;

        // used to reset outputWindow after a calculation
        private bool newCalculation;

        // used to make sure an operator is used
        private bool isAllNumbers = true;
        
        // error counts 
        private int windowFullCount;
        private int operatorTryCount;
        #endregion

        public formMain()
        {
            InitializeComponent();
        }

        // calculator starts in a powered off mode
        private void formMain_Load(object sender, EventArgs e)
        {
            try
            {
                powerOff();
                log.Info("Initializing");
            }
            catch (Exception ex)
            {
                log.Error("Problem loading main", ex);
            }
        }

        #region Button Event Handlers
        // power button toggles the power On/Off and logs the state
        // Req 1)	The calculator shall have an On/Off button for power control.
        private void btnPower_Click(object sender, EventArgs e)
        { 
            // turn off if there is power
            if(this.power)
            {
                try
                {
                    powerOff();
                    log.Info("Powering Off");
                }
                catch (Exception ex)
                {
                    log.Error("Could not power OFF", ex);
                }
            }
            // or on if there isn't
            else
            {
                try
                {
                    powerOn();
                    log.Info("Powering On");
                }
                catch (Exception ex)
                {
                    log.Error("Could not power ON", ex);
                }

            }
            //update power state
            this.power = !this.power;
        }


        private void btnEquals_Click(object sender, EventArgs e)
        {
            powerOn();
            newCalculation = true;

            // Req 18)	The calculator shall not accept an input of just numbers.
            if (isAllNumbers)
            {
                lblHints.Text = "Can't calculate on one number.";
                outputTextBox.Text = "---------------";
            }
            else
            {
                // Req 25)	The calculator shall output the result to the same window used for input.
                outputTextBox.Text = calcResult(outputTextBox.Text);
                lblHints.Text = "Result displayed.";
                log.Info("Result: " + outputTextBox.Text);
            }
            isAllNumbers = true;
        }

        // event handler that sends text from selected number button to outputWindow if it isn't full
        private void btnNum_Click(object sender, EventArgs e)
        {
            // Req 26)	The calculator shall clear the output when a user starts another input.
            if (newCalculation)
            {
                outputTextBox.Text = "";

            }

            // validate input      
            if (outputFull())
            {
                outputFullWarning();
            }
            else
            {
                outputTextBox.Text += ((Button)sender).Text;
                operatorTryCount = 0;
                powerOn();
                newCalculation = false;
            }        
        }

        // event handler for the math buttons with extra checks
        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (outputFull())
            {
                outputFullWarning();
            }
            else if (startingWithAnOperator())
            {
                // Req 19)	The calculator shall not accept an input of just operators.
                lblHints.Text = "Can't start with an operator!";
                operatorTryCounter();

            }
            else if (lastInputWasOperator())
            {
                // Req 20)	The calculator shall not accept an input that contains sequential operators.
                lblHints.Text = "Can't use two operators in a row!";
                operatorTryCounter();
            }
            else if (endingWithAnOperator())
            {
                lblHints.Text = "Can't end with an operator!";
                operatorTryCounter();
            }
            else
            {
                outputTextBox.Text += ((Button)sender).Text;
            }

            isAllNumbers = false;
        }

        #endregion

        #region Methods
        // calculation
        // Req 22)	The calculator shall perform the arithmetic operations request by an accepted input when the equals button is pressed.
        private string calcResult(string input)
        {
            log.Info("Input: " + input);

            long result = 0;
            List<string> numbers = new List<string>() ;
            List<char> orderOfoperations = new List<char>();

            // extract numbers
            log.Info("Trying to extract Numbers from input");
            try
            {
                char[] operators = { '+', '-' };
                numbers.AddRange(input.Split(operators));
                log.Info("Numbers Extacted");
            }
            catch (Exception ex)
            {
                log.Error("Couldn't extract numbers from input", ex);
            }

            // extract operators
            log.Info("Trying to extract Operators from input");
            try
            {
                foreach (char c in input)
                {
                    if (c == '+' || c == '-')
                    {
                        orderOfoperations.Add(c);
                    }
                }
                log.Info("Operators Extacted");
            }
            catch (Exception ex)
            {
                log.Error("Couldn't extract operators from input", ex);
            }

            // start with the first number
            result += Int64.Parse(numbers[0]);

            // modify it according to the input
            log.Info("CalCULATING...");
            try
            {
                for (int i = 1; i < numbers.Count; i++)
                {

                    switch (orderOfoperations[i - 1])
                    {
                        case '+':
                            result += Int64.Parse(numbers[i]);
                            break;
                        case '-':
                            result -= Int64.Parse(numbers[i]);
                            break;
                        default:
                            log.Error("Invalid operator extracted");
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                log.Error( "Could not calculate result.", ex);
            }

            return result.ToString();

        }

        //power states
        private void powerOff()
        {
            lblHints.Text = "Press the power button";
            outputTextBox.Text = "";
            ActiveForm.BackColor = Color.Black;

            this.btnOne.Enabled = false;
            this.btnOne.BackColor = Color.Black;

            this.btnTwo.Enabled = false;
            this.btnTwo.BackColor = Color.Black;

            this.btnThree.Enabled = false;
            this.btnThree.BackColor = Color.Black;

            this.btnFour.Enabled = false;
            this.btnFour.BackColor = Color.Black;

            this.btnFive.Enabled = false;
            this.btnFive.BackColor = Color.Black;

            this.btnSix.Enabled = false;
            this.btnSix.BackColor = Color.Black;

            this.btnSeven.Enabled = false;
            this.btnSeven.BackColor = Color.Black;

            this.btnEight.Enabled = false;
            this.btnEight.BackColor = Color.Black;

            this.btnNine.Enabled = false;
            this.btnNine.BackColor = Color.Black;

            this.btnZero.Enabled = false;
            this.btnZero.BackColor = Color.Black;

            this.btnPlus.Enabled = false;
            this.btnPlus.BackColor = Color.Black;

            this.btnMinus.Enabled = false;
            this.btnMinus.BackColor = Color.Black;

            this.btnEquals.Enabled = false;
            this.btnEquals.BackColor = Color.Black;
        }

        private void powerOn()
        {
            lblHints.Text = "Press buttons to start calculating";

            ActiveForm.BackColor = Color.Green;

            this.btnOne.Enabled = true;
            this.btnOne.UseVisualStyleBackColor = true;

            this.btnTwo.Enabled = true;
            this.btnTwo.UseVisualStyleBackColor = true;

            this.btnThree.Enabled = true;
            this.btnThree.UseVisualStyleBackColor = true;

            this.btnFour.Enabled = true;
            this.btnFour.UseVisualStyleBackColor = true;

            this.btnFive.Enabled = true;
            this.btnFive.UseVisualStyleBackColor = true;

            this.btnSix.Enabled = true;
            this.btnSix.UseVisualStyleBackColor = true;

            this.btnSeven.Enabled = true;
            this.btnSeven.UseVisualStyleBackColor = true;

            this.btnEight.Enabled = true;
            this.btnEight.UseVisualStyleBackColor = true;

            this.btnNine.Enabled = true;
            this.btnNine.UseVisualStyleBackColor = true;

            this.btnZero.Enabled = true;
            this.btnZero.UseVisualStyleBackColor = true;

            this.btnPlus.Enabled = true;
            this.btnPlus.UseVisualStyleBackColor = true;

            this.btnMinus.Enabled = true;
            this.btnMinus.UseVisualStyleBackColor = true;

            this.btnEquals.Enabled = true;
            this.btnEquals.UseVisualStyleBackColor = true;

        }

        // lblHints updators
        private void outputFullWarning()
        {
            windowFullCount++;

            switch  (windowFullCount)
            {
                case 1:
                    log.Info("Input has reached maximum length");
                    goto default;
                case 10:
                    lblHints.Text = "Please, stop.";
                    break;
                case 11:
                    lblHints.Text = "This";
                    break;
                case 12:
                    lblHints.Text = "is";
                    break;
                case 13:
                    lblHints.Text = "madness!";
                    break;
                case 14:
                    lblHints.Text = "Can't...";
                    break;
                case 15:
                    lblHints.Text = "I can't take this anymore!";
                    ActiveForm.BackColor = Color.Red;
                    btnPower.Enabled = false;
                    btnPlus.Enabled = false;
                    btnMinus.Enabled = false;
                    btnOne.Enabled = false;
                    btnTwo.Enabled = false;
                    btnThree.Enabled = false;
                    btnFour.Enabled = false;
                    btnFive.Enabled = false;
                    btnSix.Enabled = false;
                    btnSeven.Enabled = false;
                    btnEight.Enabled = false;
                    btnNine.Enabled = false;
                    btnZero.Enabled = false;
                    break;
                default:
                    // Req 24)	The calculator shall output an error message if the result is too long to display in the window.
                    lblHints.Text = "The input window is full!";
                    break;
            }
        }

        private void operatorTryCounter()
        {
            operatorTryCount++;

            switch (operatorTryCount)
            {
                case 1:
                    log.Info("User tried to press two operators in a row");
                    goto default;
                case 10:
                    lblHints.Text = "Seriously, you can't.";
                    break;
                case 11:
                    lblHints.Text = "I mean't it.";
                    break;
                case 12:
                    lblHints.Text = "Still trying?";
                    break;
                case 13:
                    lblHints.Text = "Are you always like this?";
                    break;
                case 14:
                    lblHints.Text = "Let me help you.";
                    break;
                case 15:
                    lblHints.Text = "Press a number, please.";
                    ActiveForm.BackColor = Color.Purple;
                    btnEquals.Enabled = false;
                    btnPower.Enabled = false;
                    btnPlus.Enabled = false;
                    btnMinus.Enabled = false;
                    break;
                default:
                    // Req 20)	The calculator shall not accept an input that contains sequential operators.
                    lblHints.Text = "Can't use two operators in a row!";
                    break;
            }
        }

        // boolean checks
        private bool outputFull()
        {
            return outputTextBox.Text.Length >= outputTextBox.MaxLength;
        }

        private bool lastInputWasOperator()
        {
            char lastInput = outputTextBox.Text[outputTextBox.Text.Length - 1];

            if (lastInput == '+' || lastInput == '-')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool startingWithAnOperator()
        {
            return outputTextBox.Text.Length == 0;
        }

        private bool endingWithAnOperator()
        {
            return outputTextBox.Text.Length == (outputTextBox.MaxLength - 1);
        }
        #endregion
    }
}
