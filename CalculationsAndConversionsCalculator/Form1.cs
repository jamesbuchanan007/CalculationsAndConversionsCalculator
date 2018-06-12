using System.Windows.Forms;

namespace CalculationsAndConversionsCalculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //METHOD CHECKS IF A NUMBER
        private bool IsNumberValidate(string text, TextBox textBox)
        {
            var isNumber = double.TryParse(text, out var inputResult);
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
        private bool IsZeroOrLess(string text, TextBox textBox)
        {
            var checker = double.TryParse(text, out var number);

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

        private void buttonCircuitResistanceClear_Click(object sender, System.EventArgs e)
        {
            textBoxResistorSeries.Clear();
            textBoxResistorParallel.Clear();
            textBoxInductorSeries.Clear();
            textBoxInductorParallel.Clear();
            textBoxCapacitorSeries.Clear();
            textBoxCapacitorParallel.Clear();
            labelCircuitOutput.Text = "";
            textBoxResistorSeries.Focus();
        }

        private void buttonCircuitResistanceCalculate_Click(object sender, System.EventArgs e)
        {
            string[] rsInput = textBoxResistorSeries.Lines;
            string[] rpInput = textBoxResistorParallel.Lines;

            double rs = 0;
            double rp = 0;

            //RESISTANCE SERIES INPUT
            foreach (var t in rsInput)
            {
                if (IsNumberValidate(t, textBoxResistorSeries)) break;
                if (IsZeroOrLess(t, textBoxResistorSeries)) break;

                double.TryParse(t, out double rsOutPut);

                rs += rsOutPut;
            }

            //RESISTANCE PARALLEL INPUT
            foreach (var t in rpInput)
            {
                if (IsNumberValidate(t, textBoxResistorParallel)) break;
                if (IsZeroOrLess(t, textBoxResistorParallel)) break;

                if (string.IsNullOrEmpty(t)) continue;
                double.TryParse(t, out double rpOutPut);
                rp += (1 / rpOutPut);
            }

            if (rp != 0)
            {
                rp = 1 / rp;
            }

            var totalRsRp = (rs + rp).ToString("F");

            labelCircuitOutput.Text = totalRsRp + " ohms";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (panelCircuit.Visible) panelCircuit.Hide();
            else panelCircuit.Show();
        }
    }
}
