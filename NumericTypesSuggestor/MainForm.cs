using System.Globalization;
using System.Numerics;

namespace NumericTypesSuggestor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;

            if (!IsValidInput(e.KeyChar, textBox))
            {
                e.Handled = true;
            }
        }

        private static bool IsValidInput(
            char keyChar, TextBox textBox)
        {
            return
                char.IsDigit(keyChar) ||
                char.IsControl(keyChar) ||
                (keyChar == '-' && textBox.SelectionStart == 0);

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

            suggestType();
            SetColorOfMaxValueTextField();
        }

        private void isIntegral_CheckedChanged(object sender, EventArgs e)
        {
            isPrecise.Visible = !isIntegral.Checked;
            suggestType();
        }

        private void isPrecise_CheckedChanged(object sender, EventArgs e)
        {
            suggestType();
        }





        private void SetColorOfMaxValueTextField()
        {
            bool isValid = true;

            if (IsInputComplete())
            {
                var minValue = BigInteger.Parse(textBoxMinValue.Text);
                var maxValue = BigInteger.Parse(textBoxMaxValue.Text);

                if (maxValue < minValue)
                {
                    isValid = false;
                }
            }
            textBoxMaxValue.BackColor = isValid ? Color.White : Color.Red;

        }

        private bool IsInputComplete()
        {
            return textBoxMinValue.Text.Length > 0 &&
                textBoxMinValue.Text != "-" &&
                textBoxMaxValue.Text.Length > 0 &&
                textBoxMaxValue.Text != "-";
        }

        private void suggestType()
        {
            if (IsInputComplete())
            {
                var minValue = BigInteger.Parse(textBoxMinValue.Text);
                var maxValue = BigInteger.Parse(textBoxMaxValue.Text);

                if (maxValue >= minValue)
                {
                    suggestedTypeResult.Text =
                        NumericTypeSuggester.GetName(
                            minValue,
                            maxValue,
                            isIntegral.Checked,
                            isPrecise.Checked);
                    return;
                }
            }
            suggestedTypeResult.Text = "not enough data";


        }

    }
}
