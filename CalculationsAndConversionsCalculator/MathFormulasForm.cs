﻿using System;
using System.Windows.Forms;

namespace CalculationsAndConversionsCalculator
{
    public partial class formMathFormulas : Form
    {
        public formMathFormulas()
        {
            InitializeComponent();
            buttonCircleAreaClipboard.Text = "\u2702";
            buttonCircleCircumferenceClipboard.Text = "\u2702";
            buttonSphereVolumeClipboard.Text = "\u2702";
            buttonSphereSurfaceAreaClipboard.Text = "\u2702";
            buttonCylinderVolumeClipboard.Text = "\u2702";
            buttonCylinderLateralAreaClipboard.Text = "\u2702";
            buttonCylinderSurfaceAreaClipboard.Text = "\u2702";
            buttonConeVolumeClipboard.Text = "\u2702";
            buttonConeLateralAreaClipboard.Text = "\u2702";
            buttonConeSurfaceAreaClipboard.Text = "\u2702";
            buttonHypotenuseClipboard.Text = "\u2702";
        }

        //BACK TO HOME MENU
        private void buttonCircuitryHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Close();
            formMain.Show();
        }
        //EXITS APPLICATION
        private void buttonCircuitryExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //GROUP - HYPOTENUSE - CALCULATE
        private void buttonHypotenuseCalculate_Click(object sender, EventArgs e)
        {
            var numA = double.TryParse(textBoxHypotenuseSideA.Text, out var inputA);
            var numB = double.TryParse(textBoxHypotenuseSideB.Text, out var inputB);

            if (string.IsNullOrWhiteSpace(textBoxHypotenuseSideA.Text))
            {
                MessageBox.Show("Side A is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHypotenuseSideA.Clear();
                textBoxHypotenuseSideA.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxHypotenuseSideB.Text))
            {
                MessageBox.Show("Side B is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHypotenuseSideB.Clear();
                textBoxHypotenuseSideB.Focus();
                return;
            }

            if (!numA)
            {
                MessageBox.Show("Side A is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHypotenuseSideA.Clear();
                textBoxHypotenuseSideA.Focus();
                return;
            }

            if (!numB)
            {
                MessageBox.Show("Side B is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHypotenuseSideB.Clear();
                textBoxHypotenuseSideB.Focus();
                return;
            }



            var outputC = Math.Sqrt(Math.Pow(inputA, 2) + Math.Pow(inputB, 2));

            textBoxHypotenuseSideC.Text = outputC.ToString("F");

        }
        //GROUP - HYPOTENUSE - CLEAR
        private void buttonHypotenuseClear_Click(object sender, EventArgs e)
        {
            textBoxHypotenuseSideA.Clear();
            textBoxHypotenuseSideB.Clear();
            textBoxHypotenuseSideC.Clear();
            textBoxHypotenuseSideA.Focus();
        }
        //GROUP - CIRCLE - CALCULATE
        private void buttonCircleCalculate_Click(object sender, EventArgs e)
        {
            var numA = double.TryParse(textBoxAreaofCircleDiameterInput.Text, out var input);
            if (string.IsNullOrWhiteSpace(textBoxAreaofCircleDiameterInput.Text))
            {
                MessageBox.Show("Diameter is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAreaofCircleDiameterInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxCircleUOM.Text))
            {
                MessageBox.Show("Unit of Measure is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCircleUOM.Focus();
                return;
            }

            if (!numA)
            {
                MessageBox.Show("Diameter is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAreaofCircleDiameterInput.Clear();
                textBoxAreaofCircleDiameterInput.Focus();
                return;
            }

            var diameter = input;
            var radius = diameter / 2;
            var uom = " " + textBoxCircleUOM.Text;
            var uomSquared = " " + textBoxCircleUOM.Text + "\u00b2";

            textBoxCircleCircumberenceOutput.Text = (2 * Math.PI * radius).ToString("F") + uom;
            textBoxCircleAreaOutput.Text = (Math.PI * Math.Pow(radius, 2)).ToString("F") + uomSquared;
        }
        //GROUP - CIRCLE - CLEAR
        private void buttonCircleClear_Click(object sender, EventArgs e)
        {
            textBoxCircleAreaOutput.Clear();
            textBoxCircleCircumberenceOutput.Clear();
            textBoxAreaofCircleDiameterInput.Clear();
            textBoxCircleUOM.Clear();
            textBoxAreaofCircleDiameterInput.Focus();
        }
        //GROUP - SPHERE - CALCULATE
        private void buttonSphereCalculate_Click(object sender, EventArgs e)
        {
            var num = double.TryParse(textBoxSphereDiameterInput.Text, out var diameter);
            if (string.IsNullOrWhiteSpace(textBoxSphereDiameterInput.Text))
            {
                MessageBox.Show("Diameter is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSphereDiameterInput.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxSphereUOM.Text))
            {
                MessageBox.Show("Unit of Measure is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSphereUOM.Focus();
                return;
            }

            if (!num)
            {
                MessageBox.Show("Diameter must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSphereDiameterInput.Clear();
                textBoxSphereDiameterInput.Focus();
                return;
            }

            var radius = diameter / 2;

            var uom = " " + textBoxSphereUOM.Text;
            var uomSquared = uom + "\u00b2";
            var uomCubed = uom + "\u00b3";

            var volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;
            var surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);

            textBoxSphereVolumeOutput.Text = volume.ToString("F") + uomCubed;
            textBoxSphereSurfaceAreaOutput.Text = surfaceArea.ToString("F") + uomSquared;
        }
        //GROUP - SPHERE - CLEAR
        private void buttonSphereClear_Click(object sender, EventArgs e)
        {
            textBoxSphereDiameterInput.Clear();
            textBoxSphereUOM.Clear();
            textBoxSphereVolumeOutput.Clear();
            textBoxSphereSurfaceAreaOutput.Clear();
            textBoxSphereDiameterInput.Focus();
        }
        //GROUP - CYLINDER - CALCULATE
        private void buttonCylinderCalculate_Click(object sender, EventArgs e)
        {
            var numA = double.TryParse(textBoxCylinderDiameterInput.Text, out var diameter);
            var numB = double.TryParse(textBoxCylinderHeightInput.Text, out var height);
            if (string.IsNullOrWhiteSpace(textBoxCylinderDiameterInput.Text))
            {
                MessageBox.Show("Diameter is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCylinderDiameterInput.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxCylinderHeightInput.Text))
            {
                MessageBox.Show("Height is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCylinderHeightInput.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxCylinderUOM.Text))
            {
                MessageBox.Show("Unit of Measure is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCylinderUOM.Focus();
                return;
            }
            if (!numA)
            {
                MessageBox.Show("Diameter must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCylinderDiameterInput.Clear();
                textBoxCylinderDiameterInput.Focus();
                return;
            }
            if (!numB)
            {
                MessageBox.Show("Height must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCylinderHeightInput.Clear();
                textBoxCylinderHeightInput.Focus();
                return;
            }

            var radius = diameter / 2;
            var uom = " " + textBoxCylinderUOM.Text;
            var uomSquared = uom + "\u00b2";
            var uomCubed = uom + "\u00b3";

            var volume = Math.PI * Math.Pow(radius, 2) * height;
            var lateralArea = 2 * Math.PI * radius * height;
            var totalSurfaceArea = (2 * Math.PI * radius * height) + (2 * Math.PI * Math.Pow(radius, 2));

            textBoxCylinderVolumeOutput.Text = volume.ToString("F") + uomCubed;
            textBoxCylinderLateralAreaOutput.Text = lateralArea.ToString("F") + uomSquared;
            textBoxCylinderTotalSurfaceAreaOutput.Text = totalSurfaceArea.ToString("F") + uomSquared;

        }
        //GROUP - CYLINDER - CLEAR
        private void buttonCylinderClear_Click(object sender, EventArgs e)
        {
            textBoxCylinderDiameterInput.Clear();
            textBoxCylinderHeightInput.Clear();
            textBoxCylinderUOM.Clear();
            textBoxCylinderVolumeOutput.Clear();
            textBoxCylinderLateralAreaOutput.Clear();
            textBoxCylinderTotalSurfaceAreaOutput.Clear();
            textBoxCylinderDiameterInput.Focus();
        }
        //GROUP - CONE - CALCULATE
        private void buttonConeCalculate_Click(object sender, EventArgs e)
        {
            var numA = double.TryParse(textBoxConeDiameterInput.Text, out var diameter);
            var numB = double.TryParse(textBoxConeHeightInput.Text, out var height);
            if (string.IsNullOrWhiteSpace(textBoxConeDiameterInput.Text))
            {
                MessageBox.Show("Diameter is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConeDiameterInput.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxConeHeightInput.Text))
            {
                MessageBox.Show("Height is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConeHeightInput.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxConeUOM.Text))
            {
                MessageBox.Show("Unit of Measure is needed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConeUOM.Focus();
                return;
            }
            if (!numA)
            {
                MessageBox.Show("Diameter must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConeDiameterInput.Clear();
                textBoxConeDiameterInput.Focus();
                return;
            }
            if (!numB)
            {
                MessageBox.Show("Height must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxConeHeightInput.Clear();
                textBoxConeHeightInput.Focus();
                return;
            }

            var radius = diameter / 2;
            var uom = " " + textBoxConeUOM.Text;
            var uomSquared = uom + "\u00b2";
            var uomCubed = uom + "\u00b3";

            var volume = (Math.PI * Math.Pow(radius, 2) * height) / 3;
            var lateralArea = (Math.PI * radius) * Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
            var totalSurfaceArea =
                (Math.PI * radius) *
                Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2)) +
                (Math.PI * Math.Pow(radius, 2));

            textBoxConeVolumeOutput.Text = volume.ToString("F") + uomCubed;
            textBoxConeLateralAreaOutput.Text = lateralArea.ToString("F") + uomSquared;
            textBoxConeTotalSurfaceAreaOutput.Text = totalSurfaceArea.ToString("F") + uomSquared;
        }
        //GROUP - CONE - CLEAR
        private void buttonConeClear_Click(object sender, EventArgs e)
        {
            textBoxConeDiameterInput.Clear();
            textBoxConeHeightInput.Clear();
            textBoxConeUOM.Clear();
            textBoxConeVolumeOutput.Clear();
            textBoxConeLateralAreaOutput.Clear();
            textBoxConeTotalSurfaceAreaOutput.Clear();
            textBoxConeDiameterInput.Focus();
        }
        //GROUP - HYPTENUSE - CLIPBOARD
        private void buttonHypotenuseClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxHypotenuseSideC.Text);
        }
        //GROUP - CIRCLE - AREA - CLIPBOARD
        private void buttonCircleAreaClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxCircleAreaOutput.Text);
        }
        //GROUP - CIRCLE - CIRCUMFERENCE - CLIPBOARD
        private void buttonCircleCircumferenceClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxCircleCircumberenceOutput.Text);
        }
        //GROUP - SPHERE - VOLUME - CLIPBOARD
        private void buttonSphereVolumeClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSphereVolumeOutput.Text);
        }
        //GROUP - SPHERE - SURFACE AREA - CLIPBOARD
        private void buttonSphereSurfaceAreaClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxSphereSurfaceAreaOutput.Text);
        }
        //GROUP - CYLINDER - VOLUME - CLIPBOARD
        private void buttonCylinderVolumeClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxCylinderVolumeOutput.Text);
        }
        //GROUP - CYLINDER - LATERAL AREA - CLIPBOARD
        private void buttonCylinderLateralAreaClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxCylinderLateralAreaOutput.Text);
        }
        //GROUP - CYLINDER - TOTAL SURFACE AREA - CLIPBOARD
        private void buttonCylinderSurfaceAreaClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxCylinderTotalSurfaceAreaOutput.Text);
        }
        //GROUP - CONE - VOLUME - CLIPBOARD
        private void buttonConeVolumeClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxConeVolumeOutput.Text);
        }
        //GROUP - CONE - LATERAL AREA - CLIPBOARD
        private void buttonConeLateralAreaClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxConeLateralAreaOutput.Text);
        }
        //GROUP - CONE - TOTAL SURFACE AREA - CLIPBOARD
        private void buttonConeSurfaceAreaClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxConeTotalSurfaceAreaOutput.Text);
        }
        //GROUP - FRACTIONS - ADDITION - CALCULATE
        private void buttonFractionsAdditionCalculate_Click(object sender, EventArgs e)
        {
            var numA = int.TryParse(textBoxFractionAdditionA.Text, out var inputA);
            var numB = int.TryParse(textBoxFractionAdditionB.Text, out var inputB);
            var numC = int.TryParse(textBoxFractionAdditionC.Text, out var inputC);
            var numD = int.TryParse(textBoxFractionAdditionD.Text, out var inputD);

            if (string.IsNullOrWhiteSpace(textBoxFractionAdditionA.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionAdditionA.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionAdditionB.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionAdditionB.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionAdditionC.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionAdditionC.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionAdditionD.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionAdditionD.Focus();
                return;
            }

            if (!numA)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionAdditionA.Clear();
                textBoxFractionAdditionA.Focus();
                return;
            }
            if (!numB)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionAdditionB.Clear();
                textBoxFractionAdditionB.Focus();
                return;
            }
            if (!numC)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionAdditionC.Clear();
                textBoxFractionAdditionC.Focus();
                return;
            }
            if (!numD)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionAdditionD.Clear();
                textBoxFractionAdditionD.Focus();
                return;
            }

            var numerator = (inputA * inputD) + (inputB * inputC);
            var denominator = inputB * inputD;

            var gcd = GetGreatestCommonDivisor(numerator, denominator);

            var numReduced = numerator / gcd;
            var denReduced = denominator / gcd;

            textBoxFractionAdditionNumerator.Text = numerator.ToString();
            textBoxFractionAdditionDenominator.Text = denominator.ToString();
            textBoxFractionAdditionNumeratorReduced.Text = numReduced.ToString();
            textBoxFractionAdditionDenominatorReduced.Text = denReduced.ToString();

            //MIXED FRACTION CONVERSION
            if (numReduced > denReduced)
            {
                var wholeMixed = Math.Floor((double)(numReduced / denReduced));
                var numMixed = numReduced % denReduced;
                textBoxFractionsAdditionMixedWholeNumber.Text = wholeMixed.ToString();
                textBoxFractionsAdditionMixedNumerator.Text = numMixed.ToString();
                textBoxFractionsAdditionMixedDenominator.Text = denReduced.ToString();
            }
            else
            {
                textBoxFractionsAdditionMixedWholeNumber.Clear();
                textBoxFractionsAdditionMixedNumerator.Clear();
                textBoxFractionsAdditionMixedDenominator.Clear();
            }
            //CONVERT TO DECIMAL
            var convertDecimal = (double)numReduced / denReduced;
            textBoxFractionAdditionDecimal.Text = convertDecimal.ToString("F");
        }
        //FIND GREATEST COMMON DIVISOR METHOD
        private int GetGreatestCommonDivisor(int numerator, int denominator)
        {
            while (numerator != 0 && denominator != 0)
            {
                if (numerator > denominator) numerator %= denominator;
                else
                {
                    denominator %= numerator;
                }
            }

            return numerator == 0 ? denominator : numerator;
        }
        //GROUP - FRACTIONS - CLEAR
        private void buttonFractionsClear_Click(object sender, EventArgs e)
        {
            textBoxFractionAdditionA.Clear();
            textBoxFractionAdditionB.Clear();
            textBoxFractionAdditionC.Clear();
            textBoxFractionAdditionD.Clear();
            textBoxFractionAdditionNumerator.Clear();
            textBoxFractionAdditionNumeratorReduced.Clear();
            textBoxFractionsAdditionMixedNumerator.Clear();
            textBoxFractionAdditionDenominator.Clear();
            textBoxFractionAdditionDenominatorReduced.Clear();
            textBoxFractionsAdditionMixedDenominator.Clear();
            textBoxFractionsAdditionMixedWholeNumber.Clear();
            textBoxFractionAdditionDecimal.Clear();
            textBoxFractionSubtractionA.Clear();
            textBoxFractionSubtractionB.Clear();
            textBoxFractionSubtractionC.Clear();
            textBoxFractionSubtractionD.Clear();
            textBoxFractionSubtractionNumerator.Clear();
            textBoxFractionSubtractionNumeratorReduced.Clear();
            textBoxFractionsSubtractionMixedNumerator.Clear();
            textBoxFractionSubtractionDenominator.Clear();
            textBoxFractionSubtractionDenominatorReduced.Clear();
            textBoxFractionsSubtractionMixedDenominator.Clear();
            textBoxFractionsSubtractionMixedWholeNumber.Clear();
            textBoxFractionSubtractionDecimal.Clear();
            textBoxFractionMultiplyingA.Clear();
            textBoxFractionMultiplyingB.Clear();
            textBoxFractionMultiplyingC.Clear();
            textBoxFractionMultiplyingD.Clear();
            textBoxFractionMultiplyingNumerator.Clear();
            textBoxFractionMultiplyingNumeratorReduced.Clear();
            textBoxFractionsMultiplyingMixedNumerator.Clear();
            textBoxFractionMultiplyingDenominator.Clear();
            textBoxFractionMultiplyingDenominatorReduced.Clear();
            textBoxFractionsMultiplyingMixedDenominator.Clear();
            textBoxFractionsMultiplyingMixedWholeNumber.Clear();
            textBoxFractionMultiplyingDecimal.Clear();
            textBoxFractionDividingA.Clear();
            textBoxFractionDividingB.Clear();
            textBoxFractionDividingC.Clear();
            textBoxFractionDividingD.Clear();
            textBoxFractionDividingNumerator.Clear();
            textBoxFractionDividingNumeratorReduced.Clear();
            textBoxFractionsDividingMixedNumerator.Clear();
            textBoxFractionDividingDenominator.Clear();
            textBoxFractionDividingDenominatorReduced.Clear();
            textBoxFractionsDividingMixedDenominator.Clear();
            textBoxFractionsDividingMixedWholeNumber.Clear();
            textBoxFractionDividingDecimal.Clear();
            textBoxFractionAdditionA.Focus();
        }
        //GROUP - FRACTIONS - SUBTRACTION - CALCULATE
        private void buttonFractionsSubtractionCalculate_Click_1(object sender, EventArgs e)
        {
            var numA = int.TryParse(textBoxFractionSubtractionA.Text, out var inputA);
            var numB = int.TryParse(textBoxFractionSubtractionB.Text, out var inputB);
            var numC = int.TryParse(textBoxFractionSubtractionC.Text, out var inputC);
            var numD = int.TryParse(textBoxFractionSubtractionD.Text, out var inputD);

            if (string.IsNullOrWhiteSpace(textBoxFractionSubtractionA.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionSubtractionA.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionSubtractionB.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionSubtractionB.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionSubtractionC.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionSubtractionC.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionSubtractionD.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionSubtractionD.Focus();
                return;
            }

            if (!numA)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionSubtractionA.Clear();
                textBoxFractionSubtractionA.Focus();
                return;
            }
            if (!numB)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionSubtractionB.Clear();
                textBoxFractionSubtractionB.Focus();
                return;
            }
            if (!numC)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionSubtractionC.Clear();
                textBoxFractionSubtractionC.Focus();
                return;
            }
            if (!numD)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionSubtractionD.Clear();
                textBoxFractionSubtractionD.Focus();
                return;
            }

            var numerator = (inputA * inputD) - (inputB * inputC);
            var denominator = inputB * inputD;

            var gcd = GetGreatestCommonDivisor(numerator, denominator);

            var numReduced = numerator / gcd;
            var denReduced = denominator / gcd;

            textBoxFractionSubtractionNumerator.Text = numerator.ToString();
            textBoxFractionSubtractionDenominator.Text = denominator.ToString();
            textBoxFractionSubtractionNumeratorReduced.Text = numReduced.ToString();
            textBoxFractionSubtractionDenominatorReduced.Text = denReduced.ToString();

            //MIXED FRACTION CONVERSION
            if (numReduced > denReduced)
            {
                var wholeMixed = Math.Floor((double)(numReduced / denReduced));
                var numMixed = numReduced % denReduced;
                textBoxFractionsSubtractionMixedWholeNumber.Text = wholeMixed.ToString();
                textBoxFractionsSubtractionMixedNumerator.Text = numMixed.ToString();
                textBoxFractionsSubtractionMixedDenominator.Text = denReduced.ToString();
            }
            else
            {
                textBoxFractionsSubtractionMixedWholeNumber.Clear();
                textBoxFractionsSubtractionMixedNumerator.Clear();
                textBoxFractionsSubtractionMixedDenominator.Clear();
            }
            //CONVERT TO DECIMAL
            var convertDecimal = (double)numReduced / denReduced;
            textBoxFractionSubtractionDecimal.Text = convertDecimal.ToString("F");
        }
        //GROUP - FRACTIONS - MULTIPLYING - CALCULATE
        private void buttonFractionsMultiplyingCalculate_Click(object sender, EventArgs e)
        {
            var numA = int.TryParse(textBoxFractionMultiplyingA.Text, out var inputA);
            var numB = int.TryParse(textBoxFractionMultiplyingB.Text, out var inputB);
            var numC = int.TryParse(textBoxFractionMultiplyingC.Text, out var inputC);
            var numD = int.TryParse(textBoxFractionMultiplyingD.Text, out var inputD);

            if (string.IsNullOrWhiteSpace(textBoxFractionMultiplyingA.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionMultiplyingA.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionMultiplyingB.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionMultiplyingB.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionMultiplyingC.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionMultiplyingC.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionMultiplyingD.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionMultiplyingD.Focus();
                return;
            }

            if (!numA)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionMultiplyingA.Clear();
                textBoxFractionMultiplyingA.Focus();
                return;
            }
            if (!numB)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionMultiplyingB.Clear();
                textBoxFractionMultiplyingB.Focus();
                return;
            }
            if (!numC)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionMultiplyingC.Clear();
                textBoxFractionMultiplyingC.Focus();
                return;
            }
            if (!numD)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionMultiplyingD.Clear();
                textBoxFractionMultiplyingD.Focus();
                return;
            }

            var numerator = inputA * inputC;
            var denominator = inputB * inputD;

            var gcd = GetGreatestCommonDivisor(numerator, denominator);

            var numReduced = numerator / gcd;
            var denReduced = denominator / gcd;

            textBoxFractionMultiplyingNumerator.Text = numerator.ToString();
            textBoxFractionMultiplyingDenominator.Text = denominator.ToString();
            textBoxFractionMultiplyingNumeratorReduced.Text = numReduced.ToString();
            textBoxFractionMultiplyingDenominatorReduced.Text = denReduced.ToString();

            //MIXED FRACTION CONVERSION
            if (numReduced > denReduced)
            {
                var wholeMixed = Math.Floor((double)(numReduced / denReduced));
                var numMixed = numReduced % denReduced;
                textBoxFractionsMultiplyingMixedWholeNumber.Text = wholeMixed.ToString();
                textBoxFractionsMultiplyingMixedNumerator.Text = numMixed.ToString();
                textBoxFractionsMultiplyingMixedDenominator.Text = denReduced.ToString();
            }
            else
            {
                textBoxFractionsMultiplyingMixedWholeNumber.Clear();
                textBoxFractionsMultiplyingMixedNumerator.Clear();
                textBoxFractionsMultiplyingMixedDenominator.Clear();
            }
            //CONVERT TO DECIMAL
            var convertDecimal = (double)numReduced / denReduced;
            textBoxFractionMultiplyingDecimal.Text = convertDecimal.ToString("F");
        }
        //GROUP - FRACTIONS - DIVIDING - CALCULATE
        private void buttonFractionsDividingCalculate_Click(object sender, EventArgs e)
        {
            var numA = int.TryParse(textBoxFractionDividingA.Text, out var inputA);
            var numB = int.TryParse(textBoxFractionDividingB.Text, out var inputB);
            var numC = int.TryParse(textBoxFractionDividingC.Text, out var inputC);
            var numD = int.TryParse(textBoxFractionDividingD.Text, out var inputD);

            if (string.IsNullOrWhiteSpace(textBoxFractionDividingA.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionDividingA.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionDividingB.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionDividingB.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionDividingC.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionDividingC.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFractionDividingD.Text))
            {
                MessageBox.Show("Please enter a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionDividingD.Focus();
                return;
            }

            if (!numA)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionDividingA.Clear();
                textBoxFractionDividingA.Focus();
                return;
            }
            if (!numB)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionDividingB.Clear();
                textBoxFractionDividingB.Focus();
                return;
            }
            if (!numC)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionDividingC.Clear();
                textBoxFractionDividingC.Focus();
                return;
            }
            if (!numD)
            {
                MessageBox.Show("Must be an Integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFractionDividingD.Clear();
                textBoxFractionDividingD.Focus();
                return;
            }

            var numerator = inputA * inputD;
            var denominator = inputB * inputC;

            var gcd = GetGreatestCommonDivisor(numerator, denominator);

            var numReduced = numerator / gcd;
            var denReduced = denominator / gcd;

            textBoxFractionDividingNumerator.Text = numerator.ToString();
            textBoxFractionDividingDenominator.Text = denominator.ToString();
            textBoxFractionDividingNumeratorReduced.Text = numReduced.ToString();
            textBoxFractionDividingDenominatorReduced.Text = denReduced.ToString();

            //MIXED FRACTION CONVERSION
            if (numReduced > denReduced)
            {
                var wholeMixed = Math.Floor((double)(numReduced / denReduced));
                var numMixed = numReduced % denReduced;
                textBoxFractionsDividingMixedWholeNumber.Text = wholeMixed.ToString();
                textBoxFractionsDividingMixedNumerator.Text = numMixed.ToString();
                textBoxFractionsDividingMixedDenominator.Text = denReduced.ToString();
            }
            else
            {
                textBoxFractionsDividingMixedWholeNumber.Clear();
                textBoxFractionsDividingMixedNumerator.Clear();
                textBoxFractionsDividingMixedDenominator.Clear();
            }
            //CONVERT TO DECIMAL
            var convertDecimal = (double)numReduced / denReduced;
            textBoxFractionDividingDecimal.Text = convertDecimal.ToString("F");
        }
    }
}
