using System;
using System.Windows.Forms;

namespace CalculationsAndConversionsCalculator
{
    public partial class formCircuitry : Form
    {
        public formCircuitry()
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

        private void buttonCircuitResistanceCalculate_Click_1(object sender, EventArgs e)
        {

            string[] resSeriesInput = textBoxResistorSeries.Lines;
            string[] resParallelInput = textBoxResistorParallel.Lines;
            string[] indSeriesInput = textBoxInductorSeries.Lines;
            string[] indParallelInput = textBoxInductorParallel.Lines;
            string[] capSeriesInput = textBoxCapacitorSeries.Lines;
            string[] capParallelInput = textBoxCapacitorParallel.Lines;

            double resSeries = 0;
            double resParallel = 0;
            double indSeries = 0;
            double indParallel = 0;
            double capSeries = 0;
            double capParallel = 0;


            //RESISTANCE SERIES INPUT
            foreach (var t in resSeriesInput)
            {
                if (string.IsNullOrEmpty(t)) continue;
                if (IsNumberValidate(t, textBoxResistorSeries)) break;
                if (IsZeroOrLess(t, textBoxResistorSeries)) break;

                double.TryParse(t, out double resSeriesOutPut);

                resSeries += resSeriesOutPut;
            }

            //RESISTANCE PARALLEL INPUT
            foreach (var t in resParallelInput)
            {
                if (string.IsNullOrEmpty(t)) continue;
                if (IsNumberValidate(t, textBoxResistorParallel)) break;
                if (IsZeroOrLess(t, textBoxResistorParallel)) break;

                if (string.IsNullOrEmpty(t)) continue;
                double.TryParse(t, out double resParallelOutPut);
                resParallel += (1 / resParallelOutPut);
            }

            if (resParallel != 0)
            {
                resParallel = 1 / resParallel;
            }

            //INDUCTOR SERIES INPUT
            foreach (var t in indSeriesInput)
            {
                if (string.IsNullOrEmpty(t)) continue;
                if (IsNumberValidate(t, textBoxInductorSeries)) break;
                if (IsZeroOrLess(t, textBoxInductorSeries)) break;

                double.TryParse(t, out double indSeriesOutPut);

                indSeries += indSeriesOutPut;
            }

            //INDUCTOR PARALLEL INPUT
            foreach (var t in indParallelInput)
            {
                if (string.IsNullOrEmpty(t)) continue;
                if (IsNumberValidate(t, textBoxInductorParallel)) break;
                if (IsZeroOrLess(t, textBoxInductorParallel)) break;

                if (string.IsNullOrEmpty(t)) continue;
                double.TryParse(t, out double indParallelOutPut);
                indParallel += (1 / indParallelOutPut);
            }

            if (indParallel != 0)
            {
                indParallel = 1 / indParallel;
            }

            //CAPACITOR SERIES INPUT
            foreach (var t in capSeriesInput)
            {
                if (IsNumberValidate(t, textBoxCapacitorSeries)) break;
                if (IsZeroOrLess(t, textBoxCapacitorSeries)) break;
                if (string.IsNullOrEmpty(t)) continue;

                if (string.IsNullOrEmpty(t)) continue;
                double.TryParse(t, out double capSeriesOutPut);
                capSeries += (1 / capSeriesOutPut);

            }

            if (capSeries != 0)
            {
                capSeries = 1 / capSeries;
            }


            //CAPACITOR PARALLEL INPUT
            foreach (var t in capParallelInput)
            {
                if (IsNumberValidate(t, textBoxCapacitorParallel)) break;
                if (IsZeroOrLess(t, textBoxCapacitorParallel)) break;

                double.TryParse(t, out double capParallelOutPut);

                capParallel += capParallelOutPut;
            }


            //TOTAL
            var totalRsRpIsIpCsCp = (
                resSeries +
                resParallel +
                indSeries +
                indParallel +
                capSeries +
                capParallel).ToString("F");

            textBoxCircuitryOutput.Text = totalRsRpIsIpCsCp + " Ohms";

        }

        private void buttonCircuitResistanceClear_Click(object sender, EventArgs e)
        {
            textBoxResistorSeries.Clear();
            textBoxResistorParallel.Clear();
            textBoxCapacitorSeries.Clear();
            textBoxCapacitorParallel.Clear();
            textBoxInductorSeries.Clear();
            textBoxInductorParallel.Clear();
            textBoxResistorSeries.Focus();
            textBoxCircuitryOutput.Clear();
        }

        private void buttonCircuitryHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Close();
            formMain.Show();
        }

        private void buttonCircuitryExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
