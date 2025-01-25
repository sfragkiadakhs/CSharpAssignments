
namespace NumericTypesSuggestor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            notifyIcon1 = new NotifyIcon(components);
            minValue = new Label();
            maxValue = new Label();
            isIntegral = new CheckBox();
            textBoxMinValue = new TextBox();
            textBoxMaxValue = new TextBox();
            isPrecise = new CheckBox();
            suggestedType = new Label();
            suggestedTypeResult = new Label();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // minValue
            // 
            minValue.AutoSize = true;
            minValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minValue.Location = new Point(42, 37);
            minValue.Name = "minValue";
            minValue.Size = new Size(82, 21);
            minValue.TabIndex = 0;
            minValue.Text = "Min Value:";
            // 
            // maxValue
            // 
            maxValue.AutoSize = true;
            maxValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxValue.Location = new Point(40, 76);
            maxValue.Name = "maxValue";
            maxValue.Size = new Size(84, 21);
            maxValue.TabIndex = 1;
            maxValue.Text = "Max Value:";
            // 
            // isIntegral
            // 
            isIntegral.AutoSize = true;
            isIntegral.CheckAlign = ContentAlignment.MiddleRight;
            isIntegral.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isIntegral.Location = new Point(64, 131);
            isIntegral.Name = "isIntegral";
            isIntegral.RightToLeft = RightToLeft.No;
            isIntegral.Size = new Size(123, 25);
            isIntegral.TabIndex = 2;
            isIntegral.Text = "Integral only?";
            isIntegral.UseVisualStyleBackColor = true;
            isIntegral.CheckedChanged += isIntegral_CheckedChanged;
            // 
            // textBoxMinValue
            // 
            textBoxMinValue.Location = new Point(143, 39);
            textBoxMinValue.Name = "textBoxMinValue";
            textBoxMinValue.Size = new Size(542, 23);
            textBoxMinValue.TabIndex = 3;
            textBoxMinValue.TextChanged += TextBox_TextChanged;
            textBoxMinValue.KeyPress += textBox_KeyPress;
            // 
            // textBoxMaxValue
            // 
            textBoxMaxValue.Location = new Point(143, 74);
            textBoxMaxValue.Name = "textBoxMaxValue";
            textBoxMaxValue.Size = new Size(542, 23);
            textBoxMaxValue.TabIndex = 4;
            textBoxMaxValue.TextChanged += TextBox_TextChanged;
            textBoxMaxValue.KeyPress += textBox_KeyPress;
            // 
            // isPrecise
            // 
            isPrecise.AutoSize = true;
            isPrecise.CheckAlign = ContentAlignment.MiddleRight;
            isPrecise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isPrecise.Location = new Point(42, 162);
            isPrecise.Name = "isPrecise";
            isPrecise.RightToLeft = RightToLeft.No;
            isPrecise.Size = new Size(145, 25);
            isPrecise.TabIndex = 5;
            isPrecise.Text = "Must be precise?";
            isPrecise.UseVisualStyleBackColor = true;
            isPrecise.CheckedChanged += isPrecise_CheckedChanged;
            // 
            // suggestedType
            // 
            suggestedType.AutoSize = true;
            suggestedType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            suggestedType.Location = new Point(40, 204);
            suggestedType.Name = "suggestedType";
            suggestedType.Size = new Size(126, 21);
            suggestedType.TabIndex = 6;
            suggestedType.Text = "Suggested Type: ";
            // 
            // suggestedTypeResult
            // 
            suggestedTypeResult.AutoSize = true;
            suggestedTypeResult.Font = new Font("Segoe UI", 12F);
            suggestedTypeResult.Location = new Point(172, 204);
            suggestedTypeResult.Name = "suggestedTypeResult";
            suggestedTypeResult.Size = new Size(124, 21);
            suggestedTypeResult.TabIndex = 7;
            suggestedTypeResult.Text = "not enough data";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(726, 263);
            Controls.Add(suggestedTypeResult);
            Controls.Add(suggestedType);
            Controls.Add(isPrecise);
            Controls.Add(textBoxMaxValue);
            Controls.Add(textBoxMinValue);
            Controls.Add(isIntegral);
            Controls.Add(maxValue);
            Controls.Add(minValue);
            Name = "MainForm";
            Text = "C# Numeric types";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private NotifyIcon notifyIcon1;
        internal Label minValue;
        internal Label maxValue;
        private TextBox textBoxMinValue;
        private TextBox textBoxMaxValue;
        private CheckBox isIntegral;
        private CheckBox isPrecise;
        private Label suggestedType;
        private Label suggestedTypeResult;
    }
}
