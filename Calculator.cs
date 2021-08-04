using System;
using System.Windows.Forms;

namespace WoodshopCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void LengthOpt1_CheckedChanged(object sender, EventArgs e)
        {
            if (LengthOpt1.Checked)
            {
                LengthOpt2.Checked = false;
            }
        }

        private void LengthOpt2_CheckedChanged(object sender, EventArgs e)
        {
            if (LengthOpt2.Checked)
            {
                LengthOpt1.Checked = false;
            }
        }

        private void WidthOpt1_CheckedChanged(object sender, EventArgs e)
        {
            if (WidthOpt1.Checked)
            {
                WidthOpt2.Checked = false;
            }
        }

        private void WidthOpt2_CheckedChanged(object sender, EventArgs e)
        {
            if (WidthOpt2.Checked)
            {
                WidthOpt1.Checked = false;
            }
        }

        private void ThickOpt1_CheckedChanged(object sender, EventArgs e)
        {
            if (ThickOpt1.Checked)
            {
                ThickOpt2.Checked = false;
            }
        }

        private void ThickOpt2_CheckedChanged(object sender, EventArgs e)
        {
            if (ThickOpt2.Checked)
            {
                ThickOpt1.Checked = false;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ResetTextDisplays();
            //Verify all buttons are properly selected, call verify numbers method 
            bool buttonsVerified = VerifyRadioButtons();
            bool numsVerified = VerifyInputs();

            if (numsVerified && buttonsVerified)
            {
                RadioErrorLabel.Visible = false;
                InputErrorLabel.Visible = false;
                Calculations();
            }
            else if (!buttonsVerified)
            {
                RadioErrorLabel.Text += "Error: Please select an option from each column.";
                RadioErrorLabel.Visible = true;

            }
            else if (!numsVerified)
            {
                InputErrorLabel.Text += "Error: Please enter valid numerical values";
                InputErrorLabel.Visible = true;
            }

        }

        private bool VerifyInputs()
        {
            bool stockLengthBool = double.TryParse(StockLengthEntry.Text, out _);
            bool stockWidthBool = double.TryParse(StockWidthEntry.Text, out _);
            bool stockThickBool = double.TryParse(StockThickEntry.Text, out _);

            //If all inputs are numbers, return true
            if (stockLengthBool && stockWidthBool && stockThickBool)
            {
                return true;
            }
            return false;
        }

        private bool VerifyRadioButtons()
        {
            if ((LengthOpt1.Checked || LengthOpt2.Checked) &&
                (WidthOpt1.Checked || WidthOpt2.Checked) &&
                (ThickOpt1.Checked || ThickOpt2.Checked))
            {
                return true;
            }
            return false;
        }

        private void Calculations()
        {
            /*  Constants: placeholder:
            final length = 19.25; 22.25       a
            final width = 12.25; 14.25        b
            final thickness = 2.125; 2.625    c
            d = 2.25; 2.75 depending c+.125

            Variables:
             l = starting board length
             t  = starting board thickness
             w  = starting board width
             y  = number of strips cut across the grain
             d  = thickness of strips cut across the grain +saw blade(0.125")
             z = number of strips cut along the grain
             e = thickness of strips cut along the grain + saw blade(0.125")
             p = z rounded down to the next integer*/

            double l = Convert.ToDouble(StockLengthEntry.Text);
            double t = Convert.ToDouble(StockThickEntry.Text);
            double w = Convert.ToDouble(StockWidthEntry.Text);

            double a, b, c;
            if (LengthOpt1.Checked)
            {
                a = 19.25;
            }
            else //(LengthOpt2.Checked)
            {
                a = 22.25;
            }
            if (WidthOpt1.Checked)
            {
                b = 12.25;
            }
            else //WidthOpt2.Checked
            {
                b = 14.25;
            }
            if (ThickOpt1.Checked)
            {
                c = 2.125;
            }
            else //(ThickOpt2.Checked)
            {
                c = 2.625;
            }

            FindMinLength(a, c, t);
            FindMinThick(a, c, l);
            UseInButchBlock(a, c, l, t);
            MakeWidthButchBlock(b, t, w);
            MakeFullButchBlock(a, b, c, l, t, w);
        }

        private void FindMinLength(double a, double c, double t)
        {
            double l = a * ((c + 0.125) / t);

            MinLengthOutLabel.Text += "Minimum Stock Length: " + Math.Round(l, 2).ToString();
        }
        private void FindMinThick(double a, double c, double l)
        {
            double t = (a / l) * (c + 0.125);

            MinThickOutLabel.Text += "Minimum Stock Thickness: " + Math.Round(t, 2).ToString();
        }

        private void UseInButchBlock(double a, double c, double l, double t)
        {
            if (l >= a * ((c + 0.125) / t) && t >= (a / l) * (c + 0.125))
            {
                UseButchBlockOutLabel.Text += "Can it be used in a butcher block? Yes";
            }
            else
            {
                UseButchBlockOutLabel.Text += "Can it be used in a butcher block? No";
            }
        }

        private void MakeWidthButchBlock(double b, double t, double w)
        {
            double p = Math.Floor((b / t) + 0.125);

            if (w >= b + ((p - 1) * 0.125))
            {
                WideButchBlockOutLabel.Text += "Can it make up the width of a butcher block? Yes";
            }
            else
            {
                WideButchBlockOutLabel.Text += "Can it make up the width of a butcher block? No";
            }
        }

        private void MakeFullButchBlock(double a, double b, double c, double l, double t, double w)
        {
            double p = Math.Floor((b / t) + 0.125);

            if (l >= a * ((c + 0.125) / t) && t >= (a / l) * (c + 0.125) && w >= b + ((p - 1) * 0.125))
            {
                WholeButchBlockOutLabel.Text += "Can it make a whole butcher block? Yes";
            }
            else
            {
                WholeButchBlockOutLabel.Text += "Can it make a whole butcher block? No";
            }
        }

        private void ResetTextDisplays()
        {
            RadioErrorLabel.ResetText();
            InputErrorLabel.ResetText();
            MinLengthOutLabel.ResetText();
            MinThickOutLabel.ResetText();
            WideButchBlockOutLabel.ResetText();
            WholeButchBlockOutLabel.ResetText();
            UseButchBlockOutLabel.ResetText();
        }  
    }
}
