using System;
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

        // On/Off state
        private bool power;

        // error counts 
        int windowFullCount;

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
            //to be implemented later
        }

        // event handler that sends text from selected number button to outputWindow if it isn't full
        private void btnNum_Click(object sender, EventArgs e)
        {   
            // validate input      
            if (outputTextBox.Text.Length >= outputTextBox.MaxLength)
            {
                // Req 24)	The calculator shall output an error message if the result is too long to display in the window.
                lblHints.Text = "The input window is full!";

                log.Info("Input has reached maximum length");
                windowFullCount++;

                if (windowFullCount > 10)
                {
                    lblHints.Text = "Please stop";
                }
            }
            else
            {
                outputTextBox.Text += ((Button)sender).Text;
            }        
        }


        #endregion

        #region Methods
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
            if (outputTextBox.Text.Length == 0)
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
