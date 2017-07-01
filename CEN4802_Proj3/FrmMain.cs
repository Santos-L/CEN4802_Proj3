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
        //create logger
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //On/Off state
        private bool power = false;

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

        // power button toggles the power On/Off and logs the state
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

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {

        }

        private void btnThree_Click(object sender, EventArgs e)
        {

        }

        private void btnFour_Click(object sender, EventArgs e)
        {

        }

        private void btnFive_Click(object sender, EventArgs e)
        {

        }

        private void btnSix_Click(object sender, EventArgs e)
        {

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {

        }

        private void btnEight_Click(object sender, EventArgs e)
        {

        }

        private void btnNine_Click(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {

        }

        private void powerOff()
        {
            lblHints.Text = "Press the power button";
            this.btnOne.Enabled = false;
            this.btnTwo.Enabled = false;
            this.btnThree.Enabled = false;
            this.btnFour.Enabled = false;
            this.btnFive.Enabled = false;
            this.btnSix.Enabled = false;
            this.btnSeven.Enabled = false;
            this.btnEight.Enabled = false;
            this.btnNine.Enabled = false;
            this.btnZero.Enabled = false;
            this.btnPlus.Enabled = false;
            this.btnMinus.Enabled = false;
            this.btnEquals.Enabled = false;
        }

        private void powerOn()
        {
            lblHints.Text = "Press buttons to start calculating";
            this.btnOne.Enabled = true;
            this.btnTwo.Enabled = true;
            this.btnThree.Enabled = true;
            this.btnFour.Enabled = true;
            this.btnFive.Enabled = true;
            this.btnSix.Enabled = true;
            this.btnSeven.Enabled = true;
            this.btnEight.Enabled = true;
            this.btnNine.Enabled = true;
            this.btnZero.Enabled = true;
            this.btnPlus.Enabled = true;
            this.btnMinus.Enabled = true;
            this.btnEquals.Enabled = true;
        }
    }
}
