using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerPartyApplication
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHealthyOption(setHealthyOptions.Checked);
            dinnerParty.CalculateCostOfDecorations(setFancyDecortaions.Checked);
            DisplayDinnerPartyCost();
        }
        
        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(setHealthyOptions.Checked);
            totalCostTextbox.Text = Cost.ToString("c");
        }

        private void numberOfPeopleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int) numberOfPeopleNumericUpDown.Value;
            dinnerParty.CalculateCostOfDecorations(setFancyDecortaions.Checked);
            DisplayDinnerPartyCost();
        }

        private void setFancyDecortaions_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(setFancyDecortaions.Checked);
            DisplayDinnerPartyCost();
        }

        private void setHealthyOptions_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(setHealthyOptions.Checked);
            DisplayDinnerPartyCost();
        }
    }
}

