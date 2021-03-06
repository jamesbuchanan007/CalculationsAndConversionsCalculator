﻿using System;
using System.Windows.Forms;

namespace CalculationsAndConversionsCalculator
{
    public partial class formMiscellaneous : Form
    {
        public formMiscellaneous()
        {
            InitializeComponent();
            buttonDistanceTimeClipboard.Text = "\u2702";
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

        private void buttonDistanceTimeClear_Click(object sender, EventArgs e)
        {
            textBoxDistanceTimeSpeed.Clear();
            textBoxDistanceTimeDistance.Clear();
            comboBoxDistanceTimeRate.Text = "";
            comboBoxDistanceTimeDistanceUnit.Text = "";
            textBoxDistanceResultYears.Clear();
            textBoxDistanceResultWeeks.Clear();
            textBoxDistanceResultDays.Clear();
            textBoxDistanceResultHours.Clear();
            textBoxDistanceResultMinutes.Clear();
            textBoxDistanceResultSeconds.Clear();
            textBoxDistanceResultMilliseconds.Clear();
            textBoxDistanceTimeSpeed.Focus();
        }

        private void buttonDistanceTimeClipboard_Click(object sender, EventArgs e)
        {
            string displayedText = "";

            displayedText = "To go " + textBoxDistanceTimeDistance.Text + " " + comboBoxDistanceTimeDistanceUnit.Text + " at " + textBoxDistanceTimeSpeed.Text +
                            comboBoxDistanceTimeRate.Text + " will take approx. ";

            displayedText = textBoxDistanceResultYears.Text != "" ? textBoxDistanceResultYears.Text == "1" ? displayedText + textBoxDistanceResultYears.Text + " year, " : displayedText + textBoxDistanceResultYears.Text + " years, " : displayedText;

            displayedText = textBoxDistanceResultWeeks.Text != "" ? textBoxDistanceResultWeeks.Text == "1" ? displayedText + textBoxDistanceResultWeeks.Text + " week, " : displayedText + textBoxDistanceResultWeeks.Text + " weeks, " : displayedText;
            displayedText = textBoxDistanceResultDays.Text != "" ? textBoxDistanceResultDays.Text == "1" ? displayedText + textBoxDistanceResultDays.Text + " day, " : displayedText + textBoxDistanceResultDays.Text + " days, " : displayedText;
            displayedText = textBoxDistanceResultHours.Text != "" ? textBoxDistanceResultHours.Text == "1" ? displayedText + textBoxDistanceResultHours.Text + " hour, " : displayedText + textBoxDistanceResultHours.Text + " hours, " : displayedText;
            displayedText = textBoxDistanceResultMinutes.Text != "" ? textBoxDistanceResultMinutes.Text == "1" ? displayedText + textBoxDistanceResultMinutes.Text + " minute, " : displayedText + textBoxDistanceResultMinutes.Text + " minutes, " : displayedText;
            displayedText = textBoxDistanceResultSeconds.Text != "" ? textBoxDistanceResultSeconds.Text == "1" ? displayedText + textBoxDistanceResultSeconds.Text + " second, " : displayedText + textBoxDistanceResultSeconds.Text + " seconds, " : displayedText;
            displayedText = textBoxDistanceResultMilliseconds.Text != "" ? displayedText + textBoxDistanceResultMilliseconds.Text + " ms" : displayedText;

            Clipboard.SetText(displayedText);
        }

        private void buttonDistanceTimeCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDistanceTimeSpeed.Text))
            {
                MessageBox.Show("Please Enter Speed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDistanceTimeSpeed.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxDistanceTimeDistance.Text))
            {
                MessageBox.Show("Please Enter Distance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDistanceTimeDistance.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBoxDistanceTimeRate.Text))
            {
                MessageBox.Show("Please Choose Rate of Speed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxDistanceTimeRate.Focus();
                return;
            }

            var isNum1 = double.TryParse(textBoxDistanceTimeSpeed.Text, out var speed);
            var isNum2 = double.TryParse(textBoxDistanceTimeDistance.Text, out var distance);

            if (!isNum1)
            {
                MessageBox.Show("Must Be A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDistanceTimeSpeed.Clear();
                textBoxDistanceTimeSpeed.Focus();
                return;
            }
            if (!isNum2)
            {
                MessageBox.Show("Must Be A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDistanceTimeDistance.Clear();
                textBoxDistanceTimeDistance.Focus();
                return;
            }

            double time;
            double convertedDistance;
            Result displayedText = new Result();

            switch (comboBoxDistanceTimeRate.SelectedIndex)
            {
                case 0:
                    convertedDistance = ConvertDistance("miles", comboBoxDistanceTimeDistanceUnit.SelectedIndex, distance);
                    time = convertedDistance / speed;
                    displayedText = ConvertTime("hours", time);
                    break;
                case 1:
                    convertedDistance = ConvertDistance("miles", comboBoxDistanceTimeDistanceUnit.SelectedIndex, distance);
                    time = convertedDistance / speed;
                    displayedText = ConvertTime("seconds", time);
                    break;
                case 2:
                    convertedDistance = ConvertDistance("kilometer", comboBoxDistanceTimeDistanceUnit.SelectedIndex, distance);
                    time = convertedDistance / speed;
                    displayedText = ConvertTime("hours", time);
                    break;
                case 3:
                    convertedDistance = ConvertDistance("kilometer", comboBoxDistanceTimeDistanceUnit.SelectedIndex, distance);
                    time = convertedDistance / speed;
                    displayedText = ConvertTime("seconds", time);
                    break;
                case 4:
                    convertedDistance = ConvertDistance("knot", comboBoxDistanceTimeDistanceUnit.SelectedIndex, distance);
                    time = convertedDistance / speed;
                    displayedText = ConvertTime("hours", time);
                    break;
                case 5:
                    convertedDistance = ConvertDistance("feet", comboBoxDistanceTimeDistanceUnit.SelectedIndex, distance);
                    time = convertedDistance / speed;
                    displayedText = ConvertTime("seconds", time);
                    break;
                case 6:
                    convertedDistance = ConvertDistance("meters", comboBoxDistanceTimeDistanceUnit.SelectedIndex, distance);
                    time = convertedDistance / speed;
                    displayedText = ConvertTime("seconds", time);
                    break;
            }

            textBoxDistanceResultYears.Text = displayedText.Years != 0 ? displayedText.Years.ToString("N0") : "";
            textBoxDistanceResultWeeks.Text = displayedText.Weeks != 0 ? displayedText.Weeks.ToString() : "";
            textBoxDistanceResultDays.Text = displayedText.Days != 0 ? displayedText.Days.ToString() : "";
            textBoxDistanceResultHours.Text = displayedText.Hours != 0 ? displayedText.Hours.ToString() : "";
            textBoxDistanceResultMinutes.Text = displayedText.Minutes != 0 ? displayedText.Minutes.ToString() : "";
            textBoxDistanceResultSeconds.Text = displayedText.Seconds != 0 ? displayedText.Seconds.ToString() : "";
            textBoxDistanceResultMilliseconds.Text = displayedText.Milliseconds != 0 ? displayedText.Milliseconds.ToString() : "";

        }

        private Result ConvertTime(string timeUnits, double time)
        {
            double years = 0;
            double weeks = 0;
            double days = 0;
            double hours = 0;
            double minutes = 0;
            double seconds = 0;
            double milliseconds = 0;

            if (timeUnits == "hours")
            {
                hours = Math.Truncate(time);
                minutes = Math.Truncate((time - hours) * 60);
                seconds = Math.Truncate(((time - hours) * 60 - minutes) * 60);
                milliseconds = Math.Truncate((((time - hours) * 60 - minutes) * 60 - seconds) * 1000);

                if (hours >= 24)
                {
                    days = Math.Truncate(time / 24);
                    hours = Math.Truncate((time / 24 - days) * 24);

                    if (days >= 7)
                    {
                        weeks = Math.Truncate(time / 168);
                        days = Math.Truncate((time / 168 - weeks) * 7);
                        hours = Math.Truncate(((time / 168 - weeks) * 7 - days) * 24);

                        if (weeks >= 52)
                        {
                            years = Math.Truncate(time / 8760);
                            weeks = Math.Truncate((time / 8760 - years) * 52);
                            days = Math.Truncate(((time / 8760 - years) * 52 - weeks) * 7);
                            hours = Math.Truncate((((time / 8760 - years) * 52 - weeks) * 7 - days) * 24);
                        }
                    }

                }
            }
            else
            {
                seconds = Math.Truncate(time);
                milliseconds = Math.Truncate((time - seconds) * 1000);

                if (seconds >= 60)
                {
                    minutes = Math.Truncate(time / 60);
                    seconds = Math.Truncate((time / 60 - minutes) * 60);
                    milliseconds = Math.Truncate(((time / 60 - minutes) * 60 - seconds) * 1000);

                    if (minutes >= 60)
                    {
                        hours = Math.Truncate(time / 3600);
                        minutes = Math.Truncate((time / 3600 - hours) * 60);
                        seconds = Math.Truncate(((time / 3600 - hours) * 60 - minutes) * 60);
                        milliseconds = Math.Truncate((((time / 3600 - hours) * 60 - minutes) * 60 - seconds) * 1000);

                        if (hours >= 24)
                        {
                            days = Math.Truncate(time / 86400);
                            hours = Math.Truncate((time / 86400 - days) * 24);
                            minutes = Math.Truncate(((time / 86400 - days) * 24 - hours) * 60);
                            seconds = Math.Truncate((((time / 86400 - days) * 24 - hours) * 60 - minutes) * 60);
                            milliseconds = Math.Truncate(((((time / 86400 - days) * 24 - hours) * 60 - minutes) * 60 - seconds) * 1000);

                            if (days >= 7)
                            {
                                weeks = Math.Truncate(time / 604800);
                                days = Math.Truncate((time / 604800 - weeks) * 7);
                                hours = Math.Truncate(((time / 604800 - weeks) * 7 - days) * 24);
                                minutes = Math.Truncate((((time / 604800 - weeks) * 7 - days) * 24 - hours) * 60);
                                seconds = Math.Truncate(((((time / 604800 - weeks) * 7 - days) * 24 - hours) * 60 - minutes) * 60);
                                milliseconds = Math.Truncate((((((time / 604800 - weeks) * 7 - days) * 24 - hours) * 60 - minutes) * 60 - seconds) * 1000);

                                if (weeks >= 52)
                                {
                                    years = Math.Truncate(time / 31536000);
                                    weeks = Math.Truncate((time / 31536000 - years) * 52);
                                    days = Math.Truncate(((time / 31536000 - years) * 52 - weeks) * 7);
                                    hours = Math.Truncate((((time / 31536000 - years) * 52 - weeks) * 7 - days) * 24);
                                    minutes = Math.Truncate(((((time / 31536000 - years) * 52 - weeks) * 7 - days) * 24 - hours) * 60);
                                    seconds = Math.Truncate((((((time / 31536000 - years) * 52 - weeks) * 7 - days) * 24 - hours) * 60 - minutes) * 60);
                                    milliseconds = Math.Truncate(((((((time / 31536000 - years) * 52 - weeks) * 7 - days) * 24 - hours) * 60 - minutes) * 60 - seconds) * 1000);
                                }
                            }
                        }
                    }
                }

            }

            var result = new Result
            {
                Years = years,
                Weeks = weeks,
                Days = days,
                Hours = hours,
                Minutes = minutes,
                Seconds = seconds,
                Milliseconds = milliseconds
            };

            return result;

        }

        private double ConvertDistance(string distanceUnit, int indexComboBox, double distance)
        {
            double convertedDistance = 0.0;

            if (distanceUnit == "miles")
            {
                switch (indexComboBox)
                {
                    case 0:
                        convertedDistance = distance / 1;           //mile
                        break;
                    case 1:
                        convertedDistance = distance / 1.609344;    //km 
                        break;
                    case 2:
                        convertedDistance = distance / 5280;        //feet
                        break;
                    case 3:
                        convertedDistance = distance / 1760;        //yard
                        break;
                    case 4:
                        convertedDistance = distance / 1609.344;    //meter
                        break;
                    case 5:
                        convertedDistance = distance / 0.28965875;  //league
                        break;
                    case 6:
                        convertedDistance = distance / 880;         //fathom
                        break;
                    case 7:
                        convertedDistance = distance / 0.86897624;  //nautical mile
                        break;
                    case 8:
                        convertedDistance = distance / 1.7011E-13;  //light year
                        break;
                    case 9:
                        convertedDistance = distance / 1.0758E-8;   //Astronomical unit AU
                        break;
                    case 10:
                        convertedDistance = distance / 5.2155E-14;  //parsec
                        break;

                }
            }

            if (distanceUnit == "kilometer")
            {
                switch (indexComboBox)
                {
                    case 0:
                        convertedDistance = distance / 0.62137119;           //mile
                        break;
                    case 1:
                        convertedDistance = distance / 1;    //km 
                        break;
                    case 2:
                        convertedDistance = distance / 3280.8399;        //feet
                        break;
                    case 3:
                        convertedDistance = distance / 1093.6133;        //yard
                        break;
                    case 4:
                        convertedDistance = distance / 1000;    //meter
                        break;
                    case 5:
                        convertedDistance = distance / 0.1799856;  //league
                        break;
                    case 6:
                        convertedDistance = distance / 546.806649;         //fathom
                        break;
                    case 7:
                        convertedDistance = distance / 0.5399568;  //nautical mile
                        break;
                    case 8:
                        convertedDistance = distance / 1.0570E-13;  //light year
                        break;
                    case 9:
                        convertedDistance = distance / 6.6846E-9;   //Astronomical unit AU
                        break;
                    case 10:
                        convertedDistance = distance / 3.2408E-14;  //parsec
                        break;
                }
            }

            if (distanceUnit == "knot")
            {
                switch (indexComboBox)
                {
                    case 0:
                        convertedDistance = distance / 1.15077945;           //mile
                        break;
                    case 1:
                        convertedDistance = distance / 1.852;    //km 
                        break;
                    case 2:
                        convertedDistance = distance / 6076.11549;        //feet
                        break;
                    case 3:
                        convertedDistance = distance / 2025.37183;        //yard
                        break;
                    case 4:
                        convertedDistance = distance / 1852;    //meter
                        break;
                    case 5:
                        convertedDistance = distance / 0.33333333;  //league
                        break;
                    case 6:
                        convertedDistance = distance / 1012.68591;         //fathom
                        break;
                    case 7:
                        convertedDistance = distance / 1;  //nautical mile
                        break;
                    case 8:
                        convertedDistance = distance / 1.9576E-13;  //light year
                        break;
                    case 9:
                        convertedDistance = distance / 1.2380E-8;   //Astronomical unit AU
                        break;
                    case 10:
                        convertedDistance = distance / 6.0019E-14;  //parsec
                        break;
                }
            }

            if (distanceUnit == "feet")
            {
                switch (indexComboBox)
                {
                    case 0:
                        convertedDistance = distance / 0.00018939;           //mile
                        break;
                    case 1:
                        convertedDistance = distance / 0.0003048;    //km 
                        break;
                    case 2:
                        convertedDistance = distance / 1;        //feet
                        break;
                    case 3:
                        convertedDistance = distance / 0.33333333;        //yard
                        break;
                    case 4:
                        convertedDistance = distance / 0.3048;    //meter
                        break;
                    case 5:
                        convertedDistance = distance / 0.00005486;  //league
                        break;
                    case 6:
                        convertedDistance = distance / 0.16666667;         //fathom
                        break;
                    case 7:
                        convertedDistance = distance / 0.00016458;  //nautical mile
                        break;
                    case 8:
                        convertedDistance = distance / 3.2217E-17;  //light year
                        break;
                    case 9:
                        convertedDistance = distance / 2.0375E-12;   //Astronomical unit AU
                        break;
                    case 10:
                        convertedDistance = distance / 9.8779E-18;  //parsec
                        break;
                }
            }

            if (distanceUnit == "meters")
            {
                switch (indexComboBox)
                {
                    case 0:
                        convertedDistance = distance / 0.00062137;           //mile
                        break;
                    case 1:
                        convertedDistance = distance / 0.001;    //km 
                        break;
                    case 2:
                        convertedDistance = distance / 3.2808399;        //feet
                        break;
                    case 3:
                        convertedDistance = distance / 1.0936133;        //yard
                        break;
                    case 4:
                        convertedDistance = distance / 1;    //meter
                        break;
                    case 5:
                        convertedDistance = distance / 0.00017999;  //league
                        break;
                    case 6:
                        convertedDistance = distance / 0.54680665;         //fathom
                        break;
                    case 7:
                        convertedDistance = distance / 0.00053996;  //nautical mile
                        break;
                    case 8:
                        convertedDistance = distance / 1.0570E-16;  //light year
                        break;
                    case 9:
                        convertedDistance = distance / 6.6846E-12;   //Astronomical unit AU
                        break;
                    case 10:
                        convertedDistance = distance / 3.2408E-17;  //parsec
                        break;
                }
            }

            return convertedDistance;
        }
    }

    public class Result
    {
        public double Years { get; set; }
        public double Weeks { get; set; }
        public double Days { get; set; }
        public double Hours { get; set; }
        public double Minutes { get; set; }
        public double Seconds { get; set; }
        public double Milliseconds { get; set; }
    }
}
