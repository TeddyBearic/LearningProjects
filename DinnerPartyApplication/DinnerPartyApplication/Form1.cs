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
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numberOfPeopleNumericUpDown.Value, setHealthyOptions.Checked, setFancyDecortaions.Checked) { NumberOfPeople = 5 };
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);
            DisplayBirthdayPartyCost();
        }
        
        public void DisplayDinnerPartyCost()
        {
            dinnerParty.FancyDecorations = setFancyDecortaions.Checked;
            dinnerParty.HealthyOptions = setHealthyOptions.Checked;
            decimal cost = dinnerParty.Cost;
            dinnerPartyCost.Text = cost.ToString("c");
        }

        public void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCost.Text = cost.ToString("c");
        }

        private void numberOfPeopleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberOfPeopleNumericUpDown.Value;
            DisplayDinnerPartyCost();
        }

        private void setFancyDecortaions_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = setFancyDecortaions.Checked;
            DisplayDinnerPartyCost();
        }

        private void setHealthyOptions_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOptions = setHealthyOptions.Checked;
            DisplayDinnerPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }
    }
}

