using System;
using System.Windows.Forms;

namespace CalculationsAndConversionsCalculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSeriesResistance_Click(object sender, EventArgs e)
        {
            if (IsMissingValidate(textBoxSeriesResistanceValue1)) return;
            if (IsNumberValidate(textBoxSeriesResistanceValue1)) return;
            if (IsZeroOrLess(textBoxSeriesResistanceValue1)) return;

            if (IsMissingValidate(textBoxSeriesResistanceValue2)) return;
            if (IsNumberValidate(textBoxSeriesResistanceValue2)) return;
            if (IsZeroOrLess(textBoxSeriesResistanceValue2)) return;

            double.TryParse(textBoxSeriesResistanceValue1.Text, out double sr1);
            double.TryParse(textBoxSeriesResistanceValue2.Text, out double sr2);

            var srOutput = $"{sr1 + sr2:F}";
            labelSeriesResistanceOutput.Text = "= " + srOutput;

        }

        //METHOD CHECKS IF A NUMBER
        private bool IsNumberValidate(TextBox textBox)
        {
            var isNumber = double.TryParse(textBox.Text, out var inputResult);
            if (!isNumber)
            {
                MessageBox.Show("Not A Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear(); ;
                textBox.Focus();
                return true;
            }

            return false;
        }

        //CHECKS IF ZERO OR LESS
        private bool IsZeroOrLess(TextBox textBox)
        {
            var checker = double.TryParse(textBox.Text, out var number);

            if (checker && number <= 0)
            {
                MessageBox.Show("Must Be Greater Than Zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
                textBox.Focus();
                return true;
            }

            return false;
        }

        //CHECKS FOR MISSING VALUES
        private bool IsMissingValidate(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Value Is Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return true;
            }

            return false;

        }

        private void buttonClearSeriesResistance_Click(object sender, EventArgs e)
        {
            textBoxSeriesResistanceValue1.Clear();
            textBoxSeriesResistanceValue2.Clear();
            labelSeriesResistanceOutput.Text = "";
            textBoxSeriesResistanceValue1.Focus();
        }
    }
}
