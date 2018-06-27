using System;
using System.Windows.Forms;

namespace CalculationsAndConversionsCalculator
{
    public partial class formMiscellaneous : Form
    {
        public formMiscellaneous()
        {
            InitializeComponent();
        }

        private void buttonBirthYearGo_Click(object sender, EventArgs e)
        {
            var isNum = int.TryParse(textBoxLeapYearInput.Text, out var birthYear);

            if (string.IsNullOrWhiteSpace(textBoxLeapYearInput.Text))
            {
                MessageBox.Show("Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLeapYearInput.Focus();
                return;
            }

            if (birthYear <= 0)
            {
                MessageBox.Show("Your Age is Zero?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLeapYearInput.Clear();
                textBoxLeapYearInput.Focus();
            }

            if (!isNum)
            {
                MessageBox.Show("Numbers Only.  No Decimals or Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLeapYearInput.Clear();
                textBoxLeapYearInput.Focus();
                return;
            }

            if (birthYear % 4 == 0)
            {
                if (birthYear % 100 == 0)
                {
                    if (birthYear % 400 == 0)
                    {
                        textBoxLeapYearIsALeapYear.Text = "Is A Leap Year";
                    }
                    else
                    {
                        textBoxLeapYearIsALeapYear.Text = "Is Not A Leap Year";
                    }
                }
                else
                {
                    textBoxLeapYearIsALeapYear.Text = "Is A Leap Year";
                }
            }
            else
            {
                textBoxLeapYearIsALeapYear.Text = "Is Not A Leap Year";
            }


        }



        private void buttonCircuitryHome_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void buttonBirthYearClear_Click(object sender, EventArgs e)
        {
            textBoxLeapYearInput.Clear();
            textBoxLeapYearIsALeapYear.Clear();
            textBoxLeapYearInput.Focus();
        }

        private void buttonCircuitryExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDiscountCalculatorCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDiscountCalculatorDiscountRate.Text))
            {
                MessageBox.Show("Please Enter Discount %", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDiscountCalculatorDiscountRate.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDiscountCalculatorPrice.Text))
            {
                MessageBox.Show("Please Enter Discount %", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDiscountCalculatorDiscountRate.Focus();
                return;
            }

            var isNum1 = double.TryParse(textBoxDiscountCalculatorDiscountRate.Text, out double discountRate);
            var isNum2 = double.TryParse(textBoxDiscountCalculatorPrice.Text, out double price);

            if (!isNum1)
            {
                MessageBox.Show("Discount must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDiscountCalculatorDiscountRate.Clear();
                textBoxDiscountCalculatorDiscountRate.Focus();
                return;
            }

            if (!isNum2)
            {
                MessageBox.Show("Price must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDiscountCalculatorPrice.Clear();
                textBoxDiscountCalculatorPrice.Focus();
                return;
            }

            var discountAmount = price * (discountRate / 100);
            textBoxDiscountCalculatorDiscountOutput.Text = discountAmount.ToString("C");

            var salePrice = price - discountAmount;
            textBoxDiscountCalculatorSaleAmount.Text = salePrice.ToString("C");
        }

        private void buttonDiscountCalculatorClear_Click(object sender, EventArgs e)
        {
            textBoxDiscountCalculatorPrice.Clear();
            textBoxDiscountCalculatorDiscountRate.Clear();
            textBoxDiscountCalculatorDiscountOutput.Clear();
            textBoxDiscountCalculatorSaleAmount.Clear();
            textBoxDiscountCalculatorDiscountRate.Focus();
        }

        private void buttonTipCalculatorClear_Click(object sender, EventArgs e)
        {
            comboBoxTipCalculator.Text = "";
            textBoxTipCalculatorTabAmount.Clear();
            textBoxTipCalculatorTipAmount.Clear();
            textBoxTipCalculatorTotalTabAmount.Clear();
            comboBoxTipCalculator.Focus();
        }

        private void buttonTipCalculatorCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxTipCalculator.Text))
            {
                MessageBox.Show("Choose Rate of Service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxTipCalculator.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxTipCalculatorTabAmount.Text))
            {
                MessageBox.Show("Please Enter Tab Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTipCalculatorTabAmount.Focus();
                return;
            }

            var isNum = double.TryParse(textBoxTipCalculatorTabAmount.Text, out double tabAmount);

            if (!isNum)
            {
                MessageBox.Show("Tab Amount Must Be A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTipCalculatorTabAmount.Clear();
                textBoxTipCalculatorTabAmount.Focus();
                return;
            }

            switch (comboBoxTipCalculator.SelectedIndex)
            {
                case 0:
                    textBoxTipCalculatorTipAmount.Text = "$0.00";
                    textBoxTipCalculatorTotalTabAmount.Text = tabAmount.ToString("C");
                    break;
                case 1:
                    var tipAmount = tabAmount * 0.10;
                    var totalTab = tipAmount + tabAmount;
                    textBoxTipCalculatorTipAmount.Text = tipAmount.ToString("C");
                    textBoxTipCalculatorTotalTabAmount.Text = totalTab.ToString("C");
                    break;
                case 2:
                    var tipAmount1 = tabAmount * 0.15;
                    var totalTab1 = tipAmount1 + tabAmount;
                    textBoxTipCalculatorTipAmount.Text = tipAmount1.ToString("C");
                    textBoxTipCalculatorTotalTabAmount.Text = totalTab1.ToString("C");
                    break;
                case 3:
                    var tipAmount2 = tabAmount * 0.18;
                    var totalTab2 = tipAmount2 + tabAmount;
                    textBoxTipCalculatorTipAmount.Text = tipAmount2.ToString("C");
                    textBoxTipCalculatorTotalTabAmount.Text = totalTab2.ToString("C");
                    break;
                case 4:
                    var tipAmount3 = tabAmount * 0.20;
                    var totalTab3 = tipAmount3 + tabAmount;
                    textBoxTipCalculatorTipAmount.Text = tipAmount3.ToString("C");
                    textBoxTipCalculatorTotalTabAmount.Text = totalTab3.ToString("C");
                    break;
            }
        }
    }
}
