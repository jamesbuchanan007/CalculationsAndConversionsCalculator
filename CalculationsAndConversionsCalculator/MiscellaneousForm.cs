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
            var isNum = int.TryParse(textBoxBirthYearInput.Text, out var birthYear);

            if (string.IsNullOrWhiteSpace(textBoxBirthYearInput.Text))
            {
                MessageBox.Show("Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBirthYearInput.Focus();
                return;
            }

            if (birthYear <= 0)
            {
                MessageBox.Show("Your Age is Zero?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBirthYearInput.Clear();
                textBoxBirthYearInput.Focus();
            }

            if (!isNum)
            {
                MessageBox.Show("Numbers Only.  No Decimals or Letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBirthYearInput.Clear();
                textBoxBirthYearInput.Focus();
                return;
            }

            if (birthYear % 4 == 0)
            {
                if (birthYear % 100 == 0)
                {
                    if (birthYear % 400 == 0)
                    {
                        textBoxBirthYearIsALeapYear.Text = "Is A Leap Year";
                    }
                    else
                    {
                        textBoxBirthYearIsALeapYear.Text = "Is Not A Leap Year";
                    }
                }
                else
                {
                    textBoxBirthYearIsALeapYear.Text = "Is A Leap Year";
                }
            }
            else
            {
                textBoxBirthYearIsALeapYear.Text = "Is Not A Leap Year";
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
            textBoxBirthYearInput.Clear();
            textBoxBirthYearIsALeapYear.Clear();
            textBoxBirthYearInput.Focus();
        }

        private void buttonCircuitryExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
