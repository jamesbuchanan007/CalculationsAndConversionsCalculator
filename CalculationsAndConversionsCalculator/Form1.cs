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
     

        private void comboBoxChooseType_SelectedValueChanged(object sender, System.EventArgs e)
        {
            var option = comboBoxChooseType.Text;
            switch (option)
            {
                case "Circuitry":
                    this.Hide();
                    formCircuitry formCircuitry = new formCircuitry();
                    formCircuitry.Show();
                    break;
                case "Math Formulas":
                    this.Hide();
                    formMathFormulas formMathFormulas = new formMathFormulas();
                    formMathFormulas.Show();
                    break;

            }
            
        }

        private void comboBoxChooseType_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
